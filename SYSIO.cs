using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/* William Daniel Taylor
 * 5.22.18
 * Program to practice reading from and writing to files. */

namespace SYSIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\wdtay\Documents\School Documents\11th Grade\Programming II\SYSIO.txt";

            //reset file
            replaceFile(path);

            //display contents to screen
            printFile(path);

            //write to and append file
            writeToFile(path);
            
            //display contents to screen
            printFile(path);

            
            Console.ReadLine();
        }//end main

        static void printFile(string path)
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine("Read from file:\n" + readText + "\n");
        }//end method

        static void writeToFile(string path)
        {
            //write to file; overwrites file
            File.WriteAllText(path, "Written\n");

            //appends; adds to current text
            File.AppendAllText(path, "Appended");
        }//end method

        static void replaceFile(string path)
        {
            File.WriteAllText(path, "William Daniel Taylor\n5.21.18\nSYSIO");
        }//end main
    }//end class
}
