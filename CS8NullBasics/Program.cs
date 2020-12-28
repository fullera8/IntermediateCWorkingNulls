using System;

namespace CS8NullBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message(null, "Hello There!");

            //MessagePopulator.Populate(message);
            
            Console.WriteLine(message.Text);
            Console.WriteLine(message.From);
            Console.WriteLine(message.From.Length);
            Console.WriteLine(message.ToUpperFrom());

            Console.WriteLine("Press Enter to end the app.");
            Console.ReadLine();
        }
    }
}
