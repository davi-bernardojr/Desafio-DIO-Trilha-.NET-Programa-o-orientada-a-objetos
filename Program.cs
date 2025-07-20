using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone n = new Nokia("123456", "c99", "125478", 64);
n.Ligar();
n.InstalarAplicativo("Jogos");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone i = new Iphone("123456", "c99", "125478", 64);
i.ReceberLigacao();
i.InstalarAplicativo("Jogos");