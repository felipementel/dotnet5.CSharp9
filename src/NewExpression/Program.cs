using System;

namespace NewExpression
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        //Target type - New Expression
        /// <summary>
        /// essa operacao 
        /// </summary>
        /// <param name="args">Argumento da funcao</param>
        static void Main(string[] args)
        {
            var cidade = new Cidade
                (id: 1,
                2323, 
                new DateTime(1923, 12, 31),
                false);

            Cidade cidade1 = new(
                id: 1,
                qtdRestaurantes: 2323,
                fundacao: new DateTime(1923, 12, 31),
                temPraia: false);

            Cidade cidade3 = new()
            {
                Id = 1,
                //QtdRestaurantes = 2323,
                Fundacao = new DateTime(1923, 12, 31),
                TemPraia = false
            };

            //ternario

            Cidade cidade4 = new();
            cidade4.SetQtdRestaurante(4);

            //cidade4.QtdBares = 3213;
            //cidade4.Id = 123;



            //Shared Base - Nao entrou na versao do C# 9 | nâo entrou nessa versao do C# 9
            Carro carro = null;

            Moto moto = new();

            Automovel auto;
            auto = carro ?? moto;

            Automovel auto1 = carro;

            Automovel auto2 = moto;

            if (carro != null)
                auto = carro;
            else
                auto = moto;
        }
    }

    public class Cidade
    {
        public Cidade()
        {
        }

        public Cidade(int id, int qtdRestaurantes, DateTime fundacao, bool temPraia) =>
            (Id,
            QtdRestaurantes,
            Fundacao,
            TemPraia) =
            (id,
            qtdRestaurantes,
            fundacao,
            temPraia);

        public int Id { get; init; }

        public int QtdRestaurantes { get; private set; }

        public DateTime Fundacao { get; set; }

        public bool TemPraia { get; set; }

        //public void SetQtdRestaurante(int valor) =>
        //    QtdRestaurantes = valor;
    }

    public class Automovel { }

    public class Carro : Automovel { }

    public class Moto : Automovel { }
}
