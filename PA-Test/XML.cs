using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace PA_Test
{
    public class XML
    {
        public void WriteToXmlFile(List<Snake> snakes, string filename)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Snake>));

            try
            {
                FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Write); 
                writer.Serialize(file, snakes);
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine((ex.ToString() + " " + filename));
            }

        }

        public List<Snake> LoadObjectFromXmlFile(string filename)
        {
            List<Snake> returnObject = null;

            try
            {
                var xmlStream = new StreamReader(filename);
                var serializer = new XmlSerializer(typeof(List<Snake>));
                returnObject = (List<Snake>)serializer.Deserialize(xmlStream);
                xmlStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine($"Error loading {filename}");
            }
            return returnObject;
        }

        public XML()
        {

        }
    }
}
