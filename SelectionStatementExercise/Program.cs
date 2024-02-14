namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing game
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            

            //user input
            Console.WriteLine("Pick a number between 1 and 1,000.");
            var userInput = int.Parse(Console.ReadLine());


            //if else statement assesing users input to favNumber
            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high.");
            }
            else
            {
                Console.WriteLine($"You guessed it! The number was {favNumber}!");
            }                                                


        }
    }
}
