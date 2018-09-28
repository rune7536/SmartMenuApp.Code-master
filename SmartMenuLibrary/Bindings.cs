using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class Bindings
    {
        internal static void call(string userInput)
        {
            int choice = 0;

            try
            {
                choice = Int32.Parse(userInput);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 4:
                    Console.WriteLine("case 4");
                    break;
                default:                      
                    Console.WriteLine("exit");
                    break;

            }
        }
    }
}
