/*
 * Name: Christian Price Luke
 * Date: 10/8/2023
 * Description: This program performs compile-time initilization to generate tables for the number of attendees for
 * both Zumba and Spinning classes at the Weber Gym. Each class has four time slots and run 6 days a week.
 * This program generates 2D arrays and populates them with the number of attendees per class based on the time slot and day of the week.
 * Time slots are represented by the columns, while days of the week are represented by the rows.
 * After being populated these arrays are displayed for the user using nested for loops to iterate through the arrays for 
 * both the Zumba and Spinning classes. Each is clearly labeled showing the attendees at each time slot and day, while
 * also calculating the totals for each time slot for the entire week, totals for each day, and total attendees for every
 * time slot for the entire week. Total revenue for each day and the entire week is calculated and displayed to the user as well 
 * assuming the classes charge $4.00/ person for Zumba, and $5.00/ person for Spinning class.
 * 
 * Sources:
 * https://www.w3schools.com/cs/cs_properties.php
 * https://www.geeksforgeeks.org/string-format-method-in-c-sharp-with-examples-set-1/#
 * 
 */


namespace WeberGymApp
{
    public class WeberGym
    {
        public int[,] Zumba { get; set; }
        public int[,] Spinning { get; set; }

        public WeberGym() //default constructor
        {
            Zumba = new int[,] 
            { 
                {12,10,17,22},
                {11,13,17,22},
                {12,10,22,22},
                {9,14,17,22 },
                {12,10,21,12 },
                {12,10,5,10 }
            };
            Spinning = new int[,]
            {
                {7,11,15,8},
                {9,9,9,9 },
                {3,12,13,7 },
                {2,9,9,10 },
                {8,4,9,4 },
                {4,5,9,3 }
            };
                
        }

        public int CalculateRowTotal(int row, char c)
        {
            int rowTotal = 0;
            int[,] table;
            if(c == 'z') { table = Zumba; }
            else { table = Spinning; }
            for (int i = 0; i < table.GetLength(1); i++)
            {
                rowTotal += table[row, i];
            }

            return rowTotal;
        }

        public int CalculateColTotal(int col, char c)
        {
            int colTotal = 0;
            int[,] table;
            if (c == 'z') { table = Zumba; }
            else { table = Spinning; }
            for (int i = 0; i < table.GetLength(0); i++)
            {
                colTotal += table[i, col];
            }

            return colTotal;
        }
        
    }

    
}