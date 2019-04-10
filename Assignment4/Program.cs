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
            p.FindNumberOfBlankSpaces();
        }
        public void Run()
        {
            this.ReadTextFiles();
        }
        public void ReadTextFiles()
        {
        }
        public void FindNumberOfBlankSpaces()
        {
            int countletters = 0;
            int countSpaces = 0;
            using (StreamReader file = new StreamReader(@"U:\Users\731779\Beowulf.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                    foreach (char c in line)
                    {
                        if (char.IsLetter(c))
                        {
                            countletters++;
                        }
                        if (char.IsWhiteSpace(c))
                        {
                            countSpaces++;
                        }
                    }
                Console.WriteLine($"Total letters are {countletters}");           
                file.Close();
            }
        }
    }
}
