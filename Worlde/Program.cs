using System;
namespace Worlde

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Startside
            String textToEnter1 = @"  _    _               _ _      ";
            String textToEnter2 = @" | |  | |             | | |     ";
            String textToEnter3 = @" | |  | | ___  _ __ __| | | ___ ";
            String textToEnter4 = @" | |/\| |/ _ \| '__/ _` | |/ _ \";
            String textToEnter5 = @" \  /\  / (_) | | | (_| | |  __/";
            String textToEnter6 = @"  \/  \/ \___/|_|  \__,_|_|\___|";
            String textToStart = @"Press 'Enter' to start the game";
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

                ConsoleKey key= Console.ReadKey(true).Key;
                if (key.ToString()== "Enter")
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


            }


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



        }
    }
}
