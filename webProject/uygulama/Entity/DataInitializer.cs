using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Runtime.Versioning;


namespace uygulama.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            List<KategoriBilgileri> Kategoriler = new List<KategoriBilgileri>
            {
            new KategoriBilgileri() { KategoriID = 10, KategoriIsmi = "TEKNOLOJİ" },
            new KategoriBilgileri() { KategoriID = 20, KategoriIsmi = "EV ALETİ" },
            new KategoriBilgileri() { KategoriID = 30, KategoriIsmi = "OTOMOBİL/ARAÇ" },
            new KategoriBilgileri() { KategoriID = 40, KategoriIsmi = "ARAZİ/TARLA" },
            new KategoriBilgileri() { KategoriID = 50, KategoriIsmi = "FABRİKA" },


            };
            foreach (var kategori in Kategoriler)
            {
                context.kategoriBilgileris.Add(kategori);
            }
            context.SaveChanges();

            List<IhaleBilgileri> İhaleler = new List<IhaleBilgileri>
            {


                new IhaleBilgileri() {IhaleID=1,IhaleUrunIsmi="Kamera",IhaleDurum="iptal edilmiş",IhaleBaslangicT=2021,IhaleBitisT=2022,KategoriID=10,OnaylananTeklifID=100,BaslangicFiyat=510,Image="cam.jpg",IhaleDetayBilgi="Toplam çözünürlük: 24.7 megapixel Efektif fotoğraf çözünürlüğü: 24.3 megapixel Efektif Fotoğraf Çözünürlüğü: 24.3 megapixel "},
                new IhaleBilgileri() {IhaleID=2,IhaleUrunIsmi="Mikser",IhaleDurum="Aktif",IhaleBaslangicT=2021,IhaleBitisT=2022,KategoriID=20,OnaylananTeklifID=200,BaslangicFiyat=324,Image="mikser.jpg",IhaleDetayBilgi="Ürün Tipi: Mikser Maksimum güç: 300 W Güç seviyesi: 5 Kablo tutucusu: Kablo yedeği Ek parçalar: Mikser"},
                new IhaleBilgileri() {IhaleID=3,IhaleUrunIsmi="Kamyon",IhaleDurum="Aktif ",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=30,OnaylananTeklifID=300,BaslangicFiyat=400,Image="kamyon.jpg", IhaleDetayBilgi = "2020 MODEL BOYASIZ DEĞİŞENSİZ H100 BRANDALI"},
                new IhaleBilgileri() {IhaleID=4,IhaleUrunIsmi="Arazi",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=40,OnaylananTeklifID=400,BaslangicFiyat=324,Image="arazi.jpg" , IhaleDetayBilgi = "DEMIRLER KÖY ALTI ARAZI 3.5 dm"},
                new IhaleBilgileri() {IhaleID=5,IhaleUrunIsmi="Gıda Fabrikası",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=50,OnaylananTeklifID=500,BaslangicFiyat=834,Image="gıda.jpg", IhaleDetayBilgi = "İSTANBUL ÇAĞLAYAN'da GIDA FABRİKASI"},
                  new IhaleBilgileri() {IhaleID=6,IhaleUrunIsmi="İlaç Fabrikası",IhaleDurum="iptal edilmiş",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=50,OnaylananTeklifID=100,BaslangicFiyat=510,Image="ilac.jpg", IhaleDetayBilgi = "ŞİRKET İLE BİRLİKTE  KOMPLE İLAÇ FABRİKASI"},
                new IhaleBilgileri() {IhaleID=7,IhaleUrunIsmi="Mısır Tarlası",IhaleDurum="Tamamlanmış",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=40,OnaylananTeklifID=200,BaslangicFiyat=324,Image="mısır.jpg", IhaleDetayBilgi = "ANA YOLA CEPHE MISIR TARLASI "},
                new IhaleBilgileri() {IhaleID=8,IhaleUrunIsmi="Elektrikli Süpürge",IhaleDurum="Aktif ",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=20,OnaylananTeklifID=300,BaslangicFiyat=400,Image="süpürge.jpg", IhaleDetayBilgi = "Arnica Tesla Premium Rose Elektrikli Süpürge"},
                new IhaleBilgileri() {IhaleID=9,IhaleUrunIsmi="Tır",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=30,OnaylananTeklifID=400,BaslangicFiyat=324,Image="tır.jpg", IhaleDetayBilgi = "2015 MODEL VOLVO 460 KLİMALI DEPLİ BUZDOLABI ÇEKİCİ"},
                new IhaleBilgileri() {IhaleID=10,IhaleUrunIsmi="Buğday Tarlası",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=40,OnaylananTeklifID=500,BaslangicFiyat=834,Image="bugday.jpg",IhaleDetayBilgi="Ç.KALE LAPSEKİ UMURBEY İĞDELİK YOLU ÜZERİ BUĞDAY TARLASI"},

                new IhaleBilgileri() {IhaleID=11,IhaleUrunIsmi="Laptop",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=10,OnaylananTeklifID=100,BaslangicFiyat=510,Image="laptop.jpg",IhaleDetayBilgi="Toplam çözünürlük: 24.7 megapixel Efektif fotoğraf çözünürlüğü: 24.3 megapixel Efektif Fotoğraf Çözünürlüğü: 24.3 megapixel"},
                new IhaleBilgileri() {IhaleID=12,IhaleUrunIsmi="Tablet",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=10,OnaylananTeklifID=200,BaslangicFiyat=324,Image="tablet.jpg",IhaleDetayBilgi="Ürün Tipi: Mikser Maksimum güç: 300 W Güç seviyesi: 5 Kablo tutucusu: Kablo yedeği Ek parçalar: Mikser"},
                new IhaleBilgileri() {IhaleID=13,IhaleUrunIsmi="Araba",IhaleDurum="Aktif ",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=30,OnaylananTeklifID=300,BaslangicFiyat=400,Image="araba.png", IhaleDetayBilgi = "2020 MODEL BOYASIZ DEĞİŞENSİZ H100 BRANDALI"},
                new IhaleBilgileri() {IhaleID=14,IhaleUrunIsmi="Arsa",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=40,OnaylananTeklifID=400,BaslangicFiyat=324,Image="arsa.jpg" , IhaleDetayBilgi = "DEMIRLER KÖY ALTI ARAZI 3.5 dm"},
                new IhaleBilgileri() {IhaleID=15,IhaleUrunIsmi="Tütün Fabrikası",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=50,OnaylananTeklifID=500,BaslangicFiyat=834,Image="tütün.jpg", IhaleDetayBilgi = "İSTANBUL ÇAĞLAYAN'da GIDA FABRİKASI"},
                  new IhaleBilgileri() {IhaleID=16,IhaleUrunIsmi="Tekstil Fabrikası",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=50,OnaylananTeklifID=100,BaslangicFiyat=510,Image="tekstil.jpg", IhaleDetayBilgi = "ŞİRKET İLE BİRLİKTE  KOMPLE İLAÇ FABRİKASI"},
                new IhaleBilgileri() {IhaleID=17,IhaleUrunIsmi="Domates Tarlası",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=40,OnaylananTeklifID=200,BaslangicFiyat=1000,Image="domates.jpeg", IhaleDetayBilgi = "ANA YOLA CEPHE MISIR TARLASI "},
                new IhaleBilgileri() {IhaleID=18,IhaleUrunIsmi="Çamaşır Makinesi",IhaleDurum="Aktif ",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=20,OnaylananTeklifID=300,BaslangicFiyat=400,Image="camasır.jpg", IhaleDetayBilgi = "Arnica Tesla Premium Rose Elektrikli Süpürge"},
                new IhaleBilgileri() {IhaleID=19,IhaleUrunIsmi="Motorsiklet",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=30,OnaylananTeklifID=400,BaslangicFiyat=324,Image="motor.png", IhaleDetayBilgi = "2015 MODEL VOLVO 460 KLİMALI DEPLİ BUZDOLABI ÇEKİCİ"},
                new IhaleBilgileri() {IhaleID=20,IhaleUrunIsmi="Telefon",IhaleDurum="Aktif",IhaleBaslangicT=(10/12/21),IhaleBitisT=(15/12/21),KategoriID=10,OnaylananTeklifID=500,BaslangicFiyat=834,Image="tel.jpg",IhaleDetayBilgi="Ç.KALE LAPSEKİ UMURBEY İĞDELİK YOLU ÜZERİ BUĞDAY TARLASI"},
            };
            foreach (var ihale in İhaleler)
            {
                context.ıhaleBilgileris.Add(ihale);
            }
            context.SaveChanges();
           
            List<TeklifBilgileri> Teklifler = new List<TeklifBilgileri>
            {
                new TeklifBilgileri(){  KullanıcıID=15 ,IhaleID=1,TeklifID=3,Teklif=344},
                new TeklifBilgileri(){  KullanıcıID=25 ,IhaleID=2,TeklifID=6,Teklif=344},
                new TeklifBilgileri(){  KullanıcıID=35 ,IhaleID=3,TeklifID=9,Teklif=344},
                new TeklifBilgileri(){  KullanıcıID=45 ,IhaleID=4,TeklifID=12,Teklif=344},
            };
            foreach (var teklif in Teklifler)
            {
                context.teklifBilgileris.Add(teklif);
            }
            context.SaveChanges();

            List<KabulEdilenTeklifBilgi> kabuledilenteklifler = new List<KabulEdilenTeklifBilgi>
            {
                new KabulEdilenTeklifBilgi(){OnaylananTeklifID=1000,TeklifID=3},
                new KabulEdilenTeklifBilgi(){OnaylananTeklifID=2000,TeklifID=6},
                new KabulEdilenTeklifBilgi(){OnaylananTeklifID=3000,TeklifID=9},
                new KabulEdilenTeklifBilgi(){OnaylananTeklifID=4000,TeklifID=12},
            };
            foreach (var kabuledilenteklif in kabuledilenteklifler)
            {
                context.kabulEdilenTeklifBilgis.Add(kabuledilenteklif);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}