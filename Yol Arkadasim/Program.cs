
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Yol Arkadaşım'a Hoş Geldiniz!");
Console.WriteLine();
Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL)");
Console.WriteLine();
Console.WriteLine("Lütfen yukarıda size sunulan lokasyonlardan gitmek istediğiniz lokasyonun adını giriniz: ");
string bodrum = "bodrum";
string marmaris = "marmaris";
string cesme = "çeşme";
int paketFiyati = 0;

string lokasyon = Console.ReadLine().ToLower();
bool lokasyonGecerli = false;
Console.WriteLine($"Girilen Lokasyon: {lokasyon}");

// Lokasyon seçimini alırken.
if (lokasyon == bodrum)
{
    paketFiyati = 4000;
    lokasyonGecerli = true;
}
else if (lokasyon == marmaris)
{
    paketFiyati = 3000;
    lokasyonGecerli = true;
}
else if (lokasyon == cesme)
{
    paketFiyati = 5000;
    lokasyonGecerli = true;
}

// Hatalı lokasyon girişinde uyarı verir.
if (!lokasyonGecerli)
{
    Console.WriteLine("Geçersiz bir lokasyon seçtiniz. Lütfen Bodrum, Marmaris veya Çeşme arasından seçim yapınız.");
    return;
}

// Kişi sayısını alırken.
Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
int kisiSayisi = int.Parse(Console.ReadLine());
Console.WriteLine($"{kisiSayisi} kişi için tatil planlanacaktır.\nSeçtiğiniz lokasyonda tatil yaparken deniz, güneş ve plaj keyfini çıkarabilirsiniz. Ayrıca antik kentleri gezip, gece hayatını keşfetme fırsatınız da var.");

// Ulaşım tercihini soruyoruz.
Console.WriteLine("\nLütfen tatilinize nasıl gitmek istediğinizi seçiniz, seçiminizi 1 ya da 2 şeklinde giriniz.");
Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

int ulasimTercihi = int.Parse(Console.ReadLine());
int ulasimFiyati = 0;

// Ulaşım fiyatı belirlerken.
if (ulasimTercihi == 1)
{
    ulasimFiyati = 1500;
}
else if (ulasimTercihi == 2)
{
    ulasimFiyati = 4000;
}
else
{
    Console.WriteLine("Geçersiz bir ulaşım tercihi seçtiniz. Lütfen 1 ya da 2 arasında seçim yapınız.");
    return;
}

// Toplam fiyat hesaplama
int toplamFiyat = (paketFiyati + ulasimFiyati) * kisiSayisi;
Console.WriteLine($"\nSeçilen tatilin toplam maliyeti: {toplamFiyat} TL");