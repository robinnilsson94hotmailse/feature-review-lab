//Frågar efter namnet
Console.WriteLine("Vad heter du?");
//Läser användarens input
string namn = Console.ReadLine();

//Kontrollerar om input är tom elelr bara mellanslag
if (string.IsNullOrWhiteSpace(namn))
{
    Console.WriteLine("Du måste skriva ett namn!");
}
else
{
    //Om namnet är giltigt
    Console.WriteLine($"Välkommen {namn}.");
}