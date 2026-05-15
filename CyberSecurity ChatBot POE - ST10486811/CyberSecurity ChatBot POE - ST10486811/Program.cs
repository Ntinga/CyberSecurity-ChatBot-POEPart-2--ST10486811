using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot_GUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup console title
            Console.Title = "CyberSecurity Awareness ChatBot";

            ChatBotClass bot = new ChatBotClass();

            // Plays voice message
            bot.playVoiceMessage();

            // Displays ASCII Logo
            UIClass.displayLogo();

            // Start chat functionality
            bot.Start();

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
