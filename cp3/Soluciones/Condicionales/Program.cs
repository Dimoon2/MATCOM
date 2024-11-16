public class Program
{

static void Main(string[] args)
{
//Ex1. Implemente un programa que reciba dos enteros  y determine si el primero es divisible por el segundo.
Console.WriteLine("Write a number");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write another");
int n2 = int.Parse(Console.ReadLine());

if (n1%n2 == 0)
{
Console.WriteLine("True");
}

else
{
    Console.WriteLine("False");
}


//Ex2. Implemente un programa que le pida al usuario su numero de identidad y determine su sexo (impar:mujer, par:hombre)
Console.WriteLine("Please enter your id number");
string id = Console.ReadLine();
char sex = id[9];

if (sex%2 == 0)
{
    Console.WriteLine("You are a man");
}

else
{
    Console.WriteLine("You are a women");
}


//Ex3. Implemente un programa que reciba un numero entero x de la consola y calcule su valor absoluto sin usar Math.Abs.
Console.WriteLine("Insert a number");
int num = int.Parse(Console.ReadLine());

if (num < 0)
{
    num *= -1;
    Console.WriteLine($"The absolute value of your number is {num}");
}

else
{
    Console.WriteLine($"The absolute value is {num}");
}


//Ex4. Lea tres numeros enteros de la consola que representaran day, monnth, year. Si estos valores pueden formar una fecha, 
//entonces muestrela en la consola con el formato day/month/year.
Console.WriteLine("Inserte un numero");
int d = int.Parse(Console.ReadLine());
Console.WriteLine("Inserte otro");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Inserte otro");
int y = int.Parse(Console.ReadLine());

if ()
{
    
}

}

}