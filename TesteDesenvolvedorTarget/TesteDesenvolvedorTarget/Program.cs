using Newtonsoft.Json;
using System;
using System.Linq;

namespace TesteDesenvolvedorTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            Questao1();
            Questao2();
            Questao3();
            Questao4();
            Questao5();
        }

        private static void Questao5()
        {
            Console.WriteLine("---- QUESTÃO 5 ----");

            Console.WriteLine("*** INVERSÃO DOS CARACTERES DA STRING ***\n");
            Console.Write("Digite uma string: ");

            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            int i = 0;
            int j = input.Length - 1;

            while (i < j)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                i++;
                j--;
            }

            string reversed = new string(chars);
            Console.WriteLine($"String invertida: {reversed}");
        }

        private static void Questao4()
        {
            Console.WriteLine("---- QUESTÃO 4 ----");

            // Definir faturamento mensal por estado
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            // Calcular o faturamento total
            double total = sp + rj + mg + es + outros;

            // Calcular o percentual de representação de cada estado
            double percSp = (sp / total) * 100;
            double percRj = (rj / total) * 100;
            double percMg = (mg / total) * 100;
            double percEs = (es / total) * 100;
            double percOutros = (outros / total) * 100;

            // Imprimir os resultados
            Console.WriteLine("Percentual de representação por estado:");
            Console.WriteLine("SP: {0:N2}%", percSp);
            Console.WriteLine("RJ: {0:N2}%", percRj);
            Console.WriteLine("MG: {0:N2}%", percMg);
            Console.WriteLine("ES: {0:N2}%", percEs);
            Console.WriteLine("Outros: {0:N2}%", percOutros);
            Console.WriteLine();
        }

        private static void Questao3()
        {
            Console.WriteLine("---- QUESTÃO 3 ----");

            // Lê o arquivo JSON com o vetor de faturamento diário
            string json = @"[
                {""dia"": 1, ""valor"": 22174.1664},
                {""dia"": 2, ""valor"": 24537.6698},
                {""dia"": 3, ""valor"": 26139.6134},
                {""dia"": 4, ""valor"": 0.0},
                {""dia"": 5, ""valor"": 0.0},
                {""dia"": 6, ""valor"": 26742.6612},
                {""dia"": 7, ""valor"": 0.0},
                {""dia"": 8, ""valor"": 42889.2258},
                {""dia"": 9, ""valor"": 46251.174},
                {""dia"": 10, ""valor"": 11191.4722},
                {""dia"": 11, ""valor"": 0.0},
                {""dia"": 12, ""valor"": 0.0},
                {""dia"": 13, ""valor"": 3847.4823},
                {""dia"": 14, ""valor"": 373.7838},
                {""dia"": 15, ""valor"": 2659.7563},
                {""dia"": 16, ""valor"": 48924.2448},
                {""dia"": 17, ""valor"": 18419.2614},
                {""dia"": 18, ""valor"": 0.0},
                {""dia"": 19, ""valor"": 0.0},
                {""dia"": 20, ""valor"": 35240.1826},
                {""dia"": 21, ""valor"": 43829.1667},
                {""dia"": 22, ""valor"": 18235.6852},
                {""dia"": 23, ""valor"": 4355.0662},
                {""dia"": 24, ""valor"": 13327.1025},
                {""dia"": 25, ""valor"": 0.0},
                {""dia"": 26, ""valor"": 0.0},
                {""dia"": 27, ""valor"": 25681.8318},
                {""dia"": 28, ""valor"": 1718.1221},
                {""dia"": 29, ""valor"": 13220.495},
                {""dia"": 30, ""valor"": 8414.61}
            ]";

            // Deserializa o JSON para uma lista de objetos FaturamentoDiario
            var faturamentoMensal = JsonConvert.DeserializeObject<dynamic[]>(json);

            // Calcula o menor valor de faturamento e o maior valor de faturamento
            var menorFaturamento = faturamentoMensal.Min(f => f.valor);
            var maiorFaturamento = faturamentoMensal.Max(f => f.valor);

            // Filtra apenas os dias úteis (que tiveram faturamento)
            var diasUteis = faturamentoMensal.Where(dia => dia.valor > 0);

            // Calcula a média mensal de faturamento
            double mediaMensal = diasUteis.Average(dia => (double)dia.valor);

            // Conta o número de dias em que o faturamento diário foi superior à média mensal
            int diasAcimaDaMedia = diasUteis.Count(dia => dia.valor > mediaMensal);

            Console.WriteLine($"Menor valor de faturamento diário: R${menorFaturamento}");
            Console.WriteLine($"Maior valor de faturamento diário: R${maiorFaturamento}");
            Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
            Console.WriteLine();
        }

        private static void Questao2()
        {
            Console.WriteLine("---- QUESTÃO 2 ----");

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("*** SEQUÊNCIA FIBONACCI ***\n");
                Console.WriteLine("Informe um número: ");
                int n = int.Parse(Console.ReadLine());

                int a = 0, b = 1;

                while (b <= n)
                {
                    if (b == n)
                    {
                        Console.WriteLine($"O número {n} pertence à sequência de Fibonacci.");
                        break;
                    }

                    int fib = a + b;
                    a = b;
                    b = fib;
                }

                if (b > n)
                {
                    Console.WriteLine($"O número {n} não pertence à sequência de Fibonacci.");
                }

                Console.WriteLine("\nDeseja verificar outro número? (S/N)");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta != "S")
                {
                    continuar = false;
                }
            }
            Console.WriteLine();
        }

        private static void Questao1()
        {
            Console.WriteLine("---- QUESTÃO 1 ----");

            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine(SOMA);
            //Variável SOMA será igual a 91
            Console.WriteLine();
        }
    }
}
