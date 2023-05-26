using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Florian Bruijn\Desktop\↑ma↑\bewijzenmap\periode1.4\m4prog\2023P4ProgCs2");
            FileInfo[] fileInfo = dir.GetFiles();

            Console.WriteLine("↓files↓");

            for(int i = 0; i < fileInfo.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(fileInfo[i].FullName);
            }

            Console.WriteLine("\n↓directories↓");

            DirectoryInfo[] dirInfo = dir.GetDirectories();

            for (int i = 0; i < dirInfo.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(dirInfo[i].FullName);
            }
            Console.ReadLine();
        }
    }
}
