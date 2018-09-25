using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170_Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            int rectlength = rectangle.Length;
            int rectwidth = rectangle.Width;


            string length = string.Empty;

            string width = string.Empty;

            string userinput = string.Empty;
            bool validMenuSelection = false;
            while (validMenuSelection == false)
            {



                Console.WriteLine("1 Get Rectangle Length");
                Console.WriteLine("2 Change Rectangle Length");
                Console.WriteLine("3 Get Rectangle Width");
                Console.WriteLine("4 Change Rectangle Width");
                Console.WriteLine("5 Get Rectangle Perimeter");
                Console.WriteLine("6 Get Rectangle Area");
                Console.WriteLine("7 Exit");

                userinput
                    = Console.ReadLine();


                if (userinput == "1")
                {

                    Console.WriteLine("Length of the Rectangle is {0} ", rectangle.GetLength());
                }

                else if (userinput == "2")
                {
                    Console.WriteLine("Enter new Length");
                    length = Console.ReadLine();

                    if ((rectlength <= 0) && (!int.TryParse(length, out rectlength)))
                    {
                        Console.WriteLine("Please enter a valid length");
                    }
                    else
                    {

                        Console.WriteLine("New length is {0} ", rectangle.SetLength(rectlength));
                    }
                }

                else if (userinput == "3")
                {
                    Console.WriteLine("Width is {0} ", rectangle.GetWidth());
                }

                else if (userinput == "4")
                {
                    Console.WriteLine("Enter new width");
                    width = Console.ReadLine();
                    if ((rectwidth <= 0) && (!int.TryParse(width, out rectwidth)))
                    {
                        Console.WriteLine("please enter a valid width");
                    }
                    else
                    {

                        Console.WriteLine("New width is {0} ", rectangle.SetWidth(rectwidth));
                    }
                }
                else if (userinput == "5")
                {

                    Console.WriteLine("Perimeter is {0} ", rectangle.GetPerimeter());
                }
                else if (userinput == "6")
                {

                    Console.WriteLine("Area is {0} ", rectangle.GetArea());
                }
                else if (userinput == "7")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter the value correctly");
                }
            }



        }
    }
}
