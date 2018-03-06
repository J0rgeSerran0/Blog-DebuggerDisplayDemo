using NetCoreDebuggerDisplay;
using System;

namespace ConsoleDemoNetCoreDebuggerDisplay
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Program started (.NET Core)");

            var personOne = new Person("Mary", 21);
            var personTwo = new Person("John", 22);

            Console.WriteLine($"{nameof(personOne)} => {DebuggerDisplayFrom<Person>.PropertiesOf(personOne)}");
            Console.WriteLine($"{nameof(personTwo)} => {DebuggerDisplayFrom<Person>.PropertiesOf(personTwo)}");

            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }

    }

}