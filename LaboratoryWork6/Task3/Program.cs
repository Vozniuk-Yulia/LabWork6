using System;
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.GetArray(list);
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}