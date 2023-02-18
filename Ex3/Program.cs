// Ex3
Console.Write("введите цифру: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day==6 || day==7)
{
    Console.WriteLine("Да, этот день является выходным");
}
else if (day>=1 && day<=6)
{
  Console.WriteLine("Нет, день является рабочим");  
}
else
{
  Console.WriteLine("Цифра не подходит");  
}
