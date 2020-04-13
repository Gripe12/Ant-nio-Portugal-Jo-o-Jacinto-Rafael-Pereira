using System;
using System.Threading;

namespace Ficha13
{
    public class Ficha13Solucao
    {
        static void Main(string[] args)
        {

        }

        #region Calculadora
        public static void Calculadora()
        {

            double ans;
            Calcular(out ans);
            Console.Clear();
            Desenho(ans);

        }

        public static double Calcular(out double nr1)
        {
            double nr2;
            string op;
            bool trigger = true;
            Desenho(0);

            Console.WriteLine("Escrever um nr");
            nr1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Desenho(nr1);

            do
            {
                Console.WriteLine("Operação? +, -, *, / ou = para terminar");
                op = Console.ReadLine();

                if (op == "=")
                {
                    trigger = false;
                    break;
                }

                Console.Clear();
                Desenho(nr1);

                Console.WriteLine("Escrever um nr");
                nr2 = double.Parse(Console.ReadLine());


                if (op == "+")
                {
                    nr1 += nr2;
                    Console.Clear();
                    Desenho(nr1);
                }
                else if (op == "-")
                {
                    nr1 -= nr2;
                    Console.Clear();
                    Desenho(nr1);
                }
                else if (op == "*")
                {
                    nr1 *= nr2;
                    Console.Clear();
                    Desenho(nr1);
                }
                else if (op == "/")
                {
                    nr1 /= nr2;
                    Console.Clear();
                    Desenho(nr1);
                }
                else if (op == "CE")
                {
                    nr1 = 0;
                    Console.Clear();
                }
            } while (trigger == true);
            return nr1;
        }

        public static void Desenho(double ans)
        {

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("              ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"       {ans}");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("  ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("              ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("1");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("2");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("3");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("+");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("-");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("  ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("              ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("4");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("5");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("6");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("*");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("/");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("  ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("              ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("7");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("8");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("9");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("=");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("CE");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("              ");

            Console.BackgroundColor = ConsoleColor.Black;
        }
        #endregion

        #region JogoDoGalo      

        public static void JogoDoGalo()
        {
            var esp1 = "1";
            var esp2 = "2";
            var esp3 = "3";
            var esp4 = "4";
            var esp5 = "5";
            var esp6 = "6";
            var esp7 = "7";
            var esp8 = "8";
            var esp9 = "9";
            var i = 0;
            int X = 0;
            int O = 0;
            bool trigger = true;
            bool check = false;

            while (trigger == true)
            {

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("-----------");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("-----------");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($" {esp7} | {esp8} | {esp9} ");

                while (check == false)
                {
                    Console.WriteLine("X escolhe um espaço");
                    X = int.Parse(Console.ReadLine());

                    if (
                     esp1 == "X" && X == 1 || esp1 == "O" && X == 1 ||
                     esp2 == "X" && X == 2 || esp2 == "O" && X == 2 ||
                     esp3 == "X" && X == 3 || esp3 == "O" && X == 3 ||
                     esp4 == "X" && X == 4 || esp4 == "O" && X == 4 ||
                     esp5 == "X" && X == 5 || esp5 == "O" && X == 5 ||
                     esp6 == "X" && X == 6 || esp6 == "O" && X == 6 ||
                     esp7 == "X" && X == 7 || esp7 == "O" && X == 7 ||
                     esp8 == "X" && X == 8 || esp8 == "O" && X == 8 ||
                     esp9 == "X" && X == 9 || esp9 == "O" && X == 9
                     )
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("-----------");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("-----------");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($" {esp7} | {esp8} | {esp9} ");
                        Console.WriteLine("Espaço ocupado");

                    }
                    else
                    {

                        switch (X)
                        {
                            case (1):
                                esp1 = "X";
                                i++;
                                check = true;
                                break;
                            case (2):
                                esp2 = "X";
                                i++;
                                check = true;
                                break;
                            case (3):
                                esp3 = "X";
                                i++;
                                check = true;
                                break;
                            case (4):
                                esp4 = "X";
                                i++;
                                check = true;
                                break;
                            case (5):
                                esp5 = "X";
                                i++;
                                check = true;
                                break;
                            case (6):
                                esp6 = "X";
                                i++;
                                check = true;
                                break;
                            case (7):
                                esp7 = "X";
                                i++;
                                check = true;
                                break;
                            case (8):
                                esp8 = "X";
                                i++;
                                check = true;
                                break;
                            case (9):
                                esp9 = "X";
                                i++;
                                check = true;
                                break;
                            default:
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("-----------");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("-----------");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine($" {esp7} | {esp8} | {esp9} ");
                                Console.WriteLine("Jogada Inválida");
                                continue;
                        }
                    }
                }
                Console.Clear();

                if (i == 9)
                {
                    trigger = false;

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("-----------");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("-----------");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($" {esp7} | {esp8} | {esp9} ");
                    Console.WriteLine("Empate!");
                    break;
                }
                else if
                    (//verticais
                    esp1 == "X" && esp2 == "X" && esp3 == "X" ||
                    esp4 == "X" && esp5 == "X" && esp6 == "X" ||
                    esp7 == "X" && esp8 == "X" && esp9 == "X" ||
                    //horizontais
                    esp1 == "X" && esp4 == "X" && esp7 == "X" ||
                    esp2 == "X" && esp5 == "X" && esp8 == "X" ||
                    esp3 == "X" && esp6 == "X" && esp9 == "X" ||
                    //diagonal
                    esp1 == "X" && esp5 == "X" && esp9 == "X" ||
                    esp3 == "X" && esp5 == "X" && esp7 == "X")
                {
                    Console.WriteLine("O X é um vencedor!");
                    break;
                }

                check = false;

                Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                Console.WriteLine("-----------");
                Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                Console.WriteLine("-----------");
                Console.WriteLine($" {esp7} | {esp8} | {esp9} ");

                while (check == false)
                {
                    Console.WriteLine("O escolhe um espaço");
                    O = int.Parse(Console.ReadLine());

                    if (
                    esp1 == "X" && O == 1 || esp1 == "O" && O == 1 ||
                    esp2 == "X" && O == 2 || esp2 == "O" && O == 2 ||
                    esp3 == "X" && O == 3 || esp3 == "O" && O == 3 ||
                    esp4 == "X" && O == 4 || esp4 == "O" && O == 4 ||
                    esp5 == "X" && O == 5 || esp5 == "O" && O == 5 ||
                    esp6 == "X" && O == 6 || esp6 == "O" && O == 6 ||
                    esp7 == "X" && O == 7 || esp7 == "O" && O == 7 ||
                    esp8 == "X" && O == 8 || esp8 == "O" && O == 8 ||
                    esp9 == "X" && O == 9 || esp9 == "O" && O == 9
                    )
                    {
                        Console.Clear();
                        Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                        Console.WriteLine("-----------");
                        Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                        Console.WriteLine("-----------");
                        Console.WriteLine($" {esp7} | {esp8} | {esp9} ");
                        Console.WriteLine("Espaço ocupado");

                    }
                    else
                    {
                        switch (O)
                        {
                            case (1):
                                esp1 = "O";
                                i++;
                                check = true;
                                break;
                            case (2):
                                esp2 = "O";
                                i++;
                                check = true;
                                break;
                            case (3):
                                esp3 = "O";
                                i++;
                                check = true;
                                break;
                            case (4):
                                esp4 = "O";
                                i++;
                                check = true;
                                break;
                            case (5):
                                esp5 = "O";
                                i++;
                                check = true;
                                break;
                            case (6):
                                esp6 = "O";
                                i++;
                                check = true;
                                break;
                            case (7):
                                esp7 = "O";
                                i++;
                                check = true;
                                break;
                            case (8):
                                esp8 = "O";
                                check = true;
                                i++;
                                break;
                            case (9):
                                esp9 = "O";
                                i++;
                                check = true;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine($" {esp1} | {esp2} | {esp3} ");
                                Console.WriteLine("-----------");
                                Console.WriteLine($" {esp4} | {esp5} | {esp6} ");
                                Console.WriteLine("-----------");
                                Console.WriteLine($" {esp7} | {esp8} | {esp9} ");
                                Console.WriteLine("Jogada Inválida");
                                check = false;
                                continue;

                        }
                    }
                }

                Console.Clear();
                check = false;

                if
                    (//verticais
                    esp1 == "O" && esp2 == "O" && esp3 == "O" ||
                    esp4 == "O" && esp5 == "O" && esp6 == "O" ||
                    esp7 == "O" && esp8 == "O" && esp9 == "O" ||
                    //horizontais
                    esp1 == "O" && esp4 == "O" && esp7 == "O" ||
                    esp2 == "O" && esp5 == "O" && esp8 == "O" ||
                    esp3 == "O" && esp6 == "O" && esp9 == "O" ||
                    //diagonal
                    esp1 == "O" && esp5 == "O" && esp9 == "O" ||
                    esp3 == "O" && esp5 == "O" && esp7 == "O")
                {
                    Console.WriteLine("O O é um vencedor!");
                    break;
                }
            }
        }

        #endregion

        #region JogoDaForca

        public static void JogodaForca()
        {
            var word = getword();
            var guess = "";
            var guesses = "";
            var lenght = word.Length;
            int lives = 6;
            var end = false;

            while (lenght > 0)
            {
                if (lenght == 1)
                    guess += "_";
                else
                    guess += "_ ";

                lenght--;
            }

            lenght = word.Length;

            while (!end)
            {
                DrawBoard(lives, lenght, word, guess, guesses);

                var letra = AskLetter(guesses);

                if (guesses == "")
                    guesses += letra.ToString();
                else
                    guesses += " " + letra.ToString();

                CheckLetter(ref lives, ref guess, word, letra);
                end = CheckGameEnd(guess, lives);

            }

            DrawBoard(lives, lenght, word, guess, guesses);

            Console.BackgroundColor = ConsoleColor.Blue;
            if (lives > 0)
                Console.WriteLine(" Parabéns adivinhou a palavra!");
            else
                Console.WriteLine("           GAME OVER          ");
            Console.BackgroundColor = ConsoleColor.Black;

        }

        private static string getword()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 12);

            if (num == 1)
                return "cao";
            else if (num == 2)
                return "sorte";
            else if (num == 3)
                return "verniz";
            else if (num == 4)
                return "luz";
            else if (num == 5)
                return "cha";
            else if (num == 6)
                return "pedra";
            else if (num == 7)
                return "azevinho";
            else if (num == 8)
                return "barco";
            else if (num == 9)
                return "rio";
            else if (num == 10)
                return "ficha";
            else if (num == 11)
                return "humano";
            else
                return "joaquim";

        }

        private static void DrawBoard(int lives, int lenght, string word, string guess, string guesses)
        {
            string titulo = "Jogo da Forca";

            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();

            FillBackground(0);
            FillBackground(0);
            Console.WriteLine();

            FillBackground(titulo.Length);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(titulo);
            FillBackground(titulo.Length + 1);
            Console.WriteLine();

            DrawHangedMan(lives);

            FillBackground(0);
            FillBackground(0);
            Console.WriteLine();

            FillBackground(guess.Length);
            Console.BackgroundColor = ConsoleColor.Gray;
            WriteWord(guess, word, lives, lenght);
            FillBackground(guess.Length + 1);
            Console.WriteLine();

            FillBackground(0);
            FillBackground(0);
            Console.WriteLine();

            WriteGuesses(guesses);

            FillBackground(0);
            FillBackground(0);
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }

        private static void WriteWord(string guess, string word, int lives, int lenght)
        {
            var counter = 0;

            if (lives == 0)
            {
                guess = "";

                foreach (char wordLetter in word)
                {
                    if (counter == lenght - 1)
                        guess += wordLetter;
                    else
                        guess += wordLetter + " ";
                    counter++;

                }
            }

            Console.Write(guess);

        }

        private static void WriteGuesses(string guesses)
        {
            FillBackground("Letras Tentadas:".Length);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("Letras Tentadas:");
            FillBackground("Letras Tentadas:".Length + 1);
            Console.WriteLine();

            FillBackground(guesses.Length);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write(guesses);
            FillBackground(guesses.Length + 1);
            Console.WriteLine();

        }

        private static void FillBackground(int lenght)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            for (int i = lenght / 2; i <= 14; i++)
                Console.Write(" ");
        }

        private static void DrawHangedMan(int lives)
        {
            if (lives == 6)
            {
                FillBackground(9);
                Console.Write("   ______");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   |   \\|");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("        |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("        |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("        |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("________|");
                FillBackground(10);
                Console.WriteLine();

            }
            else if (lives == 5)
            {
                FillBackground(9);
                Console.Write("   ______");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   |   \\|");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   O    |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("        |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("        |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("________|");
                FillBackground(10);
                Console.WriteLine();

            }
            else if (lives == 4)
            {
                FillBackground(9);
                Console.Write("   ______");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   |   \\|");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   O    |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   |    |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("        |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("________|");
                FillBackground(10);
                Console.WriteLine();
            }
            else if (lives == 3)
            {
                FillBackground(9);
                Console.Write("   ______");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   |   \\|");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   O    |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  /|    |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("        |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("________|");
                FillBackground(10);
                Console.WriteLine();
            }
            else if (lives == 2)
            {
                FillBackground(9);
                Console.Write("   ______");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   |   \\|");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   O    |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  /|\\   |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("        |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("________|");
                FillBackground(10);
                Console.WriteLine();
            }
            else if (lives == 1)
            {
                FillBackground(9);
                Console.Write("   ______");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   |   \\|");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   O    |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  /|\\   |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  /     |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("________|");
                FillBackground(10);
                Console.WriteLine();
            }
            else
            {
                FillBackground(9);
                Console.Write("   ______");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   |   \\|");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("   O    |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  /|\\   |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("  / \\   |");
                FillBackground(10);
                Console.WriteLine();
                FillBackground(9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("________|");
                FillBackground(10);
                Console.WriteLine();
            }

        }



        private static char LerLetra()
        {
            var letra = 'a';
            var test = char.TryParse(Console.ReadLine(), out letra);

            if (test)
                return letra;
            else
                return '1';

        }

        private static char AskLetter(string guesses)
        {
            var letra = '\0';
            var test = true;

            while (test)
            {
                Console.Write("\nLetra a testar: ");
                letra = Char.ToLower(LerLetra());
                if ((letra == '1') || ((int)letra < 65 || 90 < (int)letra) && (letra < 97 || (int)letra > 122))
                {
                    Console.WriteLine("Utilize uma letra de a-z");

                }
                else
                    test = false;

                var usedletters = guesses.Split(" ");
                foreach (string k in usedletters)
                    if (letra.ToString() == k)
                    {
                        Console.WriteLine("Já utilizou esta letra. Utilize uma letra nova.");
                        test = true;
                    }

            }

            return letra;

        }

        private static void CheckLetter(ref int lives, ref string guess, string word, char letra)
        {
            var correct = false;
            var positions = "0";
            var pos = 1;
            var guessCopy = "";

            foreach (char wordLetter in word)
            {
                if (wordLetter == letra)
                {
                    positions += " " + pos;
                    correct = true;
                }
                pos++;
            }

            if (correct)
            {
                pos = 1;
                var positionsSplit = positions.Split(" ");

                foreach (string guessLetter in guess.Split(" "))
                {
                    foreach (string pos2 in positionsSplit)
                    {
                        if (pos2 == "0")
                        { }
                        else if (pos == int.Parse(pos2))
                            if (pos == word.Length)
                                guessCopy += letra;
                            else
                                guessCopy += letra + " ";
                        else
                            if (pos == word.Length)
                            guessCopy += guessLetter;
                        else
                            guessCopy += guessLetter + " ";
                    }
                    pos++;
                }
            }

            if (!correct)
                lives--;
            else
                guess = guessCopy;
        }

        private static bool CheckGameEnd(string guess, int lives)
        {
            var leftovers = 0;

            var guessletters = guess.Split(" ");
            foreach (string k in guessletters)
            {
                if (k == "_")
                    leftovers++;
            }

            if (leftovers == 0)
            {
                return true;
            }

            if (lives == 0)
                return true;

            return false;

        }


        #endregion

        #region Pedra Papel Tesoura

        public class PedraPapelTesoura
        {
            private const char ROCK = 'r';
            private const char PAPER = 'p';
            private const char SCISSORS = 's';

            public static void Start()
            {
                var rounds = 0;
                var nome = "";
                var humWins = 0;
                var compWins = 0;
                var end = 0;

                nome = NomeJogador(out nome);
                Console.Clear();

                Console.WriteLine("A melhor de...?");
                int nrjogadas = int.Parse(Console.ReadLine());
                Console.Clear();

                do
                { 
                    ValidateGame(ref humWins, ref compWins, nome);

                    end = CheckGameEnd(humWins, compWins, nrjogadas, rounds);

                    if (end == 0) 
                    {
                        Console.WriteLine("Prima enter para jogar a proxima ronda:");
                        Console.ReadLine();
                        Console.Clear();

                    }
                    rounds++;
                } while (end == 0) ;


                if (end == 1)
                    DisplayWinner(nome);
                else if (end == 2)
                    DisplayLoser(nome);
                else
                    DisplayTie();
            }

            private static int CheckGameEnd(int humWins, int compWins, int nrjogadas, int rounds)
            {
                if (humWins == ((nrjogadas + 1) / 2))
                    return 1;
                else if (compWins == ((nrjogadas + 1) / 2))
                    return 2;
                else if (rounds == nrjogadas)
                    return 3;
                else
                    return 0;

            }
            public static char JogadaJogador()
            {
                                  
                Console.WriteLine("Qual é a tua jogada?" + '\n' + "r para pedra, p para papel, s para tesoura, ou n para parar de jogar");
                var b = Char.Parse(Console.ReadLine());

                if (b == ROCK)
                {
                    Console.WriteLine(ROCK);
                    return b;
                }
                else if (b == PAPER)
                {
                    Console.WriteLine(PAPER);
                    return b;
                    
                }
                else if (b == SCISSORS)
                {
                    Console.WriteLine(SCISSORS);
                    return b;
                }
                else
                {
                    return b;
                }
                
            }

            public static char JogadaComputador()
            {
               var num = Aleatorio(1, 3);
                var a = '\0';

                if (num == 1)
                {
                    a = ROCK;
                    Console.WriteLine(ROCK);
                    return a;                    
                }
                else if (num == 2)
                {
                    a = PAPER;
                    Console.WriteLine(PAPER);
                    return a;
                }
                else 
                {
                    a = SCISSORS; 
                    Console.WriteLine(SCISSORS);
                    return a;
                }              
            }


            public static void ValidateGame(ref int humWins, ref int compWins, string nome)
            {
                var hum = JogadaJogador();

                var comp = JogadaComputador();

                Display(hum, comp);

                var winner = Winner(hum, comp);

                if (winner == "hum")
                {
                    humWins++;
                    
                }
                else if (winner == "comp")
                {
                    compWins++;
                   
                }
                else
                {
                    
                }


            }

            private static string Winner (char hum, char comp)
            {
                if (hum == ROCK)
                {
                    if (comp == SCISSORS)
                        return "hum";
                    else if (comp == PAPER)
                        return "comp";
                    else
                        return "tie";
                }
                else if (hum == SCISSORS)
                {
                    if (comp == PAPER)
                        return "hum";
                    else if (comp == ROCK)
                        return "comp";
                    else
                        return "tie";
                }
                else if (hum == PAPER)
                {
                    if (comp == ROCK)
                        return "hum";
                    else if (comp == SCISSORS)
                        return "comp";
                    else
                        return "tie";
                }
                else
                    return "tie";

            }


            public static string NomeJogador(out string nome1)
            {
                Console.WriteLine("Como te chamas?");
                nome1 = Console.ReadLine();
                return nome1;

            }

            #region Suporte
            private static void DisplayLoser(string name)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Roses are Red");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A longboard is also called a cruiser");
                Console.Write("I'm sorry ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(name);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("!\nYou are the loser");
            }

            private static void DisplayTie()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Roses are Red");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("I must say goodbye");
                Console.WriteLine("This game is over!");
                Console.WriteLine("It ended in a tie");
            }
            private static int Aleatorio(int min, int max)
            {
                return new Random().Next(max) + min;
            }

            private static void Display(char p1, char p2, int rounds = 4)
            {
                for (var i = 0; i < rounds; i++)
                {
                    var @switch = false;
                    var pos = 0;
                    while (!(@switch && pos == 0))
                    {
                        Console.Clear();
                        if (i == rounds - 1 && pos == 2)
                        {
                            DisplayResult(pos, p1, p2);
                            Thread.Sleep(500);
                            break;
                        }
                        else
                        {
                            DisplayResult(pos, 'r', 'r');
                        }
                        Thread.Sleep(50);
                        pos = pos + (@switch ? -1 : 1);
                        if (pos == 4) @switch = !@switch;
                    }
                }
            }

            private static void DisplayWinner(string playerName)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Roses are Red");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Violets are blue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Congratulations ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(playerName);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("!\nA winner is you");
            }

            private static void DisplayResult(int lines, char p1, char p2)
            {
                while (lines > 0)
                {
                    Console.WriteLine();
                    lines--;
                }
                //1
                Console.Write("          _______");
                Console.CursorLeft = 30;
                Console.WriteLine(p2 == 'r' ? "  _______" : p2 == 'p' ? "       _______" : "       _______");

                //2
                Console.Write(p1 == 'r' ? "      ---'   ____)" : p1 == 'p' ? "      ---'   ____)____ " : "      ---'   ____)____");
                Console.CursorLeft = 30;
                Console.WriteLine(p2 == 'r' ? " (____   '---      " : p2 == 'p' ? "  ____(____   '---      " : "  ____(____   '---      ");

                //3
                Console.Write(p1 == 'r' ? "            (_____)" : "                ______)");
                Console.CursorLeft = 30;
                Console.WriteLine(p2 == 'r' ? "(____   '---      " : " (______");

                //4
                Console.Write(p1 == 'r' ? "            (_____)" : p1 == 'p' ? "                _______)" : "             __________)");
                Console.CursorLeft = 30;
                Console.WriteLine(p2 == 'r' ? "(_____)" : p2 == 'p' ? "(_______" : "(__________");

                //5
                Console.Write(p1 == 'r' ? "             (____)" : p1 == 'p' ? "               _______)" : "            (____)");
                Console.CursorLeft = 30;
                Console.WriteLine(p2 == 'r' ? "(____)" : p2 == 'p' ? " (_______" : "     (____)");

                //6
                Console.Write(p1 == 'r' ? "      ---.__(___) " : p1 == 'p' ? "      ---.__________)" : "      ---.__(___)");
                Console.CursorLeft = 30;
                Console.WriteLine(p2 == 'r' ? "  (___)__.---" : p2 == 'p' ? "   (__________.---" : "      (___)__.---");
            }

            #endregion

            #endregion



        }
    }
}