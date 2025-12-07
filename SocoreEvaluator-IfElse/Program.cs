using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocoreEvaluator_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            int age = ReadIntInput();

            Console.WriteLine("Please enter your GPA:");
            int gpa = ReadIntInput();

            Console.WriteLine("Please enter your work experience (years):");
            int experience = ReadIntInput();

            int totalScore = CalculateAgeScore(age) + CalculateGpaScore(gpa) + CalculateExperienceScore(experience);

            Console.WriteLine("\nYour total score: " + totalScore);
            Console.WriteLine(EvaluateScore(totalScore));
        }

        static int ReadIntInput()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number) && number >= 0)
                    return number;
                Console.WriteLine("Please enter a valid number:");
            }
        }

        static int CalculateAgeScore(int age)
        {
            if (age >= 18 && age <= 25) return 20;
            else if (age >= 26 && age <= 35) return 15;
            else if (age >= 36 && age <= 45) return 10;
            else return 5;
        }

        static int CalculateGpaScore(int gpa)
        {
            if (gpa >= 18) return 30;
            else if (gpa >= 15) return 20;
            else if (gpa >= 12) return 10;
            else return 0;
        }

        static int CalculateExperienceScore(int experience)
        {
            if (experience <= 1) return 5;
            else if (experience <= 5) return 10;
            else if (experience <= 10) return 15;
            else return 20;
        }

        static string EvaluateScore(int total)
        {
            if (total >= 60) return "You are excellent!";
            else if (total >= 40) return "You are suitable.";
            else if (total >= 20) return "Further review is needed.";
            else return "You are rejected.";
        }
    }
    
}
