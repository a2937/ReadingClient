using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/*
 * A class designed to read files from a file
 */
namespace ReadingClient
{
    public class Reader
    {
        private String FilePath { get; set; } 


        /*
         * Instaniates a new Reader object and sets a default FilePath
         */
        public Reader()
        {
            FilePath = @"C:\Users\aaron\source\repos\ReadingClient\ReadingClient\users.txt";
        }

        /*
        * Instaniates a new Reader object and sets the path to NewPath
        */
        public Reader(String NewPath)
        {
            FilePath = NewPath;
        }

        /*
        * Reads a file from the specified file path set in the constructor. 
        */
        public String ReadFile()
        {
            //File file = new File("users.txt");
            StringBuilder completeString = new StringBuilder();
            //Scanner newScanner;

            try
            {
                string[] lines = File.ReadAllLines(FilePath);

                foreach (string line in lines)
                {
                    completeString.Append(line + "\n");
                }

                // newScanner = new Scanner(file);
                // while (newScanner.hasNextLine()) // test for the end of the file
                // {
                //     completeString.append(newScanner.nextLine() + "\n");
                // }
                // newScanner.close();
            }
            catch (FileNotFoundException e)
            {
                Console.Error.WriteLine(e.Message);
                //e.Message;
                //Console.Error.WriteLine("users.txt not found");
            }

            return completeString.ToString().Replace("=", ": ");
        }
    }
}
