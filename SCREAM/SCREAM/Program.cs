using System;
using System.Threading;

namespace SCREAM
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(" _____________   __________   _______      __");
            Console.WriteLine("/    _________| /   _______| |   ___ |    |  |");
            Console.WriteLine("|   | ________ /   /         |  |   | |   |  | ");
            Console.WriteLine("|_________   | |   |         |  |___| |   |  |");
            Console.WriteLine("          |  | |   |         |    __ |_   |__| ");
            Console.WriteLine("__________|  | |   |_______  |  |   |  |   __");
            Console.WriteLine("|____________/ |___________| |__|   |__|  |__|");

            Console.WriteLine("Please Select A Character To Scream");
            var scrTEXT = Console.ReadLine();
            if (scrTEXT.Length > 6)
            {
                Console.WriteLine("that's too long");
                Thread.Sleep(750);
                Console.Clear();
                Main();
            }
            if (scrTEXT.Length < 1)
            {
                Console.WriteLine("that's too short");
                Thread.Sleep(750);
                Console.Clear();
                Main();
            }
            Console.Clear();
            shape(scrTEXT);

        }
        static void shape(string screami)
        {
            string screaming = screami;
            Console.WriteLine("Pyramid ascii ver? (y/n)");
            string Keypress = Console.ReadLine();
            if (Keypress == "y")
            {
                Console.Clear();
                Sec(screaming);
            }
            else
            {
                Console.Clear();
                Tec(screaming);
            }
        }
        static void Sec(string screaming)
        {
            var lengthNeeded = 53;
            int caseSwitch = screaming.Length;

            switch (caseSwitch)
            {
                case 1:
                    lengthNeeded = 53;
                    break;
                case 2:
                    lengthNeeded = 56;
                    break;
                case 3:
                    lengthNeeded = 59;
                    break;
                case 4:
                    lengthNeeded = 62;
                    break;
                case 5:
                    lengthNeeded = 65;
                    break;
                case 6:
                    lengthNeeded = 68;
                    break;
                default:
                    lengthNeeded = 53;
                    break;
            }
            var scream = screaming;
            var Length_of_Bot = ".";
            int repeat = 25;
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(scream + scream + scream);
                scream = scream + " ";
                Thread.Sleep(100);
            }
            Console.WriteLine(scream + scream + scream);
            Thread.Sleep(100);
            int lengthey = lengthNeeded;
            for (int i = 0; i < lengthey; i++)
            {
                Length_of_Bot = Length_of_Bot + ".";
            }
            Console.WriteLine(Length_of_Bot);
            Thread.Sleep(1000);
            Console.Clear();
            Sec(screaming);

        }
        static void Tec(string screaming)
        {
            var scream = screaming;
            int repeat = 25;
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(scream + scream + scream + scream + scream + scream + scream + scream + scream);
                Thread.Sleep(100);
            }
            Thread.Sleep(1000);
            Console.Clear();
            Tec(screaming);

        }
    }
}
