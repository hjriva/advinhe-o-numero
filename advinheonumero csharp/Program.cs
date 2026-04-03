// See https://aka.ms/new-console-template for more information
Console.WriteLine("Número a ser advinhado!");
string NumAlvo = Console.ReadLine();
while (!int.TryParse(NumAlvo, out int num)) {
    if (NumAlvo.ToLower() == "sair") {
    Console.WriteLine("SAINDO...");
    break;
    } else {

        Console.WriteLine($"Precisamos de um número! Por favor, tente de novo");
        NumAlvo = Console.ReadLine();
        }
    };
if (NumAlvo.ToLower() != "sair") {
Console.WriteLine("Número salvo. Aguarde...");
Console.Clear();

Console.WriteLine($"O número alvo tem {NumAlvo.Length} caracteres. Tente advinhar:");

string NumAdv = Console.ReadLine();



while (NumAlvo != NumAdv) {
   if (!int.TryParse(NumAdv, out int num))
    {
            if (NumAdv.ToLower() == "desisto") {
            Console.WriteLine($"O número correto é {NumAlvo}. Obrigado por tentar!");
            break;
    } else {

        Console.WriteLine($"Precisamos de um número! Por favor, tente de novo");
        NumAdv = Console.ReadLine();
        }
    };

    while (NumAlvo.Length != NumAdv.Length)
    {
        Console.WriteLine($"Precisamos de {NumAlvo.Length} caracteres. Por favor, tente de novo: ");
        NumAdv = Console.ReadLine();
    }

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


if (NumAlvo == NumAdv) {
Console.WriteLine($"Você acertou! O número correto é {NumAlvo}");

}
}