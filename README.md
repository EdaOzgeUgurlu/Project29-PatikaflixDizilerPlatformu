# Project29_PatikaflixDizilerPlatformu

Bu proje, kullanıcıların dizileri bir listeye ekleyebileceği, eklenen dizileri görüntüleyebileceği ve belirli türdeki dizileri filtreleyip sıralayabileceği basit bir konsol uygulamasıdır.

## İçindekiler
- [Proje Hakkında](#proje-hakkında)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)

## Proje Hakkında

Project29_PatikaflixDizilerPlatformu, kullanıcıların dizi adı, yapım yılı, türü, yayın yılı, yönetmen ve ilk yayınlandığı platform gibi bilgileri girerek bir liste oluşturmasını sağlar. Kullanıcı, birden fazla dizi ekleyebilir ve dizi bilgilerini görüntüleyebilir. Ayrıca, komedi türündeki diziler liste olarak filtrelenip sıralanır.

## Kullanılan Teknolojiler

- **C#**: Projenin temel programlama dili.
- **.NET Core Console Application**: Konsol tabanlı bir uygulama olarak geliştirilmiştir.

## Kurulum

1. Bu projeyi bilgisayarınıza klonlayın veya indirin.
   ```bash
   git clone https://github.com/kullaniciadi/Project29_PatikaflixDizilerPlatformu.git
   ```
2. Proje dosyasını bir C# IDE'sinde (Visual Studio veya Visual Studio Code) açın.
3. Projeyi başlatın veya aşağıdaki komutu kullanarak çalıştırın:
   ```bash
   dotnet run
   ```

## Kullanım

1. Program başlatıldığında, kullanıcıdan dizi bilgilerini girmesi istenir.
2. Kullanıcı `E` tuşuna basarak yeni bir dizi ekleyebilir veya `H` tuşuna basarak dizi ekleme işlemini sonlandırabilir.
3. Diziler eklendikten sonra tüm diziler ekrana yazdırılır.
4. Ardından, `Komedi` türündeki diziler filtrelenir ve alfabetik sıraya göre sıralanarak listelenir.

## Kod Açıklamaları

### Bölüm 1: Liste Tanımlama
- Dizi bilgilerini saklamak için `List<Series>` türünde `SeriesList` isimli bir liste tanımlanmıştır.

```csharp
List<Series> SeriesList = new List<Series>();
```

### Bölüm 2: Döngü ve Kontrol Değişkeni
- `yeniEkleme` adında bir `bool` değişken tanımlanarak, kullanıcı yeni bir dizi eklemek istediği sürece döngünün devam etmesi sağlanır.

```csharp
bool yeniEkleme = true;
do { ... } while (yeniEkleme);
```

### Bölüm 3: Kullanıcıdan Dizi Bilgilerini Alma
- Kullanıcıdan `Series` nesnesinin özellikleri olan `Ad`, `YapimYili`, `Tur`, `YayinYili`, `Yonetmen` ve `IlkYayinPlatformu` bilgileri alınır.
- Yapım ve yayın yılı için geçerli bir yıl olup olmadığını kontrol etmek amacıyla `try-catch` yapısı kullanılır.

```csharp
try {
    dizi.YapimYili = Convert.ToInt32(Console.ReadLine());
} catch (Exception) {
    Console.WriteLine("Hata! Lütfen geçerli bir yıl girin: ");
    goto Deneme;
}
```

### Bölüm 4: Dizi Bilgilerini Listeye Ekleme
- Kullanıcıdan alınan `dizi` nesnesi, `SeriesList` listesine eklenir.

```csharp
SeriesList.Add(dizi);
Console.WriteLine("\nBaşarıyla Eklendi.");
```

### Bölüm 5: Yeni Dizi Ekleme veya Çıkış Kontrolü
- Kullanıcı, `E` tuşuna basarak yeni bir dizi eklemeye devam edebilir veya `H` tuşuna basarak dizi eklemeyi sonlandırabilir.

```csharp
ConsoleKeyInfo keyInfo = Console.ReadKey(true);
if (keyInfo.Key == ConsoleKey.E) {
    Console.WriteLine("Yeni bir dizi ekleniyor...");
} else if (keyInfo.Key == ConsoleKey.H) {
    yeniEkleme = false;
    Console.WriteLine("Yeni dizi ekleme işlemi sonlandırıldı.");
}
```

### Bölüm 6: Listeyi Ekrana Yazdırma
- `SeriesList` listesinde yer alan tüm dizi bilgileri `foreach` döngüsü ile ekrana yazdırılır.

```csharp
foreach (var s in SeriesList) {
    Console.WriteLine($"Adı: {s.Ad}, Yılı: {s.YapimYili}, Türü: {s.Tur}, Yayın Yılı: {s.YayinYili}, Yönetmen: {s.Yonetmen}, Platform: {s.IlkYayinPlatformu}");
}
```

### Bölüm 7: Komedi Dizilerini Filtreleme ve Sıralama
- `SeriesList` içinde türü `Komedi` olan diziler, yeni bir listeye eklenir ve alfabetik sıraya göre sıralanır.
- Bu liste, `Ad`, `Tür`, ve `Yönetmen` bilgileri ile ekrana yazdırılır.

```csharp
var komedidizi = SeriesList
    .Where(s => s.Tur.Contains("Komedi"))
    .Select(s => (s.Ad, s.Tur, s.Yonetmen))
    .OrderBy(s => s.Ad)
    .ThenBy(s => s.Yonetmen)
    .ToList();

foreach (var dizis in komedidizi) {
    Console.WriteLine($"Adı: {dizis.Ad}, Türü: {dizis.Tur}, Yönetmen: {dizis.Yonetmen}");
}
```

## Örnek Çıktı

```
Dizi Bilgilerini Giriniz

Dizinin adını girin: Dizi1
Yapım Yılını Girin: 2020
Türünü Giriniz: Komedi
Yayına Başlama Yılını Girin: 2021
Yönetmen Bilgisini Girin: Yönetmen1
Yayınlandığı ilk platformu Girin: Netflix

Başarıyla Eklendi.
Yeni bir dizi eklemek için E, eklemeyi bitirip devam etmek için H tuşuna basın: H

Tüm Liste
Adı: Dizi1, Yılı: 2020, Türü: Komedi, Yayın Yılı: 2021, Yönetmen: Yönetmen1, Platform: Netflix

Komedi Yeni Liste
Adı: Dizi1, Türü: Komedi, Yönetmen: Yönetmen1
```
