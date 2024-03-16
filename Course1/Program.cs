int a, b, toplam;
a = 5;
b = 6;

toplam = a + b;

int mod = toplam % 2;

if (mod == 0)
{
    Console.WriteLine("Toplam: " + toplam + " çift sayıdır.");
}
else
{
    Console.WriteLine("Toplam: " + toplam + " tek sayıdır.");
}