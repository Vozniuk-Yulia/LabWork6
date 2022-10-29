using System;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}