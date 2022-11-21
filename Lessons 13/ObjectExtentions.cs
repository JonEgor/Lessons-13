using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lessons13
{
    public static class ObjectExtentions
    {
      /*  public static void TryOpenFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                if (reader != null)
                    reader.Close();
            }
            catch
            {
                if (reader == null)
                    throw new WrongNoFile("Нет файла по этому пути");
            }
        }
      */


        //JSON


        public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null; // Тут происходит запись 
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite); // преобразование в строку 

                // SerializeObject мож заменить на любой объ для сериализации

                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }


        // TextReader - для записи текста |
        // TextWriter - для записи текста |



        public static T ReadFromJsonFile<T>(string filePath) where T : new()
        {
           
            TextReader reader = null;

            try
            {

                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }



        // XML

        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new() // Xml
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
/*
    public static T ReadFromXmlFile<T>(string filePath) where T : new()
    {
        TryOpenFile<T>(filePath);
        TextReader reader = null;
        try
        {
            var serializer = new XmlSerializer(typeof(T));
            reader = new StreamReader(filePath);
            return (T)serializer.Deserialize(reader);
        }
        finally
        {
            if (reader != null)
                reader.Close();
        }
    }

    public class WrongNoFile : Exception
    {
        public WrongNoFile()
        {

        }
        public WrongNoFile(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
   

    */

    

















