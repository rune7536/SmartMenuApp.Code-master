﻿using System;
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
            string menuSpecPath = "";

            Console.WriteLine("Vælg Sprog");
            Console.WriteLine("Choose Language");
            Console.WriteLine("1. For Dansk" + "\n" + "2. For English");
            int langChoice = 0;
            string menuLang = Console.ReadLine();

            try
            {
                langChoice = Int32.Parse(menuLang);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            if (langChoice == 1)
            {
                menuSpecPath = @"..\..\MenuSpec.txt";                
            }
            else if (langChoice == 2)
            {
                menuSpecPath = @"..\..\MenuSpecEng.txt";
            }
            else
            {
                Console.WriteLine("Ikke en mulighed" + "\n" + "Not an Option");
            }


            System.IO.StreamReader file =
                new System.IO.StreamReader(menuSpecPath);

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

            int choice = 0;
            string userInput = Console.ReadLine();

            try
            {
                choice = Int32.Parse(userInput);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }                       
            Bindings.call(choice);
        }

    }
}
