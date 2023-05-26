using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hallo hoe gaat het";
            File.AppendAllText("leesdezefile.txt", text);
            string[] content = File.ReadAllLines("leesdezefile.txt");
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i] + " " + (i + 1));
            }
            if (!Directory.Exists("output"))
            {
                Directory.CreateDirectory("output");
            }
            File.Move("leesdezefile.txt", @"output\leesdezefile.txt");
            Console.ReadLine();
        }
    }
}
