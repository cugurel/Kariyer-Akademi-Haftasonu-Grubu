/*
 C# programlama dilinde tanımlanan erişim belirleyiciler:

Private (Gizli)
Bir değerin private olarak tanımlanması demek, o değişkene sadece kendi class’ı içinden ulaşılabileceği anlamına gelmektedir. Program içinde kesinlikle değiştirilmemesi gereken, kritik kodlarda kullanılmaktadır.
Ayrıca; private, varsayılan erişim belirleyici tipidir. Örneğin; “int deneme = 0;” gibi bir değişken tanımlandığında program tarafından deneme değeri privateolarak algılanmaktadır.

Public (Genel)
Bir değerin public olarak belirtilmesi; o değerin, kod içinde herhangi bir yerden erişilebilir durumda olmasını sağlamaktadır. Public erişim belirleyici tipinde hiç bir kısıtlama yoktur.

Protected (Korunumlu)
Kod içinde bir değerin protected olarak tanımlanması; o değere, bulunduğu class  ve ondan türetilen diğer sınıflar içinden erişilebilir olduğunu göstermektedir. Protected; bir anlamda, public ve private erişim belirleyicilerinin birleşimi olarak görülebilmektedir.

Internal (İçsel)
Internal olarak tanımlanan bir değer; aynı program içerisinden erişilebilir, fakat farklı bir program içerisinden erişilemez durumdadır. Program içerisinde herhangi bir kısıtlaması yoktur.

Protected Internal (İçsel Korunumlu)
Protected internal olarak tanımlanmış değer, tanımlandığı class’ın içinden ve ondan türetilen sınıfların içinden erişilebilir durumdadır. Türetilen sınıfın aynı program içinde olmaması sorun teşkil etmez.
 */

//Console.WriteLine("İlk sayıyı gir: ");
//int number1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("İlk sayıyı gir: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int sum = number + number1;

static void MyMethod()
{
    Console.WriteLine("I just got executed!");
}


MyMethod();

