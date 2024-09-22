
// Döngüler konusunu tekrar hatırlayalım

// 3 farklı döngümüz var bunlar;

// For
// Foreach
// Do While


// döngünün tanımı : belirli bir şart sağlandıkça aynı kod bloğunu devamlı çalıştıran yapılara döngü denir.

// Do While Döngüsü 

// Syntax 

/*

do
{
 Aşağıdaki koşul sağlandığı sürece buraya yazılan kod bloğu çalışır
} while(koşul)
*/

// Örnek : 50 den küçük sayı girmeye çalışalım

/*int girilenSayi = 0;
do{
 Console.WriteLine("Bir sayı giriniz");
 girilenSayi=int.Parse(Console.ReadLine());

}while(girilenSayi<50);
*/
// girilen sayı 50 den küçükse, döngü dönmeye devam ediyor, girilen sayı 50 den büyükse,
// döngü sonlanıyor.

// gerçek do while döngüsünü pek göremezsiniz.(çok kullanışlı olmasına rağmen)

/// Örnek : Kullanıcıdan kullanıcı adi ve şifre alarak, do while kullanarak bir kullancı
// giriş mekanizması yapınız
string dbUserName = "wissen";
string dbPassword = "besiktas";

string userName ="";
string password="";
do{

Console.WriteLine("Kullanıcı adınızı giriniz");
userName = Console.ReadLine();
Console.WriteLine("Şifrenizi giriniz");
password = Console.ReadLine();   

if(dbUserName==userName && dbPassword==password){
    Console.WriteLine("Giriş başarılı");
    // do while döngüsünden çıkabilmek için break ifadesi kullanılabilir:
    break;
}
else{
    Console.WriteLine("Giriş başarısız");
}

// while dönsün diye true set ettik
}while(true);
// while içerisinde true verirseniz bu döngü sonsuz döngü olur

// Not : while içerisinde true değer verirseniz bu döngü sonsuz döngü olur
// sonsuz döngüleri bir break ifadesi ile durdurabiliriz

// yaptığımız uygulamada sonsuza kadar dönen bir döngüyü, şartımız sağlandığında
// break komutu ile durdurduk

// Aynı şekilde, 
