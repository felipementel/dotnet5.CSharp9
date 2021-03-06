using System;
using System.Linq;

namespace LogicalPatterns
{
    /// <summary>
    /// Ligical Patterns
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var horas = new int[]
                {
                    3, 4, 8, 1, 10, 5, 43, 65, 743
                };

            horas
                .ToList()
                .ForEach(itemHora =>
                {
                    Console.WriteLine($"{itemHora} = { AnalisarHorasTrabalhadas(itemHora)}");
                });


            var result = AnalisarPermissao("123", "", "");

            Console.WriteLine(result.ToString());
        }

        public static string AnalisarHorasTrabalhadas1(int horas)
        {
            if (horas < 8)
                return $"vc esta me devendo {horas - 8} horas";
            else if (horas == 8)
                return "Sem horas extras";
            else if ((horas > 8) && (horas <= 10))
                return $"Adicionado 2 horas ao banco de horas do dia {DateTime.Now.ToShortDateString()}";
            else
                return "+ 2 horas no banco e esse mes vc ta com dinheiro pra pagar o meu almoço.";
        }

        public static string AnalisarHorasTrabalhadas(int horas) =>
            horas switch
            {
                < 8 => $"vc esta me devendo {horas - 8} horas",
                8 => "Sem horas extras",
                > 8 and <= 10 => $"Adicionado 2 horas ao banco de horas do dia {DateTime.Now.ToShortDateString()}",
                _ => "+ 2 horas no banco e esse mes vc ta com dinheiro pra pagar o meu almoço."
            };

        //Descartes


        public static bool AnalisarPermissao(string ApiKey, string ClientId, string Token) =>
            (ApiKey, ClientId, Token) switch
            {
                ("123", _, _) => true,
                (_, "123", _) => true,
                (_, _, "123") => true, 
                _ => false
            };
    }
}
