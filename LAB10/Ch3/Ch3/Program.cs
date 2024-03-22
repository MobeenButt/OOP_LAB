using System;

namespace Ch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Mobeen", "Lahore", "Hello", 2020, 15000);
            Console.WriteLine(s.getName());
            Console.WriteLine(s.getFee());
            Console.WriteLine(s.getAddress());
            Console.WriteLine(s.getProgram());

            Console.WriteLine(s.toString());
            Console.ReadLine();
        }
    }
}
