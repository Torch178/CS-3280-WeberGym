/*
 * Name: Christian Price Luke
 * Date: 10/8/2023
 * Description: This program performs compile-time initilization to generate tables for the number of attendees for
 * both Zumba and Spinning classes at the Weber Gym. Each class has four time slots and run 6 days a week.
 * This program generates two 2D jagged arrays and populates them with the number of attendees per class based on the time slot
 * and day of the week. Time slots are represented by the columns, while days of the week are represented by the rows.
 * After being populated these arrays are displayed for the user using nested for loops to iterate through the arrays for 
 * both the Zumba and Spinning classes. Each is clearly labeled showing the attendees at each time slot and day, while
 * also calculating the totals for each time slot for the entire week, totals for each day, and total attendees for every
 * time slot for the entire week. Total revenue for each day and the entire week is calculated and displayed to the user as well 
 * assuming the classes charge $4.00/ person for Zumba, and $5.00/ person for Spinning class.
 * 
 * Sources:
 * https://www.w3schools.com/cs/cs_properties.php
 * https://www.geeksforgeeks.org/string-format-method-in-c-sharp-with-examples-set-1/#
 * https://dotnettutorials.net/lesson/two-dimensional-array-in-csharp/
 * https://stackoverflow.com/questions/4260207/how-do-you-get-the-width-and-height-of-a-multi-dimensional-array
 * https://www.tutorialspoint.com/Different-ways-for-Integer-to-String-Conversions-in-Chash
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WeberGymApp
{
    internal class WeberGymApp
    {
        static void Main(string[] args)
        {
            WeberGym wg = new WeberGym();
            DisplayResults(wg);
        }

        private static void DisplayResults(WeberGym wg)
        {
            //Initialize variables to sum data in table
            int[]rowSum = wg.CalculateRowSum(wg.Zumba);
            int[]colSum = wg.CalculateColSum(wg.Zumba);
            int totalSum = 0;

            //Print Headers for Table
            WriteLine(String.Format("{0,60}", "Weber Gym Weekly Report"));
            WriteLine();
            WriteLine(String.Format("{0,60}", "Zumba Attendees"));
            WriteLine();
            WriteLine(String.Format("{0, 12} {1,12} {2,12} {3,12} {4,12} {5,12} {6,12}",  "", "1:00", "3:00", "5:00", "7:00", "Total", "Revenue"));

            for (int i = 0; i < wg.Zumba.GetLength(0);i++)
            {  
                
                Write("{0,12}", "");
                for(int j = 0; j <  wg.Zumba.GetLength(1);j++)
                {
                    Write( "{0,12}", wg.Zumba[i, j]);
                }
                totalSum += rowSum[i];
                Write("{0,12}", rowSum[i]);
                Write("{0,12:D}", rowSum[i] * 4);
                
                WriteLine();
            }

            Write("{0,12}", "Totals");
            for (int i = 0;i < wg.Zumba.GetLength(1); i++)
            {
                Write("{0,12}", colSum[i]);

            }
            Write("{0,12}", totalSum) ;
            Write("{0,12:C}", totalSum * 4);
            

        }
    }
}
