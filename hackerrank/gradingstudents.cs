using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades)
    {
            /* Declaring length of new array with rounded numbers
             * will be the same length as input array */
            int[] roundedArray = new int[grades.Length];

            for (int i = 0; i < grades.Length; i++)
            {
                /* if the remainder of grades mod 5 is less than two and
                  is also less than 38 */
                if (grades[i] % 5 > 2 && !(grades[i] < 38))
                {
                    /*then add to the array the grade rounded to the next multiple of 5
                    for some reason -5 has to be first */
                    roundedArray[i] = grades[i] + (5 - grades[i] % 5 );
                }
                else 
                {
                    // If the grade is less than 38 just add it to the array
                    roundedArray[i] = grades[i];
                }
                    
            }
            // Finally return the final array with rounded numbers
            return roundedArray;
        }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int[n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
