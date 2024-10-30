using System.Globalization;

namespace IntermediateQuests
{
    // Organiza três números em ordem crescente
    public class Q26
    {
        public static void OrderNumbers()
        {
            int[] nums = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.Write($"Digite o {i + 1}º número:");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(nums);

            Console.Write($"Números em ordem: {string.Join(", ", nums)}");
        }
    }

    // Calcula o fatorial de um número
    public class Q27
    {
       public static void CalcFatorial()
       {
            Console.Write("Digite um número para o cálculo do fatorial: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fatorial = 1;

            for (int i = num; i > 0; i--)
            {
                fatorial *= i;
            }

            Console.Clear();
            Console.WriteLine($"O Fatorial de {num} é: {fatorial}");
        }
    }

    // Representa um aluno com notas e exibe suas informações
    public class Aluno // Q28
    {
        public string Nome { get; private set; }
        public double[] Nota { get; private set; }

        public Aluno(string nome, double np1, double tde, double np2)
        {
            Nome = nome;
            Nota = new[] { np1, tde, np2 };
        }

        public void ExibirAluno()
        {
            Console.Write($"Nome: {Nome}\nNP1: {Nota[0]:F2}\nTDE: {Nota[1]:F2}\nNP3: {Nota[2]:F2}");
        }
    }

    // Calcula a média de um conjunto de números
    public class Q29
    {
        public static void AverageNums(List<int> nums)
        {
            double med = nums.Average();
            Console.Write($"A média dos números é: {med}");
        }
    }

    // Verifica se uma palavra é palíndromo
    public class Q30
    {
        public static void Palindrome()
        {
            Console.Write("Digite uma palavra: ");
            string toprint = Console.ReadLine();
            string tocheck = toprint.ToLower();
            string reverse = new string(tocheck.Reverse().ToArray());
            Console.Clear();

            string print = (tocheck == reverse) ? "é um palíndromo!" : "não é um palíndromo!";
            Console.Write($"'{toprint}' {print}");
        }
    }

    // Encontra o menor número de um array
    public class Q31
    {
        public static void FindSmallest(int[] array)
        {
            int smallest = array[0];

            foreach (int number in array)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }

            Console.Clear();
            Console.Write($"O menor número de [{string.Join(", ", array)}] é {smallest}");
        }
    }

    // Multiplica todos os elementos de um array por um número
    public class Q32
    {
        public static void MultiplyArrayElements(int[] array, int multiplier)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i] * multiplier;
            }

            Console.Clear();
            Console.Write($"Array: [{string.Join(", ", array)}]\nArray após multiplicar por {multiplier}: [{string.Join(", ", newArray)}]");
        }
    }

    // Soma os números ímpares de um array
    public class Q33
    {
        public static void SumOfOddNumbers(int[] array)
        {
            int sum = 0;

            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            Console.Clear();
            Console.Write($"Soma dos números ímpares: {sum}");
        }
    }

    // Representa um carro com nome, marca e ano
    public class Carro // Q34
    {
        public string Name { get; }
        public string Label { get; }
        public int Year { get; }

        public Carro(string name, string label, int year)
        {
            Name = name;
            Label = label;
            Year = year;
        }
        public static void ShowCarDetails()
        {
            Carro carro = new Carro("Celtapreto", "Chevrolet", 2004);
            Console.Clear();
            Console.Write($"Carro: {carro.Name} - marca: {carro.Label} - ano: {carro.Year}\n");
        }
    }

    // Verifica se um ano é bissexto
    public class Q35
    {
        public static void CheckLeapYear(int year)
        {
            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            Console.Clear();
            Console.Write($"{year} {(isLeap ? "é" : "não é")} bissexto");
        }
    }

    // Calcula a sequência de Fibonacci até a quantidade informada
    public class Q36
    {
        public static void Fibonacci(int qtd)
        {
            int aux = 1, aux2 = 1, next;

            if (qtd == 0)
            {
                Console.Write("A quantidade de termos deve ser maior que 0.");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            Console.Clear();

            Console.Write($"A sequência de Fibonacci equivalente ao termo {qtd} é: {aux}");

            for (int i = 2; i < qtd + 1; i++) {
                next = aux + aux2;
                aux = aux2;
                aux2 = next;
                Console.Write($", {aux}");
            }
        }
    }

    // Troca os espaços por "_"
    public class Q37
    {
        public static void SwapWhiteSpaces()
        {
            Console.Write("Digite uma frase: ");
            string str = Console.ReadLine();

            str = str.Replace(" ", "_");
            Console.Clear();
            Console.Write($"{str}");
        }
    }

    // Retorna o índice do maior número
    public class Q38
    {
        public static int ReturnIndexBiggest(int[] nums)
        {
            int biggest = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[biggest])
                {
                    biggest = i;
                }
            }

            return biggest;
        }
    }

    // Calcula o MDC de dois números
    public class Q39
    {
        public static void MDC()
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 -= num2;
                }
                else
                {
                    num2 -= num1;
                }
            }

            Console.Write($"MDC: {num1}");
        }
    }

    public class Q40
    {
        public static void CountVowels()
        {
            Console.Write("Digite uma string: ");
            string toshow = Console.ReadLine();
            string tocheck = toshow.ToLower();

            int count = 0;
            foreach (char c in tocheck)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }
            Console.Clear();
            Console.Write($"A string '{toshow}' contém {count} vogais");
        }
    }

    // Converte um número decimal para binário
    public class Q41
    {
        public static void DecimalToBinary()
        {
            Console.Write("Digite um número em decimal: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write($"O número {num} em binário é: {Convert.ToString(num, 2)}");
        }
    }

    // Converte um número decimal para caractere
    public class Q42
    {
        public static void DecimalToChar()
        {
            Console.Write("Digite um número em decimal: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            char letra = (char)('A' + num - 1);
            Console.Write($"O número {num} em caractere é: {letra}");
        }
    }

    // Simula qty lançamentos de dados e conta a frequência de cada lado
    public class Q43
    {
        public static void ThrowDice(int qty)
        {
            Random random = new();
            int num = random.Next(1, 7);

            int[] frequency = new int[6];

            for (int i = 0; i < 1000; i++)
            {
                num = random.Next(1, 7);
                frequency[num - 1]++;
            }

            Console.Clear();
            Console.WriteLine($"Resultados após {qty} lançamentos:");
            for (int i = 0; i < frequency.Length; i++)
            {
                Console.WriteLine();
                Console.Write($"Lado {i + 1}: {frequency[i]} vezes");
            }
        }
    }

    // Calcula o IMC
    public class Q44
    {
        public static void IMCCalculator(double Weight, double Height)
        {
            double imc = Weight / Math.Pow(Height, 2);

            var classifyIMC = new Dictionary<string, (double Min, double Max)>
            {
                { "Abaixo do peso", (0.0, 18.5) },
                { "Peso normal", (18.51, 24.9) },
                { "Sobrepeso", (25.0, 29.9) },
                { "Obesidade Grau I", (30.0, 34.9) },
                { "Obesidade Grau II", (35.0, 39.9) },
                { "Obesidade Grau III", (40.0, double.MaxValue) }
            };

            string classification = "";
            foreach (var item in classifyIMC)
            {
                if (imc >= item.Value.Min && imc <= item.Value.Max)
                {
                    classification = item.Key;
                    break;
                }
            }

            Console.WriteLine($"IMC: {imc:F2}");
            Console.Write($"Classificação: {classification}");
        }
    }

    // Encontra o segundo maior número de um array
    public class Q45
    {
        public static void SecondBiggest(int[] nums)
        {
            int biggest = int.MinValue;
            int second = int.MinValue;

            foreach (int num in nums)
            {
                if (num > biggest)
                {
                    second = biggest;
                    biggest = num;
                }
                else if (num > second && num != biggest)
                {
                    second = num;
                }
            }

            Console.Write($"O segundo maior número é: {second}");
        }
    }

    // Inverte um array
    public class Q46
    {
        public static void ReverseArray(int[] nums)
        {
            int[] Before = (int[])nums.Clone();
            Array.Reverse(nums);

            Console.WriteLine($"Array antes da inversão: {string.Join(", ", Before)}");
            Console.Write($"Array depois da inversão: {string.Join(", ", nums)}");
        }
    }

    // Soma duas matrizes 2x2
    public class Q47
    {
        public static void SumMatrix2by2(int[,] matrixA, int[,] matrixB)
        {
            int[,] result = new int[2, 2];

            if (matrixA.GetLength(0) != 2 || matrixA.GetLength(1) != 2 ||
            matrixB.GetLength(0) != 2 || matrixB.GetLength(1) != 2)
        {
            Console.WriteLine("Ambas as matrizes devem ser 2x2!");
            return;
        }

            for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

            Console.WriteLine("Matriz resultante:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{result[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }

    // Converte uma data em um dia da semana
    public class Q48
    {
        public static void GetInput()
        {
            Console.Write("Digite uma data (formato: dd/MM/yyyy): ");
            string input = Console.ReadLine();
            Console.Clear();

            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime data))
            {
                ShowDayOfWeek(data);
            }
            else
            {
                Console.Write("Data inválida. Por favor, utilize o formato dd/MM/yyyy.");
            }
        }

        public static void ShowDayOfWeek(DateTime date)
        {
            var daysOfWeek = new Dictionary<DayOfWeek, string>
            {
                { DayOfWeek.Sunday, "Domingo" },
                { DayOfWeek.Monday, "Segunda-feira" },
                { DayOfWeek.Tuesday, "Terça-feira" },
                { DayOfWeek.Wednesday, "Quarta-feira" },
                { DayOfWeek.Thursday, "Quinta-feira" },
                { DayOfWeek.Friday, "Sexta-feira" },
                { DayOfWeek.Saturday, "Sábado" }
            };

            string dayInPTBR = daysOfWeek[date.DayOfWeek];

            Console.Write($"Dia da semana: {dayInPTBR}");
        }
    }

    // Verifica se uma string contém apenas letras ou números
    public class Q49
    {
        public static void GetInput()
        {
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();
            Console.Clear();

            var message = OnlyLettersOrNums(input)
            ? "A string contém apenas letras ou números"
            : "A string contém outros tipos de caracteres";

            Console.Write(message);
        }

        public static bool OnlyLettersOrNums(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ')
                {
                    return false;
                }
            }

            return true;
        }
    }

    // Calcula potência de um número
    public class Q50
    {
        public static void ManualPow(int baseNum, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }

            Console.Write($"O resultado de {baseNum}^{exponent} é: {result}");
        }
    }
}