using BeginnerQuests;
using IntermediateQuests;
using ProficientQuests;
namespace HardQuests;

class Program
{
    static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("         --- Menu ---");
            Console.WriteLine("1. Escolher Questão (1 a 100)");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    EscolherQuestao();
                    break;
                case "0":
                    sair = true;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }

    static void EscolherQuestao()
    {
        bool escolher = true;

        while (escolher)
        {
            Console.Clear();
            Console.Write("Digite o número da questão (1 a 100): ");
            if (int.TryParse(Console.ReadLine(), out int numeroQuestao) && numeroQuestao >= 1 && numeroQuestao <= 100)
            {
                ExecutarQuestao(numeroQuestao);
            }
            else
            {
                escolher = false;
            }
        }
    }

    static void ExecutarQuestao(int numeroQuestao)
    {
        switch (numeroQuestao)
        {
            case 1:
                Console.Clear();
                Produto p1 = new("Notebook Gamer", 3499.00m);
                p1.ExibirProduto();
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                Produto p2 = new("Cadeira Escritório", 1350);
                p2.ExibirProduto();
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                Q3.Sum(10, 5);
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Q4.CheckParity(9);
                Console.ReadKey();
                break;
            case 5:
                Console.Clear();
                Q5.ConvertMetersToCentimeters(12.52);
                Console.ReadKey();
                break;
            case 6:
                Console.Clear();
                Q6.CheckMajority(18);
                Console.ReadKey();
                break;
            case 7:
                Console.Clear();
                Q7.CalculateCircleArea(5);
                Console.ReadKey();
                break;
            case 8:
                Console.Clear();
                Q8.PrintMultiplicationTable(5);
                Console.ReadKey();
                break;
            case 9:
                Console.Clear();
                Q9.PrintSumTable(10);
                Console.ReadKey();
                break;
            case 10:
                Console.Clear();
                Q10.ConvertCelsiusToFahrenheit(30f);
                Console.ReadKey();
                break;
            case 11:
                Console.Clear();
                Q11.CheckStringEmpty("");
                Console.ReadKey();
                break;
            case 12:
                Console.Clear();
                Q12.PrintEvenNumbers();
                Console.ReadKey();
                break;
            case 13:
                Console.Clear();
                Q13.FindLargestNumber(10, 20, 30);
                Console.ReadKey();
                break;
            case 14:
                Console.Clear();
                Q14.InvertString("programacao");
                Console.ReadKey();
                break;
            case 15:
                Console.Clear();
                Q15.CheckVotingEligibility(15, 10, 2005);
                Console.ReadKey();
                break;
            case 16:
                Console.Clear();
                Q16.CheckNumberSign(-10.5);
                Console.ReadKey();
                break;
            case 17:
                Console.Clear();
                Q17.EvaluateAverage(6, 7, 8);
                Console.ReadKey();
                break;
            case 18:
                Console.Clear();
                Q18.CountLetterA("anagrama");
                Console.ReadKey();
                break;
            case 19:
                Console.Clear();
                Q19.PrintCountdown();
                Console.ReadKey();
                break;
            case 20:
                Console.Clear();
                Q20.SumOfSquares(5);
                Console.ReadKey();
                break;
            case 21:
                Console.Clear();
                Q21.WelcomeUser("João", 25);
                Console.ReadKey();
                break;
            case 22:
                Console.Clear();
                Q22.ShowDoubleAndTriple(6);
                Console.ReadKey();
                break;
            case 23:
                Console.Clear();
                Q23.ShowLastCharacter("exemplo");
                Console.ReadKey();
                break;
            case 24:
                Console.Clear();
                Q24.ConvertHoursToSeconds(3);
                Console.ReadKey();
                break;
            case 25:
                Console.Clear();
                Q25.CheckDivisibility(15);
                Console.ReadKey();
                break;
            case 26:
                Console.Clear();
                Q26.OrderNumbers();
                Console.ReadKey();
                break;
            case 27:
                Console.Clear();
                Q27.CalcFatorial();
                Console.ReadKey();
                break;
            case 28:
                Console.Clear();
                Aluno a1 = new("Lila", 3.5, 8.75, 10);
                a1.ExibirAluno();
                Console.ReadKey();
                break;
            case 29:
                Console.Clear();
                Q29.AverageNums(new List<int> { 10, 7, 4, 4, 2 });
                Console.ReadKey();
                break;
            case 30:
                Console.Clear();
                Q30.Palindrome();
                Console.ReadKey();
                break;
            case 31:
                Q31.FindSmallest(new int[] { 5, 2, 9, 1, 7 });
                Console.ReadKey();
                break;
            case 32:
                Q32.MultiplyArrayElements(new int[] { 2, 3, 4 }, 3);
                Console.ReadKey();
                break;
            case 33:
                Q33.SumOfOddNumbers(new int[] { 1, 2, 3, 4, 5 });
                Console.ReadKey();
                break;
            case 34:
                Carro.ShowCarDetails();
                Console.ReadKey();
                break;
            case 35:
                Q35.CheckLeapYear(2024);
                Console.ReadKey();
                break;
            case 36:
                Console.Clear();
                Q36.Fibonacci(10);
                Console.ReadKey();
                break;
            case 37:
                Console.Clear();
                Q37.SwapWhiteSpaces();
                Console.ReadKey();
                break;
            case 38:
                Console.Clear();
                int index = Q38.ReturnIndexBiggest(new int[] { 10, 7, 999, 4, 99, 28 });
                Console.WriteLine($"O índice do maior número é: {index} ({index + 1}° elemento do Array)");
                Console.ReadKey();
                break;
            case 39:
                Console.Clear();
                Q39.MDC();
                Console.ReadKey();
                break;
            case 40:
                Console.Clear();
                Q40.CountVowels();
                Console.ReadKey();
                break;
            case 41:
                Console.Clear();
                Q41.DecimalToBinary();
                Console.ReadKey();
                break;
            case 42:
                Console.Clear();
                Q42.DecimalToChar();
                Console.ReadKey();
                break;
            case 43:
                Console.Clear();
                Q43.ThrowDice(100);
                Console.ReadKey();
                break;
            case 44:
                Console.Clear();
                Q44.IMCCalculator(80, 1.70);
                Console.ReadKey();
                break;
            case 45:
                Console.Clear();
                Q45.SecondBiggest(new int[] { 10, 7, 999, 4, 99, 28 });
                Console.ReadKey();
                break;
            case 46:
                Console.Clear();
                Q46.ReverseArray(new int[] { 10, 7, 999, 4, 99, 28 });
                Console.ReadKey();
                break;
            case 47:
                Console.Clear();
                Q47.SumMatrix2by2(new int[,] { { 1, 2 }, { 3, 4 } }, new int[,] { { 5, 6 }, { 7, 8 } });
                Console.ReadKey();
                break;
            case 48:
                Console.Clear();
                Q48.GetInput();
                Console.ReadKey();
                break;
            case 49:
                Console.Clear();
                Q49.GetInput();
                Console.ReadKey();
                break;
            case 50:
                Console.Clear();
                Q50.ManualPow(2, 3);
                Console.ReadKey();
                break;
            case 51:
                Console.Clear();
                Q51.CheckSymmetricMatrix(new int[,] { { 1, 2, 3 }, { 2, 1, 4 }, { 3, 4, 1 } });
                Console.ReadKey();
                break;
            case 52:
                Console.Clear();
                Q52.SortAlphabetical(new List<string> { "banana", "abacate", "uva" });
                Console.ReadKey();
                break;
            case 53:
                Console.Clear();
                Q53.MostFrequentElement(new int[] { 1, 3, 2, 3, 4, 3 });
                Console.ReadKey();
                break;
            case 54:
                Console.Clear();
                Q54.AbsoluteValue(-3.14);
                Console.ReadKey();
                break;
            case 55:
                Console.Clear();
                Q55.FindElement(new int[] { 1, 2, 3, 4 }, 3);
                Console.ReadKey();
                break;
            case 56:
                Console.Clear();
                Q56.Stopwatch();
                Console.ReadKey();
                break;
            case 57:
                Console.Clear();
                Q57.WordCount("Esta é uma frase de teste");
                Console.ReadKey();
                break;
            case 58:
                Console.Clear();
                Pessoa.DisplayMessage();
                Console.ReadKey();
                break;
            case 59:
                Console.Clear();
                Q59.ArrayIntersection(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 });
                Console.ReadKey();
                break;
            case 60:
                Console.Clear();
                Q60.AlternateCase("texto para teste");
                Console.ReadKey();
                break;
            case 61:
                Console.Clear();
                int uniqueCount = Q61.CountUniqueCharacters("teste");
                Console.Write($"Número de caracteres únicos: {uniqueCount}");
                Console.ReadKey();
                break;
            case 62:
                Console.Clear();
                Q62.ShowPrimes(50);
                Console.ReadKey();
                break;
            case 63:
                Console.Clear();
                bool isPerfect = Q63.IsPerfectNumber(28);
                Console.Write($"28 é um número perfeito? {isPerfect}");
                Console.ReadKey();
                break;
            case 64:
                Console.Clear();
                Q64.ShowDividers(12);
                Console.ReadKey();
                break;
            case 65:
                Console.Clear();
                Q65.TransposeMatrix();
                Console.ReadKey();
                break;
            case 66:
                Console.Clear();
                Q66.SimulateClock();
                break;
            case 67:
                Console.Clear();
                Q67.Calculator();
                break;
            case 68:
                Console.Clear();
                string extenso = Q68.NumeroExtenso(45);
                Console.Write($"45 por extenso: {extenso}");
                Console.ReadKey();
                break;
            case 69:
                Console.Clear();
                Q69.WeightedAverage();
                break;
            case 70:
                Console.Clear();
                Q70.CaixaEletronico();
                break;
            case 71:
                Console.Clear();
                bool arraysEqual = Q71.CompareArrays(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
                Console.Write($"Os arrays são iguais? {arraysEqual}");
                Console.ReadKey();
                break;
            case 72:
                Console.Clear();
                string password = Q72.RandomPassword(10);
                Console.Write($"Senha gerada: '{password}'");
                Console.ReadKey();
                break;
            case 73:
                Console.Clear();
                Q73.MultiplicationTable();
                break;
            case 74:
                Console.Clear();
                double area = Q74.TriangleArea(3, 4, 5);
                Console.Write($"A área do triângulo é: {area}");
                Console.ReadKey();
                break;
            case 75:
                Console.Clear();
                List<int> uniqueNumbers = Q75.NumerosAleatoriosUnicos(10);
                Console.Write("Números aleatórios únicos: " + string.Join(", ", uniqueNumbers));
                Console.ReadKey();
                break;
            case 76:
                Console.Clear();
                Q76.GuessNumber();
                Console.ReadKey();
                break;
            case 77:
                Console.Clear();
                Q77.SameNumbersArrays(new[] { 999, 99, 7, 28, 10, 4 }, new[] { 10, 7, 999, 4, 99, 28 });
                Console.ReadKey();
                break;
            case 78:
                Console.Clear();
                Q78.QueueService();

                for (int i = 0; i < 3; i++)
                {
                    string attendedPerson = Q78.Dequeue();
                    if (attendedPerson != null)
                    {
                        Console.WriteLine($"Atendendo: {attendedPerson}");
                        Console.WriteLine("Pessoas restantes na fila:");
                        foreach (var person in Q78.queue)
                        {
                            Console.WriteLine(person);
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                Console.Write("Todas as pessoas foram atendidas.");
                Console.ReadKey();
                break;
            case 79:
                Console.Clear();
                Q79.RockPaperScissors();
                Console.ReadKey();
                break;
            case 80:
                Console.Clear();
                Q80.GetInput();
                Console.ReadKey();
                break;
            case 81:
                Console.Clear();
                Q81.AddNums();
                Q81.PrintEvenNums();
                Console.ReadKey();
                break;
            case 82:
                Console.Clear();
                Q82.ShowResults();
                Console.ReadKey();
                break;
            case 83:
                Console.Clear();
                Q83.ShowNames();
                Console.ReadKey();
                break;
            case 84:
                Console.Clear();
                Q84.Palindrome();
                Console.ReadKey();
                break;
            case 85:
                Console.Clear();
                Q85.ShowResults();
                Console.ReadKey();
                break;
            case 86:
                Console.Clear();
                ContaBancaria conta1 = new("56789-1", "Lila", 1000);
                conta1.ExibirMenu();
                break;
            case 87:
                Console.Clear();
                Funcionario Lila = new("Lila", 1000);
                Lila.ExibirSalarioLiquido();
                Console.ReadKey();
                break;
            case 88:
                Console.Clear();
                Q88.DecimalToBinary();
                Console.ReadKey();
                break;
            case 89:
                Console.Clear();
                Q89.AverageGrades();
                Console.ReadKey();
                break;
            case 90:
                Console.Clear();
                Q90.SumElementsMatrix();
                Console.ReadKey();
                break;
            case 91:
                Console.Clear();
                Q91.Election("Lila", "Icaro", "Witallo");
                Console.ReadKey();
                break;
            case 92:
                Console.Clear();
                Q92.GetInput();
                Console.ReadKey();
                break;
            case 93:
                Console.Clear();
                Q93.GetInput();
                Console.ReadKey();
                break;
            case 94:
                Console.Clear();
                Q94.GenerateNums(5);
                Console.ReadKey();
                break;
            case 95:
                Console.Clear();
                AgendaContatos.Menu();
                break;
            case 96:
                Console.Clear();
                Q96.GetPrimes();
                Console.ReadKey();
                break;
            case 97:
                Console.Clear();
                Q97.MultiTable();
                Console.ReadKey();
                break;
            case 98:
                Console.Clear();
                int[,] matrix = {
                { 3, 8, 2 },
                { 55, 1, 7 },
                { 4, 6, 9 }
                };
                Q98.FindBiggest(matrix);
                Console.ReadKey();
                break;
            case 99:
                Console.Clear();
                Q99.PrintSquares1toN(Q99.GetInput());
                Console.ReadKey();
                break;
            case 100:
                Console.Clear();
                Q100.Menu();
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Questão ainda não implementada.");
                break;
        }
    }
}