Console.WriteLine("--- Esperto Contra Sabido ---");
Console.Write("Quantos alimentos serão distribuídos? ");
int resultado = Convert.ToInt32(Console.ReadLine());

if (resultado <= 0) return;

Console.WriteLine();

int restantes = resultado;
int picapau = 0, sabido = 0;

int pravc = 0, pramim = 0;
while (restantes > 0)
{
    pravc++;
    picapau += 1;
    restantes -= 1;

    Console.Write($"{picapau} para você. ");

    pramim = 0;
    while (restantes > 0 && pramim < pravc)
    {
        pramim++;
        sabido += 1;
        restantes -= 1;

        Console.Write($"{pramim}");

        if (restantes > 0 && pramim < pravc)
        {
            Console.Write(",");
        }

        Console.Write(" ");
    }

    if (pramim > 0)
    {
        Console.WriteLine("para mim.");
    }
}

if (pramim == 0)
{
    Console.WriteLine();
}

Console.WriteLine($"Pica-pau recebeu {picapau} alimento(s).");
Console.WriteLine($"sabido recebeu {sabido} alimento(s).");