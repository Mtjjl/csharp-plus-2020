using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace session04
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q = 0;
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken");
            var input = Console.ReadLine();
            var inputAray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            double[] numberArray = new double[inputAray.Length];
            
            for (int i=0; i<inputAray.Length;i++)
            {
                try
                {
                    numberArray[i] = Convert.ToDouble(inputAray[i]);

                }

                catch(Exception)
                {
                    numberArray[i] = 0;
                }

                finally //körs alltid,
                {

                }


                for (int i = 0; i < inputAray.Length; i++)
                {
                    bool parsed = double.TryParse(inputAray[i], CultureInfo.InvariantCulture, out double paredValue);

                  if(parsed==true)
                    {
                        numberArray[i] = paredValue;
                    }

                    else 
                    {
                        numberArray[i] = null;
                    }
                }


            }
            /*

            int execeptionStatus=1

                try
            {
                execeptionStatus
            }
            
             throw new exeption ("provocerat fel"); 
             */

            foreach (var number in inputAray)
            {
                Console.WriteLine("Värdet är " + number);
                Console.WriteLine("");
                
            }
          




            

            Console.WriteLine(" l" +inputAray.Length);

        }
    }
}
