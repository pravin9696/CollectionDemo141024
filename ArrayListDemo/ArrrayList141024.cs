using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo141024.ArrayListDemo
{
    internal class ArrrayList141024
    {
        public static  void method1()
        {
            ArrayList ar = new ArrayList() { "11", "22", "33", "44", "55" };

            //int[] temp =(int[]) ar.ToArray(typeof(int));
            string[] stArray = (string[])ar.ToArray(typeof(string));
            for (int i = 0; i < stArray.Length; i++)
            {
                Console.WriteLine(stArray[i] + stArray[i]);
            }
            //foreach (int i in ar)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"element at 1 is {ar[1]} element at 2 is {ar[2]} ");
            //Console.WriteLine("----------------------");
            ////ar.Remove(22);

            //ar.RemoveAt(1);
            //foreach (int i in ar)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"element at 1 is {ar[1]} element at 2 is {ar[2]} ");


            Console.WriteLine("=================================");
            stud s1 = new stud() { roll = 1, name = "rajesh" };//0X001
            ArrayList StudArList = new ArrayList()
              {
                new stud() { roll = 1, name = "rajesh" },//0x00234
               new stud() { roll = 2, name = "disnesh" },//0X002
               new stud() { roll = 3, name = "pankaj" },//0X003
              };

            foreach (var item in StudArList)
            {
                //item.show();
                //((stud)item).show();
                //or
                // stud temp = (stud)item;
                // temp.show();
            }
            Console.WriteLine("=================================");
            stud newObj = new stud() { roll = 1, name = "rajesh" };//0X004
            //stud newObj = s1;//0X001
            // StudArList.Remove(newObj);
            StudArList.Remove(newObj);

            foreach (var item in StudArList)
            {
                //item.show();
                //((stud)item).show();
                //or
                // stud temp = (stud)item;
                //temp.show();
            }
        }
    }
}
