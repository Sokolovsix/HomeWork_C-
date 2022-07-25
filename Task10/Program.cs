int randomNumber = new Random ().Next(99,1000);

int result1 = randomNumber % 100;
int result2 = result1 / 10;
Console.Write($"{randomNumber} -> {result2}");
