using System;
using System.Collections.Generic;

namespace TragetType
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> field1 = new()
            {
                { "item1", new List<int> { 1, 2, 3 } }
            };

            Dictionary<string, List<int>> field = new()
            {
                { "item1", new() { 1, 2, 3 } }
            };

            (int a, int b) t = new(1, 2);

            Console.WriteLine(t.GetType());

            Action a = new(() => { });

            (int a, int b) t1 = new();


            Atleta atleta = new(3, "Felipe");

            var atletta1 = new List<Atleta>
            {
                new(1, ""),
                new(2, "")
            };

            var numeroDaSorte = 7;

            bool? ganhouSorteio = numeroDaSorte == 3 ? true : null; //(bool?)null;
        }
    }

    public class Atleta
    {
        public int Id { get; init; }

        public string Nome { get; init; }

        public Atleta(int id, string nome) =>
            (Id, Nome) = (id, nome);
    }
}
