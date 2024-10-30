using System.Text;

namespace ProficientQuests
{
    // Verifica se uma matriz é simétrica
    public class Q51
    {
        public static void CheckSymmetricMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                Console.Clear();
                Console.Write("A matriz não é simétrica");
                return;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = i + 1; j < cols; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        Console.Clear();
                        Console.Write("A matriz não é simétrica");
                        return;
                    }
                }
            }

            Console.Clear();
            Console.Write("A matriz é simétrica");
        }
    }

    // Organiza uma lista em ordem alfabética
    public class Q52
    {
        public static void SortAlphabetical(List<string> list)
        {
            list.Sort();
            Console.Clear();
            Console.WriteLine("[Lista em ordem alfabética]");
            foreach (var name in list)
            {
                Console.WriteLine();
                Console.Write(name);
            }
        }
    }

    // Encontra o elemento mais frequente em um array
    public class Q53
    {
        public static void MostFrequentElement(int[] array)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int count = 0;
            int element = array[0];

            foreach (var num in array)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }

                if (frequency[num] > count)
                {
                    count = frequency[num];
                    element = num;
                }
            }

            Console.Clear();
            Console.Write($"O elemento mais frequente é: {element}.");
        }
    }

    // Encontra o valor absoluto de um número
    public class Q54
    {
        public static void AbsoluteValue(double numb)
        {
            double value = (numb < 0) ? -numb : numb;
            Console.Clear();
            Console.Write($"O valor absoluto de {numb} é: {value}\n");
        }
    }

    // Encontra um elemento em um array e exibe sua posição
    public class Q55
    {
        public static void FindElement(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    Console.Clear();
                    Console.Write($"Elemento {element} encontrado no índice {i}.");
                    return;
                }
            }
            Console.Clear();
            Console.Write($"Elemento {element} não encontrado no array.");
        }
    }

    // Cronômetro
    public class Q56
    {
        public static void Stopwatch()
        {
            Console.Clear();
            Console.WriteLine("[Cronômetro iniciado. Aperte qualquer tecla para parar!]");

            int seconds = 0;
            while (!Console.KeyAvailable)
            {
                Console.Clear();
                Console.Write($"Cronômetro: {seconds}s");
                Thread.Sleep(800);
                seconds++;
            }

            Console.ReadKey(true);
            Console.Clear();
            Console.Write($"Cronômetro marcou {seconds}s.");
        }
    }

    // Conta o número de palavras em uma frase
    public class Q57
    {
        public static void WordCount(string phrase)
        {
            string[] words = phrase.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            Console.Clear();
            Console.Write($"Número de palavras na frase \"{phrase}\": {wordCount}");
        }
    }

    // Representa uma pessoa em uma rede social e exibe sua mensagem
    public class Pessoa // Q58
    {
        public string Talk { get; private set; }

        public Pessoa(string message)
        {
            Talk = message;
        }

        public static void DisplayMessage()
        {
            Console.Clear();
            Console.Write("Escreva uma mensagem: ");
            string message = Console.ReadLine();
            Pessoa pessoa = new Pessoa(message);
            Console.Clear();
            Console.Write($"Mensagem: {pessoa.Talk}");
        }
    }

    // Calcula a interseção entre dois arrays
    public class Q59
    {
        public static void ArrayIntersection(int[] array1, int[] array2)
        {
            HashSet<int> set = new HashSet<int>(array1);
            List<int> intersection = new List<int>();

            foreach (int num in array2)
            {
                if (set.Contains(num))
                {
                    intersection.Add(num);
                }
            }

            Console.Clear();
            Console.Write("Interseção entre os arrays: " + string.Join(", ", intersection));
        }
    }

    // Alterna entre maiúsculas e minúsculas em uma string
    public class Q60
    {
        public static void AlternateCase(string input)
        {
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = (i % 2 == 0) ? char.ToUpper(charArray[i]) : char.ToLower(charArray[i]);
            }

            string result = new string(charArray);
            Console.Clear();
            Console.Write($"{result}");
        }
    }

    // Conta o número de caracteres distintos em uma string
    public class Q61
    {
        public static int CountUniqueCharacters(string input)
        {
            HashSet<char> uniqueChars = new();

            foreach (char caracter in input)
            {
                uniqueChars.Add(caracter);
            }

            return uniqueChars.Count;
        }
    }

    // Exibe os números primos menores ou iguais a um número
    public class Q62
    {
        public static void ShowPrimes(int limit)
        {
            for (int num = 2; num <= limit; num++)
            {
                bool ehPrimo = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }
                if (ehPrimo)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }

    // Verifica se um número é perfeito
    public class Q63
    {
        public static bool IsPerfectNumber(int num)
        {
            int sumDividers = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sumDividers += i;
                }
            }

            return sumDividers == num;
        }
    }

    // Exibe os divisores de um número
    public class Q64
    {
        public static void ShowDividers(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    // Realiza a transposição de uma matriz
    public class Q65
    {
        public static void TransposeMatrix()
        {
            int[,] matriz = {
                {11, 12, 13},
                {14, 15, 16},
                {17, 18, 19}
            };

            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int[,] transposta = new int[colunas, linhas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
            }

            Console.WriteLine("Matriz transposta:");
            for (int i = 0; i < colunas; i++)
            {
                for (int j = 0; j < linhas; j++)
                {
                    Console.Write($"{transposta[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    // Simula o relogio
    public class Q66
    {
        public static void SimulateClock()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Horário atual: \n");
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("\n{0} - Sair", 0);

                if (Console.KeyAvailable)
                {
                    if (int.TryParse(Console.ReadLine(), out int sair) && sair == 0)
                    {
                        break;
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }

    // Calculadora simples com as 4 operações
    public class Q67
    {
        public static void Calculator()
        {
            int num1, num2, operation = -1;

            while (operation != 0)
            {
                Console.Clear();
                Console.WriteLine("Calculadora\n");
                Console.WriteLine("{1} - Soma");
                Console.WriteLine("{2} - Subtração");
                Console.WriteLine("{3} - Multiplicação");
                Console.WriteLine("{4} - Divisão");
                Console.WriteLine("{0} - Sair");
                operation = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (operation)
                {
                    case 1:
                        Console.Write("Digite o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Digite o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write($"Resultado da soma: {num1 + num2}");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("Digite o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Digite o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write($"Resultado da subtração: {num1 - num2}");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Write("Digite o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Digite o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write($"Resultado da multiplicação: {num1 * num2}");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Write("Digite o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Digite o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (num2 == 0)
                        {
                            Console.Write("Divisão por zero não é permitida!");
                            Console.ReadKey();
                        }
                        else
                        {
                            double resultadoDivisao = (double)num1 / num2;
                            Console.Write($"Resultado da divisão: {resultadoDivisao}");
                            Console.ReadKey();
                        }
                        break;

                    case 0:
                        Console.Clear();
                        Console.Write("Saindo da calculadora.");
                        break;

                    default:
                        Console.Clear();
                        Console.Write("Operação inválida. Tente novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    // Transforma um valor em leitura extensiva
    public class Q68
    {
        public static string NumeroExtenso(int num68)
        {
            string[] unid = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            string[] deze = { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] espec = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string extenso = "";

            if (num68 < 10)
            {
                extenso = unid[num68];
            }
            else if (num68 < 20)
            {
                extenso = espec[num68 - 10];
            }
            else if (num68 < 100)
            {
                extenso = deze[num68 / 10];
                if (num68 % 10 > 0)
                {
                    extenso += " e " + unid[num68 % 10];
                }
            }
            else if (num68 < 1000)
            {
                extenso = unid[num68 / 100] + " cento";
                int resto = num68 % 100;
                if (resto > 0)
                {
                    extenso += " e " + NumeroExtenso(resto);
                }
            }

            return extenso;
        }

        public static string ValorExtenso(double dinheiro)
        {
            int valorInteiro = (int)dinheiro;
            int centavos = (int)((dinheiro - valorInteiro) * 100);

            string extenso = NumeroExtenso(valorInteiro) + " reais";
            if (centavos > 0)
            {
                extenso += " e " + NumeroExtenso(centavos) + " centavos";
            }

            return extenso;
        }
    }

    // Média ponderada
    public class Q69
    {
        public static void WeightedAverage()
        {
            Console.Write("Digite a quantidade de notas: ");
            int qty = int.Parse(Console.ReadLine());
            Console.Clear();

            double[] grades = new double[qty];
            double[] weights = new double[qty];
            double sumWeights = 0;
            double sum = 0;

            for (int i = 0; i < qty; i++)
            {
                Console.Write($"Digite a {i + 1}° nota : ");
                grades[i] = double.Parse(Console.ReadLine());

                Console.Write($"Digite o peso da {i + 1}° nota : ");
                weights[i] = double.Parse(Console.ReadLine());
                Console.Clear();

                sum += grades[i] * weights[i];
                sumWeights += weights[i];
            }

            Console.Clear();
            double average = sum / sumWeights;
            Console.WriteLine($"A média ponderada das notas é: {average}");
            Console.ReadKey();
        }
    }

    // Simula operações de depósito e saque em um Caixa Eletrônico
    public class Q70
    {
        public static void CaixaEletronico()
        {
            Console.WriteLine("Bem-vindo ao Caixa Eletrônico");
            Console.Write("Digite o valor do depósito: ");
            int depositado = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite o valor do saque: ");
            int saque = int.Parse(Console.ReadLine());
            Console.Clear();

            if (saque > depositado)
            {
                Console.Clear();
                Console.Write("Não é possível sacar o valor solicitado, o valor depositado é inferior ao saque.");
                Console.ReadKey();
            }
            else
            {
                int[] notas = { 100, 50, 20, 10, 5, 2 };
                int[] quantNotas = new int[notas.Length];

                for (int i = 0; i < notas.Length; i++)
                {
                    if (saque >= notas[i])
                    {
                        quantNotas[i] = saque / notas[i];
                        saque %= notas[i];
                    }
                }

                Console.WriteLine("Distribuição de notas:");
                for (int i = 0; i < notas.Length; i++)
                {
                    if (quantNotas[i] > 0)
                    {
                        Console.Write($"{quantNotas[i]} nota(s) de R$ {notas[i]}");
                    }
                }
                Console.ReadKey();
            }
        }
    }

    // Compara arrays
    public class Q71
    {
        public static bool CompareArrays(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }

    // Gera uma senha aleatória
    public class Q72
    {
        public static string RandomPassword(int tam)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder senha = new StringBuilder();
            Random aleatoria = new Random();

            for (int i = 0; i < tam; i++)
            {
                int index = aleatoria.Next(caracteres.Length);
                senha.Append(caracteres[index]);
            }

            return senha.ToString();
        }
    }

    // Multiplicação de tabelas
    public class Q73
    {
        public static void MultiplicationTable()
        {
            Console.Write("Digite o número de tabelas de multiplicação: ");
            int tam = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite o número de multiplicações por tabela: ");
            int tam2 = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= tam; i++)
            {
                Console.WriteLine($"Tabela de multiplicação de {i}:");

                for (int index = 1; index <= tam2; index++)
                {
                    Console.Write($"{i * index}\n");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    // Calcula a área de um triangulo
    public class Q74
    {
        public static double TriangleArea(double lado1, double lado2, double lado3)
        {
            double perim = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt(perim * (perim - lado1) * (perim - lado2) * (perim - lado3));
            return area;
        }
    }

    // Gera um conjunto de números aleatórios e únicos
    public class Q75
    {
        public static List<int> NumerosAleatoriosUnicos(int num)
        {
            List<int> numeros = new List<int>();
            Random aleatorio = new Random();

            while (numeros.Count < num)
            {
                int numero = aleatorio.Next(1, num + 1);
                if (!numeros.Contains(numero))
                {
                    numeros.Add(numero);
                }
            }

            return numeros;
        }
    }
}