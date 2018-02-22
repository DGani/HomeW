using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Console;

namespace HW_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriter writer = null;
            writer = new XmlTextWriter("Product.xml", System.Text.Encoding.Unicode);
            //writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("Product");
            writer.WriteStartElement("Phones");
            writer.WriteStartElement("Smartphone");
            writer.WriteStartElement("New");
            writer.WriteElementString("Name","IPhone");
            writer.WriteComment("Название марки");
            writer.WriteElementString("MadeIn", "USA");
            writer.WriteComment("Страна производства");
            writer.WriteElementString("Price", "500$");//символьные данные 
            writer.WriteComment("Цена за 1 штуку");
            writer.WriteElementString("Model", "X");
            writer.WriteComment("Модель");
            writer.WriteElementString("Color", "White");
            writer.WriteComment("Цвет");
            writer.WriteElementString("Company", "Apple");
            writer.WriteComment("Фирма");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Close();

            XmlWriter naim = null;
            naim = new XmlTextWriter("1.xml", System.Text.Encoding.Unicode);
            naim.WriteStartDocument();
           // naim.WriteStartElement("<?xml version=\"1.0\" encoding=\"utf - 8\"?>", "");
            naim.WriteStartElement("Tovar");
            naim.WriteStartElement("Naim","Benzin");
            naim.WriteEndElement();
            naim.WriteStartElement("Price","20");
            naim.WriteEndElement();
            naim.WriteEndElement();
            naim.Close();



        }
    }
}
