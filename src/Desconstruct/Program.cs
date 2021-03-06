using System;

namespace Desconstruct
{
    //C# 7
    class Program
    {
        static void Main(string[] args)
        {
            //Atribuindo variaveis a propriedades
            var item = new Caminhao(eixos: 3, toneladas: 12.5m);

            var (eixos, toneladas) = item;
            (var eixos1, var toneladas1) = item;
            (int eixos2, decimal toneladas3) = item;

            var (eixo3, _) = item;

            Console.WriteLine($"{eixos} - {toneladas}");

            Console.WriteLine(eixo3);
        }
    }

    /// <summary>
    /// Positional Record
    /// </summary>
    public class Caminhao
    {
        public int Eixos { get; set; }

        public decimal Toneladas { get; set; }

        public Caminhao(int eixos, decimal toneladas) =>
            (Eixos, Toneladas) = (eixos, toneladas);

        //out
        public void Deconstruct(out int eixos, out decimal toneladas) =>
            (eixos, toneladas) = (Eixos, Toneladas);
    }
}
