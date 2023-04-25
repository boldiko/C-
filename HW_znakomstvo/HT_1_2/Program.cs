int a, b, c;

Console.WriteLine("Введите три числа : ");

a = Convert.ToInt32(Console.ReadLine());

b = Convert.ToInt32(Console.ReadLine());

c = Convert.ToInt32(Console.ReadLine());

if (a>b && a>c)
{
    Console.WriteLine(a);
}
else 
 if (b>c)
 {
    Console.WriteLine(b);
 }
 else 
 {
    Console.WriteLine(c);
 }