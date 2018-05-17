using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/* William Daniel Taylor
 * 5.17.18
 * Custom error handling using try-catches */

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //dividing by zero, results in an error message
            divideByZero();

            //accessing out of bounds
            outOfBounds();

            //file not found
            fileNotFound();

            Console.ReadLine();
        }//end main

        #region
        /* Example of dividing by zero */
        static void divideByZero()
        {
            int x = 0;

            try
            {
                //tries to divide by zero
                double y = 3 / x;
            }
            catch (DivideByZeroException dbze)  //focal point; pass the exception in the catch
            {
                //prints default error message
                Console.WriteLine(dbze.Message);
                Console.WriteLine();
            }//end try-catch
        }//end method
        #endregion

        #region
        /* Example of out-of-bounds exceptions */
        static void outOfBounds()
        {
            int[] numbers = new int[] { 3, 4, 5 };

            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.Write(numbers[i] + " ");
                }//end for
            }
            catch (IndexOutOfRangeException ioore)
            {
                Console.WriteLine("\n" + ioore.Message);
                Console.WriteLine();
            }//end try-catch
        }//end method
        #endregion

        #region
        /* Example of file-not-found exceptions */
        static void fileNotFound()
        {
            StreamReader sr = null;

            try
            {
                sr = File.OpenText("C:/Users/wdtay/Documents/foobar");
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
                Console.WriteLine();
            }//end try-catch
        }//end method
        #endregion

    }//end class
}
