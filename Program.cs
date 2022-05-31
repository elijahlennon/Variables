using System;

namespace Dogname
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Spike";

            int dogAge = 5;

            char firstInitial = 'S';

            bool isHungry = true;

            double dogWeight = 55.3;

            decimal dogHeight = 14.7m;

            Console.WriteLine($"My dog's name is {dogName}, he is {dogAge} years old, he weighs {dogWeight} pounds, he is {dogHeight} inches tall, and his initial is {firstInitial}.");
            Console.WriteLine("It is " + isHungry + " that he is always hungry.");
        }
    }
}
