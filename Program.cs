﻿Console.WriteLine("Digite os lados do triângulo desejado");
Console.WriteLine();

decimal lado1 = 0, lado2 = 0, lado3 = 0;
bool valorValido = false;

while (!valorValido)
{
    Console.Write("Lado 1..: ");
    lado1 = Convert.ToDecimal(Console.ReadLine());

    if (lado1 <= 0)
    {
        Console.WriteLine("Digite somente números maiores que 0.");
    }
    else
    {
        valorValido = true;
    }
}

valorValido = false;

while (!valorValido)
{
    Console.Write("Lado 2..: ");
    lado2 = Convert.ToDecimal(Console.ReadLine());

    if (lado2 <= 0)
    {
        Console.WriteLine("Digite somente números maiores que 0.");
    }
    else
    {
        valorValido = true;
    }
}

valorValido = false;

while (!valorValido)
{
    Console.Write("Lado 3..: ");
    lado3 = Convert.ToDecimal(Console.ReadLine());

    if (lado3 <= 0)
    {
        Console.WriteLine("Digite somente números maiores que 0.");
    }
    else
    {
        valorValido = true;
    }
}

decimal semiperimetro = (lado1 + lado2 + lado3) / 2;

decimal resultado =
    semiperimetro *
    (semiperimetro - lado1) *
    (semiperimetro - lado2) *
    (semiperimetro - lado3);

decimal area = (decimal)Math.Sqrt((double)resultado);

Console.WriteLine();
Console.WriteLine($"Semiperímetro...: {semiperimetro}");
Console.WriteLine($"Área............: {area}");