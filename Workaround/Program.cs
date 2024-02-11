using Business.Concrete;
using Entities.Concrete;

Değişkenler();
//instance oluşturma-> bir sınıfın bir örneğini veya bir nesnesini temsil eder.
Vatandas vatandas1 = new Vatandas();//Bir tane vatandas oluşturdum.

SelamVerParametreli("Engin");
SelamVerParametreli(isim: "Buse");
SelamVerParametreli(isim: "Ayşe");
SelamVerParametreli();

SelamVer();
SelamVer();

Topla();//bu bir hesaplama

int sonuc = Topla();//sonuc değişkenine atıyabiliyorum bankacılık uygulamasında kredi hesaplarken ,kredi aylık ödeme tutarlarını belirlerken bir işlem sonucunda ortaya bir şey çıkıyorsa ve onu daha sonra kullanıcaksam kullanıyorum

int sonuc2 = ToplaParametreli(3, 5);

Diziler();

Person person1 = new Person();
person1.FirstName = "Engin";
person1.NationalIdentity = 123;
person1.LastName = "Demiroğ";
person1.DataOfBirthYear = 1985;

PttManager pttManager=new PttManager(new PersonManager());
pttManager.GiveMask(person1);
//ptt deyken sistem eczaneye döndü.
Console.ReadLine();

static void SelamVerParametreli(string isim = "isimsiz")
{
    //isimsiz->default parametre
    //fonksiyon isminde sonra parantez içerisine yazılan değerler parametre denir o parameterlere göre methodun çalışma yapması sağlanır
    Console.WriteLine("Merhaba " + isim);
}
static int ToplaParametreli(int sayi1, int sayi2)
{
    int sonuc2 = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc2);
    return sonuc2;
}
static void SelamVer()
{
    //uygulamanın içeriisnde bazı yerlerde mesaj çıkarmak istiyorum.veya bilgi vermek istiyorum.projede 10 farklı yerde kullanıyorum
    Console.WriteLine("Merhaba");
    //bu yapı method.
    //void->herhangi birşey döndürmeyecek sadece işi yapıcak.
    //void methodlar sadece işi yapar ve herhangi bilgi vermez
    //emir kipiyle çalışır git bunu kaydet,güncelle,sil.        bir değer oluşturmak istiyorsan değer return eden fonksiyonlardan yararlanırsın. Topla() methodu gibi
    //eğer sadece git şunu yap kaydet sil gücelle void,ama bir hesap yap bir şeyler yap bana değer ver ben onu kullanıcam dediğin zaman return operasyonundan yararlanıyoruz
}
static int Topla()
{
    return 5;
}
static void Değişkenler()
{
    //Bir şey yazmak için kullanılır
    Console.WriteLine("Hello, World!");

    //Değişkenler->Program akışı içinde bir veriyi tutarız
    //"DRY" (Don't Repeat Yourself)  Kendini tekrar etme

    string mesaj = "Merhaba"; //metinsel değişken
    double tutar = 10000; //ondalıklı değişken - db den gelir
    int sayi = 100; //tamsayı
    bool girişYapmışmı = false; //true yada false doğru yada yanlış

    string ad = "Engin";
    string soyad = "Demiroğ";
    int dogumYili = 1985;
    long tcNo = 123456789;//int sınırı -+2 milyar küsür long çok daha büyük 11 sayıyı tutacak kadar veri tipidir.

    //NESNE -CLASS
    //ortalama bir kamu projesinde ortalama 2000 3000 değişken vardır.
    //bu değişkenleri yönetmek çok zor olduğu için mantıksal gruplara ayırıcaz bunlara nesne deniyor.nesne yönelimli programlama denme sebebi o.
    //ben bunu bir kutunun içine koysam kutuya isim versem sonra desemki kutu.ad,kutu.soyad ,kutu.dogumYili,kutu.tcNo yani kısacası bunlara nesne->Class deniyor.
    //bir çok programa dilindede java ,python,c#,javascript ,typescript->class deniyor.

    Console.WriteLine(mesaj);
    Console.WriteLine(mesaj);
    Console.WriteLine("Merhaba");
    Console.WriteLine("Merhaba");

    Console.WriteLine(10000 * 1.18);
    Console.WriteLine(10000 * 1.18);
    Console.WriteLine(tutar * 1.18);
}

static void Diziler()
{
    //Diziler /Arrays
    //Örnek1
    //string array demek içerisine tanımladığımız türde veri tutan yapılardır.

    string[] ogrenciler = new string[3];//1
    ogrenciler[0] = "Engin";//2
    ogrenciler[1] = "Kerem";//3
    ogrenciler[2] = "Berkay";//4

    //sadece Süleyman yazar ilk 3 öğrenci yazmaz neden
    //referans tipler
    //bellekte 2 tane kısım var stack ve heap
    //1 de eşittirin sol tarafında ogrenciler tanımladım ya stack ogrenciler diye bir şey tanımlar newlemesek hata alırız (null reference exception) referans tipi kullanabilmen için heapte yer açman gerekir.
    //new string[3] ->deyince heapte 3 elemanlı yer açtı[Engin,Kerem,Berkay] yazdı ve bu değere adres değeri verdi örnek 101
    //newleyince ogrencilere diyorki sen 101 tutuyorsun.

    ogrenciler = new string[4];//5
                               //5 kod çalışınca new gördüğünde heapte yeni bir alan tanımmlıyor 
                               //4 tane alan tutabilecek şeekilde
    ogrenciler[3] = "Süleyman";//6
                               //[ , , , Süleyman] bunada 102 adresini veriyor
                               //ogrenciler 102 adresini tutuyor o yüzden Süleyman yazıyor
                               //Garbage Collector(çöp toplayıcı) bunları bellekte tutan yok diyip 101 atıyor.
                               //Array,Class,Interface,Abstract->Referans tip bellekte bu şekilde tutuluyor
//Döngüler birbirine benzeyen işleri tekrar tekrar yazmak yerine bir kereede yazmak sürecidir
    for (int i = 0; i < ogrenciler.Length; i++)
    {
        Console.WriteLine(ogrenciler[i]);
    }

    //örnek2
    //stringler referans tip , sayılar (int double float bool)değer tiplerin hepsi stackde
    string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
    string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
    //s1-stack 101-heap [ank,ist,izm]101
    //s2-stack 102-heap [bur,ant,diy]102
    sehirler2 = sehirler1;//değer atamak olarak düşünme
                          //sehirler2 nin referansı sehirler 1 in refaransı demek
                          //s2-stack 101-heap[ank,ist,izm]101 gösteriyor ikise 101 tutuyor
    sehirler1[0] = "Adana";
    //yani 101 referansın 0.değeri Adana oldu
    Console.WriteLine(sehirler2[0]);
    //sehirler2 de 101 referansını tuttuğu için Adana çıkar

    //örnek3
    //stringler referans tip , sayılar (int double float bool)değer tiplerin hepsi stackde
    int sayi1 = 10;
    int sayi2 = 20;
    sayi2 = sayi1; //3  sayi2=10 artık sayi 1 le alaamız kalmıyor
    sayi1 = 30;//3 te sayi2 ye sayi 1 i atadık bitti değeri atadık olay değer seviyesinde
    //sayi2?? ->10

    Person person1=new Person();
    person1.FirstName = "Engin";

    Person person2=new Person();
    person2.FirstName = "Murat";
    //foreach döngüsüyle dizi formatındaki yazpıları dönüyoruz

    foreach (string sehir in sehirler1) 
    {
        Console.WriteLine(sehir);
    }
    //.Net Framwork ile berebar -Generic Collection- denilen yapı geldi
    //array i projelerde çok az kullannıyoruz onun yerine 

    //Mylist
    List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" }; //*1- bu 3  elemanlı bir liste ne demek? adı üstünde bu bir dizi aslında arka planda bu listeyi yöneten bir yapı var,o referansları yöneten bir yapı var.bu referenas tip çünkü sınıf list bir sınıftır.
    yeniSehirler1.Add(item: "Çankırı 1");//*2- artık 4 elemanımı koruyor 
    //4 eleman olucak artık

    foreach (var sehir in yeniSehirler1)
    {
        Console.WriteLine(sehir);
    }
    //*1-de yeni bir liste oluştrudum
    //*2-de yeni listeye yeni eleman ekledim
    //3 4 elemanlı diye oluşturmadım
    //Bunlara Generic Collection deniyor bize çok ciddi imkanlar sunuyor 
    //referans tiipn referans probleminde kurtuluyorum
    //*2-deki Add->arka tarafta sizin yerinize siz newlediğiniz zaman önce eski verileri cebe atıyor newlediğiniz zaman yeniliyor cebe attıklarını yerine koyuyuyor ,yeni elemnanıda sonuna eklliyor.
}

public class Vatandas
{

    //public string ad = "Engin";
    //public string soyad = "Demiroğ";
    //public int dogumYili = 1985;
    //public long tcNo = 123456789;

    //get set-->getter setter
    //biz değişkenleri property dediğimiz yapıyla yönetiyoruz
    //vatdanşın property özelliği
    //prop yazıp tab 'a basıyoruz
    //Değişkenlerin kelimelerin ilk harfi büyük pascal casing deniyor
    //class property methodlarda bu şekilde pascal case kullanıyoruz.
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

    // ileride Ad ve Soyad ile ilgili okuma ve yazmada değişiklikler yapmak istersek
    //public string Ad { get
    //    {
    //bloglarını oluşturup get set özelliklerini değiştirebiliriz.
    //    }; 
    //    set; }
    //günümüzde çok az kullandığımız bir özellik ama ihtiyaç olabilir o yüzden property'leri get ve setlerle yazıyoruz.çok azdeğişkenin get set özelliğini değiştiriz ama standartlara uyup propertyle yazıyoruz.java da property diye bir şey yok get ve set ayrı ayrı yazılması gerekir.

}
