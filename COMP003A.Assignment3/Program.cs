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
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please Enter Total Grade (0-100): ");
            string grade = Console.ReadLine();
            double TotalGrade = Convert.ToDouble(grade);

            if (TotalGrade >= 90 && TotalGrade == 100)
            {
                Console.WriteLine("Letter Grade: A");
                
            }
            else if (TotalGrade >= 80 && TotalGrade <= 89)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (TotalGrade >= 70 && TotalGrade <= 79)
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (TotalGrade >= 60 && TotalGrade <= 69)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else if (TotalGrade >=0 && TotalGrade <= 60)
            {
                Console.WriteLine("Letter Grade: F");
            }
            else
            {
              Console.WriteLine("Invalid Input!");
            }
           
            Console.WriteLine("*****************************************");
            Console.Write("Enter an Integer day of the week (1-7):");
            string WeekNum = Console.ReadLine();
            int numericDay = Convert.ToInt32(WeekNum);
           
            switch (numericDay) 
            {
                case 1:
                    Console.WriteLine("String Day: Monday");
                    break; 
                case 2:
                    Console.WriteLine("String Day: Tuesday");
                    break;  
                case 3:
                    Console.WriteLine("String Day: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("String Day: Thurday");
                    break;
                case 5:
                    Console.WriteLine("String Day: Friday");
                    break;
                case 6:
                    Console.WriteLine("String Day: Saturday");
                    break;
                case 7:
                    Console.WriteLine("String Day: Sunday");
                    break;
                default: 
                    Console.WriteLine("Inavlid Day!");
                    break;
            }

            
        }
    }
}