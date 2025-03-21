using System;
using FactoryMethod;

class Program
{
    static void Main()
    {
        // Chạy phiên bản không dùng Factory Method
        Problem.Run();

        // Chạy phiên bản có Factory Method
        Solution.Run();
    }
}
