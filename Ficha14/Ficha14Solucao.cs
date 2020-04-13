using System;

namespace Ficha14
{
    public class Ficha14Solucao
    {
        public static void Main(string[] args)
        {
            
        }

        #region Exercicio1

        public static void Exercicio1()
        {
            int a = 0;
            Console.WriteLine("Indique a quantidade de números");
            int n = int.Parse(Console.ReadLine());

            while (a <= n)
            {
                Console.WriteLine(a);
                a++;
            }
           

        }

        #endregion

        #region Exercicio2

        public static void Exercicio2 ()
        {
           
          
                Console.WriteLine("Indique a quantidade de números");
                int n = int.Parse(Console.ReadLine());

                while (n >= 0)
                {
                    Console.WriteLine(n);
                    n--;
                }


            
        }

        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Indique a quantidade de números");
            int n = int.Parse(Console.ReadLine());

            while (b <  n)
            {
                a += b;
                a++;
                b++;
            }
            Console.WriteLine(a);
        } 

        

        #endregion

        #region Exercicio4

        public static void Exercicio4()
        {
            Console.WriteLine("Dá-me dois números");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (var i = num1; i < num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }


        #endregion

        #region Exercicio5

        public static void Exercicio5()
        {
            int num1 = 0;
            int num2 = 1;

            Console.WriteLine("Dá-me um número");
            int lim = int.Parse(Console.ReadLine());

            for (var i = 0; i <= lim; i++)
            {
                int total = num1 + num2;
                num1 = num2;
                num2 = total;


                Console.Write(total + " ");
                
            }
        }

        #endregion

        #region Exercicio6

        public static void Exercicio6()
        {


            Console.WriteLine("Dá-me um número");
            int num = int.Parse(Console.ReadLine());
           
            int fact = 1;



            for (int i=1; i< num; i++)
            {
                fact += fact * i;
                
               
            }

            Console.Write("O factorial de " + num + " é " + fact);
        }

        #endregion


    }
}
