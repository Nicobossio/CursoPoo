using System;

namespace CursoPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Persona1 = new Person();
            Persona1.Name = "Pedro";
            Persona1.Age = 21;

            Person Persona2 = new Person();
            Persona2.Name = "Daniela";
            Persona2.Age = 23;


            Console.WriteLine($"Persona1 se llama {Persona1.Name} y  tiene {Persona1.Age}");
            Console.WriteLine($"Persona1 se llama {Persona2.Name} y  tiene {Persona2.Age}");
            
        }
    }
}
