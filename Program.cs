int primeiroNumero, segundoNumero, soma;

Console.WriteLine("Calculo da soma entre dois números.\n");
primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo numero");
segundoNumero = Convert.ToInt32(Console.ReadLine());

soma = primeiroNumero + segundoNumero;

Console.WriteLine($"\nSoma: {soma}");


