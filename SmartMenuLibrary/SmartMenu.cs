using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu

    {
        List<string> menuLines = new List<string>();
        public void LoadMenu(string path)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file = 
                new System.IO.StreamReader(@"..\..\MenuSpec.txt");


            while ((line = file.ReadLine()) != null)
            {
                menuLines.Add(line);             
                counter++; 
            }
            file.Close();
            
        }
        public void Activate()
        {
            foreach (var item in menuLines) {
                int i = 0;
                string idCut = item.Split(';')[i];
                Console.WriteLine(idCut);
                i++;
            }
            string call = System.Console.ReadLine();
            Bindings.call(call);

            int choice = 0;
            try {
                choice = Int32.Parse(userInput);
            }

            catch (FormatException e) {
                Console.WriteLine(e.Message);
            }

            switch (choice) {
                case 1:
                    Console.WriteLine(Functions.DoThis());
                    break;
                case 2:
                    Console.WriteLine(Functions.DoThat());
                    break;
                case 3:
                    Console.WriteLine("Skriv noget");
                    Console.WriteLine(Functions.DoSomething(Console.ReadLine()));
                    break;
                case 4:
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    break;
                default:
                    Console.WriteLine("exit");
                    break;
            }
        }
    }
}
