int a;

Console.WriteLine("Введите исло дня недели: ");

a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
        Console.WriteLine("Это будний день");
        break;
    case 2:
        Console.WriteLine("Это будний день");
        break;
    case 3:
        Console.WriteLine("Это будний день");
        break;
    case 4:
        Console.WriteLine("Это будний день");
        break;
    case 5:
        Console.WriteLine("Это будний день");
        break;
    case 6:
        Console.WriteLine("Выходной. Отдых отдых.");
        break;
    case 7:
        Console.WriteLine("Выходной. Отдых отдых.");
        break;
    default:
        Console.WriteLine("Алё, в неделе семь дней...");
        break;
}