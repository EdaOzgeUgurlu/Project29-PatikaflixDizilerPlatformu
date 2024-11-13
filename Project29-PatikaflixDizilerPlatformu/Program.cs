using Project29_PatikaflixDizilerPlatformu; // Dizilerin bulunduğu projeye ait Adspace'i içeri aktarıyoruz.
internal class Program
{
    private static void Main(string[] args)
    {
            #region 1.bölüm liste tanımlıyoruz

        // Series sınıfından oluşturulan dizi nesnelerini saklamak için bir liste tanımlıyoruz.
        List<Series> SeriesList = new List<Series>();

        #endregion

            #region 2.bölüm boolen değişken tanımlıyoruz ve yeni dizi ekleme döngüsünü başlatıyoruz

        // Kullanıcının yeni dizi eklemeye devam edip etmeyeceğini kontrol etmek için bir boolean değişken tanımlıyoruz.
        bool yeniEkleme = true;

        // Yeni dizi ekleme döngüsünü başlatıyoruz. Kullanıcı çıkana kadar bu döngü devam edecek.
        do
        {
            // Series sınıfından yeni bir dizi nesnesi oluşturuyoruz.
            Series dizi = new Series();
            // Konsolu temizleyerek kullanıcıdan dizi bilgilerini toplamak için arayüz hazırlıyoruz.
            Console.Clear();

            #endregion

            #region 3.bölüm kullanıcıdan dizi bilgilerini alıyoruz
            Console.WriteLine("Dizi Bilgilerini Giriniz\n\n");

                #region dizi adını alıyoruz
            // Dizinin adını kullanıcıdan alıyoruz.
            Console.Write("Dizinin adını girin: ");
            dizi.Ad = Console.ReadLine(); // Kullanıcının girdiği dizi adını 'Ad' özelliğine atıyoruz.
            #endregion

                #region dizinin yapım yılını alıyoruz
            // Dizinin yapım yılını kullanıcıdan alıyoruz ve hatalı girişlere karşı denetim sağlıyoruz.
            Console.Write("\nYapım Yılını Girin: ");

        // try - catch  ile girilen tarihin int bir değer olup olmadığı kontrol ediliyor ve kullanıcıya tarih değeri girilmesi için uyarı mesajı veriliyor.

        Deneme:
            try
            {
                // Kullanıcının girdiği yıl bilgisini int türüne çevirip Year özelliğine atıyoruz.
                dizi.YapimYili = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception Ex)
            {
                // Kullanıcı yıl dışında bir değer girdiğinde uyarı veriyoruz.
                Console.WriteLine("Hata! Lütfen geçerli bir yıl girin: ");
                goto Deneme; // Hatalı giriş olduğunda kullanıcıdan tekrar giriş yapmasını istiyoruz.
            }

            #endregion

                #region dizi türünü alıyoruz

            // Dizinin türünü kullanıcıdan alıyoruz (Komedi, Drama vb.).
            Console.Write("\nTürünü Giriniz: ");
            dizi.Tur = Console.ReadLine(); // Kullanıcı tarafından girilen tür bilgisini Türü özelliğine atıyoruz.

            #endregion

                #region dizinin yayın yılını alıyoruz
            // Dizinin yayına başlama yılını kullanıcıdan alıyoruz.
            Console.Write("\nYayına Başlama Yılını Girin: ");
            dizi.YayinYili = Convert.ToInt32(Console.ReadLine());
        deneme2:
            try
            {

                // Yayın yılı, yapım yılından daha önce olamaz. Bu durumda kullanıcıdan tekrar giriş yapmasını istiyoruz.
                if (dizi.YayinYili < dizi.YapimYili)
                {
                    Console.WriteLine("Yayın tarihi yapım yılından önce olamaz!"); // Uyarı mesajı veriyoruz.
                    goto deneme2; // Kullanıcı hatalı giriş yaptıysa tekrar yayına başlama yılı soruluyor.
                }
            }
            catch
            {
                // Yayın yılı olarak sayısal olmayan bir değer girildiğinde hata mesajı gösteriliyor.
                Console.WriteLine("Hatalı Giriş!!");
                goto deneme2; // Hatalı giriş yapılırsa tekrar yayına başlama yılı isteniyor.
            }

            #endregion

                #region dizinin yönetmeninin adını alıyoruz
            // Dizinin yönetmenini kullanıcıdan alıyoruz.
            Console.Write("\nYönetmen Bilgisini Girin: ");
            dizi.Yonetmen = Console.ReadLine(); // Kullanıcının girdiği yönetmen adını Director özelliğine atıyoruz.

            #endregion

                #region dizinin ilk yayın platformunu alıyoruz

            // Dizinin ilk yayınlandığı platformu kullanıcıdan alıyoruz
            Console.Write("\nYayınlandığı ilk platformu Girin: ");
            dizi.IlkYayinPlatformu = Console.ReadLine(); // İlk yayın platform bilgisini ilk yayın platform özelliğine atıyoruz.

            #endregion

            #endregion

            #region 4.bölüm dizi bilgilerini listeye ekliyoruz

            // Kullanıcının girdiği dizi bilgilerini listeye ekliyoruz.
            SeriesList.Add(dizi);

            Console.WriteLine("\nBaşarıyla Eklendi.");

            #endregion

            #region 5.bölüm yeni bir dizi eklemek istediği soruyoruz ve koşulu kontrol ediyoruz.

            // Kullanıcıya yeni bir dizi eklemek veya işlemi bitirip devam etmek için E veya H tuşlarına basmalarını istiyoruz.
            Console.WriteLine("Yeni bir dizi eklemek için E, eklemeyi bitirip devam etmek için H tuşuna basın:");

            // Kullanıcının tuşa basmasını bekliyoruz ve `true` parametresi ile basılan tuşun ekranda görünmemesini sağlıyoruz.
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); // true ile tuş basıldığında ekranda görünmez

            if (keyInfo.Key == ConsoleKey.E)
            {
                // "E" tuşuna basılırsa döngü devam edecek ve yeni bir dizi eklenebilecek.
                Console.WriteLine("Yeni bir dizi ekleniyor...");
                // Burada dizi ekleme işlemini gerçekleştirebilirsiniz.
            }
            else if (keyInfo.Key == ConsoleKey.H)
            {
                // "H" tuşuna basılırsa döngü sonlanacak.
                yeniEkleme = false;
                Console.WriteLine("Yeni dizi ekleme işlemi sonlandırıldı.");
            }
            else
            {
                // Kullanıcı geçersiz bir tuşa bastıysa, tekrar geçerli bir giriş yapması isteniyor.
                Console.WriteLine("Geçersiz giriş yaptınız. Lütfen 'E' veya 'H' tuşlarından birine basınız.");
            }

        } while (yeniEkleme); // Kullanıcı H tuşuna basana kadar döngü devam eder.

        // Tüm dizileri listelemek için konsolu temizleyip başlık oluşturuyoruz.
        Console.Clear();

        Console.WriteLine("Tüm Liste");

        #endregion

            #region 6.bölüm nesneleri forech ile ekrana yazdırıyoruz
        // Tüm dizi nesnelerini ekrana yazdırmak için foreach döngüsü kullanılıyor.
        foreach (var s in SeriesList)
        {
            Console.WriteLine($"Adı: {s.Ad}, Yılı: {s.YapimYili} Türü: {s.Tur}, Yayın Yılı: {s.YayinYili} Yönetmen: {s.Yonetmen}, Platform: {s.IlkYayinPlatformu} ");
        }
        #endregion

            #region 7.bölüm yeni liste oluşturuyoruz 

        // Komedi türündeki dizileri filtreleyip yeni bir liste oluşturuyoruz.
        var komedidizi = SeriesList
            .Where(s => s.Tur.Contains("Komedi")) // Dizinin türü "Komedi" ise listeye ekleniyor.
            .Select(s => (s.Ad, s.Tur, s.Yonetmen)) // Yalnızca dizi adı, türü ve yönetmeni seçiliyor.
            .OrderBy(s => s.Ad) // Liste ilk olarak dizi adlarına göre sıralanıyor.
            .ThenBy(s => s.Yonetmen) // Eğer adlar aynıysa yönetmen adına göre sıralanıyor.
            .ToList(); // Sıralanmış elemanlar yeni bir liste olarak saklanıyor.

        // Komedi dizileri listesini ekrana yazdırıyoruz.
        Console.WriteLine("Komedi Yeni Liste");

        // Her komedi dizisini adı, türü ve yönetmeni ile ekrana yazdırıyoruz.
        foreach (var dizis in komedidizi)
        {
            Console.WriteLine($"Adı: {dizis.Ad}, Türü: {dizis.Tur}, Yönetmen: {dizis.Yonetmen} ");
        }
    }
}
#endregion
















