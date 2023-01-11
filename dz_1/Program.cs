Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int[] numberAsArray = new int[5];

for (int i = 0; i < 5; i++)
{
    numberAsArray[i] = number % 10;
    number = number / 10;
}
if (numberAsArray[0] == numberAsArray[4] && numberAsArray[1] == numberAsArray[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}