var item = System.IO.Directory.GetFiles(@"c:\temp\filesCloud");

for (int i = 0; i < item.Length; i++)
{
    System.Console.WriteLine(item[i].GetHashCode());
}

System.Console.WriteLine($"Data de verificação: {System.DateTime.Now:dd/MM/yyyy}");
System.Environment.Exit(0); //sucesso