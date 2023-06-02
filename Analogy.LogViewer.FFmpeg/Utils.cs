using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Analogy.Interfaces;
using Newtonsoft.Json;

namespace Analogy.LogViewer.FFmpeg
{
    public static class Utils
    {
        //
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <param name="filename"></param>
        public static void SerializeToJsonFile<T>(T item, string filename)
        {
            var directoryName = Path.GetDirectoryName(filename);
            try
            {
                if (!string.IsNullOrEmpty(directoryName) && !(Directory.Exists(directoryName)))
                {
                    Directory.CreateDirectory(directoryName);
                }

                string data = JsonConvert.SerializeObject(item);
                File.WriteAllText(filename,data);
            }
            catch (SerializationException ex)
            {
                throw new Exception("GeneralDataUtils: Error in SerializeToBinaryFile", ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static T DeSerializeJsonFile<T>(string filename) where T : class, new()
        {
            var formatter = new BinaryFormatter();
            if (File.Exists(filename))
            {
                try
                {
                    string data = File.ReadAllText(filename);
                    T obj = JsonConvert.DeserializeObject<T>(data);
                    return obj;
                }
                catch (Exception ex)
                {
                    return default;
                }
            }
            return default;
        }
        public static string GetFileNameAsDataSource(string fileName)
        {
            string file = Path.GetFileName(fileName);
            return fileName.Equals(file) ? fileName : $"{file} ({fileName})";

        }
        public abstract class Saver
        {
            public static void ExportToJson(DataTable data, string filename)
            {
                List<AnalogyLogMessage> messages = new List<AnalogyLogMessage>();
                foreach (DataRow dtr in data.Rows)
                {

                    AnalogyLogMessage log = (AnalogyLogMessage)dtr["Object"];
                    messages.Add(log);
                }

                string json = JsonConvert.SerializeObject(messages);
                File.WriteAllText(filename, json);
            }
            public static void ExportToJson(List<AnalogyLogMessage> messages, string filename)
            {
                string json = JsonConvert.SerializeObject(messages);
                File.WriteAllText(filename, json);
            }

            public static void ExportToCSV(List<AnalogyLogMessage> messages, string fileName)
            {
                string text = string.Join(Environment.NewLine, messages.Select(GetCSVFromMessage).ToArray());
                File.WriteAllText(fileName, text);
            }

            private static string GetCSVFromMessage(AnalogyLogMessage m) =>
            $"ID:{m.Id};Text:{m.Text};Source:{m.Source};Level:{m.Level};Class:{m.Class};Module:{m.Module};Method:{m.MethodName};FileName:{m.FileName};LineNumber:{m.LineNumber};ProcessID:{m.ProcessId};User:{m.User}";
        }
    }
}
