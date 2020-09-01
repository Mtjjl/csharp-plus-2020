using System;

namespace Felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //  int bilderror = "stringValue"; Byggfel


            //körningsfel
            //för att undvika att fel avslutar körning måste man hantera eventuella körfel

            try
            {
                string word = "12a";
                int integer = int.Parse(word);
            }

               
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           



        }
    }
}
