using System;

class hello { 

    static void Main()
    {
        /*
        string dou = "dougas";
        int idade = 18;
        Console.WriteLine("hello world!");
        Console.WriteLine("my name is " + dou + " i am " + idade + " years old");
        if (dou == "douglas")
        {
            Console.WriteLine("ok");
        }
        else
        {
            Console.WriteLine("fake neeerii");
        };
        --------------------------------------

        const int teste = 0;
        Console.WriteLine(teste);
        Console.ReadLine();

        --------------------------------------

        Console.WriteLine("digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if(idade >= 18)
        {
            Console.WriteLine("ola " + nome + " sua idade é valida");
        }else
        {
            Console.WriteLine("ola " + nome + " sua idade é ivalida");
        }

        --------------------------------------

        Console.WriteLine("quanto é 1+1?: ");
        int resposta = int.Parse(Console.ReadLine());
        const int resposta2 = 2;

        if(resposta == resposta2)
        {
            Console.WriteLine("parabens!");
        }
        else
        {
            Console.WriteLine("errou!");
        }

        --------------------------------------
        */
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

