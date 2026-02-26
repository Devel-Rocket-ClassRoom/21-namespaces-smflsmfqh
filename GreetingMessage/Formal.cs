using System;

namespace Formal
{
    class Message
    {
        public static void SayHello(string name)
        {
            Console.WriteLine($"{name}님, 안녕하십니까!");
        }

        public static void SayBye(string name)
        {
            Console.WriteLine($"{name}님, 안녕히 가십시오!");
        }
    }
}