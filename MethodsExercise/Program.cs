namespace MethodsExercise
{
    public class Program
    {

        static void Main(string[] args)
        {
         /*   Run newProgram = new Run();
            newProgram.GetToKnowMeName();*/

            HelloWorld();
            GetToKnowMeName();
            //Product();
        }

        public static void GetToKnowMeName()
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

            Console.WriteLine("type a number you would like to add to.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("type another number you would like to add to it");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Addition(num1, num2);
            Console.WriteLine($"the sum of these numbers is {sum}");


            Console.WriteLine("type a number you would like to multiply.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("type another number you would like to multiply by.");
            int y = int.Parse(Console.ReadLine());

            int product = Product(x, y);
            Console.WriteLine($"the Produsct of these numbers is {product}");




        }
        public static void HelloWorld()
        {
            Console.WriteLine("Hello World"); 
        }

        public static int Addition(int num1, int num2)
        { return num1 + num2; }

        public static int Product(int x, int y)
        { return x * y; }

        //public static int UseParams(int num1, int num2, int num3)



    }
}
    