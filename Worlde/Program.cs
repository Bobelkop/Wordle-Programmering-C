using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Collections.Generic;
namespace Worlde

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.SystemKey key = Console.ReadKey(true).Key;
            if (key.ToString() == "Enter")
            {

            }


            String textToEnter1 = @"  _    _               _ _      ";
            String textToEnter2 = @" | |  | |             | | |     ";
            String textToEnter3 = @" | |  | | ___  _ __ __| | | ___ ";
            String textToEnter4 = @" | |/\| |/ _ \| '__/ _` | |/ _ \";
            String textToEnter5 = @" \  /\  / (_) | | | (_| | |  __/";
            String textToEnter6 = @"  \/  \/ \___/|_|  \__,_|_|\___|";
            String textToStart = @"Press enter to continue...";
             bool Repeat = true;

            //Menu
            String Sværhedsgrad = @" Difficulty";
            String choose = @"To chose difficulty press ";
            String Katogeri = @"e=Easy         m=Medium          h=Hard";
        
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

    


            //Variabler
            var random = new Random(); // vælger et tilfældigt tal
            int indexEasy = random.Next(EasyWords.Count); //vælger et tilfældigt ord fra listen easywords
            int indexMedium = random.Next(MediumWords.Count); //vælger et tilfældigt ord fra listen mediumwords
            int indexHard = random.Next(HardWords.Count); //vælger et tilfældigt ord fra listen hardwords

            //Console.WriteLine(EasyWords[indexEasy]); // for at kalde et tilfæligt ord fra listen

            //Startside

            while (Repeat)
            {

                ConsoleKey Key= Console.ReadKey(true).Key;
                if (Key.ToString()== "Enter")
                {
                    Repeat = false;
                }
                else
                {
                    continue;
                }
                Console.Clear();

                Console.WriteLine(@"
");
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Sværhedsgrad.Length / 2)) + "}", Sværhedsgrad));
                Console.WriteLine(@"
");
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (choose.Length / 2)) + "}", choose));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (Katogeri.Length / 2)) + "}", Katogeri));

                //bestemmer hvilkne katogori man har valgt
                char isPressed = Char.ToLower(Console.ReadKey(true).KeyChar);
                if (isPressed == 'e' || isPressed == 'm' || isPressed == 'h')
                {
                    Repeat = false;
                }
                else
                {
                    continue;
                }
                if (isPressed == 'e')
                {
                    Console.WriteLine("EasyWords is chosen");
                    string Rigtigtord = EasyWords[indexEasy]; //bestemmer det valgte ord
                    //string Rigtigtord = "kage";
                    sus(Rigtigtord);
                    



                }

                else if (isPressed == 'm')
                {
                    string Rigtigtord = MediumWords[indexMedium];

                    sus(Rigtigtord);
                }
                else if (isPressed == 'h')
                {
                    string Rigtigtord = HardWords[indexHard];
                    sus(Rigtigtord);


                List<string> EasyWords = new List<string>(); //EasyWords er ord på 5 bogstaver.
            EasyWords.Add("");
            EasyWords.Add("");

            List<string> MediumWords = new List<string>(); //MediumWords er ord på 7 bogstaver.
            MediumWords.Add("");


                if (Antalforsøg == 5)
                {
                    Console.WriteLine("you used too many tries. the right word was " + Rigtigtord);
                    break;
                }
                if (Rigtigtord.Length == RigtigeGæt)
                {
                    Console.WriteLine();
                    Console.WriteLine("du gættede det rigtige ord " + Rigtigtord);
                    break;
                }

            }

        }
    }
}
