using System;
using System.Runtime.Serialization;

public class PrimeiroPrograma
{
    public static void Main(string[] args)
    {
        //variable
        int numero1 = 10;
        int numero2 = 20;

        // logic de programma
        int soma = numero1 + numero2;
        int subtracao = numero1 - numero2;
        int multicacao = numero1 * numero2;
        int divisao = numero1 / numero2;
        int resto = numero1 % numero2;


        //output of programma
        Console.WriteLine("the sum is: " +soma);
        Console.WriteLine("the subtraction is:{0}" , subtracao);
        Console.WriteLine("the product is:{0}", multicacao);
        Console.WriteLine("the division is:{0}", divisao);
        Console.WriteLine("the resto is:{0}", resto);




    }

}