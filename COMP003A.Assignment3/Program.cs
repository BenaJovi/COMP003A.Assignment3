//  Author: Jovani Benavides
 // Course: COMP - 003A
 // Purpose: 
 // 


namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;                 // Allows the console to be white.
            Console.Write("Please Enter Total Grade (0-100): ");          // Tells the user to input a number 0-100.
            string grade = Console.ReadLine();
            double TotalGrade = Convert.ToDouble(grade);                  // Converts string into a double which will allow decimal values.

            if (TotalGrade >= 90 && TotalGrade == 100)                    // First condition checks wether the score is within 90-100
            {
                Console.WriteLine("Letter Grade: A");                     // If this condition is met, the letter grade A will be displayed.
                
            }
            else if (TotalGrade >= 80 && TotalGrade <= 89.9)              // Second condition checks wether the score is within 80-89
            {
                Console.WriteLine("Letter Grade: B");                     // If this condition is met, the letter grade B will be displayed.
            }
            else if (TotalGrade >= 70 && TotalGrade <= 79.9)              // Third condition checks wether the score is within 70-79
            {
                Console.WriteLine("Letter Grade: C");                     // If this condition is met, the letter grade C will be displayed.
            }
            else if (TotalGrade >= 60 && TotalGrade <= 69.9)              // Fourth condition checks wether the score is within 60-69
            {
                Console.WriteLine("Letter Grade: D");                     // If this condition is met, the letter grade D will be displayed.
            }
            else if (TotalGrade >=0 && TotalGrade <= 59.9)                // Fifth condition checks wether the score is within 0-59
            {
                Console.WriteLine("Letter Grade: F");                     // If this condition is met, the letter grade F will be displayed.
            }
            else                                                          // This statement will terminate the code if a value that is not within 0-100 is entered.
            {
              Console.WriteLine("Invalid Input!");                        // Invalid input will be displayed if conditions are not satisfied. 
            }
           
            Console.WriteLine("*****************************************");
            Console.Write("Enter an Integer day of the week (1-7):");     // Prompts user to input an integer 1-7 that will correspond to a day of the week. 
            string WeekNum = Console.ReadLine();                          // Stores input as a string.
            int numericDay = Convert.ToInt32(WeekNum);                    // Converts strign to integer. 
            
            switch (numericDay)                                           // Switch statement beings the case/breaks.
            {
                case 1:                                                   // If integer 1 is entered it will choose case 1.
                    Console.WriteLine("String Day: Monday");              // If case one is chosen, then Monday will be displayed
                    break; 
                case 2:                                                   // If integer 1 is entered it will choose case 2.
                    Console.WriteLine("String Day: Tuesday");             // If case one is chosen, then Tuesday will be displayed
                    break;  
                case 3:                                                   // If integer 1 is entered it will choose case 3.
                    Console.WriteLine("String Day: Wednesday");           // If case one is chosen, then Wednesday will be displayed
                    break;
                case 4:                                                   // If integer 1 is entered it will choose case 4.
                    Console.WriteLine("String Day: Thurday");             // If case one is chosen, then Thursday will be displayed
                    break;
                case 5:                                                   // If integer 1 is entered it will choose case 5.
                    Console.WriteLine("String Day: Friday");              // If case one is chosen, then Friday will be displayed
                    break;
                case 6:                                                   // If integer 1 is entered it will choose case 6.
                    Console.WriteLine("String Day: Saturday");            // If case one is chosen, then Saturday will be displayed
                    break;
                case 7:                                                   // If integer 1 is entered it will choose case 6.
                    Console.WriteLine("String Day: Sunday");              // If case one is chosen, then Sunday will be displayed
                    break;
                default:                                                  // If no integer from 1-7 is chosen it will default to invalid input.
                    Console.WriteLine("Inavlid Day!");                    // Invalid input will be displayed if conditions are not met.
                    break;
            }

            
        }
    }
}