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
                Nome = "Felipe"
            };

            var clientClass2 = new ClientClass(id: 1, nome: "Felipe");

            ////////// primeira

            if (clientClass1.Equals(clientClass2))
                Console.WriteLine("Equals True");
            else
                Console.WriteLine("Equals False");

            ////////// segunda
            if (clientClass1 == clientClass2)
                Console.WriteLine("== True");
            else
                Console.WriteLine("== False");

            //Erro
            //ClientClass clientClass99 = clientClass2 with { Nome = "Mario" };

            //////

            var clientRecord1 = new ClientRecord
            {
                Id = 1,
                Nome = "Felipe"
            };

            ClientRecord clienteRecordWith = clientRecord1 with { Nome = "Calors" };
            clienteRecordWith.Nome = ""; // erro de compilacao

            //ClientRecord clientRecord2 = new(id: 1, nome: "Felipe1");


            if (clientRecord1.Equals(clientRecord2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (clientRecord1 == clientRecord2)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");


            //ClientRecord clienteWith = clientRecord1 with { Nome = "Carlos" };

            //clienteWith.Nome = "";




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

        public string Nome { get; init; }
    }
}
