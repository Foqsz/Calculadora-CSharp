using System;
using Calculadora_CSharp;
using Calculadora_CSharp.Enums;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Calculadora C# - Feita por Victor Vinicius ##");
        Console.WriteLine("[1] - Adição\n[2] - Subtração\n[3] - Multiplicação\n[4] - Divisão\n[5] - Sair");
        Console.Write("## Qual forma deseja somar?:  ");

        var opcaoSoma = int.Parse(Console.ReadLine());

        if (Enum.IsDefined(typeof(nomesSoma), opcaoSoma))
        {
            var nomeSoma = (nomesSoma)opcaoSoma;
            Console.WriteLine($"Você escolheu: {nomeSoma}");
        }
        else
        {
            Console.WriteLine("Opcção Inválida.");
        }

        switch (opcaoSoma)
        {
            case 1:
                {
                    var somarAdicao = new Adicao();

                    Console.Write("Digite os números para somar (separados por espaço): ");
                    string numerosSoma = Console.ReadLine();
                    string[] nums = numerosSoma.Split(' ');

                    if (nums.Length == 2 &&
                        int.TryParse(nums[0], out int numeroA) &&
                        int.TryParse(nums[1], out int numeroB))
                    {
                        var result = somarAdicao.SomarAdicao(numeroA, numeroB);
                        ResultadoSoma(numeroA, numeroB, result);
                    }
                    else
                    {
                        Duplicado();
                    }

                    break;
                }

            case 2:
                {
                    var somarSubtracao = new Subtracao();

                    Console.Write("Digite os números para soma: ");
                    string numerosSoma = Console.ReadLine();
                    string[] nums = numerosSoma.Split(' ');

                    if (nums.Length == 2 &&
                        int.TryParse(nums[0], out int numeroA) &&
                        int.TryParse(nums[1], out int numeroB))
                    {
                        var result = somarSubtracao.SomarSubtracao(numeroA, numeroB);
                        ResultadoSoma(numeroA, numeroB, result);
                    }
                    else
                    {
                        Duplicado();
                    }

                    break;
                }
            case 3:
                {
                    var somarMultiplicacao = new Multiplicacao();

                    Console.Write("Digite os números para soma: ");
                    string numerosSoma = Console.ReadLine();
                    string[] nums = numerosSoma.Split(' ');

                    if (nums.Length == 2 &&
                        int.TryParse(nums[0], out int numeroA) &&
                        int.TryParse(nums[1], out int numeroB))
                    {
                        var result = somarMultiplicacao.SomarMultiplicacao(numeroA, numeroB);
                        ResultadoSoma(numeroA, numeroB, result);
                    }
                    else
                    {
                        Duplicado();
                    }

                    break;
                }
        }
    }

    private static void ResultadoSoma(double numeroA, double numeroB, double result)
    {
        Console.WriteLine($"# Resultado da sua soma {numeroA} + {numeroB}: {result}");
    }

    private static void Duplicado()
    {
        Console.WriteLine("Entrada inválida. Certifique-se de digitar dois números inteiros.");
    }
}