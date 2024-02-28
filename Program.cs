using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prac13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(4.5);
            list.Add(18);
            list.AddRange(new string[] { "Студент", "Петров" });

            foreach(object e in list)
            {
                Console.WriteLine(e);
            }

            list.RemoveAt(0);
            list.Reverse();
            Console.WriteLine(list[1]);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            ArrayList list1 = new ArrayList();
            list1.Add(23);
            list1.Add(0.6);
            list1.AddRange(new string[] { "Яблоко", "Банан" });

            try
            {
                Console.Write("n1: ");
                int n1 = int.Parse(Console.ReadLine());
                if (n1 > list1.Count || n1 < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    list.InsertRange(n1, list1);
                    Console.WriteLine("--------------");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
                Console.Write("k: ");
                int k = int.Parse(Console.ReadLine());
                if (k > list.Count || k < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    list.RemoveRange(n1 / 2, k);
                    Console.WriteLine("--------------");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
        }
    }
}
