using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    double result = 0;

                    //Console.WriteLine("Enter a value to convert:");
                    //int input = int.Parse(Console.ReadLine());

                    //if (input < 0)
                    //    throw new Exception("Please only enter numbers greater than 0.");
                  
                    
                    Console.WriteLine("Enter number of Megabytes");
                    int mb = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number of Gigabytes");
                    int gb = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number of Terabytes");
                    int tb = int.Parse(Console.ReadLine());

                    Conversion c = new Conversion(mb, gb, tb);

                    Console.WriteLine("1. Convert Megabyte to Byte\n2. Convert Gigabyte to Megabyte\n3. Convert Terrabyte to Gigabyte\n4. Exit");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            result = c.ConvertMegabyteToByte(mb);
                            Console.WriteLine("The result is " + result + " Bytes");
                            break;

                        case 2:
                            result = c.ConvertGigabyteToMegabyte(gb);
                            Console.WriteLine("The result is " + result + " Megabytes");
                            break;
                        case 3:
                            result = c.ConvertTerrabyteToGigabyte(tb);
                            Console.WriteLine("The result is " + result + " gigabytes");
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            throw new Exception("Incorrect option. Please try again.");
                    }

                    if (!exit)
                        Console.WriteLine("Result: " + result.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e + "\nERROR\nPress ENTER to try again.\n");
                    Console.ReadLine();
                }
            }
            Environment.Exit(1);
        }
    }
}
  