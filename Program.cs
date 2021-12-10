using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass3 = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                 mass3[i] = rnd.Next(-50, 50);
                
                Console.Write("|" + mass3[i] + "|");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (mass3[i] > mass3[j])
                    { 
                        int x = mass3[i];
                        mass3[i] = mass3[j];
                        mass3[j] = x;
                    }
                }


            }
            for (int i = 5; i <9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (mass3[i] < mass3[j])
                    {
                        int x = mass3[i];
                        mass3[i] = mass3[j];
                        mass3[j] = x;
                    }
                }


            }

            Console.WriteLine();
            for (int j = 0; j < 10; j++)
            {
               
                Console.Write("|" + mass3[j] + "|");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
