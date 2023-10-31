using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
                doApp();
            }

            static void doApp()
            {
                // Create a text file
                string fileName = "sample.txt";

                // Write to the file
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("Hello, World!");
                    writer.WriteLine("This is a text file created using C#.");
                }

                Console.WriteLine("Text file created.");

                // Read from the file
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                Console.WriteLine("Text file read.");
            Console.ReadLine();
            }
        }

    }

