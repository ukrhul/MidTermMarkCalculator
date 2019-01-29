/************************************************************************
 * Program:     MidTermMarkCalculation                                  *
 *                                                                      *
 * Author:      Rahul                                                   *
 * Date:        March 8, 2017                                           *
 *                                                                      *
 * Description: This program is used to determine one's mid-term mark   *
 *              given input received from the user.                     *
 *              In this case, the program is set up to use arrays.      *
 *              It will accept a series of whole numbers between        *
 *              0 and 100 from the user based on the assessments in     *
 *              PROG 1205 for Fall 2017. There will be a loop to        *
 *              accept ICE data, a loop to accept CRA data, a loop for  *
 *              Labs and a loop. It will then calculate the             *
 *              averages for each category as well as a final mark      *
 *              based on those averages and display them to the user.   *
 *              Within each loop to accept data for a different type    *
 *              of assessment, some validation is performed.            *
 *                                                                      *
 ************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermMarkCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * DECLARATIONS
             */


            // Declare constants for the number of ICEs, CRCs, and Labs
            // as well as constants for the overall category maximum values: ICE, CRC, and Lab.

            const int minimumGrade = 0;
            const int maximumGrade = 100;

            const int NUMBER_OF_ICES_INCLUDED = 8;  // for the number of all ICEs that count at present
            const double OVERALL_ICE_VALUE = 0.20; // the percentage that ICEs are worth, overall

            const int NUMBER_OF_CRCS_INCLUDED = 4;  // for the number of all CRCs that count at present
            const double OVERALL_CRC_VALUE = 0.40; // the percentage that CRCs are worth, overall

            const int NUMBER_OF_LABS_INCLUDED = 2;  // for the number of all Labs that count at present
            const double OVERALL_LAB_VALUE = 0.40; // the percentage that Labs are worth, overall

            // Declare an array for each of these evaluation types with a number of elements equal to the constant representing the number of evaluations.
            double[] iceScores = new double[NUMBER_OF_ICES_INCLUDED];
            double[] crcScores = new double[NUMBER_OF_CRCS_INCLUDED];
            double[] labScores = new double[NUMBER_OF_LABS_INCLUDED];

            // Declare a variable for the average grade in each evaluation category.

            double iceAverage = 0; // average ICE grade
            double crcAverage = 0; // average CRC grade
            double labAverage = 0; // average Lab grade

            // Declare a variable for the total grade overall.

            double overallAverage = 0; // average overall grade


            /*
             * INPUT
             */


            // Iterating up to the total number of ICEs...
            for (int iceCounter = 1; iceCounter < NUMBER_OF_ICES_INCLUDED + 1; iceCounter++)
            {
                // Prompt the user for their grade on each ICE as a real number out of 100
                Console.Write("Please enter your grade on ICE " + iceCounter + ": ");

                // Validate input from the user - re-prompt as needed
                // The use of TryParse below will store each valid value in 
                // elements in the array for ICE grades
                if (Double.TryParse(Console.ReadLine(), out iceScores[iceCounter - 1]) == false)
                {
                    // If the input is non-numeric, it will prompt for input again
                    Console.WriteLine("\nGrades must be entered as whole numbers.");
                    iceCounter--;
                }
                else if ((iceScores[iceCounter - 1] < minimumGrade) || (iceScores[iceCounter - 1] > maximumGrade))
                {
                    // If the input is out-of-range, it will prompt for input again
                    Console.WriteLine("\nGrades must be between "+minimumGrade+" and " + maximumGrade+ ".");
                    iceCounter--;
                }

            }



         
            // Iterating up to the total number of CRCs...
            for (int crcCounter = 1; crcCounter < NUMBER_OF_CRCS_INCLUDED + 1; crcCounter++)
            {

                // Prompt the user for their grade on each CRC as a real number out of 100
                Console.Write("Please enter your grade on CRC " + crcCounter + ": ");

                // Validate input from the user - re-prompt as needed
                // Store each value in subsequent elements in the array for CRC grades
                if (Double.TryParse(Console.ReadLine(), out crcScores[crcCounter - 1]) == false)
                {
                    // If the input is non-numeric, it will prompt for input again
                    Console.WriteLine("\nGrades must be entered as whole numbers.");
                    crcCounter--;
                }
                else if ((crcScores[crcCounter - 1] < minimumGrade) || (crcScores[crcCounter - 1] > maximumGrade))
                {
                    // If the input is out-of-range, it will prompt for input again
                    Console.WriteLine("\nGrades must be between " + minimumGrade + " and " + maximumGrade + ".");
                    crcCounter--;
                }
            }


            // Iterating up to the total number of Labs...
            for (int labCounter = 1; labCounter < NUMBER_OF_LABS_INCLUDED + 1; labCounter++)
            {

                // Prompt the user for their grade on each Lab as a real number out of 100
                Console.Write("Please enter your grade on LAB " + labCounter + ": ");

                // Validate input from the user - re-prompt as needed
                // Store each value in subsequent elements in the array for Lab grades
                if (Double.TryParse(Console.ReadLine(), out labScores[labCounter - 1]) == false)
                {
                    // If the input is non-numeric, it will prompt for input again
                    Console.WriteLine("\nGrades must be entered as whole numbers.");
                    labCounter--;
                }
                else if ((labScores[labCounter - 1] < minimumGrade) || (labScores[labCounter - 1] > maximumGrade))
                {
                    // If the input is out-of-range, it will prompt for input again
                    Console.WriteLine("\nGrades must be between " + minimumGrade + " and " + maximumGrade + ".");
                    labCounter--;
                }
            }


            /*
             * PROCESSING
             */

            // Determine the average of the ICE array, store this in the relevant variable

            // *** AVERAGE METHOD 1 ***

            // Determine the average of the CRC array, store this in the relevant variable

            iceAverage = iceScores.Average(); 
            

            // *** AVERAGE METHOD 2 ***

           
            for (int crcCounter = 1; crcCounter < crcScores.Length + 1; crcCounter++)
            {
                crcAverage += (crcScores[crcCounter - 1] / NUMBER_OF_CRCS_INCLUDED);
                // this is adding the scores on each CRC and dividing by the total number of CRCs
            }
            

            // Determine the average of the Lab array, store this in the relevant variable
            for (int labCounter = 1; labCounter < labScores.Length + 1; labCounter++)
            {
                labAverage += (labScores[labCounter - 1] / NUMBER_OF_LABS_INCLUDED);
                // this is adding the scores on each LAB and dividing by the total number of LABs
            }


            // Determine the total grade overall:
            // Total grade overall: add the average of the ICE array multiplied by the value of the ICE array (0.20)
            overallAverage += iceAverage * OVERALL_ICE_VALUE;

            // Total grade overall: add the average of the CRC array multiplied by the value of the CRC array (0.40)
            overallAverage += crcAverage * OVERALL_CRC_VALUE;

            // Total grade overall: add the average of the Lab array multiplied by the value of the Lab array (0.40)
            overallAverage += labAverage * OVERALL_LAB_VALUE;


            /*
             * OUTPUT
             */
             
            // Output the average of the ICE array (already determined above), with an appropriate identifier

            Console.WriteLine("\nThe average grade in ICEs is: " + iceAverage);

            // Output the average of the CRC array (already determined above), with an appropriate identifier

            Console.WriteLine("\nThe average grade in CRCs is: " + crcAverage);

            // Output the average of the Lab array (already determined above), with an appropriate identifier

            Console.WriteLine("\nThe average grade in LABs is: " + labAverage);

            // Output the total grade overall (already determined above), with an appropriate identifier.

            Console.WriteLine("\nThe overall grade of the student is: " + overallAverage);

            // Prompt the user to press a key to exit
            Console.Write("\nPress any key to exit... ");
            Console.ReadKey();
        }
    }
}
