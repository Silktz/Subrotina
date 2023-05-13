// Made by Silktz 

DizerOi(nomeUSER);
Saudar(nomeUSER); 
Console.WriteLine("HAHAHA");
DizerTchau(nomeUSER);

void DizerOi(string nomeUSER)
{
    Console.WriteLine($"Oi {nomeUSER}!");
}

void Saudar(string nomeUSER)
{
    Console.WriteLine($"Booom Diaaa {nomeUSER}!");
}

void DizerTchau(string nomeUSER)
{
    Console.Write($"Tchau! {nomeUSER}!");
    }

Console.WriteLine("");
int n1 = 10;
int n2 = 5;

int subtracao1,subtracao2;

subtracao1 = n1 - n2;
subtracao2 = n2 - n1; 
ExibirResultado(n1, n2, subtracao1);
ExibirResultado(n2, n1, subtracao2);

void ExibirResultado(int minuendo, int subtraeno, int diferenca)
{
    Console.WriteLine($"{minuendo} - {subtraeno} = {diferenca}");
}
