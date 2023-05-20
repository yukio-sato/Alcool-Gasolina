void frase(string txt)
{
    for (int i = 0; i < txt.Length; i++)
    {
    Console.Write(txt[i]);
    Thread.Sleep(25); 
    }
}
double calcular(double etan, double gaso)
{
    return etan/gaso;
}
double checker(double etanol, double gasolina)
{
    return calcular(etanol,gasolina);
}
Console.ForegroundColor = ConsoleColor.Cyan;
frase("Qual é o preço do Etanol: ");
Console.ForegroundColor = ConsoleColor.White;
double eta = Convert.ToDouble(Console.ReadLine()!.Trim());
Console.ForegroundColor = ConsoleColor.DarkGreen;
frase("Qual é o preço do Gasolina: ");
Console.ForegroundColor = ConsoleColor.White;
double gas = Convert.ToDouble(Console.ReadLine()!.Trim());
Console.ForegroundColor = ConsoleColor.Blue;
frase($"\n\nA porcentagem de Etanol comparando a Gasolina é de {(checker(eta,gas)*100):N1}%\n\nUtilize ");
if (checker(eta,gas) >= 0.73)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    frase("gasolina.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    frase("etanol.");
}
Console.ResetColor();