using System;

public class program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Bienvenidos a nuestro primer sistema creado en C#");

        Console.WriteLine("Ingresa tu nombre para continuar");
        string Nombre = Console.ReadLine();//para recibir valores de caracter
        Console.WriteLine("ingrese su edad");
        int Edad = Convert.ToInt32(Console.ReadLine());//convertir a dato tipo double
        double EdadMeses = Edad * 12; // Calculos Matematicos
        Console.WriteLine(Nombre + " Tu edad en Meses es: " + EdadMeses + "Meses");//Concatenacion
        if(Edad > 18)
        {
            Console.WriteLine("Usted es Mayor de edad");
        }
        else
        {
            Console.WriteLine("Usted es Menor de edad");
        }
    
    
    
    
    }




}








