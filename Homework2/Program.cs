using System;
using System.Web.Script.Serialization;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            lab1 firstTask = new lab1(); //instance of lab1 object
            int sumOfTheNumbers; 
            int NumbersMultiplied = firstTask.multiplyint(2, 2, 3, out sumOfTheNumbers);
            Console.WriteLine("Sum of the numbers: "+sumOfTheNumbers);
            Console.WriteLine("Numbers Multiplied: "+NumbersMultiplied);


            Cat cat01 = new Cat("Tibby", 2); //instance of cat with name and age
            Cat.CatAge(cat01);
            Cat.CatAge(cat01);

            var json = new JavaScriptSerializer().Serialize(cat01);
            Console.WriteLine(json.ToString());

            Console.Read();
        }
    }

    class lab1
    {
        public int multiplyint(int int1, int int2, int int3,out int sumOfNrs)
        {
            sumOfNrs = int1 + int2 + int3;
            return int1 * int2 * int3;
        }
    }

    class Cat
    {
        private string name;
        private int age;
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        
        public int Age
        {
            get => age;
            set => age = value; 
        }
        public static object CatAge(Cat cat)
        {
            cat.age = cat.age + 5;

            return cat;
        }
    }
}
