using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu = "Meterials (have/need)";
            
            int cherryblossompetal = 6;
            int hardwood = 2;
            int clumpofweeds = 3;
            int clay = 3;




            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃     {menu}           ┃");
            Console.WriteLine($"┃                                     ┃");
            Console.WriteLine($"┃     cherry-blossom petal   0/{cherryblossompetal}      ┃");
            Console.WriteLine($"┃     hard wood              0/{hardwood}      ┃");
            Console.WriteLine($"┃     clump of weed          0/{clumpofweeds}      ┃");
            Console.WriteLine($"┃     clay                   0/{clay}      ┃");
            Console.WriteLine($"┃                                     ┃");
            Console.WriteLine($"┃                                     ┃");
            Console.WriteLine($"┃       ┏━━━━━━━━━━━━━━━┓             ┃");
            Console.WriteLine($"┃       ┃ No Meterials! ┃             ┃");
            Console.WriteLine($"┃       ┗━━━━━━━━━━━━━━━┛             ┃");
            Console.WriteLine($"┃                                     ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            


        }
    }
}
