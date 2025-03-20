using System;
using Singleton;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Vấn đề không dùng Singleton ===");
        Singleton.Problem.Run();

        Console.WriteLine("\n=== Giải pháp dùng Singleton ===");
        Singleton.Solution.Run();
    }
}
