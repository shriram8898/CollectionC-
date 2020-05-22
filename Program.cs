using System;
using System.Collections;   
using System.Collections.Generic;




namespace server
{
    class currency
    {
        public readonly string money;
        public readonly string country;
        public currency(string money,string country)
        {
            this.money = money;
            this.country = country;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            currency c = new currency("INR", "India");
            Console.WriteLine(c.country + " " + c.money);
        }
    }
   
    /* class Program
     {
         public delegate void Del(int x, int y);

         class Test
         {
             public void plus(int x, int y)
             {
                 Console.WriteLine(x + y);
             }
             public void sub(int x, int y)
             {
                 Console.WriteLine(x - y);
             }
         }
         static void Main(string[] args)
         {

             Test obj = new Test();
             Del del = new Del(obj.plus); 
             del += new Del(obj.sub);
             del(50, 10);
             Console.WriteLine();
             del -= new Del(obj.plus);
             del(20, 10);
             Console.ReadLine();
         }
     }


     class program
     {
         public delegate void Del(List<int> list);

         static void Main(string[] args)
         {
             List<int> list = new List<int>();
             list.Add(1);
             list.Add(2);
             list.Add(3);
             list.Add(4);
             list.Add(5);
             list.Add(6);
             stark s = new stark();
             Del del = new Del(s.PrintEven);
             del += new Del(s.PrintOdd);
             del(list);
             //PrintValues(list);

         }
         class stark
         {
             public void PrintEven(List<int> lists)
             {
                 Console.WriteLine("Even number");
                 foreach (var obj in lists)
                     if (obj % 2 == 0)
                     {
                         Console.WriteLine(obj);
                     }

             }
             public void PrintOdd(List<int> lists)
             {
                 Console.WriteLine("Odd number");
                 foreach (var obj in lists)
                     if (obj % 2 != 0)
                     {
                         Console.WriteLine(obj);
                     }

             }
         }

          var names = new LinkedList<string>();
           names.AddLast("Sonoo Jaiswal");
           names.AddLast("Ankit");
           names.AddLast("Peter");
           names.AddLast("Irfan");
           names.AddFirst("John");
           foreach (var k in names)
               Console.WriteLine(k);

           // Dictionary<string, string> names = new Dictionary<string, string>();
           SortedDictionary<string, string> names = new SortedDictionary<string, string>();
           names.Add("3", "Sonoo");
           names.Add("2", "Peter");
           names.Add("1", "James");
           names.Add("4", "Ratan");
           names.Add("5", "Irfan");

           foreach (KeyValuePair<string, string> kv in names)
           {
               Console.WriteLine(kv.Key + " " + kv.Value);
           }

       }
       public static void Main()
       {

           // Creates and initializes a new ArrayList.
           ArrayList myAL = new ArrayList();
           myAL.Add("Hello");
           myAL.Add("World");
           myAL.Add("!");

           // Displays the properties and values of the ArrayList.
           Console.WriteLine("myAL");
           Console.WriteLine("    Count:    {0}", myAL.Count);
           Console.WriteLine("    Capacity: {0}", myAL.Capacity);
           Console.Write("    Values:");
           PrintValues(myAL);
       }

         public static void PrintValues(IEnumerable myList)
         {
             foreach (Object obj in myList)
                 Console.Write("   {0}", obj);
             Console.WriteLine();
         }
     }*/

}
