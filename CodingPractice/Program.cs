using System;
using static System.Console;
using static System.Math;


// 1
{
    Foo.Car.Go();
    Bar.Car.Go();
    Console.WriteLine();
}
// 2
{
    Korea.Seoul.Car.Run();
    Korea.Incheon.Car.Run();
    Console.WriteLine();
}

// 3
{
    WriteLine("Hello, World");
    WriteLine($"제곱근: {Math.Sqrt(16)}");
    WriteLine($"최댓값: {Math.Max(5, 20)}");
}

// --- namespace 정의 ---

    // 1
namespace Foo
{
    class Car
    {
        public static void Go()
        {
            Console.WriteLine("Foo 네임스페이스의 Car 클래스");
        }
    }
}

namespace Bar
{
    class Car
    {
        public static void Go()
        {
            Console.WriteLine("Bar 네임스페이스의 Car 클래스");
        }
    }
}

// 2
namespace Korea.Seoul
{
    class Car
    {
        public static void Run()
        {
            Console.WriteLine("서울 자동차가 달립니다");
        }
    }
}

namespace Korea.Incheon
{
    class Car
    {
        public static void Run()
        {
            Console.WriteLine("인천 자동차가 달립니다");
        }
    }
}

