using System;

namespace session04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken");
            var input = Console.ReadLine();
            var inputAray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in inputAray)
            {
                Console.WriteLine("Värdet är " + number);
            }
        }
    }
}
