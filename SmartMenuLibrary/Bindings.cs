using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    public class Bindings
    {
        internal static void call(int userInput)
        {

            switch (userInput)
            {
                case 1:
                    Console.WriteLine(Functions.DoThis());
                    break;
                case 2:
                    Console.WriteLine(Functions.DoThat());
                    break;
                case 3:
                    Console.WriteLine("Skriv Noget" + "\n" + "Write Something");
                    Console.WriteLine(Functions.DoSomething(Console.ReadLine()));
                    break;
                case 4:
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    break;
                case 0:
                    Console.WriteLine("Exit");
                    break;
            }
            if (userInput > 4)
            {
                Console.WriteLine("Forkert Valg" + "\n" + "Unknown Selection");
            }

        }
    }
}
