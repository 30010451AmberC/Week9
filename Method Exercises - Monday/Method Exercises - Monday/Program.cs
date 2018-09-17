using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Exercises___Monday
{
    class Program //Task 1:
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your weight (kg): ");
            int Weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your height (m): ");
            int Height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your BMI is: {Bmi(Weight, Height)}");
            
            int bmic = Bmi(Weight, Height);
            Console.WriteLine($"You are {Category(bmic)}");
        }

        public static int Bmi(int Weight, int Height)
        {
            return Weight/(Height*Height);
            
        }

        public static string Category(int bmic) //Task 2 Extension:
        {
            if (bmic < 18.5)
            {
                return "Underweight";
            } else if (bmic < 25)
            {
                return "Normal Weight";
            } else if (bmic < 30)
            {
                return "Overweight";
            } else if (bmic > 30)
            {
                return "Obese";
            }
            else
            {
                return "Something went wrong.";
            }
        }
    }

    class Program3 //Task 3:
    {
        public static void task3()
        {
            Console.WriteLine("Please enter cents: ");
            int Cents = int.Parse(Console.ReadLine());
            string UpDown = "Up";
            Console.WriteLine($"{Cents} rounded is: {Round(Cents)}");

        }

        public static string Round(int Cents)
        {
            switch (Cents)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "DOWN!";

                case 6:
                case 7:
                case 8:
                case 9:
                    return  "UP!";

                default: 
                    return "Something went wrong!";



            }

        }
    }
}
