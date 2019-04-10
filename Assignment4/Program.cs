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
            p.ReadTextFiles();
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
                int number = 0;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("Sea") && line.Contains("Fare") || line.Contains("sea") && line.Contains("fare"))
                    {
                        int x = counter - 1;
                        Console.WriteLine(x);
                        number++;
                    }
                    counter++;
                }
                Consol

                file.Close();
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;

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
            return countSpaces;
        }
    }
   }
