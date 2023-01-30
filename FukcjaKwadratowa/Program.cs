//deklarujemy a, b i c
float a, b, c;

a = 3; 
b = 2;
c = -3;

float delta = b*b - 4 * a * c;

Console.WriteLine("Delta wynosi: " + delta);

if(delta > 0)
{
    //jeżeli delta jest > 0 to wykona się ten kawałek kodu
    Console.WriteLine("Delta jest większa od zera");
    //double bo sqrt zwraca double
    double x1 = ((-1)*b - Math.Sqrt(delta) ) / (2 * a);
    double x2 = ( b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("Miejsca zerowe wynoszą: x1: " + x1 + " x2: " + x2);
} 
else if (delta == 0)
{
    //ten kawałek kodu wykona się tylko jeśli delta = 0
    Console.WriteLine("Delta jest równa zero");
    double x = ( (-1) * b ) / (2 * a);
    Console.WriteLine("Miejsce zerowe wynosi: " + x);
} 
else
{
    //ostatni przypadek - delta < 0
    Console.WriteLine("Delta jest mniejsza od zera - brak miejsc zerowych");
}