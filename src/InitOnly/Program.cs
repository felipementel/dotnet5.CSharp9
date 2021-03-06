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

            Cidade cidade1 = new Cidade(id: 12,
                qtdRestaurantes: 12,
                fundacao: DateTime.Now,
                true);

            //cidade.Id = 123;
        }
    }

    public class Cidade
    {
        public Cidade()
        {

        }

        //public Cidade(int id, int qtdRestaurantes, DateTime fundacao, bool temPraia)
        //{
        //    Id = id;
        //    QtdRestaurantes = qtdRestaurantes;
        //    Fundacao = fundacao;
        //    TemPraia = temPraia;
        //}

        //3 - contrutor
        public Cidade(
            int id, 
            int qtdRestaurantes,
            DateTime fundacao, bool temPraia) =>
            (Id, QtdRestaurantes, Fundacao, TemPraia) = (id, qtdRestaurantes, fundacao, temPraia);

        //2 - vai quebrar
        //public void SetQtdBar(int qtdBar) =>
        //    QtdRestaurantes = qtdBar;

        //public void SetFundacao(DateTime dateTime1) =>
        //    Fundacao = dateTime1;

        public int Id { get; init; }

        public int QtdRestaurantes { get; init; } // 1 - init

        public DateTime Fundacao { get; init; }

        public bool TemPraia { get; init; }
    }

    //4
    public class Bairro
    {
        //mais proximo de imutabilidade - só pode ser instanciado no construtor
        //muito usado para Interfaces e DI
        //Nao conseguimos inicializar fora do construtor - via construtor vazio nao conseguimos

        //Para expor publicamente, precisamos de uma propriedade publica
        //Podem ser incializados com initOnlyProperties
        private readonly string _rua; 

        public string Rua
        {
            get { return _rua; }
            init { _rua = value; }
        }

        //public string Rua2
        //{
        //    get => _rua;
        //    init => _rua = value;
        //}
    }
}