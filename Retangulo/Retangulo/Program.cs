using Retangulo;

Formula ret = new Formula();

Console.WriteLine("Entre com a largura e altura do retangulo:");
ret.largura = double.Parse(Console.ReadLine()); 
ret.altura = double.Parse(Console.ReadLine());

Console.WriteLine("Area: " +ret.Area()) ;
Console.WriteLine("Perimetro: " + ret.Perimetro());
Console.WriteLine("Diagonal: " + ret.Diagonal());
