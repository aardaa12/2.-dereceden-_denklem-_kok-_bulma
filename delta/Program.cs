double a, b, c;
Console.WriteLine(" Birinci değeri girin: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci değeri girin: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Üçüncü değeri girin: ");
c = Convert.ToInt32(Console.ReadLine());
double delta = b * b - 4 * a * c; ;
double x1;
double x2;
if (delta > 0)
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine($"KÖK1: {+x1}");
    Console.WriteLine($"KÖK2: {+x2}");

}
else if (delta == 0){
    double x= (-b / (2 * a));
    Console.WriteLine( $"KÖK: {x}");

}
else if (delta < 0) Console.WriteLine("Gerçek kök yoktur");
else Console.WriteLine("Düzgün deger giriniz");




