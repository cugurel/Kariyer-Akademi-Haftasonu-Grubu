Console.WriteLine("Birinci sayıyı giriniz: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int multiplication = number1 * number2;

int mod = multiplication % 2;

if((number1 > 0 || number2 > 0) && mod == 1) {
    Console.WriteLine("Çarpım tek sayı");
}
else
{
    Console.WriteLine("Çarpım çift sayı");
}
