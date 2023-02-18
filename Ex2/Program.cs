//Ex2
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=1000000 && number<=9999999)
{
    Console.WriteLine("Третья цифра числа с левой стороны: " + number/10000%10);
    Console.WriteLine("Третья цифра числа с правой стороны: " + number/100%10);
}
else
{
  Console.WriteLine("Число не семизначное");  
}

