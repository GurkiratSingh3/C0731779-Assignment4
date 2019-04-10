using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
        }
        public void Run()
        {
            this.ReadTextFiles();
        }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader(@"U:\Users\731779\Beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int 
        }
    }
}
