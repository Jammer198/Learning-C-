using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp2;

namespace Chapter1
{
    public class Scene
    {

        
        public string message;
        public string name;

        public void ShowMenu(Scene scText)
        {
            foreach (char c in scText.message)
            {
                
                Console.Write(c);
                Thread.Sleep(50);
                

            }

            Console.ReadKey();




        }
    }
}