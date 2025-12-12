using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _temel_konular_CSharpeğitimkampı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Hello Word!");
            //Console.Write("Selam");

            //Console.WriteLine("*******Yemek Katagorileri********");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*******Yemek Katagorileri********");

            #endregion

            #region String  Değişkenler
            //String
            //Değişkenin_türü değişken_Adı;


            //string name;
            //name = "Timur";
            //Console.Write(name);


            //string passengerName;
            //string passengerSurname;
            //string passengerPhone;
            //string passengerEmail, district, city;

            //passengerName = "Timur";
            //passengerSurname = "Zaman";
            //passengerPhone = " +90 505 400 98 78";
            //passengerEmail = "denem@gmail.com";
            //district = "Sarıçam";
            //city = "Adana";
            //Console.WriteLine("*****Rezervasyon Kartı*****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri:" + passengerName + "" + passengerSurname);
            //Console.WriteLine("İletişim:" + passengerPhone);
            //Console.WriteLine("Email Adresi:" + passengerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);

            //Console.WriteLine();

            //passengerName = "Ayse";
            //passengerSurname = "Kaya";
            //passengerPhone = " +90 545 987 78 95";
            //passengerEmail = "denem1@gmail.com";
            //district = "Sarıçam";
            //city = "Adana";
            //Console.WriteLine("Müşteri:" + passengerName + "" + passengerSurname);
            //Console.WriteLine("İletişim:" + passengerPhone);
            //Console.WriteLine("Email Adresi:" + passengerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);



            #endregion

            #region int Değişkenler

            ////int
            ////int number = 24;
            ////Console.WriteLine(number);


            //int hamburgerPrice = 300;
            //int CokePrice = 35;
            //int WaterPrice = 10;
            //int FrisPrice = 50;
            //int PizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("************Restoran Menü Fiyatı*****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger :"+hamburgerPrice+ " TL");
            //Console.WriteLine("-----Pizza:"+ PizzaPrice+ " TL");
            //Console.WriteLine("-----Kola"+CokePrice+ " TL");
            //Console.WriteLine("-----Limonata"+lemonadePrice+ " TL");
            //Console.WriteLine("-----Kızartma"+FrisPrice + " TL");
            //Console.WriteLine("-----Su"+WaterPrice+ " TL");

            //Console.WriteLine();
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int frisCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamburgerPrice = 0;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalFrisPrice;
            //int totalPizzaPrice;
            //int totalLemonadePrice;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //frisCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;
            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokeCount * CokePrice;
            //totalWaterPrice = waterCount * WaterPrice;
            //totalFrisPrice = frisCount * FrisPrice;
            //totalPizzaPrice = pizzaCount * PizzaPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Hamburger Tutarı" + totalHamburgerPrice + " TL");
            //Console.WriteLine("Kola Tutarı" + totalCokePrice+ " TL");
            //Console.WriteLine("Pizza Tutarı" + totalPizzaPrice + " TL");
            //Console.WriteLine("Su Tutarı" + totalWaterPrice + " TL");
            //Console.WriteLine(" Kızartma Tutarı" + totalFrisPrice + " TL");
            //Console.WriteLine("Limonata Tutarı" + totalLemonadePrice + " TL");


            //Console.WriteLine();
            //int totalPrice = totalCokePrice + totalFrisPrice + totalHamburgerPrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice;
            //Console.WriteLine("Ödenecek Tutar:" + totalPrice + " TL");





            #endregion

            #region Double Değişkenler
            //double number ;
            //number = 4.87;
            //Console.WriteLine(number);

            //Console.WriteLine("********* Fiyat listesi********");

            //Console.WriteLine();

            //double applePrice, orangePrice, starwberryPrice, patatoPrice, tamatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //starwberryPrice = 45;
            //patatoPrice = 9.74;
            //tamatoPrice = 12.30;

            //Console.WriteLine("****Elma Birim Fiyatı" + applePrice+"TL");
            //Console.WriteLine("****Portakal Birim Fiyatı" + orangePrice+"TL");
            //Console.WriteLine("****Çilek Birim Fiyatı" + starwberryPrice+"TL");
            //Console.WriteLine("****Patates Birim Fiyatı" + patatoPrice+"TL");
            //Console.WriteLine("****Domates Birim Fiyatı" + tamatoPrice+"TL");

            //double appleGram, orangeGram, starwberryGram, patatoGram, tamatoGram;
            //appleGram = 1.234;
            //orangeGram = 2.345;
            //starwberryGram = 0.750;
            //patatoGram = 4.859;
            //tamatoGram = 3.745;


            //double appleTotalPrice = appleGram * applePrice;
            //double starwberryTotalPrice = starwberryGram * starwberryPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double tamatoTotalPrice = tamatoGram * tamatoPrice;

            //Console.WriteLine(" Alınan ürün :Elma - "+" Birim Fiyat:" + appleTotalPrice+ 
            //    "-Gramaj"+appleGram+"-Toplam Tutar"+appleTotalPrice);

            //Console.WriteLine(" Alınan ürün :Portakal - "+ " Birim Fiyat:" + orangeTotalPrice + 
            //    "-Gramaj"+orangeGram+"-Toplam Tutar" + orangeTotalPrice);

            //Console.WriteLine(" Alınan ürün :Çilek -" + "Birim Fiyat:" + starwberryTotalPrice+
            //    "-Gramaj"+starwberryGram+"-Toplam Tutar"+ starwberryTotalPrice);

            //Console.WriteLine(" Alınan ürün :Patetes -" + " Birim Fiyat:" + patatoTotalPrice +
            //    "-Gramaj" +patatoGram+"-Toplam Tutar" + patatoTotalPrice);

            //Console.WriteLine(" Alınan ürün :Domates -"+" Birim Fiyat:" + tamatoTotalPrice +
            //    "-Gramaj"+tamatoGram+"-Toplam Tutar" + tamatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice +starwberryTotalPrice +orangeTotalPrice + patatoTotalPrice + tamatoTotalPrice;
            //Console.WriteLine(shoppingTotalPrice);








            //Console.WriteLine();









            #endregion

            #region Char Değişkenler 

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);







            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("*******CSharp Hava Yolları Yolcu Bilgisi******");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentyNumber;
            //Console.Write("Yolcu Adı");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı");
            //passengerSurname = Console.ReadLine();



            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi:");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC kimlik No:");
            //passengerIdentyNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu:" + passengerName +""+ passengerSurname+""+passengerDistrict+"/" +
            //   passengerCity+"" +passengerIdentyNumber+""+passengerAge);









            #endregion

            #region Klavyeden Tam Sayı Grişileri ve Dönüşümler


            //ADB12D



            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;


            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısıı giriniz : ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + chairCount * chairPrice + computerCount * computerPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz gereken değer:" + totalPrice);













            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu giriniz");
            // exam1 = double.Parse(Console.ReadLine()); 
            //Console.Write("Lütfen 2. Sınav Notunu giriniz");
            // exam2 = double.Parse(Console.ReadLine()); 
            //Console.Write("Lütfen 3. Sınav Notunu giriniz");
            // exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınac Ortalamasını Giriniz"+result);










            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen Cinsiyet Griniz :");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cisniyet:" + gender);










            #endregion

            #region IF 

            //Console.Write("Lütfen Şifre Giriniz:");
            //string passowrd;
            //passowrd = Console.ReadLine();
            //Console.ReadKey();
            //if(passowrd=="abcd")
            //{
            //    Console.WriteLine("Şifre Dopru");

            //}
            //else
            //{

            //    Console.WriteLine("Şifre Yanlış");
            //}



            //string capital, country;
            //Console.Write("Başkenti Giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara"& country=="türkiye")

            //{
            //    Console.Write("Veriler Doğrulandı");

            //}
            //else
            //{

            //    Console.WriteLine("Hatalı Bilgi");



            //}

            //int sayi;
            //Console.Write("Sayıyı Giriniz:");
            //sayi = int.Parse(Console.ReadLine());

            //if(sayi==5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{

            //    Console.WriteLine("Sayı yanlış");

            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";
            //Console.Write("Sınav1:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3:");
            //exam3 = int.Parse(Console.ReadLine());

            //average=(exam1+exam2+exam3)/3;
            //Console.Write("Sınavların Ortalaması:" + average);

            //if(average>0&average<=20)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average>50&average<=80)
            //{

            //    result = "Sonuç Orta";

            //}
            //if(average>81&average<=100)
            //{
            //    result = "Sonuç İyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız:");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "istanbul")
            //{
            //    Console.WriteLine("Şehir Mecvut");


            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}


            //Console.Write("Lütfen Kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if( username !="admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");


            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}

            #endregion

            #region mod işlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            // Console.Write("Lütfen 1. sayıyı Giriniz");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı Giriniz");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.Sayının 2.Sayıya bölümünden kalan :" + result);

            //Console.Write("Lütfen Bir Sayı giriniz:");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2==0)
            //{
            //    Console.Write("Sayı Çiftir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}


            #endregion

            #region char değişkenler ile karar yapıları
            //char team;
            //Console.Write("Lütfen takım sembolunu giriniz:");
            //team = char.Parse(Console.ReadLine());
            //if(team=='g'|team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if(team=='f'|team=='F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            #endregion

            #region Örnek proje Uygulaması 

            //Console.WriteLine("*******C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1.Ana Yemekler");
            //Console.WriteLine("2.Çorbalar");
            //Console.WriteLine("3.Pizzalar");
            //Console.WriteLine("4.İçecekler");
            //Console.WriteLine("5.Tatlılar");

            //string menuItem;
            //Console.WriteLine("Lütfen detayını görmek istediğiniz menü seçin");
            //menuItem = Console.ReadLine();
            //if(menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1.Köri soslu Tavuk");
            //    Console.WriteLine("2.Döner");
            //    Console.WriteLine("3.Somon");
            //    Console.WriteLine("4.musakka");
            //    Console.WriteLine("5.Tavuk Pilav");
            //    Console.WriteLine("----------Ana Yemekler-----------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorba-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1.Mercimek");
            //    Console.WriteLine("2.Arabaşı");
            //    Console.WriteLine("3.Ezogelin");
            //    Console.WriteLine("----------Çorba-----------");
            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1.Mantarlı");
            //    Console.WriteLine("2.Sucuklu");
            //    Console.WriteLine("3.Peynirli");
            //    Console.WriteLine("----------Pizzalar-----------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1.Kola");
            //    Console.WriteLine("2.Ayran");
            //    Console.WriteLine("3.Su");
            //    Console.WriteLine("----------İçecekler-----------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1.Kazandibi");
            //    Console.WriteLine("2.Sütlaç");
            //    Console.WriteLine("3.Pasta");
            //    Console.WriteLine("----------Tatlılar-----------");
            //    Console.WriteLine();

            //}










            #endregion

            #region Swtich Case



            //Console.Write("Lütfen Ay Girişi Yapınız");
            //int montNumber = int.Parse(Console.ReadLine());
            //switch(montNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı Veri Girişi"); break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi 

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayı Giriniz");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2.Sayı Giriniz");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz");
            //symbol = char.Parse(Console.ReadLine());
            
            
            
            //switch(symbol)
            //    {
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam:"+result);break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma:" + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma:" + result); break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm:" + result); break;
            //}


















































































































            #endregion





















            Console.ReadLine();

        }
    }
}

