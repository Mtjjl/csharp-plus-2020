using System;
using System.Linq;

namespace session4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                   ");





                            //arry

            int[] array = new int[4]; { 1,2,3,4};
            //Antalet värden i arrayen
           int arrayLengs =array.Length;
            //kommer åt data i arrayen, innom []anger position 
            int FirstPosition = array[0];

            char[] voles = new char[] { 'a', 'e' };

            //se om arreyen innehåller ett världe
            voles.Contains('å');
            //första posesionen där å förekommer
            //´-1 om värdet inte förekommer
           int vowleIndex Array.IndexOf(voles, 'å');





            int vowleIndexfromLoop = -1;

            for(int i =0; i<voles.Length; i++)
            {
                var currenVovle = voles[i];
                if (currenVovle == 'å')
                { 
                    vowleIndexfromLoop = i;
                break;
                }


                //går att göra sama sak 
                string[] supportedLanguages = new string[] { "sv", "no", "dk" };


            }





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


                catch (Exception ex)
                {
                    //Denna del är till för att hantera felet vissa fel till användaren eller till att skriva log.
                    Console.WriteLine(ex.Message);
                    //går att användA throw; för att kasta om felet.
                }

                finally //3körs alltid är till för att städa upp körningen.
                {
                    //körs även om try-satsen innehäller return;
                }





            }
        }
    }

}
    }
}


