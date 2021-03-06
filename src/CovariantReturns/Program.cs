using System;

namespace CovariantReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new NegociacaoPF().ObterPessoa();

            Console.WriteLine($"{x.GetType().Name}");
        }
    }

    public class Pessoa
    {
        public int Id { get; set; }
    }

    public class Fisica : Pessoa
    {
        public long CPF { get; set; }
    }

    public class Juridica : Pessoa
    {
        public long CNPJ { get; set; }
    }

    public abstract class Negociacao
    {
        public Guid HashBlockchain { get; set; }

        public abstract Pessoa ObterPessoa();
    }

    public class NegociacaoPF : Negociacao
    {
        public override Fisica ObterPessoa()
        {
            return new Fisica();
        }
    }

    //public class NegociacaoPF : Negociacao
    //{
    //    public override Pessoa ObterPessoa() // Fisica
    //    {
    //        return new Pessoa();
    //    }
    //}
}
