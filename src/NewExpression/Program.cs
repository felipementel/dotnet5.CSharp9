using System;

namespace NewExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var cidade = new Cidade(1, 2323, new DateTime(1923, 12, 31), false);

            Cidade cidade2 = new (
                id: 1,
                qtdBares: 2323,
                fundacao: new DateTime(1923, 12, 31),
                temPraia: false);

            Cidade cidade3 = new()
            {
                Id = 1,
                //QtdBares = 2323,
                Fundacao = new DateTime(1923, 12, 31),
                TemPraia = false
            };

            //ternario

            Cidade cidade4 = new();
            cidade4.SetQtdBar(4);

            //cidade4.QtdBares = 3213;
            //cidade4.Id = 123;

            //Shared Base - Nao entrou na versao do C# 9
            //Carro carro = null;

            //Moto moto = new();

            //Automovel auto = carro ?? moto;

            //Automovel auto1 = carro;

            //Automovel auto2 = moto;
        }
    }

    public class Cidade
    {
        public Cidade()
        {

        }

        public Cidade(int id, int qtdBares, DateTime fundacao, bool temPraia)
        {
            Id = id;
            QtdBares = qtdBares;
            Fundacao = fundacao;
            TemPraia = temPraia;
        }

        public int Id { get; init; }

        public int QtdBares { get; private set; }

        public DateTime Fundacao { get; set; }

        public bool TemPraia { get; set; }

        public void SetQtdBar(int valor) =>
            QtdBares = valor;
    }

    public class Automovel { }

    public class Carro : Automovel { }

    public class Moto : Automovel { }
}
