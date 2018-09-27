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
                Console.WriteLine(item);

            }
            string call = System.Console.ReadLine();
            Bindings.call(call);
        }
    }
}
