using System;
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = MyClass<int>.FactoryMethod();
            var word = MyClass<double>.FactoryMethod();
            Console.WriteLine($"Value: {num} and type: {num.GetType()}");
            Console.WriteLine($"Value: {word} and type: {word.GetType()}");
        }
    }
}