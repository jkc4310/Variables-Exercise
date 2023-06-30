namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Rex";
            int age = 5;
            char initial = 'R';
            bool isHungry = true;
            double weight = 14.2;
            decimal height = 15.3m;

            Console.WriteLine($"Meet my dog {dogName}, but he also goes by {initial}!");
            Console.WriteLine($"He is {age} years old, {weight} pounds, and stands a whopping {height} inches off the ground.");
            Console.WriteLine($"It is {isHungry} that he is always hungry!");
        }  

    }
}
