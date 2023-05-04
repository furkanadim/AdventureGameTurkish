using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PeriliKoskOyun
{
    public static class Menu
    {
        public static void Islemler(ConsoleKey key)
        {

            switch (key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    OturmaOdasi("");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Mutfak("");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Merdivenler("");
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    YatakOdasi("");
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Kiler("");
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    ArkaBahce("");
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Garaj("");
                    break;
            }
        }

        public static void OturmaOdasi(string v)
        {
            BaslikYazdir(v);
            Console.WriteLine("Oturma odasına gitmeyi seçtin.");
            Console.WriteLine("Oturma odasına girerken yerde bir pitbull'un uyuduğunu gördün ve bazı mücevherleri koruduğunu fark ettin.");
            Console.WriteLine("Mücevherleri almak ister misin?");
            Console.WriteLine();
            Console.Write("> ");
            string pitbullSecim = Console.ReadLine().ToLower();
            if (pitbullSecim == "evet")
            {
                if (Esyalar.SopaSayisi == 0)
                {
                    Console.WriteLine("Mücevheri çalmayı denedin ama pitbull uyandı ve seni parçalara ayırdı");
                    Console.WriteLine("Artık ölüsün.");
                    Console.WriteLine("Programdan çıkmak için bir tuşa basıp, enter'a basınız.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (Esyalar.SopaSayisi == 1 && Esyalar.DegerliEsyaSayisi < 2)
                {
                    Console.WriteLine("Yerde uyuyan pitbull uyandı ve üzerine zıpladı.");
                    Console.WriteLine("Hızlı davranıp golf sopasıyla onu bayılttın.");
                    Console.WriteLine("Artık mücevherleri çantaya atabilirsin.");
                    Console.WriteLine("Tebrikler, 3 adet mücevher aldın! Fakat Golf sopan kırıldı...");
                    AnaMenuyeDon(v);
                    Esyalar.DegerliEsyaSayisi += 3;
                    Esyalar.SopaSayisi--;
                }
                
            }
            else if (pitbullSecim == "hayır" || pitbullSecim == "hayir")
            {
                Console.WriteLine("Mücevherleri almamayı seçtin.");
                Console.WriteLine();

                if (Esyalar.KapiAnahtari == 0)
                {
                    Console.WriteLine("Çıkış kapısına doğru ilerlerken yerde eski bir anahtar olduğunu gördün.");
                    Console.WriteLine("Bu bir kapı anahtarına benziyor.");
                    Console.WriteLine("Almak ister misin?");
                    Console.Write("> ");
                    string kapiAnahtari = Console.ReadLine().ToLower();
                    if (kapiAnahtari == "evet")
                    {
                        Console.WriteLine("Bir adet kapı anahtarı envanterine eklendi");
                        if (Esyalar.KapiAnahtari == 0)
                        {
                            Esyalar.KapiAnahtari++;
                        }
                    } 
                    else if (kapiAnahtari == "hayir" ||  kapiAnahtari == "hayır")
                    {
                        Console.WriteLine("Anahtarı almamayı seçtin.");
                        Console.WriteLine("Kapıdan çıktın ve koridora doğru ilerliyorsun...");
                        AnaMenuyeDon(v);
                    }
                }
                
                AnaMenuyeDon(v);
            }
            else
            {
                Console.WriteLine("Yanlış seçim. Lütfen evet veya hayır olarak cevaplayın.");
            }
            
        }

        public static void Mutfak(string v)
        {
            BaslikYazdir(v);
            Console.WriteLine("Mutfağa gitmeyi seçtin.");
            Console.WriteLine("Mutfağa doğru yürürken, masanın üzerinde parlak bir kutu gördün.");
            Console.WriteLine("Açmak ister misin?");
            Console.Write("> ");
            string kutuSecim = Console.ReadLine().ToLower();

            if (kutuSecim == "evet")
            {
                if (Esyalar.AnahtarSayisi == 1 && Esyalar.DegerliEsyaSayisi == 0)
                {
                    Console.WriteLine("Kutuyu açtın ve içerisinde değerli bir mücevher buldun.");
                    Esyalar.DegerliEsyaSayisi++;
                    Esyalar.AnahtarSayisi--;
                    AnaMenuyeDon(v);
                }
                else
                {
                    Console.WriteLine("Kutu kilitli. Anahtar gerekiyor..");
                    AnaMenuyeDon(v);
                }
            }
            else if (kutuSecim == "hayır" || kutuSecim == "hayir")
            {
                Console.WriteLine("Kutuyu açmamayı tercih ettin.");
                Console.WriteLine("Ve mutfaktan ayrılırken, karşından sesler geldiğini duydun.");
                Console.WriteLine("Gözleri kırmızı, siyah bir sillüyet sana vurdu ve bayıldın.");
                Console.WriteLine("Uyandığında tekrardan perili köşkün kapısında olduğunu farkettin...");
                AnaMenuyeDon(v);
            }
            else
            {
                Console.WriteLine("Yanlış seçim. Lütfen evet veya hayır olarak cevaplayın.");
            }
        }

        public static void Merdivenler(string v)
        {
            BaslikYazdir(v);
            Console.WriteLine("Merdivenler bölümüne girdin.");
            Console.WriteLine("Merdivenlerden yukarı çıkmaya karar verdin ama üst katta karanlık olduğunu fark ettin.");
            Console.WriteLine("Devam etmek istiyor musun?");
            Console.Write("> ");
            string merdivenSecim = Console.ReadLine().ToLower();
            if (merdivenSecim == "evet")
            {
                Console.WriteLine("Uzun boş bir koridora bakıyorsun.");
                Console.WriteLine("İleride bir sehpa var.");
                Console.WriteLine("Sehpayı kontrol etmek ister misin?");
                Console.Write("> ");
                string sehpaKontrol = Console.ReadLine().ToLower();
                if (sehpaKontrol == "evet")
                {
                    Console.WriteLine("Sehpanın üzerinde bir araba anahtarı gördün.");
                    if (Esyalar.ArabaAnahtari == 0)
                    {
                        if (Esyalar.ArabaAnahtari >= 1)
                        {
                            Console.WriteLine("Envanterinde zaten bir araba anahtarı mevcut.");
                            Console.WriteLine("Geri dönüyorsun...");
                            AnaMenuyeDon(v);
                        }
                        Console.WriteLine("Bunun işine yarayacağını düşündün ve cebine attın.");
                        Esyalar.ArabaAnahtari++;
                        AnaMenuyeDon(v);
                    }
                }
                else if (sehpaKontrol == "hayır" || sehpaKontrol == "hayir")
                {
                    Console.WriteLine("Tehlikeli olacağını düşündüğün için vazgeçtin.");
                    Console.WriteLine("Merdivenlerden aşağı iniyorsun...");
                    AnaMenuyeDon(v);
                }
            }
            else if (merdivenSecim == "hayır" || merdivenSecim == "hayir")
            {
                Console.WriteLine("Merdivenlerden geri dönmeye karar verdin ve başka bir yol aramaya devam edeceksin.");
                AnaMenuyeDon(v);
            }
            else
            {
                Console.WriteLine("Yanlış seçim. Lütfen evet veya hayır olarak cevaplayın.");
                Console.ReadLine();
            }
        }

        public static void YatakOdasi(string v)
        {
            BaslikYazdir(v);
            Console.WriteLine("Yatak Odası bölümüne girdin.");
            Console.WriteLine("Odada sadece bir yatak var ve üzerinde bir not var.");
            Console.WriteLine("Notu okumak ister misin?");
            Console.Write("> ");
            string notSecim = Console.ReadLine().ToLower();
            if (notSecim == "evet")
            {
                Console.WriteLine("Not, 'Korkma. Gerçekler sadece karanlıkta saklanır.' şeklinde yazılmıştı.");
                if(Esyalar.NotSayisi == 0)
                {
                    Esyalar.NotSayisi++;
                }
                AnaMenuyeDon(v);
            }
            else if (notSecim == "hayır" || notSecim == "hayir")
            {
                Console.WriteLine("Notu okumamaya karar verdin. Ancak bir şeylerin yanlış olduğunu hissetmeye devam ettin.");
                AnaMenuyeDon(v);
            }
            else
            {
                Console.WriteLine("Yanlış seçim. Lütfen evet veya hayır olarak cevaplayın.");
            }
        }

        public static void Kiler(string v)
        {
            BaslikYazdir(v);
            Console.WriteLine("Yavaş yavaş evin altındaki Kiler'e doğru ilerliyorsun.");
            Console.WriteLine("Kilerde bir eski bir süpürge ve birkaç adet boya kutusu olduğunu gördün. İleride bir kapı var.");
            Console.WriteLine("Burada bakılacak bir şey olmadığını düşündün, yine de kapıya gidip açmak ister misin?");
            Console.WriteLine("> ");
            string kapiSecim = Console.ReadLine().ToLower();
            if (kapiSecim == "evet")
            {
                if (Esyalar.AnahtarSayisi == 0)
                {
                    Console.WriteLine("Kapıyı açtın ve buranın eskiden bir çalışma odası olduğunu anladın.");
                    Console.WriteLine("Masanın üzerinde bir anahtar var.");
                    Console.WriteLine("Almak ister misin ?");
                    Console.Write("> ");
                    string anahtarSecim = Console.ReadLine().ToLower();
                    if (anahtarSecim == "evet" && Esyalar.AnahtarSayisi < 1)
                    {
                        Esyalar.AnahtarSayisi++;
                        Console.WriteLine("Envanterine bir anahtar eklendi.");
                        Console.WriteLine("Artık burada bir şey yok. Kilerden çıkıyorsun...");
                        AnaMenuyeDon(v);
                    }
                    else if (anahtarSecim == "hayir" || anahtarSecim == "hayır")
                    {
                        Console.WriteLine("Anahtarı almadan odadan ayrılıyorsun..");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Buraya zaten uğramıştın, bu yüzden bakılacak bir şey olmadığını farkettin.");
                    Console.WriteLine("Kilerden çıkıyorsun...");
                    AnaMenuyeDon(v);
                }
            }
            else if (kapiSecim == "hayir" || kapiSecim == "hayır")
            {
                Console.WriteLine("Kapıyı açmadan Kiler'den ayrılıyorsun..");
            }


        }

        public static void ArkaBahce(string v)
        {
            BaslikYazdir(v);
            Console.WriteLine("Koridorun sonunda arka bahçeye açılan bir kapı olduğunu farkettin ve oraya doğru ilerliyorsun...");
            Console.WriteLine("Kapıyı açtın ve bahçedesin.");
            Console.WriteLine("Eski bir ev olmasına rağmen bahçe çok dikkatli bir şekilde bakılmış, düzenli ve her şey güzel görünüyordu.");
            Console.WriteLine("İleride bir masa ve 4 adet sandalye olduğunu gördün.");
            Console.WriteLine("Biraz oturup dinlenmek ister misin?");
            Console.WriteLine("> ");
            string dinlenmeSecim = Console.ReadLine().ToLower();
            if (dinlenmeSecim == "evet")
            {
                Console.WriteLine("Sandalyeye oturdun ve biraz dinleniyorsun.");
                Console.WriteLine("Dinlenirken ileride bir barbekü olduğunu gördün.");
                Console.WriteLine("Gidip onu incelemek ister misin?");
                Console.Write("> ");
                string barbekuSecim = Console.ReadLine().ToLower();
                if (barbekuSecim == "evet")
                {
                    
                    if(Esyalar.SopaSayisi == 0)
                    {
                        Console.WriteLine("Sönmüş ızgara ve artıklar görüyorsun.");
                        Console.WriteLine("Barbekünün yanında bir adet golf sopası olduğunu farkettin.");
                        Console.WriteLine("Almak ister misin?");
                        Console.Write("> ");
                        string sopaSecim = Console.ReadLine().ToLower();
                        if (sopaSecim == "evet")
                        {
                            Console.WriteLine("Golf sopasını aldın.");
                            Console.WriteLine("Geri dönmeye karar verdin.");
                            Esyalar.SopaSayisi++;
                            AnaMenuyeDon(v);
                        }
                        else if (sopaSecim == "hayir" || sopaSecim == "hayır")
                        {
                            Console.WriteLine("Golf sopasını almadın ve geri dönüyorsun.");
                            AnaMenuyeDon(v);
                        }
                        else
                        {
                            Console.WriteLine("Golf sopasını zaten almıştın.");
                            Console.WriteLine("Burada başka bakacak bir şey yok.");
                            Console.WriteLine("Geri dönüyorsun...");
                            AnaMenuyeDon(v);
                        }
                        
                    }
                    else if(barbekuSecim == "hayir" || barbekuSecim == "hayır")
                    {
                        Console.WriteLine("Barbeküye bakmamaya karar verdin.");
                        Console.WriteLine("Burada yeterince dinlendin ve geri dönmeye karar verdin.");
                        AnaMenuyeDon(v);
                    }
                }
            }


        }

        public static void Garaj(string v)
        {
            BaslikYazdir(v);
            Console.WriteLine("Garaja gitmeye karar verdin.");
            Console.WriteLine("Daha önce bir kapı anahtarı bulduysan bu kapıyı açabilirsin.");
            Console.WriteLine("Kapıyı açmak istiyor musun?");
            Console.Write("> ");
            string kapiSecim = Console.ReadLine().ToLower();

            if (kapiSecim == "evet")
            {
                if (Esyalar.KapiAnahtari == 1)
                {
                    Console.WriteLine("Garaja giriş yaptın.");
                    if (Esyalar.ArabaSayisi == 0)
                    {
                        Console.WriteLine("Karşında kırmızı bir araba var.");
                        Console.WriteLine("Oldukça değerli bir araba gibi görünüyor.");
                        Console.WriteLine("Arabayı almak ister misin?");
                        Console.Write("> ");
                        string arabaSecim = Console.ReadLine().ToLower();
                        if (arabaSecim == "evet")
                        {
                            if (Esyalar.ArabaAnahtari == 1 && Esyalar.ArabaSayisi == 0)
                            {
                                Console.WriteLine("Tebrikler! Artık bir araba sahibisin.");
                                Esyalar.ArabaSayisi++;
                                AnaMenuyeDon(v);
                            }
                            else if (Esyalar.ArabaAnahtari == 0)
                            {
                                Console.WriteLine("Arabayı alabilmen için bir araba anahtarına ihtiyacın var.");
                                Console.WriteLine("Geri dönüyorsun.");
                                AnaMenuyeDon(v);
                            }
                        }
                        else if (arabaSecim == "hayir" || arabaSecim == "hayır")
                        {
                            Console.WriteLine("Arabayı almamayı seçtin.");
                            Console.WriteLine("Garajdan çıkıyorsun...");
                            AnaMenuyeDon(v);
                        }
                    }
                    else if (Esyalar.ArabaSayisi == 1)
                    {
                        Console.WriteLine("Zaten arabayı almıştın.");
                        AnaMenuyeDon(v);
                    }
                }
                else if (Esyalar.KapiAnahtari == 0)
                {
                    Console.WriteLine("Garaj kapısı kilitli.");
                    Console.WriteLine("Geri dönüyorsun.");
                    AnaMenuyeDon(v);
                }
            }
        }

        private static void BaslikYazdir(string v)
        {
            Console.Clear();
            Console.WriteLine(v);
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }

        private static void AnaMenuyeDon(string v)
        {
            Console.WriteLine();
            Console.WriteLine(v);
            Console.WriteLine();
            Console.WriteLine("Ana menüye dönmek için Bir tuşa basınız");
            Console.ReadKey();
        }

    }
}
