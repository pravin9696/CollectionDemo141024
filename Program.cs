using CollectionDemo141024.ArrayListDemo;
using CollectionDemo141024.HashtableDemo;
using System.Collections;

namespace CollectionDemo141024
{
    class stud
    {
        public int roll { get; set; }
        public string name { get; set; }

            
        public void show()
        {
            Console.WriteLine($"Roll = {roll} Name = {name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrrayList141024.method1();
            MyHashtable.method2();

        }
    }
}
