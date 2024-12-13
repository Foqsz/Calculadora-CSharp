using System;
using Calculadora_CSharp;
using Calculadora_CSharp.Enums;

class Program
{
    static void Main(string[] args)
    {
        var opcaoSoma = Menu();

        Calculadora(opcaoSoma);
    }

    #region Menu
    private static int Menu()
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

        return opcaoSoma;
    }
    #endregion

    #region Calculadora
    private static void Calculadora(int opcaoOperacao)
    {
        bool continuar = true;

        while (continuar)
        {
            switch (opcaoOperacao)
            {
                case 1:
                    {
                        var somarAdicao = new Adicao();

                        var nums = leituraNumeros();

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

                        continuar = ContinuarCalculadora(continuar);

                        break;
                    }

                case 2:
                    {
                        var somarSubtracao = new Subtracao();

                        var nums = leituraNumeros();

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

                        continuar = ContinuarCalculadora(continuar);

                        break;
                    }
                case 3:
                    {
                        var somarMultiplicacao = new Multiplicacao();

                        var nums = leituraNumeros();

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

                        continuar = ContinuarCalculadora(continuar);

                        break;
                    }
                case 4:
                    {
                        var somarDivisao = new Divisao();

                        var nums = leituraNumeros();

                        if (nums.Length == 2 &&
                            int.TryParse(nums[0], out int numeroA) &&
                            int.TryParse(nums[1], out int numeroB))
                        {
                            var result = somarDivisao.SomarDivisao(numeroA, numeroB);
                            ResultadoSoma(numeroA, numeroB, result);
                        }
                        else
                        {
                            Duplicado();
                        }

                        continuar = ContinuarCalculadora(continuar);

                        break;
                    }
                    break;
            }

            if (continuar)
            {
                opcaoOperacao = Menu();
            }
        }
    }

    #endregion

    private static bool ContinuarCalculadora(bool continuar)
    {
        Console.Write("Deseja fazer outra operação? Sim / Não: ");
        string resposta = Console.ReadLine();

        if (resposta.Equals("sim", StringComparison.OrdinalIgnoreCase))
        {
            return true; // continua no loop
        }
        else
        {
            return false; // sai do loop
        }
    }


    #region Leitura dos Numeros
    private static string[] leituraNumeros()
    {
        Console.Write("Digite os números para soma: ");
        string numerosSoma = Console.ReadLine();
        string[] nums = numerosSoma.Split(' ');
        return nums;
    }
    #endregion

    #region String de Resultado
    private static void ResultadoSoma(double numeroA, double numeroB, double result)
    {
        Console.WriteLine($"# Resultado da sua soma dos números {numeroA} e {numeroB}: {result}");
    }
    #endregion

    #region String de Erro 
    private static void Duplicado()
    {
        Console.WriteLine("Entrada inválida. Certifique-se de digitar dois números inteiros.");
    }

    #endregion 
}