// See https://aka.ms/new-console-template for more information
Console.WriteLine("Número a ser advinhado!");
string NumAlvo = Console.ReadLine();
Console.WriteLine("Número salvo. Aguarde...");
Console.Clear();

Console.WriteLine($"O número alvo tem {NumAlvo.Length} caracteres. Tente advinhar:");

string NumAdv = Console.ReadLine();


while (NumAlvo != NumAdv) {
int PosCor = 0;
 for (int i=0; i <= (NumAlvo.Length - 1); i++)
    {
        if (NumAdv[i] == NumAlvo[i])
    {
        PosCor++;
    } } 
    Console.WriteLine($"{PosCor} posições corretas. Tente novamente:");
    NumAdv = Console.ReadLine();
}

Console.WriteLine($"Você acertou! O número correto é {NumAlvo}");




