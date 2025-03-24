Console.Clear();

//double numero01, numero02, resultado;
//
//Console.WriteLine("Digite os números que você quer!");
//numero01 = Convert.ToDouble(Console.ReadLine());
//numero02 = Convert.ToDouble(Console.ReadLine());
//
//resultado = numero01 / numero02;
//
//Console.WriteLine($"O resultado é: {resultado:N15}");

//pi * r^2

const double valorPiAproximado = 3.1416;
double raio, areaCirculo;

Console.WriteLine("-------Área do Círculo-------");
Console.WriteLine("Digite o raio do seu círculo:");
raio = Convert.ToDouble(Console.ReadLine());

areaCirculo = Math.PI * Math.Pow(raio,2);

Console.WriteLine($"A área do círculo é: {areaCirculo}");

