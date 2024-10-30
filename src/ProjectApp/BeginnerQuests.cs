using System.Threading;

namespace BeginnerQuests
{
    // Representa um produto com nome e preço, exibindo essas informações
    public class Produto // Q1 e Q2
    {
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }

    public Produto (string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void ExibirProduto()
    {
        Console.Write($"Nome: {Nome}\nPreço: {Preco}");
    }

    }

    // Realiza a soma de dois números inteiros
    public class Q3
    {
        public static void Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.Write($"Soma: {sum}");
        }
    }

    // Verifica se um número é par ou ímpar
    public class Q4
    {
        public static void CheckParity(int n)
        {
            if (n % 2 == 0)
            {
                Console.Write($"O número {n} é par");
            }
            else
            {
                Console.Write($"O número {n} é ímpar");
            }
        }
    }

    // Converte metros para centímetros
    public class Q5
    {
        public static void ConvertMetersToCentimeters(double m)
        {
            double cm = m * 100;
            Console.Write($"{m:N2} metros equivalem a {cm:N2} centímetros.");
        }
    }

    // Verifica se uma pessoa é maior de idade ou não
    public class Q6
    {
        public static void CheckMajority(int age)
        {
            if (age >= 18)
            {
                Console.Write($"A idade {age} é maioridade.");
            }
            else
            {
                Console.Write($"A idade {age} é menoridade.");
            }
        }
    }

    // Calcula a área de um círculo dado o raio
    public class Q7
    {
        public static void CalculateCircleArea(int r)
        {
            float pi = 3.14f;
            var area = pi * (r * r);
            Console.Write($"Tendo em vista o raio {r}, a área do círculo é: {area}");
        }
    }

    // Imprime uma tabela de multiplicação
    public class Q8
    {
        public static void PrintMultiplicationTable(int n)
        {
            Console.WriteLine($"[TABELA MULTIP.]");
            for (int i = 0; i < 11; i++)
            {
                int multip = n * i;
                Console.WriteLine();
                Console.Write($"{n} X {i} = {multip}");
            }
        }
    }

    // Imprime uma tabela de soma
    public class Q9
    {
        public static void PrintSumTable(int N)
        {
            Console.WriteLine($"[TABELA SOMA.]");
            for (int i = 1; i <= N; i++)
            {
                int sumN = i + N;
                Console.WriteLine();
                Console.Write($"{i} + {N} = {sumN}");
            }
        }
    }

    // Converte Celsius para Fahrenheit
    public class Q10
    {
        public static void ConvertCelsiusToFahrenheit(float C)
        {
            float F = C * 1.8f + 32f;
            Console.Write($"{C}°C são {F}°F.");
        }
    }

    // Verifica se uma string é vazia
    public class Q11
    {
        public static void CheckStringEmpty(string s)
        {
            if (string.IsNullOrEmpty(s.Trim()))
            {
                Console.Write($"A string fornecida está vazia.");
            }
            else
            {
                Console.Write($"A string fornecida possui conteúdo): {s}.");
            }
        }
    }

    // Imprime os números pares de 1 a 50
    public class Q12
    {
        public static void PrintEvenNumbers()
        {
            Console.Write($"[NÚMEROS PARES DE 1 A 50]");
            for (int i = 1; i < 51; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine();
                    Console.Write($"{i}");
                }
            }
        }
    }

    // Encontra o maior número
    public class Q13
    {
        public static void FindLargestNumber(int a, int b, int c)
        {
            var bigger = Math.Max(a, Math.Max(b, c));
            Console.Write($"O maior número é: {bigger}");
        }
    }

    // Inverte uma string
    public class Q14
    {
        public static void InvertString(string s)
        {
            char[] cArray = s.ToCharArray();
            Array.Reverse(cArray);
            string invertedString = new string(cArray);
            Console.Write($"String invertida: {invertedString}");
        }
    }

    // Verifica se uma pessoa pode votar ou não
    public class Q15
    {
        public static void CheckVotingEligibility(int day, int month, int year)
        {
            if (year < 2007 || (year == 2007 && month < 11))
            {
                Console.Write($"Nascido em: {year} - Apto para votar");
            }
            else
            {
                Console.Write($"Nascido em: {year} - Inapto para votar");
            }
        }
    }

    // Verifica se um número é positivo ou negativo
    public class Q16
    {
        public static void CheckNumberSign(double numb)
        {
            if (numb < 0)
            {
                Console.Write($"[{numb}] -> negativo");
            }
            else
            {
                Console.Write($"[{numb}] -> positivo");
            }
        }
    }

    // Calcula a média ponderada
    public class Q17
    {
        public static void EvaluateAverage(int sco1, int sco2, int sco3)
        {
            int media = (sco1 + sco2 + sco3) / 3;
            if (media < 7)
            {
                Console.Write($"Média final: {media} -> reprovado");
            }
            else
            {
                Console.Write($"Média final: {media} -> aprovado");
            }
        }
    }

    // Conta as letras 'a' em uma string
    public class Q18
    {
        public static void CountLetterA(string s)
        {
            int count = 0;

            foreach (char c in s.ToLower())
            {
                if (c == 'a')
                {
                    count++;
                }
            }
            Console.Write($"A palavra '{s}' possui {count} letras 'a'");
        }
    }

    // Imprime uma contagem regressiva
    public class Q19
    {
        public static void PrintCountdown()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.Clear();
                Console.Write(i);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.Write("Contagem Regressiva finalizada! Pressione qualquer tecla para continuar...");
        }
    }

    // Calcula a soma dos quadrados de 1 a N
    public class Q20
    {
        public static void SumOfSquares(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i * i;
            }
            Console.Write($"Soma dos quadrados de 1 até {N} = {sum}");
        }
    }

    // Imprime uma mensagem de boas-vindas a uma pessoa
    public class Q21
    {
        public static void WelcomeUser(string name, int age)
        {
            Console.Write($"Seja bem-vindo(a), {name} de {age} anos!");
        }
    }

    // Imprime o dobro e o triplo de um número
    public class Q22
    {
        public static void ShowDoubleAndTriple(int numb)
        {
            double doub = numb * 2;
            double triple = numb * 3;
            Console.Write($"{numb} -> dobro: {doub} // triplo: {triple}");
        }
    }

    public class Q23
    {
        public static void ShowLastCharacter(string s)
        {
            var last = s[s.Length - 1];
            Console.Write($"Último caractere de '{s}' é '{last}'");
        }
    }

    // Converte horas em segundos
    public class Q24
    {
        public static void ConvertHoursToSeconds(int hours)
        {
            int converter = hours * 3600;
            Console.Write($"{hours} horas são {converter} segundos");
        }
    }

    // Verifica se um número é divisível por 3 e 5
    public class Q25
    {
        public static void CheckDivisibility(int numb)
        {
            if (numb % 3 == 0 && numb % 5 == 0)
            {
                Console.Write($"{numb} é divisível por 3 e 5!");
            }
            else
            {
                Console.Write($"{numb} NÃO é divisível por 3 e 5!");
            }
        }
    }
}