int randomNumber = new Random().Next();

string randomNumberText = Convert.ToString(randomNumber);

if (randomNumberText.Length > 2)
{
    Console.WriteLine(randomNumber);
    Console.WriteLine("Цифра" + randomNumberText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}