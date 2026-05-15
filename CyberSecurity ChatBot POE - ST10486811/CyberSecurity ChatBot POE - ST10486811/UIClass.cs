using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberSecurityChatbot_GUI
{
    internal class UIClass
    {
        public static void displayLogo()
        {
            // ASCII Logo
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@  ____                       _ _         @");
            Console.WriteLine("@ / ___|  ___  ___ _   _ _ __(_) |_ _   _ @");
            Console.WriteLine("@ |___   / _ |/ __| | | | '__| | __| | | |@");
            Console.WriteLine("@  ___) | ___/|(__| |_| | |  | | |_| |_| |@");
            Console.WriteLine("@ |____/ |___| |__|___,_|_|  |_||__||__, |@");
            Console.WriteLine("@                                   |___/ @");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("\n" + new string('=', 43) + "\n");
            Console.ResetColor();
        }

        // Method to create a typing effect(10ms delay on typing for a more normal conversational speed)
        public static void typeMessage(string message, ConsoleColor color = ConsoleColor.DarkBlue)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
