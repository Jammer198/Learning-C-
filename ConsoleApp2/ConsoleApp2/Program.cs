using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter1;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            

            Scene scText = new Scene();
            Scene scName = new Scene();
            
            scText.message = "Hello World";
            scText.ShowMenu(scText);

            scText.message = "\nPlease tell me your name";
            scText.ShowMenu(scText);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nYour name is ");

            scName.name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;

            scText.message = ("\nHi " + scName.name);
            scText.ShowMenu(scText);

            scText.message = ("\nLet me tell you a Story");
            scText.ShowMenu(scText);


            scText.message = ("\nThe Story is about a Man, Called " + scName.name + " , Who is hardworking");
            scText.ShowMenu(scText);

            scText.message = "\nOne day , He went to the supermarket to buy some fresh vegetable";
            scText.ShowMenu(scText);

            scText.message = ("\nHe saw a Man , A very strange Man");
            scText.ShowMenu(scText);

            scText.message = ("\nHe behaved strange , like a disabled people , But Trying to steal things");
            scText.ShowMenu(scText);


            scText.message = ("\nCan you guess what will "+ scName.name + " do");
            scText.ShowMenu(scText);


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n1. Try to stop him");
            Console.WriteLine("2. Nothing");
            

            bool isCheck = true;
            int i = 0;

            for (; isCheck;)
            {
                try
                {

                    i = int.Parse(Console.ReadLine());
                    
                    isCheck = false ;

                }
                catch
                {

                    Console.WriteLine("Please input a right number");

                    isCheck = true;

                }



            }

            if (i == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                scText.message = (scName.name + " said : Hey ! You can't do this , get out of here");
                scText.ShowMenu(scText);

                Console.ForegroundColor = ConsoleColor.White;
                scText.message = ("\nThen , The Man run away , he saved the supermarket's goods");
                scText.ShowMenu(scText);

                scText.message = ("\nBut soon , he found that everyone was angry with he ");
                scText.ShowMenu(scText);

                scText.message = ("\nActually , he were the real thief");
                scText.ShowMenu(scText);

                return;

            }
            if (i == 2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                scText.message = (scName.name + " did nothing , seeing the thief took goods running away");
                scText.ShowMenu(scText);

                

                return;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                scText.message = (scName.name + " said : Hey ! Stop this or I will call the police");
                scText.ShowMenu(scText);

                Console.ForegroundColor = ConsoleColor.White;
                scText.message = ("\nThe Man looked at him for a while , but did not care about what he says");
                scText.ShowMenu(scText) ;

                scText.message = ("\nHe called the police , Asking for help");
                scText.ShowMenu(scText);

                scText.message = ("\nSoon the police arrived , Took A Man away.");
                scText.ShowMenu(scText);


            }



        }
    }
}
