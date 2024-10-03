try
{
    //Введите секунды с начала суток
    Console.Write("Введите сколько прошло секунд с начала суток:");
        int seconds = int.Parse(Console.ReadLine());
    //Сколько прошло часов 
    int N = seconds / 3600;
    //Сколько прошло минут
    int M = (seconds % 3600) / 60;
    //Вывод сколько прошло времени
    Console.WriteLine($"Это {N} часов {M} минут");
}
catch
{
    Console.WriteLine("Введите переменные правильно");
}