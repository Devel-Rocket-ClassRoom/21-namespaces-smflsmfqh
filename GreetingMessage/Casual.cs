using System;


namespace Casual
{
    class Message
    {
        public static void SayHello(string name)
        {
            Console.WriteLine($"안녕, {name}!");
        }

        public static void SayBye(string name)
        {
            Console.WriteLine($"잘가, {name}!");
        }
    }
}
