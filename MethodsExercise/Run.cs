using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Run
    {

        public void GetToKnowMeName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite food");
            string favoriteFood = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {userName}. It seems that you and i have a lot it common, for instance");
            Console.WriteLine($"I also love the color {favoriteColor}.");
            Console.WriteLine($"if i could have any pet I would want a/an {favoriteAnimal}.");
            Console.WriteLine($"I really love all food but if i had to choose just one i would pick {favoriteFood}!");


        }

    

    }
}
