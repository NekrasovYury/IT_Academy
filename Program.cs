using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double fx,fx2=0,fxV=0, x = -0.6;
            List<double> znach = new List<double>();
            for(int j = 0; j < 20; j++)
            {
                fx = (x / 2) + (Math.Pow(x, 2)) + ((1 / 2) * (1 - Math.Pow(x, 2)) * (Math.Log10(1 - x)));
                x += 0.05;
                //Console.WriteLine(fx);
                znach.Add(fx);
            }
            fx2 = 0;
            fxV = 0;
            x = -0.6;
            int k;
            for ( k=1; k<21; k++)
            {

               
                    fxV = (Math.Pow(x, k + 2)) / (k * (k + 2));
                    fx2 += fxV;
                    x += 0.05;
                    string[] temp = fx2.ToString().Split('.', ',');
                if (temp[1].Length > 2)
                    break;
 

            }
            Console.WriteLine($"Количество элементов ряда ={k}");
            Console.WriteLine(fx2);
            fx2 = 0;
            fxV = 0;
            x = -0.6;
            for (k = 1; k < 21; k++)
            {


                fxV = (Math.Pow(x, k + 2)) / (k * (k + 2));
                fx2 += fxV;
                x += 0.05;
                string[] temp1 = fx2.ToString().Split('.', ',');
                if (temp1[1].Length > 3)
                    break;


            }
            Console.WriteLine($"Количество элементов ряда ={k}");
            Console.WriteLine(fx2);
            fx2 = 0;
            fxV = 0;
            x = -0.6;
            for (k = 1; k < 21; k++)
            {


                fxV = (Math.Pow(x, k + 2)) / (k * (k + 2));
                fx2 += fxV;
                x += 0.05;
                string[] temp2 = fx2.ToString().Split(',', '.');
                if (temp2[1].Length > 4)
                    break;


            }
            Console.WriteLine($"Количество элементов ряда ={k}");
            Console.WriteLine(fx2);
        }
    }
}
