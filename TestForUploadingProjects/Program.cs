using System;

namespace TestForUploadingProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            if (message.Length < 10)
            {
                Console.WriteLine("Length is bigger than 10");
            }
            else
            {
                Console.WriteLine("Length is less than 10");
            }
            Console.WriteLine("Made a change");
        }
    }
}
