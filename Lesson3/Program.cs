using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    public class Program
    {
        public static void Main(String[] args)
        {
            IList<int> list = new List<int>();
            list.Add(8);
            list.Add(10);
            list.Add(-3);
            list.Add(18);
            list.Add(-100);
            list.Add(10);
            list.Add(1);
            list.Add(0);
            list.Insert(6, 2);
            list.Remove(10);
            list.RemoveAt(0);
            list.IndexOf(0);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i] + "   ");
            //}
            //Console.WriteLine();
            foreach (int number in list)
            {
                Console.Write(number + "   ");

            }
            Console.WriteLine();
            Console.WriteLine("Indexul elemetului '0' este " + list.IndexOf(0));
            Console.WriteLine("HashCode is " + list.GetHashCode());
            Console.WriteLine("Is there the element with value = 8? \nThe answer is: " + list.Contains(8));
         
            //sortare asc si desc
            var sorted = new List<int> { 11, 20, -3, -3, 10, -12, 189, 18 };
            sorted.Sort();
            Console.WriteLine("Sorted list asc: " + string.Join("   ", sorted));

            sorted.Reverse();
            Console.WriteLine("Sorted list desc: " + string.Join("   ", sorted));
            Console.WriteLine();
            IList<string> nameList = new List<string> { "Dorina", "Ana", "Elena" };
            foreach (string name in nameList)
            {
                Console.Write("String list - " + name + "   ");

            }

            IDictionary<int, string> clients = new Dictionary<int, string>();
            clients.Add(1, "Amelie");
            clients.Add(2, "John");

            Console.WriteLine("\nDictionary HashCode is " + clients.GetHashCode());
        }


}
}
