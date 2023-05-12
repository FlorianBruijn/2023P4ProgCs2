using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> Birds = new List<string>() { "uil", "kraai", "hond", "papegaai"};
            List<string> Birds2 = new List<string>() { "meeuw", "duif"};
            Birds.AddRange(Birds2);
            Birds.Remove("hond");
            for (int i = 0; i < Birds.Count; i++)
            {
                Console.WriteLine(Birds[i]);
            }
            Console.Read();
        }
    }
}
