Console.WriteLine("1 a 10");

Console.WriteLine("While");
int numero = 1;
while (numero <= 10)
{
    Console.WriteLine(numero);
    numero++;
}

Console.WriteLine("\r\nFor");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

int soma = 0;
Console.WriteLine("\r\nSoma de 1 a 100");
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
    soma += i;
}

Console.WriteLine(soma);
