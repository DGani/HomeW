using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HW_Serializable
{
    [Serializable]
    public class MyAtrribute : Attribute
    {
        public int Count(int year)
        {
            int yearofreading = DateTime.Now.Year - year;
            return yearofreading; // возвращает сколько уже лет эта книга читается людьми
        }
    }
    [MyAtrribute]
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public int year()
        {
            return Year;
        }

    }
    

    class Program
    {
        static void Main(string[] args)
        {

            List<Book> book = new List<Book>();
            book.Add(new Book() { Name = "Garry Potter", Author = "Joan Rowling", Price = 3120, Year = 1997 });
            book.Add(new Book() { Name = "The Lord of the ring", Author = "J.R.R Tolkien", Price = 3110, Year = 1954 });
            book.Add(new Book() { Name = "Anna Karenina", Author = "L.N.Tolstoy", Price = 3100, Year = 1877 });
            book.Add(new Book() { Name = "Fathers And Sons", Author = "I.S.Turgenev", Price = 3020, Year = 1862 });

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("book.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, book);

                Console.WriteLine("Объект сериализован");
            }

            try
            {
                using (FileStream fs = new FileStream("book.dat", FileMode.OpenOrCreate))
                {
                    Book bookdes = (Book)formatter.Deserialize(fs);

                    Console.WriteLine("Объект десериализован");
                    Console.WriteLine("Имя: {0} --- Автор : {1}", bookdes.Name, bookdes.Author);
                    

                }
            }
            catch (Exception)
            {

                 Console.WriteLine("Error");
            }
            Book nooks = new Book();
            nooks.Author = "Chingiz Aitmatov";
            nooks.Name = "Plaha";
            nooks.Price = 2060;
            nooks.Year = 1987;

            Type t = typeof(Book);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (MyAtrribute roleAttr in attrs)
            {
                Console.WriteLine(roleAttr.Count(nooks.Year)); // Я не смог вытащить год в book( 
            }



            Console.ReadLine();


        }
    }
}
