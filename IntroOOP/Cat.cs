using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    class Cat
    {
        // Inside of our class, we create the blueprint for our object.
        // Classes are templates in OOP that we use to create objects.
        // They should always be names in Pascal case.


        // In OOP are 2 types. 
        // - Fields: a variable that belongs to a class
        private string name;
        private int age;
        private string furColor;
        private bool isHungry;

        // - Properties: a sort of mix between a field and a method that allow controlled access
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        // We also have behavior.
        // - Methods: repeatable/reusable sections of code - Actions
        // - Constructors: specialized methods that are used from instantiating an object
        //         - Allows us to control the sata of an object upon creation.
        //         - Allows us to perform any action the object might need upon creation/
        //         - Always shares the name of the class
        public Cat()
        {
            // This is an example of a default constructor. A default constructor takes
            // no arugments/paramaters.
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
        //This Cat has a method.
        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry?" + isHungry);
        }

    }
}
