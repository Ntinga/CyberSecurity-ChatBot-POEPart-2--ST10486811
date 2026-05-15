using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot_GUI
{
    public delegate string SentimentDelegate(string input);
    internal class ChatBotClass
    {
        public string UserName { get; set; }

        // Voice message audio
        // PlaySync() plays audio till finish
        public void playVoiceMessage()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer("Recording.wav"))
                {
                    player.Play();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("System Note: Welcome audio not found.");
            }
        }
        public void Start()
        {
            
            System.Console.WriteLine("Bot is running...");
        }

        public class ChatbotClass
        {
            //Generic Collections
            public Dictionary<string, string> userMemory = new Dictionary<string, string>();

            public string GetResponse(string input, SentimentDelegate checkSentiment)
            {
                string lowerInput = input.ToLower();

                // 1. Keyword Recognition
                if (lowerInput.Contains("purpose"))
                    return "My purpose is to educate citizens on identifying cyber threats like phishing.";

                if (lowerInput.Contains("password"))
                    return "Safe practices include using long, complex passwords and 2FA.";

                if (lowerInput.Contains("phishing"))
                    return "Phishing is when attackers use fake links to steal data. Check the sender's address!";

                // 2. Default Response
                return "I'm not sure how to answer that yet. Ask me about 'passwords' or 'phishing'.";
            }

            // Your existing voice method
            public void playVoiceMessage()
            {
                try
                {
                    using (var player = new System.Media.SoundPlayer("Recording.wav"))
                    {
                        player.Play();
                    }
                }
                catch { /* Handle missing file */ }
            }
        }
    }
}
