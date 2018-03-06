using DotNetDebuggerDisplay;
using System.Diagnostics;

namespace ConsoleDemoDotNetDebuggerDisplay
{

    [DebuggerDisplay("{DotNetDebuggerDisplay.DebuggerDisplayFrom<Person>.PropertiesOf(this)}")]
    public class Person
    {
        [DebuggerDisplayMember] public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}