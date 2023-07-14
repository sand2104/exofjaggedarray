using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exof_jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noc, nos;             //noc=number of class; nos=number of student
            Console.WriteLine("Enter Number of Classes");
            noc = int.Parse(Console.ReadLine());
            string[][] students = new string[noc][];
            for (int i = 0; i < noc; i++)
            {
                Console.WriteLine("Enter Number of Student in Class " + (i + 1));
                nos = int.Parse(Console.ReadLine());

                students[i] = new string[nos];
                for (int j = 0; j < nos; j++)
                {
                    Console.WriteLine($"Enter Student {j + 1}\'s name");
                    students[i][j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($" Students List of class {i + 1}");
                Console.WriteLine("********");
                for (int j = 0; j < students[i].Length; j++)
                {
                    Console.WriteLine(students[i][j]);
                }
                Console.WriteLine("********");
            }
            Console.ReadKey();
        }
    }
}
