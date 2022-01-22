using Event;
using System;
using System.Text;
using static Event.Run;

namespace ConsoleApp11
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");

            var str = Console.ReadLine();
            MyClass cls = new MyClass();
            Func funcDell = cls.Space;
            funcDell += cls.Reverse;

            Run run = new Run();
            run.RunFunc(funcDell, str);
        }
    }
}
