using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Microsoft.VisualBasic;

namespace HardQuests
{
    // Implementa um algoritmo de advinhação de número
    public class Q76
    {
        public static void GuessNumber()
        {
            Console.Write("Advinhe o número (entre 1 e 100): ");
            int guess = 0;
            Random random = new();
            int number = random.Next(1, 101);

            while (guess != number)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (guess > number)
                {
                    if (guess - 30 > number)
                    {
                        Console.Clear();
                        Console.Write("O palpite é muito alto. Tente novamente: ");
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("O palpite é alto. Tente novamente: ");
                    }
                }

                if (guess < number)
                {
                    if (guess + 30 < number)
                    {
                        Console.Clear();
                        Console.Write("O palpite é muito baixo. Tente novamente: ");
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("O palpite é baixo. Tente novamente: ");
                    }
                }
            }

            Console.WriteLine($"Parabéns! O número era {number}!");
        }
    }

    // Implementa um algoritmo para verificar se dois arrays possuem os mesmos valores
    public class Q77
    {
        public static void SameNumbersArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length != nums2.Length)
            {
                Console.WriteLine("Os arrays possuem tamanhos diferentes!");
                return;
            }

            Array.Sort(nums1);
            Array.Sort(nums2);

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] != nums2[i])
                {
                    Console.WriteLine("Os arrays possuem valores diferentes!");
                    return;
                }
            }

            Console.WriteLine("Os arrays possuem valores iguais!");
        }
    }

    // Implementa um algoritmo para manipular uma fila de pessoas
    public class Q78
    {
        public static List<string> queue = new();

        public static void QueueService()
        {
            queue.Add("Joãozinho");
            queue.Add("Maria");
            queue.Add("Lila");
        }

        public static string Dequeue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("A fila está vazia.");
                return null;
            }

            string firstInLine = queue[0];
            queue.RemoveAt(0);
            return firstInLine;
        }
    }

    // Implementa um algoritmo para jogar pedra, papel e tesoura com a máquina
    public class Q79
    {
        public static void RockPaperScissors()
        {
            Random random = new();
            int computerChoice = random.Next(1, 4);
            Console.WriteLine("Pedra, Papel ou Tesoura?");
            Console.WriteLine("(1) Pedra | (2) Papel | (3) Tesoura");
            Console.Write("Escolha: ");
            int playerChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int result = (playerChoice - computerChoice + 3) % 3;

            if (result == 0)
            {
                Console.Write("Empate.");
                return;
            }
            if (result == 1)
            {
                Console.Write("Jogador ganhou.");
                return;
            }

                Console.Write("Computador ganhou.");
        }
    }

    // Implementa um algoritmo para somar todos os digitos de um número
    public class Q80
    {
        public static void GetInput()
        {
            Console.Write("Digite o número: ");
            string input = Console.ReadLine();

            SumOfDigits(input);
        }

        public static void SumOfDigits(string input)
        {
            int sum = 0;

            foreach (char digit in input)
            {
                if (char.IsDigit(digit))
                {
                    sum += (digit - '0');
                }
            }

            Console.Clear();
            Console.Write($"A soma dos digitos de {input} é: {sum}");
        }
    }

    // Implementa um algoritmo para imprimir os números pares de 0 a 20
    public class Q81
    {
        public static List<int> nums = new();

        public static void AddNums()
        {
            for (int i = 0; i < 21; i++)
            {
                nums.Add(i);
            }
        }

        public static void PrintEvenNums()
        {
            List<string> evenNums = new();

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    evenNums.Add(num.ToString());
                }
            }

            Console.WriteLine($"Os números pares de 0 a 20 são: {string.Join(", ", evenNums)}");
        }
    }

    // Implementa um algoritmo para calcular a média dos números digitados e retorna ela e o maior número
    public class Q82
    {
        List<int> Nums = new();
        public void GetInput()
        {
            bool Continue = true;

            while (Continue)
            {
                Console.Clear();
                Console.Write("Digite um número inteiro (0 para parar): ");

                if (int.TryParse(Console.ReadLine(), out int num) && num != 0)
                {
                    Nums.Add(num);
                } else
                {
                    Continue = false;
                    Console.Clear();
                }
            }
        }

        public double CalcAverage()
        {
            double sum = Nums.Sum();
            double average = sum / Nums.Count;
            return average;
        }

        public int GetBiggest()
        {
            int biggest = Nums.Max();
            return biggest;
        }

        public static void ShowResults()
        {
            Q82 obj = new();
            obj.GetInput();

            double average = obj.CalcAverage();
            int biggest = obj.GetBiggest();

            Console.WriteLine($"A média dos números digitados é: {average}");
            Console.Write($"O maior número digitado foi: {biggest}");
        }
    }

    // Implementa um algoritmo para ordenar uma lista de nomes
    public class Q83
    {
        List<string> Names = new();
        public void GetNames()
        {
            Names.Add("Joaquim");
            Names.Add("Icaro");
            Names.Add("Lara");
            Names.Add("Witallo");
            Names.Add("Carlos");
            Names.Add("Larissa");
            Names.Add("Gabriel");
            Names.Add("Cristiane");
            Names.Add("Leticia");
            Names.Add("Lila");
        }

        public void OrderNames()
        {
            Names.Sort();
        }

        public static void ShowNames()
        {
            Q83 obj = new();
            obj.GetNames();
            obj.OrderNames();

            Console.WriteLine($"Nomes em ordem alfabética: {string.Join(", ", obj.Names)}");
        }
    }

    // Implementa um algoritmo para verificar se uma frase é um palíndromo
    public class Q84
    {
        public static void Palindrome()
        {
            Console.Write("Digite uma frase: ");
            string toprint = Console.ReadLine();
            string tocheck = toprint.ToLower();
            tocheck = tocheck.Replace(" ", "");
            string reverse = new string(tocheck.Reverse().ToArray());
            Console.Clear();

            string print = (tocheck == reverse) ? "é um palíndromo!" : "não é um palíndromo!";
            Console.Write($"'{toprint}' {print}");
        }
    }

    // Implementa um algoritmo para gerar 10 números aleatórios e mostrar o maior e o menor
    public class Q85
    {
        List<int> Nums = new();

        public void GenerateNums()
        {
            Random random = new();
            for (int i = 0; i < 10; i++)
            {
                Nums.Add(random.Next(2, 50));
            }
        }

        public static void ShowResults()
        {
            Q85 obj = new();
            obj.GenerateNums();

            Console.Write($"biggest número gerado: {obj.Nums.Max()}\nMenor número gerado: {obj.Nums.Min()}");
        }
    }

    // Simula operações de depósito e saque em uma conta bancária
    public class ContaBancaria // Q86
    {
        public string NumConta { get; private set; }
        public string NomeTitular { get; private set; }
        private decimal saldo;

        public ContaBancaria(string numConta, string nomeTitular, decimal saldoInicial)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
            saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso.");
                ExibirSaldo();
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso.");
                ExibirSaldo();
            }
            else
            {
                Console.WriteLine("Saque não efetuado. Saldo insuficiente ou valor inválido.");
            }
        }

        public void ExibirSaldo()
        {
            Console.Write($"Saldo atual: R$ {saldo:F2}");
        }

        public void ExibirMenu()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Sacar");
                Console.WriteLine("3. Exibir Saldo");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Digite o valor para depósito: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito))
                            {
                                Depositar(valorDeposito);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Valor inválido!");
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.Write("Digite o valor para saque: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque))
                            {
                                Sacar(valorSaque);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Valor inválido!");
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            Console.Clear();
                            ExibirSaldo();
                            Console.ReadKey();
                            break;
                        case 0:
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.Write("Opção inválida. Tente novamente.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número.");
                }

            } while (opcao != 0);
        }
    }

    // Calcula o salário líquido de um funcionário
    public class Funcionario // Q87
    {
        public string Nome { get; private set; }
        public decimal SalarioBruto { get; private set; }

        public Funcionario(string nome, decimal salarioBruto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
        }

        public decimal CalcularSalarioLiquido()
        {
            decimal desconto = SalarioBruto * 0.10m;
            return SalarioBruto - desconto;
        }

        public void ExibirSalarioLiquido()
        {
            Console.Write($"Salário Líquido de {Nome}: R$ {CalcularSalarioLiquido():F2}");
        }
    }

    // Converte um número decimal para binário
    public class Q88
    {
        public static void DecimalToBinary()
        {
            Console.Write("Digite um número em decimal: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write($"O número {num} em binário é: {Convert.ToString(num, 2)}");
        }
    }

    // Calcula a média de um conjunto de 3 notas
    public class Q89
    {
        public static void AverageGrades()
        {
            int[] Grade = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.Write($"Digite a {i + 1}º nota: ");
                Grade[i] = Convert.ToInt32(Console.ReadLine());
            }

            var average = Grade.Average();
            Console.Clear();
            Console.Write($"A média do aluno é: {average:F2}");
        }
    }

    // Soma os elementos de uma matriz 2x2
    public class Q90
    {
        public static void SumElementsMatrix()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            int sum = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum += matrix[i, j];
                }
            }

            Console.Write($"A soma dos elementos da matriz é: {sum}");
        }
    }

    // Decide o vencedor de uma eleição de uma cidade qualquer com 3 candidatos
    public class Q91
    {
        public static void Election(string CandidatoA, string CandidatoB, string CandidatoC)
        {
            Random random = new();

            int votosCandidatoA = random.Next(100, 2001);
            int votosCandidatoB = random.Next(100, 2001);
            int votosCandidatoC = random.Next(100, 2001);

            if (votosCandidatoA > votosCandidatoB && votosCandidatoA > votosCandidatoC)
            {
                Console.Write($"{CandidatoA} venceu com {votosCandidatoA} votos");
            }
            else if (votosCandidatoB > votosCandidatoA && votosCandidatoB > votosCandidatoC)
            {
                Console.Write($"{CandidatoB} venceu com {votosCandidatoB} votos");
            }
            else if (votosCandidatoC > votosCandidatoA && votosCandidatoC > votosCandidatoB)
            {
                Console.Write($"{CandidatoC} venceu com {votosCandidatoC} votos");
            }
            else
            {
                Console.Write("Empate. Um segundo turno será realizado.");
            }
        }
    }

    // Verifica se um número é múltiplo de 3 e 7 ao mesmo tempo
    public class Q92
    {
        public static void GetInput()
        {
            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Q92 q92 = new Q92();
            q92.MultiplesOf3And7(num);
        }
        public void MultiplesOf3And7(int num)
        {
            if (num % 21 == 0)
            {
                Console.Write($"{num} é múltiplo de 3 e 7");
            }
            else
            {
                Console.Write($"{num} não é múltiplo de 3 e 7");
            }
        }
    }

    // Calcula a distância entre dois pontos no plano cartesiano
    public class Q93
    {
        public static void GetInput()
        {
            Console.Write($"Digite as coordenadas do primeiro ponto: ");
            string[] input = Console.ReadLine().Split(' ');
            double x1 = double.Parse(input[0]);
            double y1 = double.Parse(input[1]);

            Console.Clear();

            Console.Write($"Digite as coordenadas do segundo ponto: ");
            input = Console.ReadLine().Split(' ');
            double x2 = double.Parse(input[0]);
            double y2 = double.Parse(input[1]);

            Console.Clear();

            Console.Write($"A distância entre os pontos ({x1}, {y1}) e ({x2}, {y2}) é: {CalcularDistancia(x1, y1, x2, y2):F2}");
        }

        private static double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }

    // Gera números aleatórios e os ordena de forma crescente
    public class Q94
    {
        public static void GenerateNums(int qty)
        {
            List<int> Nums = new();
            Random random = new();

            for (int i = 0; i < qty; i++)
            {
                Nums.Add(random.Next(1, 101));
            }

            Nums.Sort();

            Console.Write($"Os números gerados em ordem crescente: {string.Join(", ", Nums)}");
        }
    }

    // Simula uma agenda de contatos, permitindo adicionar e listar os contatos
    public class AgendaContatos // Q95
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }

        public AgendaContatos(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public static void Menu()
        {
            List<AgendaContatos> agenda = new();
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("--- Agenda de Contatos ---");
                Console.WriteLine("1. Adicionar Contato");
                Console.WriteLine("2. Listar Contatos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        AddContact(agenda);
                        break;
                    case 2:
                        Console.Clear();
                        ListContacts(agenda);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 0);
        }

        public static void AddContact(List<AgendaContatos> agenda)
        {
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine();

            Console.Clear();

            Console.Write("Digite o número de telefone: ");
            string telefone = Console.ReadLine();

            Console.Clear();

            AgendaContatos contato = new AgendaContatos(nome, telefone);
            agenda.Add(contato);

            Console.Clear();
            Console.Write("Contato adicionado com sucesso!");
            Console.ReadKey();
        }

        public static void ListContacts(List<AgendaContatos> agenda)
        {
            if (agenda.Count == 0)
            {
                Console.Write("Nenhum contato na agenda.");
            }
            else
            {
                Console.WriteLine("--- Lista de Contatos ---");
                foreach (var contato in agenda)
                {
                    Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}");
                }
            }
            Console.ReadKey();
        }
    }

    // Encontra os números primos entre 1 e 100
    public class Q96
    {
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int d = 2; d*d < num; d++)
            {
                if (num % d == 0)
                    return false;
            }
            return true;
        }

        public static void GetPrimes()
        {
            List<int> PrimeNums = new();

            for (int i = 2; i < 100; i++)
            {
                if (IsPrime(i))
                {
                    PrimeNums.Add(i);
                }
            }

            Console.Write($"Os números primos entre 1 e 100 são: {string.Join(", ", PrimeNums)}");
        }
    }

    // Exibe a tabuada de um número até 10
    public class Q97
    {
        public static void MultiTable()
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }

    // Encontra o maior número na matriz
    public class Q98
    {
        public static void FindBiggest(int[,] matrix)
        {
            int biggest = matrix.Cast<int>().Max();

            Console.Write($"O maior número na matriz é: {biggest}");
        }
    }

    // Encontra a soma dos quadrados de 1 a um número
    public class Q99
    {
        public static int GetInput(){

            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();

            return num;
        }

        public static void PrintSquares1toN(int num)
        {
            var sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i * i;
            }

            Console.Write($"A soma dos quadrados de 1 a {num} é: {sum}");
        }
    }

    // Simula o jogo da forca, permitindo ao jogador tentar adivinhar uma palavra sem alcançar 5 tentativas falhas
    public class Q100
    {
        public static void Menu()
        {
            var word = "ABELHA";
            int tries = 5;
            List<char> FoundChars = new List<char>();
            List<char> TriedChars = new List<char>();

            Console.WriteLine("Bem-vindo ao jogo da Forca!");
            Console.WriteLine($"A palavra da vez possui {word.Length} letras.");
            Console.Write("Você tem 5 tentativas para adivinhar as letras da palavra. Boa Sorte!");
            Console.ReadKey();

            do
            {
                Console.Clear();
                ShowWord(word, FoundChars);
                Console.WriteLine($"Tentativas restantes: {tries}");
                Console.Write("Digite uma letra: ");

                string input = Console.ReadLine();
                char guess;

                if (string.IsNullOrEmpty(input))
                {
                    Console.Write("Digite uma letra válida.");
                    Console.ReadKey();
                    continue;
                }

                guess = input[0];

                if (TriedChars.Contains(guess))
                {
                    Console.Clear();
                    Console.Write("Essa letra já foi testada. Tente outra.");
                    Console.ReadKey();
                    continue;
                }

                TriedChars.Add(guess);

                if (word.Contains(guess))
                {
                    FoundChars.Add(guess);
                    Console.Clear();
                    Console.Write("Você acertou uma letra!");
                    Console.ReadKey();
                } else
                {
                    tries--;
                    Console.Clear();
                    Console.WriteLine($"Letra incorreta! Você perdeu uma tentativa.");
                    Console.ReadKey();
                }

                if (IsWordComplete(word, FoundChars))
                {
                    Console.Clear();
                    ShowWord(word, FoundChars);
                    Console.WriteLine($"Parabéns! Você adivinhou a palavra com {tries} tentativas restantes.");
                    return;
                }

            } while (tries > 0);

            Console.Clear();
            Console.WriteLine($"Suas tentativas acabaram. A palavra era: {word}");
            Console.Write($"Boa sorte na proxima!");
        }

        static void ShowWord(string word, List<char> FoundChars)
        {
            foreach (char letter in word)
            {
                if (FoundChars.Contains(letter))
                    Console.Write(letter + " ");
                else
                    Console.Write("_ ");
            }
            Console.WriteLine();
        }

        static bool IsWordComplete(string word, List<char> FoundChars)
        {
            foreach (char letter in word)
            {
                if (!FoundChars.Contains(letter))
                    return false;
            }
            return true;
        }
    }
}