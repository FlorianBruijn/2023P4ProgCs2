using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SplitOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("stringsplit.txt");
            string[] keyvalue = content.Trim(',').Split(':');
            string[] cijfersPerVak = keyvalue[1].Split(',');
            Console.WriteLine(keyvalue[0]);
            for (int i = 0; i < cijfersPerVak.Length; i++)
            {
                Console.WriteLine(cijfersPerVak[i]);
            }
            Console.Read();
        }
    }
}
