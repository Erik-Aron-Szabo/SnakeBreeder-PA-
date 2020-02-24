using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Linq;

namespace PA_Test
{
    public class XML
    {
        // reader
        public void Writer(string name, string type)
        {
            XmlWriter xmlWriter = XmlWriter.Create("AllSnakes.xml");
            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("Snakes");
            xmlWriter.WriteStartElement("snake");
            xmlWriter.WriteAttributeString("name", name);
            xmlWriter.WriteAttributeString("type", type);

        }

        public void SnakeWriter(string name, string type)
        {
            XmlWriter xmlWriter = XmlWriter.Create("AllSnakes.xml");
            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("Snakes");
            xmlWriter.WriteStartElement("snake");
            xmlWriter.WriteAttributeString("name", name);
            xmlWriter.WriteAttributeString("type", type);

        }

        public XML()
        {

        }

    }
}
