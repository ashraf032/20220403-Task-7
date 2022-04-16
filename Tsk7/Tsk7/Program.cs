using System;
using System.Collections.Generic;

namespace Tsk7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Arr = { };
            string key = string.Empty;
            int count = 1;
            do
            {
                //------------Insert Datas------------

                Console.WriteLine("Insert book name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Insert Author name: ");
                string authName = Console.ReadLine();
                Console.WriteLine("Insert book published date: ");
                string publishedDatestr = Console.ReadLine();
                Console.WriteLine("Insert Book page count: ");
                string pageCountstr = Console.ReadLine();
                count++;


                //------------Parse 2 prop------------
                //int publishedDate = 0;
                 int.TryParse(publishedDatestr,out int publishedDate);
                 int.TryParse(pageCountstr, out int pageCount);

                //------------Instance books and Create books------------
                Book book = new Book(name, authName, publishedDate, pageCount);

                //------------Final------------
               
                Array.Resize(ref Arr, Arr.Length + 1);
                Arr[Arr.Length - 1] = book.ToString();
                 

            } while (count!=5);

            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("----------");
                Console.WriteLine(Arr[i]);
                
            }
        }
    }
    class Book
    {
        public string Name = "sakhjbacs";
        public string AuthorName = "sadjvfn";
        public int PublisheDate = 123123;
        public int PageCount = 1322;
        public int Count {
            get => PageCount;
            set
            {
                while (value<=10)
                {
                    Console.WriteLine("10 dan yuxari daxil et");
                    
                    int.TryParse(Console.ReadLine(), out value);
                }
                PageCount = value;
            }
        }
        public Book(string name, string authorname, int publisheddate, int pagecount)
        {
            Name = name;
            AuthorName = authorname;
            PublisheDate = publisheddate;
            Count = pagecount;
            
        }

        public override string ToString()
        {
            return $"Kitabin adi: {Name}\nMuellifin adi: {AuthorName}\nCap olunma tarixi: {PublisheDate}\nSehife sayi: {PageCount}";
        }
    }
}
