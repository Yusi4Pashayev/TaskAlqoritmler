using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

namespace TaskAlqoritmler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.
            //İnsanın yaşı  n(1≤ n ≤ 1188) aylarla verilmişdir.Yaşı aşağıdakı formada göstərən
            //proqramı yazın.
            //Input: 262
            //Output: 21 il 10 ay



            //Console.WriteLine("nece ay:");
            //int a = int.Parse(Console.ReadLine());
            //int il, ay;

            //if (a >= 1 && a <= 1188)
            //{
            //    il = a / 12;
            //    ay = a % 12;
            //    Console.WriteLine($"{il} il,{ay} ay.");
            //}

            //else Console.WriteLine("min: 1, max: 1188 aral;];nda eded daxil edin");


            #endregion

            #region 2.
            ///Verilmiş natural N(N > 9) ədəddə olan sıfırların sayını müəyyənləşdirən proqramı yazın.


            //Console.WriteLine("Eded daxil edin:");
            //int number = int.Parse(Console.ReadLine());
            //int a, sum = 0;

            //while (number != 0)
            //{
            //    a = number % 10;
            //    number = number / 10;
            //    if (a == 0)
            //    {
            //        sum++;
            //    }
            //}
            //Console.WriteLine(sum);


            #endregion

            #region 3.
            //nnn.ddd formatında verilmiş həqiqi ədədi kəsr və
            //tam hissısi ilə yerini dəyişən(ddd.nnn) proqramı yazın


            Console.WriteLine("Eded daxil edin:");
            decimal number = Decimal.Parse(Console.ReadLine());
            decimal kesr,tam;
            tam = (int)number;
            kesr = number - tam;

            while (kesr % 1 != 0)
            {
                kesr = kesr * 10;

            }

            while (tam >= 1)
            {
                tam = tam / 10;
            }

            decimal newnumber = kesr + tam;
            Console.WriteLine(newnumber);


            #endregion
        }
    }
}