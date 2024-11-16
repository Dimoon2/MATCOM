public class Program
{
    
static void Main(string[] args)
{

//Ex1. Dado que tienes dos enteros guardados en las variables a y b, realiza el 
//intercambio de las variables.
int a = 4;
int b = 8;
a = b;
b -= 4;
Console.WriteLine($"The value of a is {a} and  {b}");
       
//Ex2.Circunferencias: sean las circunferencias C1 y C2 de radio r. Lea de la consola el
//radio r y calcule el area sombreada.
System.Console.WriteLine("Escriba el radio de la circunferencia");
double r = double.Parse(Console.ReadLine());
double pi= Math.PI;
       
double Area(double n)
{
double Area = 2 * pi * n * n / 3 - Math.Sqrt(3) * n * n / 2;

return Area;
}
       
double Ar = Area(r);

Console.WriteLine($"El area sombreada es de {Ar}");


//Ex3. Ecuacion cuadratica: Reciba los coeficientes (numeros reales) de una ecuacion cuadratica
//(asumiendo que tiene solucion) halle sus soluciones. ax^2+ bx + c = 0
Console.WriteLine("Inserte el coeficiente de ax^2");
double ax = double.Parse(Console.ReadLine());

Console.WriteLine("Inserte el coeficiente de bx");
double bx = double.Parse(Console.ReadLine());
 
Console.WriteLine("Inserte el coeficiente de c");
double cx = double.Parse(Console.ReadLine());

double Disc = bx * bx - 4 * ax * cx;

double Solu1 = (- bx + Math.Sqrt(Disc)) / (2 * ax); 
double Solu2 = (- bx - Math.Sqrt(Disc)) / (2 * ax); 

Console.WriteLine($"Las soluciones son x1 = {Solu1} y x2 = {Solu2}");
 

//Ex4. Velocidad de escitura: Lea un texto de la terminal y muestre en la consola la velocidad de escritura del usuario
int start = Environment.TickCount;
    
Console.WriteLine("Escriba una frase");
string f = Console.ReadLine();

int time = Environment.TickCount - start;
Console.WriteLine($"Duracion:{time} ms");


//Ex5. Fecha de nacimiento: Reciba de la consola el numero de identidad de una persona e imprima su fecha
//de nacimiento con el formato day/month/year.
Console.WriteLine("Please write your identity number");
string id = (Console.ReadLine());
char year1 = id[0];
char year2 = id[1];
char month1 = id[2];
char month2 = id[3];
char day1 = id[4];
char day2 = id[5];
Console.WriteLine($"Your date of birth is {day1}{day2}/{month1}{month2}/{year1}{year2}");

//Sin usar string:
Console.WriteLine("Please write your identity number");
long i = long.Parse(Console.ReadLine());

int date = (int)(i / 100000);
int year = date / 10000;
int month = date / 100 % 100;
int day = date % 100;

Console.WriteLine($"Your date of birth is {day}/{month}/{year}");
}
}



