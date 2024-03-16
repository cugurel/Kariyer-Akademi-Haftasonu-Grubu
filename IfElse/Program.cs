Console.WriteLine("Bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());

//if (number > 0)
//{
//    Console.WriteLine("Girilen sayı pozitif");
//}
//else if (number == 0)
//{
//    Console.WriteLine("Girilen sayı sıfıra eşit");
//}
//else
//{
//    Console.WriteLine("Girilen sayı negatif.");
//}

bool result = number < 0 ? false : true;

if (result)
{
    Console.WriteLine("Sayı Pozitif");
}
else
{
    Console.WriteLine("Sayı negatif");
}