int bodrum = 4000;
int marmaris = 3000;
int cesme = 5000;
int karaYolu = 1500;
int havaYolu = 4000;
int paketFiyat = 0;
string lokasyon;
int count = 0;
string secim;
do
{

    do
    {
        Console.Write("Bodrum (Paket başlangıç fiyatı 4000TL)\n"
        + "Marmaris (Paket başlangıç fiyatı 3000TL)\n" +
        "Çeşme (Paket başlangıç fiyatı 5000TL)\n" +
        "Hoşgeldiniz lütfen gitmek istediğiniz lokasyonu seçiniz:");
        lokasyon = Console.ReadLine().ToLower();

        if (lokasyon == "bodrum" || lokasyon == "marmaris" || lokasyon == "çeşme")
        {
            count = 1;
        }
        else
        {
            Console.WriteLine("Yanlış lokasyon seçimi yaptınız. Lütfen geçerli lokasyon seçimi yapınız.");
            count = 0;
        }
    }
    while (count != 1);

    Console.Write("Kaç kişi için tatil planlamak istiyorsunuz:");
    int kisiSayisi = Convert.ToInt32(Console.ReadLine());

    switch (lokasyon)
    {
        case "bodrum":
            Console.WriteLine("Bodrumda gezilecek yerler\nBodrum Kalesi\nBodrum Çarşısı\nBodrum Antik Tiyatrosu\nBodrum Yel Değirmeni");
            paketFiyat = bodrum;
            break;
        case "marmaris":
            Console.WriteLine("Marmariste gezilecek yerler\nAkyaka\nKöyceğiz\nSelimiye\nİçmeler");
            paketFiyat = marmaris;
            break;
        case "çeşme":
            Console.WriteLine("Çeşmede gezilecek yerler\nAlaçatı\nÇeşme Marina\nDelikli Koy\nSakız Adası");
            paketFiyat = cesme;
            break;
    }

    Console.Write("1-Karayolu(Kişi başı ulaşım tutarı gidiş-dönüş 1500TL)" +
        "\n2-Havayolu (Kişi başı ulaşım gidiş-dönüş 4000TL)" +
        "\nHangi ulaşım türünü tercih ediyorsunuz? ");
    int ulasimTercih = Convert.ToInt32(Console.ReadLine());
    while ((ulasimTercih != 1 && ulasimTercih != 2))
    {
        Console.WriteLine("Yanlış tercih yaptınız.Lütfen 1 ve ya 2 numarayı tuşlayınız.");
        Console.Write("1-Karayolu(Kişi başı ulaşım tutarı gidiş-dönüş 1500TL)" +
        "\n2-Havayolu (Kişi başı ulaşım gidiş-dönüş 4000TL)" +
        "\nHangi ulaşım türünü tercih ediyorsunuz? ");
        ulasimTercih = Convert.ToInt32(Console.ReadLine());
    }

    switch (ulasimTercih)
    {
        case 1:
            paketFiyat = paketFiyat + 1500;
            break;
        case 2:
            paketFiyat = paketFiyat + 4000;
            break;
    }
    paketFiyat = paketFiyat * kisiSayisi;

    Console.WriteLine($"{kisiSayisi} kişilik {lokasyon} tatilinizin fiyatı ->" + paketFiyat + "TL'dir");
    Console.Write("Başka bir tatil planmak ister misiniz? (Evet-Hayır)");
    secim = Console.ReadLine().ToLower();
} while (secim == "evet");
Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler ederiz, iyi günler dileriz.");













