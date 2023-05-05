using System;

class hello { 

    static void Main()
    {
        // calculadora simples

        // pegar numero1
        Console.WriteLine("digite um numero: ");
        double numero1 = double.Parse(Console.ReadLine());
        // identificar a função
        Console.WriteLine("qual funçao você quer fazer? (ex: + , / , -, *): ");
        var func = Console.ReadLine();
        // pegar numero2
        Console.WriteLine("digite outro numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        if (func == "*" || func == "x")
        {
            Console.WriteLine("resultado: " + (numero1 * numero2));
        }else if(func == "+")
        {
            Console.WriteLine("resultado: " + (numero1 + numero2));

        }else if (func == "/" || func == "%")
        {
            Console.WriteLine("resultado: " + (numero1 / numero2));

        }
        else if (func == "-")
        {
            Console.WriteLine("resultado: " + (numero1 - numero2));

        };


        Console.ReadLine();

    }

}

