using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ////inicijalizuju se variable_name = value, ali prvo ih trebamo deklarisati tj odrediti im tip
            //int num;
            //num = 1;

            ////mogu se inicijalizovati u deklaraciji
            //string name = "Ana";


            //// inicijalizacija niza stringova od 25 elemenata


            //string[] slova = new string[25];
           
            
            //slova[1] = "A";
            //slova[2] = "B";
            //slova[3] = "C";
            //slova[4] = "D";
            //slova[5] = "E";

            //slova[6] = "F";
            //slova[7] = "G";
            //slova[8] = "H";
            //slova[9] = "I";
            //slova[10] = "J";

            //slova[11] = "K";
            //slova[12] = "L";
            //slova[13] = "M";
            //slova[14] = "N";
            //slova[15] = "O";

            //slova[16] = "P";
            //slova[17] = "Q";
            //slova[18] = "R";
            //slova[19] = "S";
            //slova[20] = "T";

            //slova[21] = "U";
            //slova[22] = "V";
            //slova[23] = "W";
            //slova[24] = "X";
            //slova[25] = "Y";

            






            int n;

            Console.WriteLine("Unesite broj od 1 do 50 ");
            n = int.Parse(Console.ReadLine());

            if (n <= 50)
            { 
                if (n % 3 == 0 && n % 5 == 0 )
                {
                    Console.WriteLine("Cica Maca");
                    Console.ReadKey();
                }
                else if (n % 3 == 0 && !(n % 5 == 0))
                {
                    Console.WriteLine("Cica");
                    Console.ReadKey();
                }
                else if (!(n % 3 == 0) && n % 5 == 0)
                {
                    Console.WriteLine("Maca");
                    Console.ReadKey();
                }
            }
            else
                Console.WriteLine("Broj koji ste uneli ne zadovoljava pocetne uslove");

        }
    }
}
