using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

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





                Console.WriteLine(@"
______ _   _ _      _____ _____ 
| ___ \ | | | |    |  ___/  ___|
| |_/ / | | | |    | |__ \ `--. 
|    /| | | | |    |  __| `--. \
| |\ \| |_| | |____| |___/\__/ /
\_| \_|\___/\_____/\____/\____/ 
                                ");

                Console.WriteLine(@"
The Roles to this game is simple
* Gæt ordet
");


                Console.Clear();

                Console.WriteLine(@"
");
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" Difficulty".Length / 2)) + "}", @" Difficulty"));
                Console.WriteLine(@"
");
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"To chose difficulty press ".Length / 2)) + "}", @"To chose difficulty press "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"e=Easy         m=Medium          h=Hard".Length / 2)) + "}", @"e=Easy         m=Medium          h=Hard"));

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
                    Console.Clear();
                    Console.WriteLine(@"

");
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("EasyWords is chosen".Length / 2)) + "}", "EasyWords is chosen"));
                    
                    string Rigtigtord = EasyWords[indexEasy]; //bestemmer det valgte ord
                    
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
                Console.WriteLine();
                int RigtigeGæt = 0;
                Console.Write(String.Format("{0," + ((Console.WindowWidth/ 2) + ("".Length-Rigtigtord.Length / 2)) + "}", ""));
                string UserGuess = Console.ReadLine();

              
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
                    Console.WriteLine("Error Error, Det ord findes ikke bitch mand...");
                    continue;
                }


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


                if (Antalforsøg == 1)
                {
                    Console.WriteLine("");
                    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ("you used too many tries. the right word was " .Length/ 2)) + "}", "you used too many tries. the right word was "));
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(Rigtigtord);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                if (Rigtigtord.Length == RigtigeGæt)
                {
                    Console.WriteLine();
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("du gættede det rigtige ord ".Length / 2)) + "}", "du gættede det rigtige ord "));
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(Rigtigtord);
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                }

            }

        }
    }
}
