using System;

namespace InitOnly
{
    //Conteito de imutabilidade de propriedade
    //ValueObject
    class Program
    {
        static void Main(string[] args)
        {
            Bairro bairro = new Bairro()
            {
                Rua = ""
            };

            Cidade cidade = new Cidade()
            {
                Id = 123
            };

            //cidade.Id = 123;
        }
    }

    public class Cidade
    {
        public Cidade()
        {

        }

        public Cidade(int id, int qtdRestaurantes, DateTime fundacao, bool temPraia)
        {
            Id = id;
            //QtdRestaurantes = qtdRestaurantes;
            Fundacao = fundacao;
            TemPraia = temPraia;
        }

        //3 - contrutor
        //public Cidade(int id, int qtdRestaurantes, DateTime fundacao, bool temPraia) =>      
        //    (Id, QtdRestaurantes, Fundacao, TemPraia) = (id, qtdRestaurantes, fundacao,  temPraia);

        //2 - vai quebrar
        //public void SetQtdBar(int qtdBar) =>
        //    QtdRestaurantes = qtdBar;

        public int Id { get; init; }

        public int QtdRestaurantes { get; init; } // 1 - init

        public DateTime Fundacao { get; init; }

        public bool TemPraia { get; init; }
    }

    //4
    public class Bairro
    {
        private readonly string _rua;

        public string Rua
        {
            get { return _rua; }
            set { _rua = value; }
        }

        //public string Rua2
        //{
        //    get => _rua;
        //    init => _rua = value;
        //}
    }
}