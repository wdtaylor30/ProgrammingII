using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IOExceptionsII
{
    class Program
    {
        static void Main(string[] args)
        {
            tcfTest();
        }//end main

        static void tcfTest()
        {
            //stream reader
            StreamReader sr = null;

            /* try-catch-finally to try to open the file */
            try
            {
                sr = File.OpenText(@"C:\Users\wdtay\Documents\School Documents\11th Grade\Programming II/IOExceptions.txt");
                Console.WriteLine("The file says:\n" + sr.ReadToEnd());
                Console.ReadLine();
            }
            catch (FileNotFoundException fnfe)  //if file doesn't exist
            {
                Console.WriteLine(fnfe.Message);
                Console.ReadLine();
            }
            finally //always executes
            {
                //if file exists, close it
                if (sr != null)
                {
                    sr.Close();
                }//end if

                Console.WriteLine("The finally block has executed. The file has been closed.");
                Console.ReadLine();
            }//end try-catch-finally
        }//end method
    }//end class
}
