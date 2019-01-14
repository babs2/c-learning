using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pw = "";

            // while (pw != "password")
            // {
            //     Console.WriteLine("what is the password?");
            //     pw = Console.ReadLine();
            //     if (pw == "password")
            //     {
            //         Console.WriteLine("Authentic");
            //         Console.ReadKey();
            //     }
            //     else
            //     {
            //         Console.WriteLine("get lost");
            //     }
            // }






















            var pw = "";


            while (pw != "Secret")
            {
                Console.WriteLine("Enter Password");
                pw = Console.ReadLine();

                if (pw == "Secret")
                {
                    Console.WriteLine("Authenticated");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("bug off");
                }
            }



            //Console.WriteLine("what is your name?");
            //var name = Console.ReadLine();
            //Console.WriteLine("Great, Now what month were you born in?");
            //var month = Console.ReadLine();
            //Console.WriteLine("Well, " + name + " your sign is ");
            //if (month == "July")
            //{
            //    Console.WriteLine("Leo");
            //    Console.ReadKey();
            //}

        }
    }
}
