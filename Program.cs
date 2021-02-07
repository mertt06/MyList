using System;
using System.Collections.Concurrent;
using System.Text;


namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> ogrenciler = new MyList<string>();


            ogrenciler.Add("Mert");
            ogrenciler.Add("Murat");
            ogrenciler.Add("Yunus");

            Console.WriteLine("Öğrenci sayısı: " + ogrenciler.Length);

            
            
            foreach (var ogrenci in ogrenciler.Items)
            {
                Console.WriteLine("Öğrenciler: " + ogrenci);
                Console.ReadLine();
                Console.WriteLine("===============================================");
            }

            
        }
    }


    class MyList<C>
    {
        C[] items;

        public MyList()
        {
            items = new C[0];
        }

        public void Add(C item)
        {
            C[] tempArray = items;
            items = new C[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }


            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length;}
        }

        public C[] Items
        {
            get { return items; }
        }
    }
}
