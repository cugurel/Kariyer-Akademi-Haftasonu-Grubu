Console.WriteLine("Bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 0:
        Console.WriteLine("Girilen sayı 0");
        break;
    case 1:
        Console.WriteLine("Girilen sayı 1");
        break ;
    default:
        Console.WriteLine("Girilen sayı geçersiz");
        break;
}