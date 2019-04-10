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
                string delim = " ,."; //maybe some more delimiters like ?! and so on
                string[] fields = null;
                string line = null;

                while (!file.EndOfStream)
                {
                    line = file.ReadLine();
                    line.Trim();
                    fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    counter += fields.Length; //and just add how many of them there is
                }


                file.Close();
                Console.WriteLine("The word count is {0}", counter);
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
