int magicNumber = 4;

Console.WriteLine("Угадай число!");
Console.WriteLine();
Console.WriteLine("Загадо число от 1 до 5. Попробуйте его угадать!");
Console.WriteLine();
Console.Write("Введите ваше число: ");

int input = Convert.ToInt32(Console.ReadLine());

if (input == magicNumber)

    Console.WriteLine($"Да! Это число {magicNumber}!");

else
    Console.WriteLine($"Нет! Это не {input}!");
    