string[] yapiKredi = { "Taşıt Kredisi", "İhtiyaç Kredisi", "Konut Kredisi", "Kobi" };
string[] garanti = { "Taşıt Kredisi"};
string[] akbank = { "Taşıt Kredisi", "İhtiyaç Kredisi"};


Console.WriteLine("Kredi çekmek istediğiniz banka: ");
string bankName = Console.ReadLine();

if (bankName.Contains("yapi"))
{
    foreach (var item in yapiKredi)
    {
        Console.WriteLine(item);
    }
}else if (bankName.Contains("ak"))
{
    foreach (var item in akbank)
    {
        Console.WriteLine(item);
    }
}
else
{
    foreach (var item in garanti)
    {
        Console.WriteLine(item);
    }
}




