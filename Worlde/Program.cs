using System;
using System.IO;
using System.Collections.Generic;
namespace Worlde

{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConsoleKey key = Console.ReadKey(true).Key;
            if (key.ToString() == "Enter")
            {

            }


            String textToEnter1 = @"  _    _               _ _      ";
            String textToEnter2 = @" | |  | |             | | |     ";
            String textToEnter3 = @" | |  | | ___  _ __ __| | | ___ ";
            String textToEnter4 = @" | |/\| |/ _ \| '__/ _` | |/ _ \";
            String textToEnter5 = @" \  /\  / (_) | | | (_| | |  __/";
            String textToEnter6 = @"  \/  \/ \___/|_|  \__,_|_|\___|";
            String textToStart = @"Press 'Enter' to start the game";
             bool Repeat = true;
        
            Console.SetWindowSize(120, 30);
            Console.WriteLine(@"


            ");
            // centere AciiArten
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter3.Length / 2)) + "}", textToEnter3));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter4.Length / 2)) + "}", textToEnter4));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter5.Length / 2)) + "}", textToEnter5));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter6.Length / 2)) + "}", textToEnter6));
    
            Console.WriteLine(@"


            ");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToStart.Length / 2)) + "}", textToStart));

            while (Repeat)
            {

                ConsoleKey key= Console.ReadKey(true).Key;
                if (key.ToString()== "Enter")
                {
                    Repeat = false;
                }
                else
                {
                    continue;
                }
            }


            string text = File.ReadAllText("words.txt");
            string[] allWords = text.Split('\n');

            List<string> EasyWords = new List<string>();
            List<string> MediumWords = new List<string>();
            List<string> HardWords = new List<string>();

            for (int i = 0; i < allWords.Length; i++)
            {
                if (allWords[i].Length == 5)
                {
                    EasyWords.Add(allWords[i]); 
                }
                else if (allWords[i].Length == 7)
                {
                    MediumWords.Add(allWords[i]);
                }
                else if (allWords[i].Length == 10) 
                { 
                    HardWords.Add(allWords[i]);
                }

            }

            for (int i = 0; i < EasyWords.Count; i++)
            {
                Console.WriteLine(EasyWords[i]);
            }




        }
    }
}
