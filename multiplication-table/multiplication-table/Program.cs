Console.WriteLine("Tabla de multiplicar");
Console.Write("Ingrese el numero a multiplicar: ");
var input = Console.ReadLine();

if (float.TryParse(input, out float factor))
{
    Console.Write("Ingrese hasta que número multiplicar: ");
    var input2 = Console.ReadLine();

    if (float.TryParse(input2, out float multiplo))
    {
        Console.WriteLine($"Tabla de multiplicar de: {factor}");
        for (int i = 0; i <= multiplo; i++)
        {
            Console.WriteLine($"{factor} x {i} = {factor * i}");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida.");
    }
}
else
{
    Console.WriteLine("Entrada no válida.");
}