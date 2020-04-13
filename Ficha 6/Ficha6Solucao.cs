using System;

namespace Ficha_6
{
    public class Ficha6Solucao
    {
        #region Exercicio1

        public static void Exercicio1()
        {
            Console.WriteLine("Qual é o nome?");
            var nome = Console.ReadLine();
            OlaNome(nome);
        }



        private static void OlaNome(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }
        #endregion

        #region Exercicio2

        public static void Exercicio2()
        {
            Console.WriteLine("Num 1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Num 2?");
            var num2 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            ApresentarSoma(num1Conv, num2Conv);
        }

        public static int ConverterStringParaNumero(string num)
        {
            var parseOK = int.TryParse(num, out int parsedNum);
            return parseOK ? parsedNum : 0;
        }

        public static void ApresentarSoma(int numA, int numB)
        {
            Console.WriteLine(numA + " + " + numB + " = " + (numA + numB));
        }
        #endregion

        #region Exercício 3
        public static void Exercicio3()
        {
            var total = LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            Console.WriteLine(total);
        }

        public static int LerEConverter()
        {
            Console.WriteLine("Número?");
            var num = Console.ReadLine();
            var numParsed = ConverterStringParaNumero(num);
            return numParsed;
        }


        #endregion

        #region Exercício 4
        public static void Exercicio4()
        {

            Console.WriteLine("Número 1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Número 2?");
            var num2 = Console.ReadLine();

            var num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine("A = " + num1 + " e" + " B = " + num2);
            Console.ReadLine();


        }








        #endregion

        #region Exercício 5

        public static void Exercicio5()
        {
            Console.WriteLine("Introduz um número");
            var a = Console.ReadLine();
            Console.WriteLine("Introduz um número");
            var b = Console.ReadLine();
            Console.WriteLine("Introduz um número");
            var c = Console.ReadLine();
            Console.WriteLine("Introduz um número");
            var d = Console.ReadLine();
            Console.WriteLine("Introduz um número");
            var e = Console.ReadLine();
            Console.WriteLine("Introduz um número");
            var f = Console.ReadLine();


            var aConv = ConverterStringParaNumero(a);
            var bConv = ConverterStringParaNumero(b);
            var cConv = ConverterStringParaNumero(c);
            var dConv = ConverterStringParaNumero(d);
            var eConv = ConverterStringParaNumero(e);
            var fConv = ConverterStringParaNumero(f);
            Console.WriteLine("a." + "-" + aConv + " + " + bConv + " * " + cConv + " = " + (-aConv + bConv * cConv));
            Console.WriteLine("b." + "(" + aConv + " + " + bConv + ")" + " % " + cConv + " = " + ((aConv + bConv) % cConv));
            Console.WriteLine("c." + aConv + " + -" + bConv + " + " + cConv + " /" + dConv + " = " + (aConv + -bConv + cConv / dConv));
            Console.WriteLine("d." + aConv + " + " + bConv + "/" + cConv + " * " + dConv + " - " + eConv + " % " + fConv + " = " + (aConv + bConv / cConv * dConv - eConv % fConv));

            Console.ReadLine();


        }
        #endregion

        #region Exercicio6

        public static void Exercicio6()
        {
            Console.WriteLine("Introduz um número");
            var a = Console.ReadLine();
            var aConv = ConverterStringParaNumero(a);
            TabuadaDoDez(aConv);
        }

        public static void TabuadaDoDez(int aConv)
        {

            Console.WriteLine(aConv + " * 1 = " + aConv * 1);
            Console.WriteLine(aConv + " * 2 = " + aConv * 2);
            Console.WriteLine(aConv + "* 3 = " + aConv * 3);
            Console.WriteLine(aConv + "* 4 = " + aConv * 4);
            Console.WriteLine(aConv + "* 5 = " + aConv * 5);
            Console.WriteLine(aConv + "* 6 = " + aConv * 6);
            Console.WriteLine(aConv + "* 7 = " + aConv * 7);
            Console.WriteLine(aConv + "* 8 = " + aConv * 8);
            Console.WriteLine(aConv + "* 9 = " + aConv * 9);
            Console.WriteLine(aConv + " * 10 = " + aConv * 10);
        }

        #endregion

        #region Exercício 7

        public static void Exercicio7()
        {
            Console.WriteLine("Introduz um número por favor");
            var a = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var b = Console.ReadLine();
            var aConv = ConverterStringParaDecimal(a);
            var bConv = ConverterStringParaDecimal(b);
            decimal c = ((aConv + bConv) / 2);
            Console.WriteLine(aConv + " + " + bConv + "/ 2" + " = " + c);   
        }

        public static decimal ConverterStringParaDecimal(string num)
        {
            var parseOK = decimal.TryParse(num, out decimal parsedNum);
            return parseOK ? parsedNum : 0;
        }




        #endregion

        #region Exercicio 8

        public static void Exercicio8()
        {
            Console.WriteLine("Introduz um número por favor");
            var a = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var b = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var c = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var d = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var e = Console.ReadLine();
            var aConv = ConverterStringParaDecimal(a);
            var bConv = ConverterStringParaDecimal(b);
            var cConv = ConverterStringParaDecimal(c);
            var dConv = ConverterStringParaDecimal(d);
            var eConv = ConverterStringParaDecimal(e);
            decimal dec = ((aConv + bConv + cConv + dConv + eConv) / 5);
            Console.WriteLine(aConv + " + " + bConv + " + " + cConv + " + " + dConv + " + " + eConv + "/ 5 = " + dec);
        }
        #endregion

        #region Exercício 9

        public static void Exercicio9()
        {
            Console.WriteLine("Introduz um número por favor");
            var a = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var b = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var c = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var d = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var e = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var f = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var g = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var h = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var i = Console.ReadLine();
            Console.WriteLine("Introduz um número por favor");
            var j = Console.ReadLine();
            var aConv = ConverterStringParaDecimal(a);
            var bConv = ConverterStringParaDecimal(b);
            var cConv = ConverterStringParaDecimal(c);
            var dConv = ConverterStringParaDecimal(d);
            var eConv = ConverterStringParaDecimal(e);
            var fConv = ConverterStringParaDecimal(f);
            var gConv = ConverterStringParaDecimal(g);
            var hConv = ConverterStringParaDecimal(h);
            var iConv = ConverterStringParaDecimal(i);
            var jConv = ConverterStringParaDecimal(j);
            decimal dec = ((aConv + bConv + cConv + dConv + eConv + fConv + gConv + hConv + iConv + jConv) / 10);
            Console.WriteLine(aConv + " + " + bConv + " + " + cConv + " + " + dConv + " + " + eConv + " + " + fConv + " + " + gConv + " + " + hConv + " + " + iConv + " + " + jConv + "/ 10 = " + dec);
        }
        #endregion

        #region Exercício 10

        public static void Exercicio10()
        {
            Console.WriteLine("Escreva um caracter se faz favor");
            var a = Console.ReadLine();
            Console.WriteLine(a + " " + a + " " + a + '\n' + a + " " + a + " " + a + '\n' + a + " " + a + " " + a);
        }
        #endregion

        #region Exercício 11

        public static void Exercicio11()
        {
            Console.WriteLine("Produto?");
            var a = Console.ReadLine();
            Console.WriteLine("Preço?");
            var b = Console.ReadLine();
            Console.WriteLine("Quantia?");
            var c = Console.ReadLine();
            Console.WriteLine("Produto?");
            var d = Console.ReadLine();
            Console.WriteLine("Preço?");
            var e = Console.ReadLine();
            Console.WriteLine("Quantia?");
            var f = Console.ReadLine();
            Console.WriteLine("Produto?");
            var g = Console.ReadLine();
            Console.WriteLine("Preço?");
            var h = Console.ReadLine();
            Console.WriteLine("Quantia?");
            var i = Console.ReadLine();
            Console.WriteLine("Produto?");
            var j = Console.ReadLine();
            Console.WriteLine("Preço?");
            var k = Console.ReadLine();
            Console.WriteLine("Quantia?");
            var l = Console.ReadLine();


            
            var bConv = ConverterStringParaNumero(b);
            var cConv = ConverterStringParaNumero(c);
            var eConv = ConverterStringParaNumero(e);
            var fConv = ConverterStringParaNumero(f);
            var hConv = ConverterStringParaNumero(h);
            var iConv = ConverterStringParaNumero(i);
            var kConv = ConverterStringParaNumero(k);
            var lConv = ConverterStringParaNumero(l);



            var A = bConv * cConv;
            var B = eConv * fConv;
            var C = hConv * iConv;
            var D = kConv * lConv;
            var total = A + B + C + D;
            Console.WriteLine(a + "|" + A + '\n' + d + "|" + B + '\n' + g + "|" + C + '\n' + j + '|' + D + '\n' + "total |" + total);

        }

        #endregion

        #region Exercício 12

        public static void Exercicio12()
        {
            Console.WriteLine("Diz-me algo que eu não saiba");
            var x = Console.ReadLine();
            Console.WriteLine("Eu já sabia que " + x);
        }

        #endregion

        #region Exercício 13

        public static void Exercicio13()
        {
            Console.WriteLine("Introduz dois números");
            var fstNum = Console.ReadLine();
  
            var sndNum = Console.ReadLine();
            Console.WriteLine("O primeiro número é "  + fstNum + " e o segundo número é " + sndNum);
        }
        #endregion

        #region Exercício 14

        public static void Exercicio14 ()
        {
            Console.WriteLine("Introduz a temperatura");
            var temp = Console.ReadLine();
            var tempConvert = ConverterStringParaDouble(temp);
            double tempF = tempConvert * 9 / 5 + 32;
            double tempK = tempConvert + 273.15;
            Console.WriteLine("A temepratura " + tempConvert + "ºC é " + tempF + "ºF e " + tempK + "ºK");


        }

        public static double ConverterStringParaDouble(string num)
        {
            var parseOK = double.TryParse(num, out double parsedNum);
            return parseOK ? parsedNum : 0;
        }

        #endregion

        #region Exercício 15

        public static void Exercicio15()
        {
            Console.WriteLine("Quantas horas?");
            var hor = Console.ReadLine();
            Console.WriteLine("Quantos minutos?");
            var min = Console.ReadLine();
            Console.WriteLine("Quantos segundos?");
            var seg = Console.ReadLine();
            var total = hor + 3600 + min + 60 + seg;
            Console.WriteLine(hor + " : " + min + " : " + "é equivalente a " + total + " segundos");

        }

        #endregion

        #region Exercício 16

        public static void Exercicio16()
        {
            Console.WriteLine("Qual é o raio?");
            var raio = Console.ReadLine();
            var raioConv = ConverterStringParaNumero(raio);
            var area = 3.14 * raioConv * raioConv;
            var per = 2 * 3.14 * raioConv;
            Console.WriteLine(" A área do circulo é " + area + " e o perímetro é " + per);
        }

        #endregion


    }
}







