using System;
namespace Worlde

{
    internal class Program
    {
        static void Main(string[] args)
        {
            String textToEnter = @" 

                 _    _               _ _      
                | |  | |             | | |     
                | |  | | ___  _ __ __| | | ___ 
                | |/\| |/ _ \| '__/ _` | |/ _ \
                \  /\  / (_) | | | (_| | |  __/
                 \/  \/ \___/|_|  \__,_|_|\___|";
            Console.SetWindowSize(130, 35);
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("".Length / 2)) + "}", textToEnter));
            Console.Read();
            Console.WriteLine("Hello World!");


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