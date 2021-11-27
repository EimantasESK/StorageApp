using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace StorageApp
{
    class XmlBase
    {
        public static void CreateXmlFile()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Table");
            doc.AppendChild(root);
            doc.Save(@"C:\Users\Eimis\source\repos\StorageApp\StorageApp\Table.xml");
            Console.WriteLine(doc.InnerXml);
        }
        public static void AddPartsToXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Eimis\source\repos\StorageApp\StorageApp\Table.xml");
            XmlNode root = doc.SelectSingleNode("Table");
            XmlElement parts = doc.CreateElement("Parts");
            root.AppendChild(parts);

            XmlElement id = doc.CreateElement("Id");
            id.InnerText = "001";
            parts.AppendChild(id);

            XmlElement name = doc.CreateElement("Name");
            name.InnerText = "akumuliatorius";
            parts.AppendChild(name);

            XmlElement price = doc.CreateElement("Price");
            price.InnerText = "100";
            parts.AppendChild(price);
            Console.WriteLine(doc.InnerXml);
            doc.Save(@"C:\Users\Eimis\source\repos\StorageApp\StorageApp\Table.xml");
        }

    }
}
