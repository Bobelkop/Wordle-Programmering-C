using System;
namespace Worlde

{
    internal class Program
    {
        static void Main(string[] args)
        {
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


                List<string> EasyWords = new List<string>(); //EasyWords er ord på 5 bogstaver.
            EasyWords.Add("");
            EasyWords.Add("");

            List<string> MediumWords = new List<string>(); //MediumWords er ord på 7 bogstaver.
            MediumWords.Add("");

            List<string> HardWords = new List<string>(); //HardWords er ord på 10 bogstaver
            HardWords.Add("");



        }
    }
}
