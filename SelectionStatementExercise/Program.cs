namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the number guessing game!");
            Console.WriteLine("see if you cn guess the nmber correctly!");
            Console.WriteLine("what is the upper limit of the range number?");

            var userResponse = (Console.ReadLine());
            var upperLimit = int.Parse(userResponse);
            var random = new Random();
            var number = random.Next(1, 10);

            Console.WriteLine("input your guess please");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("your guess is too high");
            }

            else if (guess < number)
            {
                Console.WriteLine("your guess is too low");
            
            } 
            else 
            {
               Console.WriteLine("correct! Great job!");
            
            
            }
        }
    }
}
