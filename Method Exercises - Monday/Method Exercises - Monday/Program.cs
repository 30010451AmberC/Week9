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
                    return "UP!";

                default:
                    return "Something went wrong!";



            }

        }
    }

    class Program4 //Task 4:
    {
            public static void task4()
            {
                Console.WriteLine("Please enter a number between 1 - 5:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"{num} is {Greeting(num)}");
            }

            public static string Greeting(int num)
            {
                string[] array1 = new string[5];
                array1[0] = "Hello";
                array1[1] = "Kia Ora";
                array1[2] = "Kon'nichiwa";
                array1[3] = "Bonjour";
                array1[4] = "Talofa";
                return array1[num];
            }
    }

    class Program5 // Task 5:
    {
       public static void task5()
       {
                Console.WriteLine("Enter first number in equation: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an operator (-, +, *, /, or %): ");
                string Operator = Console.ReadLine();
                Console.WriteLine("Enter second number for equation: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{num1} {Operator} {num2}= {Calculator(num1, num2, Operator)}");
       }

       public static int Calculator(int num1, int num2, string Operator)
       {
         switch (Operator)
         {
                case "+":
                    return num1 + num2;
                   
                case "-":
                    return num1 - num2;
                    
                case "/":
                    return num1 / num2;
                  
                case "*":
                    return num1 * num2;
                case "%":
                    return num1 % num2;
                    

         }


       }
    }
     
    
}
