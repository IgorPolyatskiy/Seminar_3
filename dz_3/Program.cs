Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

for (int i = 1; i <= number; i++)
{
    int result = i * i * i;
    Console.Write(result);
    if (i < number)
    {
        Console.Write(", ");
    }
}
