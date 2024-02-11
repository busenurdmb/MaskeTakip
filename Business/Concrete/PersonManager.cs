using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Çıplak class kalmasın-> bir clası oluşturduğunuz zaman onun interfaceni oluşturduğunuzdan emin olunuz
    //manager yerine service olarakta görebiliriz
    //person manager kullnaıcıya maske verdiğim ortam sunuyor olucak
    //PersonManager bir iş sınıfıdır demekki biz classları sadece özellik tutmak için değil aynı zamanda böyle operasyonları tutmak iiçnde kullanıyoruz.
    //eğer özelliklerle operasyonları aynı sınıfta yazsak single responsibilitye aykırı
    //bir sınıf sadece özellik tutabilir yada sadece operasyon tutabilir
    public class PersonManager:IApplicantService
    {
        //bu yapı Fonksiyon,method,prosedür gibi isimler veriyoruz.
        //maske için başvur
        //encapsulation-->özellikleri parametreden çağırmak yerine özellikleri alıp bir classın içine koymak
        public void ApplyForMask(Person person)
        {

        }
        //Fonsksiyon dediğimiz yapı nedir?
        //bu projede diyelimki bir operasyonumuz var maske başvurusunda bulun 
        //maske başvurusunda bulun olayını projenin bir çok yerinde kullanabiliriz.
        //a sayfasında, b sayfasında, c sayfasında bunları kullanabiliriz.
        //sıklıkla kullanacağımız operasyonları fonksiyonların methodlarıniçine yazıyoruzki kullanabilelim

        //kimler maske başvurusunda bulunmuş
        public List<Person> Getlist()
        {
            return null;
        }
        //bu adam doğrumu
        public  bool CheckPerson(Person person)
        {
            //KPS->kimlik paylaşım sistemi
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return  client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,Ad:person.FirstName,Soyad:person.LastName,DogumYili:person.DataOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
