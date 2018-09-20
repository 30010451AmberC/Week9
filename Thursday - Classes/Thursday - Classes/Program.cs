using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thursday___Classes //Task 1:
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Make = "Corvette";
            c1.Model = "Stingray";
            c1.Colour = "Matte Black";
            c1.Rego = "BYE123";

            int[] nums = new int[10]; //These arrays are just to show how you can use arrays after making a collection
            Car[] carCollection = new Car[10];
        }
    }

    class Car
    {
        private string make;
        private string model;
        private string colour;
        private string rego;

        public string Make { get { return make; } set { Make = value; } }

        public string Model { get { return model; } set{ model = value; } }

        public string Colour { get { return colour; } set { colour = value; } }

        public string Rego { get { return rego; } set { rego = value; } }

    }
    
}

namespace Task_2 //Task 2:
{
    class Person
    {
        public string fname;
        public string lname;
        private int age;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }



        public static void Main()
        {
            Person p1 = new Person("Amber", "Cook", 21);
            Console.WriteLine(p1);

        }

        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }


    }
}

namespace Task_3
{
    class Animal
    {
        public string name;
        public int idNum;

        public string Name { get { return name; } set { name = value; } }
        public int IdNum { get { return idNum; } set { idNum = value; } }

        public static void Main()
        {
            Animal a1 = new Animal("Tiger",3455);
        }

        public Animal(string _name, int _idNum)
        {
            Name = _name;
            IdNum = _idNum;
        }
    }
}
