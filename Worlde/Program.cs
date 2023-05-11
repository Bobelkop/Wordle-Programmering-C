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

            Console.SetWindowSize(120, 30); // sætter vindue størellsen
            Console.WriteLine(@"
            ");

            // centere AciiArten
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  _    _               _ _      ".Length / 2)) + "}", @"  _    _               _ _      "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" | |  | |             | | |     ".Length / 2)) + "}", @" | |  | |             | | |     "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" | |  | | ___  _ __ __| | | ___ ".Length / 2)) + "}", @" | |  | | ___  _ __ __| | | ___ "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" | |/\| |/ _ \| '__/ _` | |/ _ \".Length / 2)) + "}", @" | |/\| |/ _ \| '__/ _` | |/ _ \"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" \  /\  / (_) | | | (_| | |  __/".Length / 2)) + "}", @" \  /\  / (_) | | | (_| | |  __/"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"  \/  \/ \___/|_|  \__,_|_|\___|".Length / 2)) + "}", @"  \/  \/ \___/|_|  \__,_|_|\___|"));

            // centrere continue teksten
            Console.WriteLine(@"
            ");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"Press enter to continue...".Length / 2)) + "}", @"Press enter to continue..."));

            // mens Boolen Repeat er true kan man blive ved med at spille spillet
            while (Repeat)
            {

                //Startside
                // Skal trykke på Enter knappen for at kunne forstætte
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
                // centrere asciiarten
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"______      _           ".Length / 2)) + "}", @"______      _           "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"| ___ \    | |          ".Length / 2)) + "}", @"| ___ \    | |          "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"| |_/ /   _| | ___  ___ ".Length / 2)) + "}", @"| |_/ /   _| | ___  ___ "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"|    / | | | |/ _ \/ __|".Length / 2)) + "}", @"|    / | | | |/ _ \/ __|"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"| |\ \ |_| | |  __/\__ \".Length / 2)) + "}", @"| |\ \ |_| | |  __/\__ \"));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"\_| \_\__,_|_|\___||___/".Length / 2)) + "}", @"\_| \_\__,_|_|\___||___/"));

                Console.WriteLine(@"
            ");
                // centere reglerne
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"The rules of Wordle are elegantly simple.                                ".Length / 2)) + "}", @"The rules of Wordle are elegantly simple.                               "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"Your objective is to guess a secret five to ten-letter word              ".Length / 2)) + "}", @"Your objective is to guess a secret five to ten-letter word             "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"in five guesses. To submit a guess, type any five to ten-letter          ".Length / 2)) + "}", @"in five guesses. To submit a guess, type any five to ten-letter         "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"and press enter. All of your guesses must be real words,   m             ".Length / 2)) + "}", @"and press enter. All of your guesses must be real words,                "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@" according to a dictionary of five to ten-letter words                   ".Length / 2)) + "}", @"according to a dictionary of five to ten-letter words                   "));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (@"that Wordle allows as guesses. To get a hint you shall guess *.          ".Length / 2)) + "}", @"that Wordle allows as guesses. To get a hint you shall guess *.         "));
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (@"Press Enter to start...                                                  ".Length / 2)) + "}", @"Press Enter to start...                                                 "));

                //skal trykke på Enter for at kunne komme videre
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

                    // gøre sårn man kan bruge piletasterne til at vælge sværhedsgrad
                    int selectedClass = ConsoleHelper.MultipleChoice(true, "Easy", "Medium", "Hard");
                }

            }
        }
        // laver en static void til valg til den valgte sværhedsgrad for at undgå kode spild
        static void Sværhedsgrad(string Rigtigtord)
        {

            int antalhint = 0;
            int Antalforsøg = 0;
            string hint = "*";
            while (true)
            {
              
                // Laver et dictionary til alle grammatik spørgsmålene
                Dictionary<int,string> Grammatikspørgsmål = new Dictionary<int,string>();

                Grammatikspørgsmål.Add(0, "I play badminton");
                Grammatikspørgsmål.Add(1,"It is ranning outside");
                Grammatikspørgsmål.Add(2,"He attends school in Randers");
                Grammatikspørgsmål.Add(3,"Bob was watching TV, when the power went out");

                //laver et dictionary til all svarene til grammatik spørgsmålene
                Dictionary<int, string> GrammatikSvar = new Dictionary<int, string>();
                GrammatikSvar.Add(0, "simpel");
                GrammatikSvar.Add(1, "udvidet");
                GrammatikSvar.Add(2, "simpel");
                GrammatikSvar.Add(3, "udvidet");


                var random = new Random(); // vælger et tilfældigt tal
                int indexGrammatikspørgsmål = random.Next(Grammatikspørgsmål.Count);


                Console.WriteLine();
                int RigtigeGæt = 0;
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ("".Length - Rigtigtord.Length / 2)) + "}", ""));
                string UserGuess = Console.ReadLine().ToLower();



                // laver hele hint funktionen men kun vis Antalhint er 0
                if (antalhint == 0)
                {

                    // vis du skriver * så kommmer dit hint
                    if (UserGuess == hint)
                    {

                        Console.WriteLine("er sætnigen simpel eller udvidet");

                        // stiller et grammatik spørgsmål
                        Console.WriteLine(Grammatikspørgsmål[indexGrammatikspørgsmål]);

                        // sikre at ens gæt ikke bliver forkert ved store bogstaver
                        string UserGrammaguess = Console.ReadLine().ToLower();


                        // vis du gætter rigtigt idløser denne kode
                        if (GrammatikSvar[indexGrammatikspørgsmål] == UserGrammaguess)
                        {
                            Console.WriteLine("du gættede rigtigt");


                            
                            string inputString = Rigtigtord;
                            
                            //splitter det rigtige ord ud i hvert bogstav
                            List<char> charList = new List<char>(inputString.ToCharArray());

                            var Random = new Random(); // vælger et tilfældigt tal
                            int indexRigtigOrd = random.Next(charList.Count); //vælger et tilfældigt ord fra listen easywords


                           

                                string RigtigBogstavGæt = inputString[indexRigtigOrd].ToString();


                            // da det starter på 0 skal der plusses med 1
                            int FixedIndexRigtigOrd = indexRigtigOrd+ 1;
                            Console.WriteLine("bogstavet "+RigtigBogstavGæt+ " er bogstavet nummer "+ FixedIndexRigtigOrd);
                          
                            



                        }
                        else // vis svaret er forkert udløses koden
                        {
                            Console.WriteLine("Wrong answer. You can guess your word again");
                        }

                        antalhint++;
                        continue;
                    }

                }
                


                /*
                 * vis man skriver forsøg kan man se de forsøg man har brugt
                 
                string forsøg = "forsøg";             
                if (UserGuess == forsøg) 
                {
                    Console.WriteLine("Antal forsøg brugt "+Antalforsøg);
                    continue;
                }
                */


                Antalforsøg++;


                // vis brugerens gæt ikke har den rigtige længde køres denne kode
                if (UserGuess.Length != Rigtigtord.Length)
                {
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("your words is not matching the leantgh of the word".Length / 2)) + "}", "your words is not matching the leantgh of the word"));
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("Try again".Length / 2)) + "}", "Try again"));

                    continue;
                }
                //henter alle ordene fra en txt fil
                string text = File.ReadAllText("words.txt");
                // splitter hvert ord indtil en liste
                string[] allWords = text.Split('\n');

                // tjekker om det er det rigtige ord
                bool detErEtRigtigtOrd = false;
                for (int i = 0; i < allWords.Length; i++)
                {
                    if (allWords[i] == UserGuess)
                    {
                        detErEtRigtigtOrd = true;
                    }

                }
                // vis ordet ikke er på listen melder den en fejl og siger at ordet ikke findes
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

                    //vis et af bogstaverne er rigtig placeret skifter den til grøn
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
                        //vis et af bogstaverne er med i ordet men er placeret forkert skifter den til gul
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
                    //vis bogstaverne slet ikke er med i ordet skifter bokstavet til rødt
                    if (!somethingElse)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(UserGuess[i].ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                // giver et maks antal forsøg man kan bruge før den siger du har brugt for mange forsøg på at finde ordet
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
                
                // vis du gætter ordet rigtigt siger den at du gættede det rigtigt
                if (Rigtigtord.Length == RigtigeGæt)
                {
                    Console.WriteLine();
                    Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ("you guessed the right word ".Length / 2)) + "}", "you guessed the right word "));
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(Rigtigtord);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadKey(true);
                    break;
                }

            }





        }

        // er funktionen der styre valg af sværhedsgrad
        public static class ConsoleHelper
        {
            public static int MultipleChoice(bool canCancel, params string[] options)
            {
                //Ordlisten bliver lavet og splittet
                string text = File.ReadAllText("words.txt");
                string[] allWords = text.Split('\n');

                // laver ordlister til de forskellige sværhedsgrader
                List<string> EasyWords = new List<string>();
                List<string> MediumWords = new List<string>();
                List<string> HardWords = new List<string>();


                // splitter alle ordene ud til listerne til vær sværhedsgrad 
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

                //definere start positionen
                const int startX = 40;
                const int startY = 11;

                //definere afstanden mellem katogirierne 
                const int optionsPerLine = 3;
                const int spacingPerLine = 19;

                int currentSelection = 0;

                ConsoleKey key;

                //skjuler markøren
                Console.CursorVisible = false;

                Console.Clear();
                Console.WriteLine(@"
");

                // centere ascii arten
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


                    //definere hvor start posiotionen skal være
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
                        //vis der trykkes på den venstre piletast bevæger makøren sig et tak til venstre
                        case ConsoleKey.LeftArrow:
                            {
                                if (currentSelection % optionsPerLine > 0)
                                    currentSelection--;
                                break;
                            }

                        //vis der trykkes på den højre piletast bevæger makøren sig et tak til højre
                        case ConsoleKey.RightArrow:
                            {
                                if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                    currentSelection++;
                                break;
                            }

                            // vis du trykker enter køre koden
                        case ConsoleKey.Enter:
                            {


                                //vis du vælger easy køres denne kode
                                if (currentSelection == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"

");
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("EasyWords is chosen".Length / 2)) + "}", "EasyWords is chosen"));
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("EasyWords has a length of five-letters".Length / 2)) + "}", "EasyWords has a length of five-letters"));

                                    string Rigtigtord = EasyWords[indexEasy]; //bestemmer det valgte ord

                                    // aktiviere funkionen sværhedsgrad
                                    Sværhedsgrad(Rigtigtord);
                                }
                                //vis du vælger medium køres denne kode
                                else if (currentSelection == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"

");
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("MediumWords is chosen".Length / 2)) + "}", "MediumWords is chosen"));
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("MediumWords has a length of seven-letters".Length / 2)) + "}", "MediumWords has a length of seven-letters"));
                                    string Rigtigtord = MediumWords[indexMedium];

                                    // aktiviere funkionen sværhedsgrad
                                    Sværhedsgrad(Rigtigtord);
                                }

                                //vis der vælges svær køres denne kode
                                else if (currentSelection == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"

                                    ");
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("HardWords is chosen".Length / 2)) + "}", "HardWords is chosen"));
                                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("HardWords has a length of ten-letters".Length / 2)) + "}", "HardWords has a length of ten-letters"));
                                    string Rigtigtord = HardWords[indexHard];

                                    // aktiviere funkionen sværhedsgrad
                                    Sværhedsgrad(Rigtigtord);
                                }

                                break;
                            }






                    }
                    //vis der trykkes forkert køres koden igen
                } while (key != ConsoleKey.Enter);

                Console.CursorVisible = true;

                return currentSelection;

            }

        }




    }
}
