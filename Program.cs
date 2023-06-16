const double gravidade = 9.80665;
double velocidade, anguloGraus, anguloRadianos, altura, alcance;

Console.WriteLine("Projétil");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Entre com a velocidade, em m/s: ");
velocidade = Convert.ToDouble
(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Entre com o ângulo, em graus: ");
anguloGraus = Convert.ToDouble 
(Console.ReadLine());
Console.ResetColor();

anguloRadianos = anguloGraus * Math.PI / 360;

altura = Math.Pow(velocidade * 
Math.Sin(anguloRadianos), 2) / (2 * gravidade);
alcance = (Math.Pow(velocidade, 2) *
 Math.Sin(anguloRadianos * 2)) / gravidade;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\nAlcance: {alcance:N2} m");
Console.WriteLine($"Altura máxima: {altura:N2} m");
Console.ResetColor();