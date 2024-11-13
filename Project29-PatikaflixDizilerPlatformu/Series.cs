using Project29_PatikaflixDizilerPlatformu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project29_PatikaflixDizilerPlatformu
{
    // dizis sınıfı, bir dizi platformunda yer alan dizilerin temel özelliklerini tutmak için oluşturulmuştur.
    // Bu sınıf sayesinde dizilerin isimleri, türleri, yayın yılları gibi bilgileri tek bir nesne üzerinden takip edebiliriz.
    internal class Series
    {
        // Dizi adı.
        public string Ad { get; set; }

        // Dizi yayın yılı. 
        public int YapimYili { get; set; }

        // Dizinin türünü tanımlar. 
        public string Tur { get; set; }

        // Dizinin ilk yayınlandığı yılı tutar.
        public int YayinYili { get; set; }

        // Dizinin yönetmenini belirtir.
        public string Yonetmen { get; set; }

        // Dizinin ilk yayınlandığı platformu belirtir. 
        public string IlkYayinPlatformu { get; set; }

    }
}