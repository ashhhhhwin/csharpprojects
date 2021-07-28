using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class collectionEG
    {
        static void ArrayEg()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add(10);
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add("Ash");
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add(1);
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add("LOL");
            Console.WriteLine("Capacity {0}", al.Capacity);
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add(10);
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add("Ash");
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add(1);
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add("LOL");
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add("LOL");
            Console.WriteLine("Capacity {0}", al.Capacity);
            foreach (var n in al)
            {
                Console.WriteLine("{0}", n);
            }
           
        }
        static void HashTableEG()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("N", ".NET");
            hashtable.Add("O", "OPERATING SYS");
            hashtable.Add("A", "ALPHABET");
            hashtable.Add("P", "PYTHON");
            hashtable.Add("B", "BASIC OF JAVA");

            foreach(DictionaryEntry i in hashtable)
            {
                Console.WriteLine(i.Key+ " : "+i.Value );
            }
        }
        static void SortedTableEG()
        {
            
            SortedList sorted = new SortedList();
            sorted.Add("N", ".NET");
            sorted.Add("O", "OPERATING SYS");
            sorted.Add("A", "ALPHABET");
            sorted.Add("P", "PYTHON");
            sorted.Add("B", "BASIC OF JAVA");
            foreach (DictionaryEntry i in sorted)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
        }
        static void Main()
        {
            ArrayEg();
            Console.WriteLine("-------------------------------------------");
            HashTableEG();

            Console.WriteLine("-------------------------------------------");

            SortedTableEG();

            Console.WriteLine("-------------------------------------------");
        }
    }
    class CollectionDemo
    {
        
    }
}
