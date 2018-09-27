using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"..\..\MenuSpec.txt");

            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }
            file.Close();
        }
        public void Activate()
        {

        }
    }
}
