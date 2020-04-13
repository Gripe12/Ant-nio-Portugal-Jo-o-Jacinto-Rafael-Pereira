using System;

namespace Ficha_7
{
    public class Ficha7Solucao
    {
        static void Main(string[] args)
        {

        }
        #region Exercício 1
        public static void Exercicio1()
        {
            Console.WriteLine("Introduz um número");
            var num = Console.ReadLine();
            var numConv = ConverterStringParaDouble(num);
            if (numConv < 9.44)
            {
                Console.WriteLine("Chumbou");
            }
            else
            {
                Console.WriteLine("Passou");
            }
        }
        public static double ConverterStringParaDouble(string num)
        {
            var parseOK = double.TryParse(num, out double parsedNum);
            return parseOK ? parsedNum : 0;
        }

        #endregion

        #region Exercício 2

        public static void Exercicio2()
        {
            Console.WriteLine("Qual a altura?");
            var alt = Console.ReadLine();
            Console.WriteLine("Qual o peso?");
            var pes = Console.ReadLine();
            var pesConv = ConverterStringParaDouble(pes);
            var altConv = ConverterStringParaDouble(alt);
            var bmi = pesConv / altConv;
            if (bmi <= 18.5)
            {
                Console.WriteLine("Abaixo de peso");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine("Acima de peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
          
        }
        #endregion

        #region Exercicio3

        public static void Exercicio3()
        {
            Console.WriteLine("Cavalheiro/Madame, Introduza um número por favor");
            var num = Console.ReadLine();
            var numConv = ConverterStringParaDouble(num);
            if (numConv % 3 == 0 && numConv % 7 == 0)
                {
                    Console.WriteLine("Temos um vencedor! É múltiplo de ambos!!!");
                } 
            else if (numConv % 7 == 0)
            {
                Console.WriteLine("É múltiplo de 7 sim, senhores e senhoras!");
            }
            else if(numConv % 3 == 0)
            {
                Console.WriteLine("É múltiplo de 3 sim, senhores e senhoras!");
            } else
            {
                Console.WriteLine("Woaun woaun woaaaaaauuuuuuun");
            }
            Console.ReadLine();
        }

        #endregion

        #region Exercício4

        public static void Exercicio4()
        {
            Console.WriteLine("Introduz um número");
            var a = Console.ReadLine();
            var aConv = ConverterStringParaNumero(a);
                if (aConv < 30 && aConv > 50) 
            {
                Console.WriteLine("Este número está algures entre 30 e 50");
            } else
            {
                Console.WriteLine("Não sei do que me falas");
            }
        }

        public static int ConverterStringParaNumero(string num)
        {
            var parseOK = int.TryParse(num, out int parsedNum);
            return parseOK ? parsedNum : 0;
        }
        #endregion

        #region Exercicio5

        public static void Exercicio5()
        {
            Console.WriteLine("Introduz um número");
            var a = Console.ReadLine();
            var aConv = ConverterStringParaNumero(a);
            if (aConv <= 10 && aConv >= 20)
            {
                Console.WriteLine("Sim senhor!");
            } else
            {
                Console.WriteLine("Não senhor!");
            }
        }

        #endregion

        #region Exercicio 6

        public static void Exercicio6()
        {
            Console.WriteLine("Escolhe um andar");
            var and = Console.ReadLine();
            var andConv = ConverterStringParaNumero(and);
            if (andConv > 6 || andConv < -2 || andConv == 3 || andConv == 5)
            {
                Console.WriteLine("Piso Indiponível");
            }
        }

        #endregion

        #region Exercicio 7

        public static void Exercicio7()
        {
           
          
            double total = 0;
           
            for (var a = 0; a < 10; a++)
            {
                Console.WriteLine("Introduz um número");
                total += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(total);



        }

        public static void Exercicio7a()
        {
            double total = 0;
            var a = 0;
            do
            {
                Console.WriteLine("Introduz aí um numérico");
                total += int.Parse(Console.ReadLine());
                a++;
            }
            while (a < 10);
            Console.WriteLine(total);
            

        }
        #endregion

        #region Exercicio8 [x]

        public static void Exercicio8()
        {
            var nome = "";
            double val;
            double total = 0;
            var i = 0;
            while (i < 5)
            {
                Console.WriteLine("Qual o produto?");
                nome = Console.ReadLine();
                Console.WriteLine("Qual o valor?");
                val = Console.Read();
                Console.WriteLine("Qual a quantidade?");
                var qua = int.Parse(Console.ReadLine());
             
                i++;
                total += val * qua;
            }
            
            Console.WriteLine(total);
        }

        

        #endregion

        #region Exercício 9

        public static void Exercicio9()
        {
            
            var n = 0;
            var a = 0;
            var m = 0;
            
            do
            {
               Console.WriteLine("Introduz um número se fazes o favor");
                 n = int.Parse(Console.ReadLine());
                 a++;
                 m += n;
            }
            while (n != 0);

            int media = m / a;
            Console.Write(media);
            
            
        }

        #endregion

        #region Exercicio 10

        public static void Exercicio10()
        {
            Console.WriteLine("Introduz dois números");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduz uma operação");
            int c = Console.Read();
           switch(c)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    Console.WriteLine(a / b);
                    break;
                case '%':
                    Console.WriteLine(a % b);
                    break;
                default: Console.WriteLine("Operação inválida");
                    break;
            }
           
        }

        #endregion

        #region Exercício 11

        public static void Exercicio11()
        {
            Console.WriteLine("Introduz um caracter");
            var a = Console.ReadLine();
            Console.WriteLine(a + a + a + '\n' + a + a + a + '\n' + a + a + a);
        }

        #endregion

        #region Exercicio 12

        public static void Exercicio12()
        {
            Console.WriteLine("Introduz um caracter");
            var car = Console.ReadLine();
            Console.WriteLine("Introduz um número");
            int num = int.Parse(Console.ReadLine());
            for(var i = 0; i < num; i++)
            {
                for( var j=0; j < num; j++)
                {
                    Console.Write(car);
                    
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Exercicio 13

        public static void Exercicio13()
        {
            Console.WriteLine("Introduz um caracter");
            var car = Console.ReadLine();
            Console.WriteLine("Introduz um caracter");
            var car1 = Console.ReadLine();
            Console.WriteLine("Introduz um número");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduz um número");
            int num2 = int.Parse(Console.ReadLine());
            for (var i = 0; i < num; i++)
            {
                for (var j = 0; j < num2; j++)
                {
                    Console.Write(car);
                    Console.Write(car1);
                }
                Console.WriteLine();  
            }
           

        }

        #endregion

        #region Exercicio 14

        public static void Exercicio14()
        {
            var escala = "";
            Console.WriteLine("Introduz temperatura");
            var temp = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Em que escala?");
                escala = Console.ReadLine();
            }
            while (escala != "C" && escala != "K" && escala != "F") ;
            switch(escala)
            {
                case "C":
                    Console.WriteLine(temp + "ºC é equivalente a" + (temp + 273.15) + "ºK e " + (temp * 9 / 5 + 32)+"ºF");
                    break;
                case "K":
                    Console.WriteLine(temp + "ºK é equivalente a " + (temp - 273.15) + "ºC e " + (temp * 9 / 5 - 459.67) + "ºF");
                    break;
                case "F":
                    Console.WriteLine(temp + "ºF é equivlente a " + ((temp - 32) * 5 / 9) + "ºC e " + ((temp + 459.67) * 5 / 9) + "ºK");
                    break;
            }
        }

        #endregion

        #region Exercicio 15

        public static void Exercicio15()
        {
            Console.WriteLine("Qual é o número limite?");
            var num = int.Parse(Console.ReadLine());
            for(var cont = 0; cont <= num; cont++)
            {
                if (cont % 2 == 1) {
                Console.WriteLine(cont);
            }
            }
        }

        #endregion

        #region Exercicio 16

        public static void Exercicio16 ()
        {
            var cars = "";
            var car = "";
            do
            {
                Console.WriteLine("Introduz um número, ou enter para terminar");
                car = Console.ReadLine();
                cars += car;
            }
            while (car != "");
        }

        #endregion

        #region Exercicio 17

        public static void Exercicio17()
        {
            Console.WriteLine("Introduz um número");
            var n = int.Parse(Console.ReadLine());
            if (n % 2==0)
            {
                Console.WriteLine(n * 3);

            }
            else
            {
                Console.WriteLine(n * 2);
            }
        }

        #endregion

        #region Exercicio 18

        public static void Exercicio18()
        {
            Console.WriteLine("Qual a dimensão do triângulo?");
            int n = int.Parse(Console.ReadLine());
            int i = 1;

            while(n > 0)
            {
                n--;
                int a = 0;
                while (a != n)
                {

                    Console.Write(" ");
                    a++;
                    
                }
                int b = 0;
                while (b != i)
                {
                    Console.Write("*");
                    b++;
                }
                    
                i += 2;
                Console.WriteLine();
            }
                
                
        }
    }

        #endregion

}

