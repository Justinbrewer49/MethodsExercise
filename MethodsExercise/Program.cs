namespace MethodsExercise
{
    public class Program
    {
        public static void madlib()
        { 
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            Console.WriteLine("whats your favorite food");
            string food = Console.ReadLine();
            Console.WriteLine("what are your hobbies");
            string hobbies = Console.ReadLine();
            Console.WriteLine("do you have a pet");
            string pet = Console.ReadLine();
            Console.WriteLine("what day was it");
            string day = Console.ReadLine();
            Console.WriteLine("what time was it");
            string time = Console.ReadLine();
            Console.WriteLine("what was the weather like");
            string weather = Console.ReadLine();
            
            
            Console.WriteLine($" on {day} {name} was eating {food} he was eating after playing {hobbies} around {time} it was {weather} his {pet} jumped up and took his {food}. It was a great day");
        }
        static void Main(string[] args){
            madlib();}
    }
}
