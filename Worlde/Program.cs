using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Worlde

{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool Repeat = true;

            Console.SetWindowSize(120, 30);
            Console.WriteLine(@"
            ");

            // centere AciiArten
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  _    _               _ _      ".Length / 2)) + "}", @"  _    _               _ _      "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" | |  | |             | | |     ".Length / 2)) + "}", @" | |  | |             | | |     "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" | |  | | ___  _ __ __| | | ___ ".Length / 2)) + "}", @" | |  | | ___  _ __ __| | | ___ "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" | |/\| |/ _ \| '__/ _` | |/ _ \".Length / 2)) + "}", @" | |/\| |/ _ \| '__/ _` | |/ _ \"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" \  /\  / (_) | | | (_| | |  __/".Length / 2)) + "}", @" \  /\  / (_) | | | (_| | |  __/"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  \/  \/ \___/|_|  \__,_|_|\___|".Length / 2)) + "}", @"  \/  \/ \___/|_|  \__,_|_|\___|"));

            Console.WriteLine(@"
            ");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"Press enter to continue...".Length / 2)) + "}", @"Press enter to continue..."));


            while (Repeat)
            {

                //Startside

                ConsoleKey Key0 = Console.ReadKey(true).Key;
                if (Key0.ToString() == "Enter")
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
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"______      _           ".Length / 2)) + "}", @"______      _           "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"| ___ \    | |          ".Length / 2)) + "}", @"| ___ \    | |          "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"| |_/ /   _| | ___  ___ ".Length / 2)) + "}", @"| |_/ /   _| | ___  ___ "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"|    / | | | |/ _ \/ __|".Length / 2)) + "}", @"|    / | | | |/ _ \/ __|"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"| |\ \ |_| | |  __/\__ \".Length / 2)) + "}", @"| |\ \ |_| | |  __/\__ \"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"\_| \_\__,_|_|\___||___/".Length / 2)) + "}", @"\_| \_\__,_|_|\___||___/"));

                Console.WriteLine(@"
            ");
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"The rules of Wordle are elegantly simple.                                ".Length / 2)) + "}", @"The rules of Wordle are elegantly simple.                               "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"Your objective is to guess a secret five to ten-letter word              ".Length / 2)) + "}", @"Your objective is to guess a secret five to ten-letter word             "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"in as few guesses as possible.To submit a guess, type any                ".Length / 2)) + "}", @"in as few guesses as possible. To submit a guess, type any              "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"five to ten-letter word and press enter. All of your guesses.            ".Length / 2)) + "}", @"five to ten-letter word and press enter. All of your guesses.           "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"must be real words,according to a dictionary of five to ten-letter words ".Length / 2)) + "}", @"must be real words,according to a dictionary of five to ten-letter words"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"that Wordle allows as guesses.                                           ".Length / 2)) + "}", @"that Wordle allows as guesses.                                          "));
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (@"Press Enter to start...                                                  ".Length / 2)) + "}", @"Press Enter to start...                                                 "));

                ConsoleKey Key1 = Console.ReadKey(true).Key;
                if (Key1.ToString() == "Enter")
                {
                    Repeat = false;

                }
                else
                {
                    continue;

                }
                Console.Clear();


                bool Tryagain = true;

                while (Tryagain)// du kan prøve igen
                {


                    Console.WriteLine(@"
                ");

                    int selectedClass = ConsoleHelper.MultipleChoice(true, "Easy", "Medium", "Hard");
                }

            }
        }

        static void Sværhedsgrad(string Rigtigtord)
        {


            int Antalforsøg = 0;
            while (true)
            {
                Console.WriteLine();
                int RigtigeGæt = 0;
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ("".Length - Rigtigtord.Length / 2)) + "}", ""));
                string UserGuess = Console.ReadLine().ToLower();
                string hint = "*";

                if (UserGuess == hint)
                {
                    Console.WriteLine("du gætter nu");
                    



                    continue;
                }
                 


                Antalforsøg++;



                if (UserGuess.Length != Rigtigtord.Length)
                {
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("your words is not matching the leantgh of the word".Length / 2)) + "}", "your words is not matching the leantgh of the word"));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("Try again".Length / 2)) + "}", "Try again"));

                    continue;
                }
                string text = File.ReadAllText("words.txt");
                string[] allWords = text.Split('\n');

                bool detErEtRigtigtOrd = false;
                for (int i = 0; i < allWords.Length; i++)
                {
                    if (allWords[i] == UserGuess)
                    {
                        detErEtRigtigtOrd = true;
                    }

                }
                if (!detErEtRigtigtOrd)
                {
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("This word doesn't exist".Length / 2)) + "}", "This word doesn't exist"));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("Try again".Length / 2)) + "}", "Try again"));
                    continue;
                }
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ("".Length - UserGuess.Length / 2)) + "}", ""));
                bool somethingElse = false;
                for (int i = 0; i < UserGuess.Length; i++)
                {
                    somethingElse = false;
                    if (UserGuess[i] == Rigtigtord[i])
                    {
                        somethingElse = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(UserGuess[i].ToString());
                        RigtigeGæt++;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        for (int j = 0; j < UserGuess.Length; j++)
                        {
                            if (UserGuess[i] == Rigtigtord[j])
                            {
                                somethingElse = true;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(UserGuess[i].ToString());
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        }
                    }
                    if (!somethingElse)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(UserGuess[i].ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }


                if (Antalforsøg == 5)
                {
                    Console.WriteLine("");
                    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ("you used too many tries. the right word was ".Length / 2)) + "}", "you used too many tries. the right word was "));
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(Rigtigtord);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadKey(true);
                    break;
                }
                if (Rigtigtord.Length == RigtigeGæt)
                {
                    Console.WriteLine();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("you guessed the right word ".Length / 2)) + "}", "you guessed the right word "));
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(Rigtigtord);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadKey(true);
                    break;
                }

            }





        }


        public static class ConsoleHelper
        {
            public static int MultipleChoice(bool canCancel, params string[] options)
            {
                //Ordlisten bliver lavet og splittet
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


                const int startX = 40;
                const int startY = 11;
                const int optionsPerLine = 3;
                const int spacingPerLine = 19;

                int currentSelection = 0;

                ConsoleKey key;

                Console.CursorVisible = false;

                Console.Clear();
                Console.WriteLine(@"
");


                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  ______ _  __  __ _            _ _         ".Length / 2)) + "}", @"  ______ _  __  __ _            _ _         "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  |  _  (_)/ _|/ _(_)          | | |        ".Length / 2)) + "}", @"  |  _  (_)/ _|/ _(_)          | | |        "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  | | | |_| |_| |_ _  ___ _   _| | |_ _   _ ".Length / 2)) + "}", @"  | | | |_| |_| |_ _  ___ _   _| | |_ _   _ "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  | | | | |  _|  _| |/ __| | | | | __| | | |".Length / 2)) + "}", @"  | | | | |  _|  _| |/ __| | | | | __| | | |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  | |/ /| | | | | | | (__| |_| | | |_| |_| |".Length / 2)) + "}", @"  | |/ /| | | | | | | (__| |_| | | |_| |_| |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  |___/ |_|_| |_| |_|\___|\__,_|_|\__|\__, |".Length / 2)) + "}", @"  |___/ |_|_| |_| |_|\___|\__,_|_|\__|\__, |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"                                       __/ |".Length / 2)) + "}", @"                                       __/ |"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"                                      |___/ ".Length / 2)) + "}", @"                                      |___/ "));


                do
                {



                    for (int i = 0; i < options.Length; i++)
                    {
                        Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                        if (i == currentSelection)
                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(options[i]);
                        Console.ResetColor();
                    }

                    key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.LeftArrow:
                            {
                                if (currentSelection % optionsPerLine > 0)
                                    currentSelection--;
                                break;
                            }
                        case ConsoleKey.RightArrow:
                            {
                                if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                    currentSelection++;
                                break;
                            }
                        case ConsoleKey.Enter:
                            {



                                if (currentSelection == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"

");
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("EasyWords is chosen".Length / 2)) + "}", "EasyWords is chosen"));
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("EasyWords has a length of five-letters".Length / 2)) + "}", "EasyWords has a length of five-letters"));

                                    string Rigtigtord = EasyWords[indexEasy]; //bestemmer det valgte ord

                                    Sværhedsgrad(Rigtigtord);
                                }
                                else if (currentSelection == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"

");
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("MediumWords is chosen".Length / 2)) + "}", "MediumWords is chosen"));
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("MediumWords has a length of seven-letters".Length / 2)) + "}", "MediumWords has a length of seven-letters"));
                                    string Rigtigtord = MediumWords[indexMedium];
                                    Sværhedsgrad(Rigtigtord);
                                }
                                else if (currentSelection == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"

");
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("HardWords is chosen".Length / 2)) + "}", "HardWords is chosen"));
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("HardWords has a length of twelve-letters".Length / 2)) + "}", "HardWords has a length of twelve-letters"));
                                    string Rigtigtord = HardWords[indexHard];
                                    Sværhedsgrad(Rigtigtord);
                                }

                                break;
                            }






                    }
                } while (key != ConsoleKey.Enter);

                Console.CursorVisible = true;

                return currentSelection;

            }

        }




    }
}
