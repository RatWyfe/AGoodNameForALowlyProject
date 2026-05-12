using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AGoodName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter file path here: ");
            string csvfile = Console.ReadLine();
            if (csvfile == "")
            {
                Console.WriteLine("No Input Given, defaulting to assumed position.");
                csvfile = "C:/Users/605711/Downloads/Document.csv";
            }
            
            
            if (File.Exists(csvfile))
            {
                StreamReader sr = new StreamReader(csvfile);
                Console.WriteLine("file exists");
                string fileline = sr.ReadLine();
                Console.WriteLine(fileline);
                Console.WriteLine(sr.EndOfStream);
                do
                {
                    fileline = sr.ReadLine();
                    Console.WriteLine(fileline);
                    Console.WriteLine(sr.EndOfStream);
                } while (!sr.EndOfStream);
                sr.Close();
                Console.WriteLine("error:69420.80085");
                Console.Write("Are you ready to ruin the file?: ");
                string ready = Console.ReadLine();
                char a ;
                sr = new StreamReader(csvfile);
                if (ready.ToLower() == "y")
                {
                    fileline = sr.ReadLine();
                    Console.WriteLine(fileline);
                    fileline.
                }
            }
        }
    }
}