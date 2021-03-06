using System;

namespace Records
{
    class Program
    {
        //Tipos de referencia
        //Conteito de imutabilidade de classe
        static void Main(string[] args)
        {
            //Inicializador da variavel na criação da classe
            var clientClass1 = new ClientClass()
            {
                Id = 1,
                Nome = "Carlos"
            };

            //Construtor
            var clientClass2 = new ClientClass(id: 1, nome: "Felipe");

            if (clientClass1.Equals(clientClass2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            //Erro
            //ClientClass clientClass99 = clientClass2 with { Nome = "Mario" };

            //////

            var clientRecord = new ClientRecord
            {
                Id = 1
            };

            ClientRecord clientRecord1 = new(id: 1, nome: "Felipe");


            ClientRecord clienteWith = clientRecord1 with { Nome = "Carlos" };

            clienteWith.Nome = "";

            if (clientRecord1.Equals(clientRecord))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");


        }
    }

    public class ClientClass
    {
        public ClientClass()
        {
        }

        public ClientClass(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; init; }

        public string Nome { get; init; }
    }

    public record ClientRecord
    {
        public ClientRecord()
        {
        }

        public ClientRecord(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; init; }

        public string Nome { get; set; }
    }
}
