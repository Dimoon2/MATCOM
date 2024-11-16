public class Program
{
    static void Main(string[] args)
    {
       //Ex 1.Reciba como entrada una cadena de caracteres.Luego muestre en la terminal
       // ese mismo sting pero con terminacion "medio limon".
       Console.WriteLine("Write any word");
       string word = Console.ReadLine();
       Console.WriteLine(word + " medio limon");


        //Ex 2. (reciba un numero entero y muestre su doble)
        System.Console.WriteLine("Write a number");
        int num = int.Parse(Console.ReadLine());
        num*=2;
        Console.WriteLine("It`s double is " + num );


        // Ex 3. (Reciba dos numeros enteros de la consola y determine cual de los dos 
        // es mayor sin utilizar Math.Max y Math.Min)
        Console.WriteLine("Write a number");
        int value1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Write another");
        int value2 = int.Parse(Console.ReadLine());
        
        if (value1>value2)
        {
            System.Console.WriteLine(value1 + " is bigger");
        }
         else
        {
         System.Console.WriteLine(value2 + " is bigger");
        }


       //Ex 4. Reciba tres numeros enteros.Muestre en la consola el de valor medio y
       // el promedio de estos
       Console.WriteLine("Write a number");
        int x = int.Parse(Console.ReadLine());
       Console.WriteLine("Write another");
        int y = int.Parse(Console.ReadLine());
       Console.WriteLine("Write another");
        int z = int.Parse(Console.ReadLine());

        int Max = Math.Max(x, y);
        int Max1 = Math.Max( Max, z);
        int Min = Math.Min(x, y);
        int Min1 =  Math.Min(Min, z);
        int Mid = x + y + z - Max1 - Min1;

       Console.WriteLine("The middle number is " + Mid);


       //Ex 5. Reciba un string y un entero (x) menor que el total de caracteres del string.
       //Muestre en la consola el caracter que ocupa la posicion x en el string.

       Console.WriteLine("Please write any word");
       string palabra = Console.ReadLine();
       Console.WriteLine("Now write an integer not bigger that the total of characters of your  word");
       int numero = int.Parse(Console.ReadLine());
       
       char position = palabra[numero];
       Console.WriteLine("The character in the position " + numero + " is " + position);
    }
}
        