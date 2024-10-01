int dogruSayisi = 0;

Console.WriteLine("Kim Milyoner Olmak İster yarışmasına hoşgeldin!\n3 sorudan 2'sini doğru cevaplarsan 1 Milyon TL'lik büyük ödülü kazanacaksın" +
    "\nBaşlamak için enter'a basın");
ConsoleKeyInfo key = Console.ReadKey();

// 1. Soru
Console.WriteLine("\n1 -> Kızınca tüküren hayvan hangisidir?");
Console.WriteLine("a) Lama  b) Deve");
string cevap1 = Console.ReadLine().ToLower(); // Cevabı alıyoruz ve büyük/küçük harf duyarlılığını kaldırıyoruz.

if (cevap1 == "a")
{
    Console.WriteLine("Doğru cevap! Lama.");
    dogruSayisi++;
}
else
{
    Console.WriteLine("Yanlış cevap. Doğru cevap Lama olacaktı.");
}

// 2. Soru
Console.WriteLine("\n2 -> Dünya'ya en yakın gezegen hangisidir?");
Console.WriteLine("a) Venüs  b) Mars");
string cevap2 = Console.ReadLine().ToLower();

if (cevap2 == "a")
{
    Console.WriteLine("Doğru cevap! Venüs.");
    dogruSayisi++;
}
else
{
    Console.WriteLine("Yanlış cevap. Doğru cevap Venüs olacaktı.");
}

// İlk iki sorunun sonucuna göre 3. soruyu atlıyoruz

if (dogruSayisi == 1) // ilk 2 sorudan sadece 1'ine dogru cevap verdigi durum
{
    Console.WriteLine("\n3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
    Console.WriteLine("a) 7  b) 12");
    string cevap3 = Console.ReadLine().ToLower();

    if (cevap3 == "b")
    {
        Console.WriteLine("Doğru cevap! 12.");
        dogruSayisi++;
    }
    else
    {
        Console.WriteLine("Yanlış cevap. Doğru cevap 12 olacaktı.");
    }

    if (dogruSayisi >= 2) // 3 sorudan 2'sine dogru cevp verdigi durum
    {
        Console.WriteLine("\nTebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
    }
    else // 3 sorudan 2'sine yanlis cevap verdigi durum
    {
        Console.WriteLine("\nMaalesef büyük ödülü kazanamadınız.");
    }

}
else if (dogruSayisi == 2) // ilk 2 soruya dogru cevap verdigi durum 
{
    Console.WriteLine("\nTebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
}
else // ilk 2 soruya da yanlis cevap verdigi durum
{
    Console.WriteLine("\nMaalesef büyük ödülü kazanamadınız.");
}
