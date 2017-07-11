using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    class Dog
    {
        // Create a Dog class
        // Your Dog class should have fileds for hair length, height, running speed, and weight.
        // You class should have the following behaviors; run, bark, potty, cuddle. 


        // DOG is the class
        // Varible that belong to class 

        // These are the fields
        private string hairLength;
        private int height;
        private int runningSpeed;
        private double weight;
        private bool crap = true; // <---- made for void potty // create a property to be true or false, if not will be true


        // These are the properties
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.Height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.RunningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.Weight; }
            set { this.weight = value; }
        }

        // This is the behavior: Constructor and Behavior

        // This is the constructor 
        public Dog()
        {
            // This is my defult constructor. 
            // Not every constructor is an empty body
            // Leave a comment if you want.
        }

        public Dog(string hairLength, int height, int runningSpeed, double weight) // <---- not the same as the fields. 
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        // This is the behavior
        public int Run()
        {
            Console.WriteLine("Go doddy go!");
            RunningSpeed -= 1;
            return RunningSpeed;
        }

        public void Bark() // <--- VOID does not return to anything....it would just bark  if you press button as an example
        {
            Console.WriteLine("Woof woof woof");
        }

        public void Potty()
        {
            if (crap == true)
            {
                Console.WriteLine("Your dog just made a mess");
            }
            else
            {
                Console.WriteLine("Your dog has made a relieve");
            }
        }


        //// OR ANOTHER EXAMPLE
        //public double Potty()
        //{
        //    if (crap == true)
        //    {
        //        Console.WriteLine("Your dog just made a mess");
        //        weight -= 1.0;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your dog has made a relieve");
        //        weight += 1.0;
        //    }
        //    return weight;
     // }
        
        public void Cuddle()
        {
            Console.WriteLine("Aww doge is so cute");
        }


    }
    
}
