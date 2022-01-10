using System;
using System.Collections.Generic;
using System.Collections;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "Suresh");
            dct.Add(4, "Rohini");
            dct.Add(2, "Trishi");


            dct[5] = "Trishi";
            String value1 = dct[4];

            Console.WriteLine(value1);
            foreach (var i in dct.Keys)
            {
                Console.WriteLine("keys {0}", i);
            }
            try
            {
                dct.Add(2, "Praveen");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = '2' already exists.");
            }

            foreach (KeyValuePair<int, string> item in dct)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }
            HashTable hash = new HashTable();
            hash.Add(1, "bob");
            hash.Add(2, "john");
            foreach (DictionaryEntry i in hash)
            {
                Console.WriteLine("key{0},value{1}", i.Key, i.Value);
            }


        }
    }
}
