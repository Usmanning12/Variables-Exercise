namespace VariablesExercise
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName; // declaration syntax

            dogName = "Rex"; // Initialized --- assigning a value 

            int dogAge = 5; //Declaring and initializing

            char firstIntial = 'R';

            bool isHungry = true;

            double dogWeight = 54.3;

            decimal dogHeight = 14.7m;

            Console.WriteLine(
                $"Hello,my dog's name is {dogName}, his initial is {firstIntial} and he is {dogAge} years old.");
            Console.WriteLine($"He weighs {dogWeight} pounds and his is {dogHeight} inches tall");
            Console.WriteLine($"It is {isHungry.ToString().ToLower()} he is always hungry.");
        }
    }
}
    
    

