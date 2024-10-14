using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo141024.HashtableDemo
{
    internal class MyHashtable
    {
        public static void method2()
        {
            ArrayList subject = new ArrayList() { "C#","PHP"};
            Hashtable hs= new Hashtable();
            hs.Add("pravin", subject);
            hs["Ajinkya"] = new ArrayList() { "Python" };
            hs.Add("Giri sir", new ArrayList() { "C", "CPP","JAVA","UI"});
            hs.Add("Khushal", new ArrayList() { "Mern Stack", "HTML","CSS" });

            //string sr = (string)hs["ajinkya"];

            //foreach (var item in hs)
            //{
            //    DictionaryEntry id = (DictionaryEntry) item;

            //    Console.WriteLine("key ="+id.Key+ " value=" + id.Value);

            //}
            //ArrayList sub = (ArrayList)hs["pravin"];
            //Console.WriteLine("all subjects of Teacher pravin is :");
            //foreach (var item in sub)
            //{
            //    Console.WriteLine(item);
            //}

            hs["pravin123"]= new ArrayList() { "VB6.0"};
            foreach (var item in hs)
            {
                DictionaryEntry GTH = (DictionaryEntry)item;
                string key =(string) GTH.Key;
                 ArrayList subjects=(ArrayList) GTH.Value;
                Console.WriteLine("Teacher Name :"+key);
                foreach (var sb in subjects)
                {
                    Console.Write(","+sb);
                }
                Console.WriteLine();
            }

        }
    }
}
