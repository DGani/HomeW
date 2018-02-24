using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exam_1
{
   public  class LogicForSotrudnik:Sotrudnik
    {
        public void FromID(int id)
        {
            if (id == ID)
            {
                PrintS();
            }
        }
      
        public void SerializeS(Sotrudnik sotrudnik)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Sotrudnik));

                
                using (FileStream fs = new FileStream($"Sotrudnik{ID}.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, sotrudnik);

                    Console.WriteLine("Объект сериализован");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Error  Serialization");
            }
        }

        public void DeserializeS(Sotrudnik sotrudnik) {

            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Sotrudnik));
                using (FileStream fs = new FileStream($"sotrudnik{ID}.xml", FileMode.OpenOrCreate))
                {
                    Sotrudnik ChangeSotrudnik = (Sotrudnik)formatter.Deserialize(fs);

                    Console.WriteLine("Объект десериализован");
                    ChangeSotrudnik.PrintS();
                    ChangeSotr(ChangeSotrudnik);

                }

            }
            catch (Exception)
            {

                Console.WriteLine("Error  Deserialization");
            }

        }


        void ChangeSotr( Sotrudnik change)
        {
            Console.WriteLine("Enter the FIO");
            change.FIO = Console.ReadLine();
            Console.WriteLine("Enter the age");
            change.Age = Console.Read();
            Console.WriteLine("Enter the Department");
            change.Department = Console.ReadLine();
            Console.WriteLine("Enter the Position");
            change.Position = Console.ReadLine();
            SerializeS(change);
        }

        public void SerializeAll(List<Sotrudnik> sotrudniki)
        {
            try
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(List<Sotrudnik>));
                StringWriter stringWriter = new StringWriter();
                serialiser.Serialize(stringWriter, sotrudniki);
                string xml = stringWriter.ToString();
                Console.WriteLine(xml);
                stringWriter.Close();

            }
            catch (Exception)
            {

                Console.WriteLine("Error  Serialization");
            }
        }

        public Sotrudnik newsSotrudni()
        {
            Sotrudnik newsotr = new Sotrudnik();
            Console.WriteLine("Enter the FIO");
            newsotr.FIO = Console.ReadLine();
            Console.WriteLine("Enter the ID");
            newsotr.ID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age");
            newsotr.Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Department");
            newsotr.Department = Console.ReadLine();
            Console.WriteLine("Enter the Position");
            newsotr.Position = Console.ReadLine();
            return newsotr;
        }

        public Sotrudnik removeSotrudnik(List<Sotrudnik> list)
        {
            Console.WriteLine("Enter ID of worker who was dismissed");
            int id = Int32.Parse(Console.ReadLine());
            foreach (var item in list)
            {
                if(item.ID==id)
                    return item;
            }
            return null;
        }

        public Sotrudnik FindS(List<Sotrudnik> list)
        {
            Console.WriteLine("Enter ID of worker who want to know");
            string name = Console.ReadLine();
            foreach (var item in list)
            {
                if (item.FIO.Contains(name))
                    return item;
            }
            return null;
        }

        public void Statistic(List<Sotrudnik> list)
        {
            Console.WriteLine($"Count of Workers {list.Count}");
            int sum = 0;
            foreach (var item in list)
            {
                sum += item.Age;
                
            }
            Console.WriteLine($"Average age of Workers {sum/(list.Count)}");
        }

    }
}
