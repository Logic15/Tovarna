using Továrna.Tridy;

string input = Tovarna.Menu();
if (input == "1")
{

    Console.WriteLine("Chcete spustit  znovu? y/n");
    string output = Console.ReadLine();
    if (input == "y")
    {
        Console.Clear();
    }

}
if (input == "2")
{
    Auto vytvoreneAuto = new Auto();
    vytvoreneAuto = Tovarna.VytvorAuto();
    Tovarna.VytvorStranku(vytvoreneAuto);

    Console.WriteLine("Chcete zobrazit vámi vytvořené auto: y/n");
    string input2 = Console.ReadLine();
    if (input2 == "y")
    {
        Tovarna.ZobrazStranku("index.html");
    }
}