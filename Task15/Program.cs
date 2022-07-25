Console.Write("Введи число от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Да,выходной");
}
else
{
    Console.WriteLine("Не выходной");
}