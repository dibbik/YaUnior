bool[] thimble = new bool[3] {false, false, true};

Console.WriteLine("Игра в наперстки");
Console.WriteLine();

Console.WriteLine("Под одним из трёх наперстков находится шарик. Попробуйте угадать в каком!");
Console.WriteLine();

Console.Write("Попробуте угадать в каком!");
Console.WriteLine();

Console.Write("Введите ваше число от 1 до 3: ");

int input = Convert.ToInt32(Console.ReadLine());

bool result = false;

if (input == 1 || input==2)
{
    result = thimble[0];
    Console.WriteLine("нет! не верно");
}
if (input == 3)
{
     result = thimble[2];
    Console.WriteLine("Вы угдали");
}
