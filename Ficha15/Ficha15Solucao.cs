using System;

namespace Ficha15
{
    public class Ficha15Solucao
    {
        static void Main(string[] args)
        {
           
        }

        #region

        public static void Exercicio1()
        {
            Console.WriteLine("dá-me dez valores");
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();
            var d = Console.ReadLine();
            var e = Console.ReadLine();
            var f = Console.ReadLine();
            var g = Console.ReadLine();
            var h = Console.ReadLine();
            var i = Console.ReadLine();
            var j = Console.ReadLine();

            var val = new[] {a, b, c, d, e, f, g, h, j};

            Console.WriteLine(val[0]);
            Console.WriteLine(val[1]);
            Console.WriteLine(val[2]);
            Console.WriteLine(val[3]);
            Console.WriteLine(val[4]);
            Console.WriteLine(val[5]);
            Console.WriteLine(val[6]);
            Console.WriteLine(val[7]);
            Console.WriteLine(val[8]);
            Console.WriteLine(val[9]);


        }
        #endregion

        #region 2

        public static void Exercicio2()
        {
            Console.WriteLine("dá-me dez valores");
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();
            var d = Console.ReadLine();
            var e = Console.ReadLine();
            var f = Console.ReadLine();
            var g = Console.ReadLine();
            var h = Console.ReadLine();
            var i = Console.ReadLine();
            var j = Console.ReadLine();

            var val = new[] { a, b, c, d, e, f, g, h, j };

            Console.WriteLine(val[9]);
            Console.WriteLine(val[8]);
            Console.WriteLine(val[7]);
            Console.WriteLine(val[6]);
            Console.WriteLine(val[5]);
            Console.WriteLine(val[4]);
            Console.WriteLine(val[3]);
            Console.WriteLine(val[2]);
            Console.WriteLine(val[1]);
            Console.WriteLine(val[0]);
        }
        #endregion

        #region 3

        public static void Exercicio3()
        {
            Console.WriteLine("dá-me dez valores");
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();
            var d = Console.ReadLine();
            var e = Console.ReadLine();
            var f = Console.ReadLine();
            var g = Console.ReadLine();
            var h = Console.ReadLine();
            var i = Console.ReadLine();
            var j = Console.ReadLine();

            var val = new[] { a, b, c, d, e, f, g, h, j };

            Console.WriteLine(val[0] + val[1] + val[2] + val[3] + val[4] + val[5] + val[6] + val[7] + val[8] + val[9]);
        }

        #endregion

        #region 4

        public static void Exercicio4()
        {
            var i = new [] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            var u = new string[12];

            u[0] = i[0];
            u[1] = i[1];
            u[2] = i[2];
            u[3] = i[3];
            u[4] = i[4];
            u[5] = i[5];
            u[6] = i[6];
            u[7] = i[7];
            u[8] = i[8];
            u[9] = i[9];

        }

        #endregion

        #region 5

        public static void Exercicio5 ()
        {
            var array = new string [10];

            

            Console.WriteLine(array.Length);
        }

        #endregion

        #region 6
        public static void Exercicio6()
        {
            var array = new[] { "repete", "repete" , "repete", "repete", "nope" };

            var count = 0;

            for( var i = 0; i< array.Length; i++)
            {
                if (array[i] == "repete")
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        #endregion

        #region 7

        public static void Exercicio7()
        {
            var array = new[] { 15, 5, 32, 68, 17 };
            var a = 1;

            for ( var i = 0; i < array.Length; i++)
            {
                for(a = 1; a < array.Length; a++)
                {
                    if (array[i] != array[a])
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
        }

        #endregion

        #region 8[?]

        public static void Exercicio8() 
        {
            var array = new[] { 2, 28, 9, 5 };

            var dim = array.Length;
            var novaPosicao = 0;

            do
            {
                for (var i = 1; i < dim ; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                       
                        var c = array[i];
                        array[i] = array[i-1];
                        array[i - 1] = c;
                        
                        novaPosicao = i;
                    }
                }
                dim = novaPosicao;

            } while (dim <= 1);

            for (var a = 0; a < array.Length; a++)
            {
                Console.WriteLine(array[a] + " ");
            }
        }

       
        #endregion

        #region 9[?]

        public static void Exercicio9()
        {
            var array1 = new[] { 2, 6, 10, 25 };
            var array2 = new[] { 3, 5, 17, 38 };
            var dummy = new int [array1.Length + array2.Length];
            Array.Copy(array1, dummy, array1.Length);
            Array.Copy(array2, 0, dummy, array1.Length, array2.Length);

            var dim = dummy.Length;
            var novaPosicao = 0;

            do
            {
                for (var i = 1; i < dim; i++)
                {
                    if (dummy[i - 1] > dummy[i])
                    {

                        var c = dummy[i];
                        dummy[i] = dummy[i - 1];
                        dummy[i - 1] = c;

                        novaPosicao = i;
                    }
                }
                dim = novaPosicao;

            } while (dim <= 1);

            for (var a=0; a<dummy.Length;a++)
            Console.Write(dummy[a] +" ");
        }

        #endregion

        #region 10

        public static void Exercicio10()
        {
            var array = new[] { 15, 5, 32, 68, 17 };

            int min = 5;
            int max = 68;

            for (var i = 0; i < array.Length; i++)
            {
                if( array[i] == min)
                {
                    Console.WriteLine(array[i]);
                }

                if (array[i] == max)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        #endregion

        #region 11

        public static void Exercicio11()
        {
            var array = new [] { 15, 5, 32, 68, 17 };
            var impares = new int[3];
            var pares = new int[2];
            var c = 0;
            var d = 0;



            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)

                {
                    impares[c] = array[i]; 
                    c++;
                }
            }


            for( var a= 0; a < array.Length; a++)
            {
                if( array[a] % 2 == 0)
                {
                    pares[d] = array[a]; 
                    d++;
                }
            }
            for (var e = 0; e < impares.Length; e++)
            {
                if(impares[e] == 0)
                {
                   
                }
                Console.Write(impares[e] + " ");
            }

            Console.WriteLine();


            for (var f = 0; f < impares.Length; f++)
            {
                Console.Write(pares[f] + " ");
            }
        }

        #endregion

        #region 12a

        public static void Exercicio12a() 
        {
            var array = new[] { 15, 5, 32, 68, 17 };

            array[0] = 2;

            for ( var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        #endregion

        #region 12b

        public static void Exercicio12b() 
        { 
            var array = new[] { 15, 5, 32, 68, 17 };

            array[4] = 2;

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }


        #endregion

        #region 12c

        public static void Exercicio12c() 
        {
            var array = new[] { 15, 5, 32, 68, 17 };
            Random rnd = new Random();

            var i = rnd.Next(0, 5);

            array[i] = 2;

            for (var a = 0; a < array.Length; a++)
            {
                Console.Write(array[a] + " ");
            }
        }


        #endregion

        #region 12d

        public static void Exercicio12d() 
        {
            var array = new[] { "15", "5", "32", "68", "17" };

            array[0] = string.Empty;

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }


        #endregion

        #region 12e

        public static void Exercicio12e() 
        {
            var array = new[] { "15", "5", "32", "68", "17" };

            array[4] = string.Empty;

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }


        #endregion

        #region 12f

        public static void Exercicio12f() 
        {
            var array = new[] { "15", "5", "32", "68", "17" };

            
            Random rnd = new Random();
            var i = rnd.Next(0, 5);

            array[i] = string.Empty;

            for (var a = 0; a < array.Length; a++)
            {
                Console.Write(array[a] + " ");
            }
        }


        #endregion

        #region 13 [x]

        public static void Exercicio13()
        {
            var array = new[] { 12, 9, 28, 100, 67, 45 };
            var array1 = new int[10];
            var array2 = new int[10];

            Console.WriteLine("Indica um pivô");
            var a = int.Parse(Console.ReadLine());



        }

        #endregion




    }
}
