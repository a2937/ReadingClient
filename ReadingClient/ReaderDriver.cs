/**
 *This program reads input from a file that uses 
 *Ampersands to seperate data. Then that 
 *data gets printed out. 
 */

using System;
using System.IO;
using System.Text;

namespace ReadingClient
{
    public class ReaderDriver
    {
        
        static void Main(string[] args)
        {
            Reader reader; 
            if (args == null || args.Length == 0)
            {
                reader = new Reader(); 
            }
            else
            {
                reader = new Reader(args[0]);
            }
            

            String unprocessedString = reader.ReadFile();

            String[] lines = unprocessedString.Split("\n");

            String[][] fields = new String[lines.Length - 1][];



            for (int line = 0; line < lines.GetLength(0) - 1; line++)
            {
                fields[line] = lines[line].Split("&");
            }

            for (int row = 0; row < fields.Length; ++row)
            {
                for (int column = 0; column < fields[row].Length ; ++column)
                {
                    Console.Write(fields[row][column] + "\n");
                }
            }

            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }

       
    }
}
