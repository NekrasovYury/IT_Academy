using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tips
{
    class Program
    {
        static void Main(string[] args)
        {

            bool live = false;
            byte bit = 255;
            sbyte sbit = 127;
            short int16 = 32767;
            ushort uint16 = 65535;
            int int32 = 2147483647;
            uint uint32 = 4294967295;
            long int64 = 9223372036854775807;
            ulong uint64 = 18446744073709551615;
            float flu = 3.4F;
            double two = 3.4;
            decimal dec = 3.4M;
            char a = 'A';
            string hello = "Hello";
            object all = 2.2;
            var b = "b";
            Console.WriteLine($"Примитивные типы данных \n bool= {live} \n byte= {bit} \n sbyte= {sbit} \n short= {int16}" +
                              $"\n ushort= {uint16} \n int= {int32} \n uint= {uint32} \n long= {int64} \n ulong= {uint64}" +
                              $"\n float= {flu} \n double= {two} \n decimal= {dec} \n char= {a} \n string= {hello} \n object= {all} \n var= {b}");

           
            bit = (byte) (bit+ 1);
            double e = 2.718281828459045;
            object obj = e; // box
            e = (double)obj;//unbox


        }
    }
}
