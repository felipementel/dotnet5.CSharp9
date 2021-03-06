using Bogus;
using System;

namespace PropertyPatterns
{
    //Houveram melhorias no C# 9
    class Program
    {
        static void Main(string[] args)
        {
            var faker = new Faker("pt_BR");
            var pessoa = new Pessoa()
            {
                Id = faker.Random.Number(1, 100),
                Idade = faker.Random.Number(22, 87),
                Nome = faker.Name.FirstName()
            };

            if (pessoa.Id > 20 && pessoa.Nome.StartsWith("B"))
                Console.WriteLine($"{pessoa.Id} - {pessoa.Nome}");

            if (pessoa is {Id: > 20, Nome: "João", Idade: < 60 }) // <-- melhoria
                Console.WriteLine($"{pessoa.Id} - {pessoa.Nome}");
        }
    }

    public class Pessoa
    {
        public int Id { get; set; }

        public int Idade { get; set; }

        public string Nome { get; set; }
    }
}
