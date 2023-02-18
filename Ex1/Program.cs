// Ex1
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=100 && number<=999)
{
    Console.WriteLine("Вторая цифра числа: " + number/10%10);
}
else
{
  Console.WriteLine("Число не трехзначное");  
}
