using System;
namespace GradeCalculatorApp
{
    class Calculator
    {
        static void Main(String[] args)
        {
            Console.Write("This determines your grade according to your percentage score\nEnter your score: ");
            int score = int.Parse(Console.ReadLine()); 

            if (score >= 90)
            {
                Console.WriteLine("Your Grade: A");
            } 
            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("Your Grade: B");
            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("Your Grade: C");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("Your Grade: D");
            }
            else if (score < 60)
            {
                Console.WriteLine("Your Grade: F");
            }
        }
    }

}




