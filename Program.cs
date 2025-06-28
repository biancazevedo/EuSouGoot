string resposta = " Eu sou Groot";
string pergunta = "";


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@"Groot Chatbot");
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Opa, eu sou a Bianca esse é meu amigo Groot, fala com ele");
Console.WriteLine("qunado você enjoar dele é so dizer tchau");
Console.ResetColor();
Console.WriteLine();

while (pergunta != "TCHAU")
{
    Console.Write("Pergunta:   "); pergunta = Console.ReadLine()!.ToUpper();
    if (pergunta != "tchau")
    {
    Console.WriteLine($"     Resposta: {resposta}.");}

    else if (pergunta == "tchau")
    {
        Console.WriteLine($"     Resposta:{resposta}!");
    }
}