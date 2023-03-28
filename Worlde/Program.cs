﻿using Microsoft.VisualBasic;
using System;
namespace Worlde

{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> EasyWords = new List<string>(); //EasyWords er ord på 5 bogstaver.
            EasyWords.Add("above");
            EasyWords.Add("abyss");
            EasyWords.Add("alarm");
            EasyWords.Add("baker");
            EasyWords.Add("blood");
            EasyWords.Add("choke");
            EasyWords.Add("clone");
            EasyWords.Add("dance");
            EasyWords.Add("dryer");
            EasyWords.Add("enjoy");
            EasyWords.Add("ethic");
            EasyWords.Add("faith");
            EasyWords.Add("float");
            EasyWords.Add("glove");
            EasyWords.Add("guard");
            EasyWords.Add("horny");
            EasyWords.Add("input");
            EasyWords.Add("joint");
            EasyWords.Add("kneel");
            EasyWords.Add("logic");
            EasyWords.Add("milky");
            EasyWords.Add("nerdy");
            EasyWords.Add("noble");
            EasyWords.Add("order");
            EasyWords.Add("proxy");

            List<string> MediumWords = new List<string>(); //MediumWords er ord på 7 bogstaver.
            MediumWords.Add("ability");
            MediumWords.Add("acquire");
            MediumWords.Add("anxious");
            MediumWords.Add("between");
            MediumWords.Add("biology");
            MediumWords.Add("chemist");
            MediumWords.Add("clarity");
            MediumWords.Add("decline");
            MediumWords.Add("display");
            MediumWords.Add("educate");
            MediumWords.Add("elegant");
            MediumWords.Add("furious");
            MediumWords.Add("harmful");
            MediumWords.Add("history");
            MediumWords.Add("improve");
            MediumWords.Add("impulse");
            MediumWords.Add("lawsuit");
            MediumWords.Add("lighter");
            MediumWords.Add("massage");
            MediumWords.Add("mystery");
            MediumWords.Add("officer");
            MediumWords.Add("penalty");
            MediumWords.Add("posture");
            MediumWords.Add("respect");
            MediumWords.Add("shallow");

            List<string> HardWords = new List<string>(); //HardWords er ord på 10 bogstaver
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");
            HardWords.Add("");



            //Variabler
            var random = new Random(); // vælger et tilfældigt tal
            int indexEasy = random.Next(EasyWords.Count); //vælger et tilfældigt ord fra listen easywords
            int indexMedium = random.Next(MediumWords.Count); //vælger et tilfældigt ord fra listen mediumwords
            int indexHard = random.Next(HardWords.Count); //vælger et tilfældigt ord fra listen hardwords

            //Console.WriteLine(EasyWords[indexEasy]); // for at kalde et tilfæligt ord fra listen
          
            //Startside





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

                }

            }





        }
        static void sus(string Rigtigtord)
        {
            int Antalforsøg = 0;
            while (true)
            {
                int RigtigeGæt = 0;
                string UserGuess = Console.ReadLine();
                Antalforsøg++;

                if (UserGuess.Length != Rigtigtord.Length)
                {
                    Console.WriteLine("your words is not matching the leantgh of the word");
                    continue;
                }

                for (int i = 0; i < UserGuess.Length; i++)
                {
                    if (UserGuess[i] == Rigtigtord[i])
                    {
                        Console.WriteLine("Correct letter: " + UserGuess[i].ToString());
                        RigtigeGæt++;
                    }
                    else
                    {
                        for (int j = 0; j < UserGuess.Length; j++)
                        {
                            if (UserGuess[i] == Rigtigtord[j])
                            {
                                Console.WriteLine(UserGuess[i].ToString() + " is in the word");
                            }
                        }
                    }


                }
                if (Antalforsøg == 5)
                {
                    Console.WriteLine("your brugte to many tryes. the right word was " + Rigtigtord);
                    break;
                }
                if (Rigtigtord.Length == RigtigeGæt)
                {
                    Console.WriteLine("du gættede det rigtige ord " + Rigtigtord);
                    break;
                }

            }

        }
    }
}
