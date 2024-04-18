int x, i;
Console.WriteLine("Digite o valor de x para ver sua tabuada: ");
x = int.Parse(Console.ReadLine());
if (x <= 0)
{
    Console.WriteLine("Digite um valor positivo");
}
else
{
    for (i = 0; i <= 10; i++)
    {
        Console.WriteLine($"{x}x{i} = {x * i}");

    }
}