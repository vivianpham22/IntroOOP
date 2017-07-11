using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //// When we initialize a new object, it is called a INSTANTIATTING (creating a new instance)
            //// An an objects need to be instantiated before it can be used
            //// All objects of a specific type are created from the same template - CLASS
            //// All objects from a class will have the same number and type os states, BUT...
            //// ... each instance can have it's own unique values

            //// The FORMAT that we use to instaniate an object looks like this: 
            //// ClassName objectName = new ClassName();

            ////Cat mittens = new Cat();
            ////mittens.Name = "Mittens"; //<---- using the set
            ////Console.WriteLine(mittens.Age);

            //Cat firstCat = new Cat();

            //firstCat.Name = "Mittens";
            //// Console.WriteLine(firstCat.Age);

            //Cat secondCat = new Cat("Oz", 3, "Orange and white");
            //secondCat.Name = "Ozzy";
            //Console.WriteLine(secondCat.Name);
            //Console.WriteLine(secondCat.Age);
            //secondCat.Eat();

            //// To create a new object, we use a special method called a CONSTRUCTOR

            //// Thinking about objects in real life, create (either hand-write or type)
            //// 3 examples of object. Your objects should have 5 states (characteristics) 
            //// and 5 behaviors. 


            // SUPERHERO
            // creating 3 Superhero

            Superhero firstHero = new Superhero(); //default
            //firstHero.StrengthLevel = 100;
            //firstHero.HasCape = true;

            //firstHero.BattleNemesis();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            //firstHero.BattleNemesis();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            Superhero secondHero = new Superhero("Diamond Daniel"); //<---Diamond Daniel is set. They can not change.
            //Console.WriteLine(secondHero.StrengthLevel);

            //secondHero.AllyGained(); // <--- this is a method
            //Console.WriteLine(secondHero.StrengthLevel);

            Superhero thirdHero = new Superhero("Black Kevlar body armor", "The Best Ever", 1000, "Being the best", true);

            thirdHero.BattleNemesis();
            Console.WriteLine("Oh no! Now my costume is " + thirdHero.Costume);
            Console.WriteLine("And my strength has deminished to " + thirdHero.StrengthLevel);


        }
    }
}
