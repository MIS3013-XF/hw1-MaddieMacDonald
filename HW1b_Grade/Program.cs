// HW1b Grade

// Your Name: Maddie MacDonald
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your student ID number: ");
            string studentIDnum = Console.ReadLine();
         
            Console.WriteLine("What is your overall percentage grade for assignments?");
            string assignments = Console.ReadLine();
            double assignmentsPrecentage = Convert.ToDouble(assignments);

            Console.WriteLine("What is your overall percentage grade Exam 1?");
            string exam1 = Console.ReadLine();
            double exam1Percentage = Convert.ToDouble(exam1);

            Console.WriteLine("What is your overall percentage Exam 2?");
            string exam2 = Console.ReadLine();
            double exam2Precentage = Convert.ToDouble(exam2);

            Console.WriteLine("What is your overall percentage for Exam 3?");
            string exam3 = Console.ReadLine();
            double exam3Precentage = Convert.ToDouble(exam3);

            Console.WriteLine("What is your overall percentage for participation?");
            string participation = Console.ReadLine();
            double participationPrecentage = Convert.ToDouble(participation);

            double assignweight = (assignmentsPrecentage * 0.2);
            double exam1weight = (exam1Percentage * 0.15);
            double exam2weight = (exam2Precentage * 0.25);
            double exam3weight = (exam3Precentage * 0.25);
            double participationweight = (participationPrecentage * 0.15);
            double finalGrade = (assignweight + exam1weight + exam2weight + exam3weight + participationweight);
          

            Console.WriteLine(firstName + " " + lastName + " (" + studentIDnum + "), your final grade is: " + (finalGrade.ToString("F2") +"%"));

            Console.ReadKey();
        }
    }
}
