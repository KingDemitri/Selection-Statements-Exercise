namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Guess my favorite Number");
            var userInput = int.Parse(Console.ReadLine());


            if (userInput < favNumber) 
            {
                Console.WriteLine("Too low :(");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high :(");                    
            }
            else {
                Console.WriteLine("You guessed it! :)");
            }


        }
    }
}


//Create an if-statement that if the guessed number is below the initial value, print out “too low”.
//    Create an else-if statement that if the number is higher than the initial value, print out “too high”.
//    Create an else statement that prints out some type of congratulations for guessing the correct number e.g. “You guessed it!!!”.