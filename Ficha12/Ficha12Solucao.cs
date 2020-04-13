using System;

namespace Ficha12
{
    public class Ficha12Solucao
    {
        static void Main(string[] args)
        {

        }

        #region Exercicio1

        public static void Exercicio1()
        {
            
            int i = 0;
            int prod =  1;
            for( i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduz um numero");
                int num1 = int.Parse(Console.ReadLine());
                prod *= num1;
            }
            Console.WriteLine(prod);
        }


        #endregion

        #region Exercicio2

        public static void Exercicio2()
        {
            Console.WriteLine("Introduz dois números");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (var i = 0; i < 5; i++)
                switch (i)
                {
                    case 0:
                        Console.WriteLine(num1 + num2);
                        break;

                    case 1:
                        Console.WriteLine(num1 - num2);
                        break;

                    case 2:
                        Console.WriteLine(num1 * num2);
                        break;

                    case 3:
                        Console.WriteLine(num1 / num2);
                        break;

                    case 4:
                        Console.WriteLine(num1 % num2);
                        break;

                }
        }

        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {
            int z = 5;
            int x = 5;
            int y = 5;

            Console.WriteLine("Introduz dois números");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine((num1 + num2) * z);
            Console.WriteLine(x * y + y * z);
        }

        #endregion

        #region Exercicio4 

        public static void Exercicio4()
        {
            Console.WriteLine("Introduz um número");
            int num1 = int.Parse(Console.ReadLine());
            bool isPrime = false;
            int a;
            for(var i = 2; i <= num1; i++)
            {

               for(a = 2; a < i; a++)
               {

                    if (i % a == 0)
                    {
                        isPrime = true;
                        break;
                    }

               }
                if(!isPrime)
                {
                    Console.Write(i + " ");
                } 
                else
                {
                    isPrime = false;
                }

            }

        }

        #endregion

        #region Exercicio5

        public static void Exercicio5()
        {
            

            Console.WriteLine("Hello?");
            var a = Console.ReadLine();
            if (a == "Is it me you're looking for?")
            {
                Console.WriteLine("I can see it in your eyes");
            }
        }

        #endregion

        #region Exercicio6

        public static void Exercicio6 ()
        {
            Console.WriteLine("Quantos itens");
            int itens = int.Parse(Console.ReadLine());

            for (int i = itens; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Um para mim");
                }
                else
                {
                    Console.WriteLine("Um para ti");
                }
            }
        }

        #endregion

        #region Exercicio 7

        public static void Exercicio7 ()
        {
            Console.WriteLine("Ano?");
            int ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0)
            {
                Console.WriteLine("O ano é bisexto");
            }else
            {
                Console.WriteLine("O ano não é bisexto");
            }
        }

        #endregion

        #region Exercicio8

        public static void Exercicio8()
        {
            for(int a = 99; a > 0; a--)
            {
                Console.WriteLine($"{a} bottles of beer on the wall, {a} bottles of beer. Take one down and pass it around, {a - 1} bottles of beer on the wall.");
            }
        }

        #endregion

        #region Exercicio9

        public static void Exercicio9()
        {
            Console.WriteLine("Qual a dimensão do lado esquerdo do triângulo?");
            int ab = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a dimensão do lado direito do triângulo?");
            int ca = int.Parse(Console.ReadLine());
            Console.WriteLine("Quais da base do triângulo?");
            int bc = int.Parse(Console.ReadLine());
           

            if (ab == bc && bc == ca && ab == ca)
            {
                Console.WriteLine("O triângulo é equilátero");
            }
            else if (ab == ca && ab != bc && ca != bc)
            {
                Console.WriteLine("O triângulo é isósceles");
            }else
            {
                Console.WriteLine("O triângulo é escaleno");
            }
        }

        #endregion

        #region Exercicio10

        public static void Exercicio10()
        {
            Console.WriteLine("Qual o valor inicial?");
            int valInic = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor total?");
            int valTotal = int.Parse(Console.ReadLine());

            if ( valInic < valTotal)
            {
                Console.WriteLine("Lucro!$$$$$$");
            }
            else 
            {
                Console.WriteLine("Prejuízo :,(");
            }
         
        }

        #endregion

        #region Exercicio11

        public static void Exercicio11()
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 13);

            if (month == 1)
            {
                Console.WriteLine("Janeiro" + '\n' + "31 dias");
            } 
            else if (month == 2)
            {
                Console.WriteLine("Fevereiro" + '\n' + "28 ou 29 dias");

            }
            else if (month == 3)
            {
                Console.WriteLine("Março" + '\n' + "31 dias");

            }
            else if (month == 4)
            {
                Console.WriteLine("Abril" + '\n' + "30 dias");

            }
            else if (month == 5)
            {
                Console.WriteLine("Maio" + '\n' + "31 dias");

            }
            else if (month == 6)
            {
                Console.WriteLine("Junho" + '\n' + "30 dias");

            }
            else if (month == 7)
            {
                Console.WriteLine("Julho" + '\n' + "31 dias");

            }
            else if (month == 8)
            {
                Console.WriteLine("Agosto" + '\n' + "31 dias");

            }
            else if (month == 9)
            {
                Console.WriteLine("Setembro" + '\n' + "30 dias");

            }
            else if (month == 10)
            {
                Console.WriteLine("Outubro" + '\n' + "31 dias");

            }
            else if (month == 11)
            {
                Console.WriteLine("Novembro" + '\n' + "30 dias");

            }
            else if (month == 12)
            {
                Console.WriteLine("Dezembro" + '\n' + "31 dias");

            }

        }

        #endregion

        #region Exercicio12

        public static void Exercicio12()
        {
            Console.WriteLine("Qual a dimensão do triângulo?");
            int n = int.Parse(Console.ReadLine());
            int i = 0;

            while (n > 0)
            {
                int nov = n * 2 - 1;
                n--;

                int b = 0;
                while (b != i)
                {
                    Console.Write(" ");
                    b++;
                }

                

                int a = 0;
                while (a != nov)
                {

                    Console.Write("*");
                    a++;

                }

                int c = 0;
                while (c != i)
                {
                    Console.Write(" ");
                    c++;
                }

                i += 1;

                Console.WriteLine();
            }
        }

        #endregion

        #region Exercicio13

        public static void Exercicio13()
        {
            Console.WriteLine("Qual a região?");
            var regiao = Console.ReadLine();
            Console.WriteLine("Quatas unidades?");
            double uni = double.Parse(Console.ReadLine());

            double valReg = 0;
            

            switch (regiao)
            {
                case ("A"):
                    valReg = 2;
                    Console.WriteLine(valReg * uni + "€");
                    break;
                case ("B"):
                    valReg = 1.20;
                    Console.WriteLine(valReg * uni + "€");
                    break;
                case ("C"):
                    valReg = 1;
                    Console.WriteLine(valReg * uni + "€");
                    break;
                case ("D"):
                    valReg = 0.75;
                    Console.WriteLine(valReg * uni + "€");
                    break;
                default:
                    Console.WriteLine("Região inexistente");
                    break;

            }

        }

        #endregion

        #region Exercicio14

        public static void Exercicio14()
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

        #region Exercicio15

        public static void Exercicio15()
        {
            Console.WriteLine("Dá-me um número");
             int num = int.Parse(Console.ReadLine());

            if (num == (num-1) + (num -2))
            {
                Console.WriteLine("É Fibonicce!");
            }
            else
            {
                Console.WriteLine("É Fibonot!");
            }

        }

        #endregion




        #region Exercicio16

        public static void Exercicio16()
        {
            int min = 1;
            int max = 100;
            bool fernandoMendes = false;




            while (!fernandoMendes)
            {
                var avc = (int)Math.Floor((double)(min + max) / 2);
                var intConf = max - min;
                var keyOK = false;
                if (intConf < 2)
                {
                    for (int i = min; i < max + 1; i++)
                    {
                        Console.WriteLine($"É {i}");
                        var key = Console.ReadKey().Key;
                        if (key == ConsoleKey.Y || key == ConsoleKey.S)
                        {
                            fernandoMendes = true;
                            keyOK = true;
                            break;
                        }
                    }
                }

                while (!keyOK)
                {
                    Console.WriteLine($"O número é inferior a {avc}?");

                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Y:
                        case ConsoleKey.S:
                            keyOK = true;
                            max = avc - 1;
                            break;

                        case ConsoleKey.N:
                            keyOK = true;
                            min = avc;
                            break;

                        default:
                            break;

                    }

                }
            }

        }

        #endregion

    }
}


