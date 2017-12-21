using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabuArama__Tavlama__GezginSatici
{
    public partial class Form1 : Form
    {
        public List<Cozum> suankiCozumListesi = new List<Cozum>();
        public List<Cozum> yeniCozumListesi = new List<Cozum>();

        public int iterasyonSayisi = 100;
        int cozumSayisi = 40;
        int sehirSayisi = 40;

        public List<Sehir> tumSehirListesi = new List<Sehir>();

        List<Cozum> eniyiler = new List<Cozum>();
        List<Tabu> tabuListemiz = new List<Tabu>(4);


        // İlk sıcaklığı ayarla
        double temp = 10000;

        // Soğutma hızı
        double coolingRate = 0.003;


        public Form1()
        {
            InitializeComponent();
            tumSehirListesi.Add(new Sehir(1,"ADALAR", 40.8650303, 29.1120209, 0));
            tumSehirListesi.Add(new Sehir(2,"ARNAVUTKÖY", 41.1837196, 28.7418537, 0));
            tumSehirListesi.Add(new Sehir(3,"ATAŞEHİR", 41.5266722, 29.3971759, 0));
            tumSehirListesi.Add(new Sehir(4,"AVCILAR", 40.9797600, 28.7115787, 0));
            tumSehirListesi.Add(new Sehir(5,"BAĞCILAR", 41.0319546, 28.8318780, 0));
            tumSehirListesi.Add(new Sehir(6,"BAHÇELİEVLER", 41.0049445, 28.8311296, 0));
            tumSehirListesi.Add(new Sehir(7,"BAKIRKÖY", 40.9947864, 28.9021766, 0));
            tumSehirListesi.Add(new Sehir(8,"BAŞAKŞEHİR", 41.080265, 28.6624851, 0));
            tumSehirListesi.Add(new Sehir(9,"BAYRAMPAŞA", 41.0490000, 28.8918398, 0));
            tumSehirListesi.Add(new Sehir(10,"BEŞİKTAŞ", 41.0379835, 29.0104814, 0));
            tumSehirListesi.Add(new Sehir(11,"BEYKOZ", 41.1357371, 29.0849440, 0));
            tumSehirListesi.Add(new Sehir(12,"BEYLİKDÜZÜ", 40.982151, 28.6388969, 0));
            tumSehirListesi.Add(new Sehir(13,"BEYOĞLU", 41.0450190, 28.9572483, 0));
            tumSehirListesi.Add(new Sehir(14,"BÜYÜKÇEKMECE", 41.0176450, 28.5817436, 0));
            tumSehirListesi.Add(new Sehir(15,"ÇATALCA", 41.1364303, 28.4535416, 0));
            tumSehirListesi.Add(new Sehir(16,"ÇEKMEKÖY", 41.0376167, 29.1759624, 0));
            tumSehirListesi.Add(new Sehir(17,"ESENLER", 41.0315740, 28.8556568, 0));
            tumSehirListesi.Add(new Sehir(18,"ESENYURT", 41.0231972, 28.6829987, 0));
            tumSehirListesi.Add(new Sehir(19,"EYÜP", 41.0484087, 28.9275158, 0));
            tumSehirListesi.Add(new Sehir(20,"FATİH", 41.0117957, 28.9621210, 0));
            tumSehirListesi.Add(new Sehir(21,"GAZİOSMANPAŞA", 41.075923, 28.904191, 0));
            tumSehirListesi.Add(new Sehir(22,"GÜNGÖREN", 41.0223788, 28.8672916, 0));
            tumSehirListesi.Add(new Sehir(23,"KADIKÖY", 40.9743400, 29.0441998, 0));
            tumSehirListesi.Add(new Sehir(24,"KAĞITHANE", 41.0836130, 28.9761602, 0));
            tumSehirListesi.Add(new Sehir(25,"KARTAL", 40.8907099, 29.1840519, 0));
            tumSehirListesi.Add(new Sehir(26,"KÜÇÜKÇEKMECE", 40.9966866, 28.7833474, 0));
            tumSehirListesi.Add(new Sehir(27,"MALTEPE", 40.9188241, 29.1256070, 0));
            tumSehirListesi.Add(new Sehir(28,"PENDİK", 40.8717986, 29.2308925, 0));
            tumSehirListesi.Add(new Sehir(29,"SANCAKTEPE", 41.5266722, 29.3971759, 0));
            tumSehirListesi.Add(new Sehir(30,"SARIYER", 41.1545937, 29.0378749, 0));
            tumSehirListesi.Add(new Sehir(31,"ŞİLE", 41.1700536, 29.6104760, 0));
            tumSehirListesi.Add(new Sehir(32,"SİLİVRİ", 41.0668909, 28.2377831, 0));
            tumSehirListesi.Add(new Sehir(33,"ŞİŞLİ", 41.0473985, 28.9869733, 0));
            tumSehirListesi.Add(new Sehir(34,"SULTANBEYLİ", 40.9703494, 29.2579766, 0));
            tumSehirListesi.Add(new Sehir(35,"SULTANGAZİ", 43.3262463, 18.5332179, 0));
            tumSehirListesi.Add(new Sehir(36,"TUZLA", 40.8163943, 29.3001684, 0));
            tumSehirListesi.Add(new Sehir(37,"ÜMRANİYE", 41.0187126, 29.0812480, 0));
            tumSehirListesi.Add(new Sehir(38,"ÜSKÜDAR", 41.0199787, 29.0099336, 0));
            tumSehirListesi.Add(new Sehir(39,"ZEYTİNBURNU", 40.9857833, 28.9019178, 0));
            tumSehirListesi.Add(new Sehir(40,"GEBZE", 40.809983, 29.436737, 0));

            tabuListemiz.Add(new Tabu(-1,-1));
            tabuListemiz.Add(new Tabu(-1, -1));
            tabuListemiz.Add(new Tabu(-1, -1));
            tabuListemiz.Add(new Tabu(-1, -1));

            StringBuilder baslangic = new StringBuilder();
     /*       baslangic.AppendLine("İterasyon Sayisi"+ iterasyonSayisi);
            baslangic.AppendLine("Tabu Sayısı "+ tabuListemiz.Count);
            baslangic.AppendLine(""); */

            for (int i = 0; i < tumSehirListesi.Count; i++)
            {
                Sehir item = tumSehirListesi[i];
                baslangic.AppendLine(String.Format("{0} - {1}  - {2}  - {3} ", item.Sira, item.Adi, item.Enlem, item.Boylam));
            }
            baslangicdurumu.Text = baslangic.ToString();

        }

        //tabu arama
        private void button1_Click(object sender, EventArgs e)
        {
            //ilk çözüm rastgele olusturuldu
            suankiCozumListesi = rastgeleCozumOlustur();
            foreach (Cozum cozum in suankiCozumListesi)
            {
                //uygunluk degerlerı kontrol edıldı
                cozum.Uygunluk= uygunlukFonk(cozum);

            }


            listBox1.Items.Clear();
           String sonucekraniyazisi = "Tabu Arama ile Çözüm";
            listBox1.Items.Add(sonucekraniyazisi);

            //tüm çözümlerin uygunlukları hesaplanır
            for (int i_nesil = 0; i_nesil < iterasyonSayisi; i_nesil++)
            {
                
                //en az mesafe benım ıcın en uygun cozum
                var minUygunluk = suankiCozumListesi.Min(obj => obj.Uygunluk);
                Cozum buNeslinEnIyibireyi = suankiCozumListesi.Where(obj => obj.Uygunluk == minUygunluk).FirstOrDefault();

                // en iyi çözümü uzun hafızaya aldım
                eniyiler.Add(buNeslinEnIyibireyi);

                //tabu arama yontemı ıle ılgılı ıslemler swapla methodunda bulunmakta
                suankiCozumListesi = swapla(buNeslinEnIyibireyi);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < buNeslinEnIyibireyi.Kromozom.Count; i++)
                {
                    sb.Append(buNeslinEnIyibireyi.Kromozom[i].ToString()+"-");
                }
                listBox1.Items.Add(String.Format("{0}. iterasyon en iyisi \n: {1}, \nToplam Yol: {2}", i_nesil + 1, sb, buNeslinEnIyibireyi.Uygunluk));

            }


        }

        public List<Cozum> swapla(Cozum buNeslinEnIyibireyi)
        {
            List<Cozum> ilkRastgeleCozum = new List<Cozum>();

            //en ıyı bireyımı kısa hafızaya aldım
            ilkRastgeleCozum.Add(buNeslinEnIyibireyi);
            
            for (int i = 0; i < buNeslinEnIyibireyi.Kromozom.Count-1; i++)
            {
                List<int> gelenOrjinalKromozom = new List<int>(buNeslinEnIyibireyi.Kromozom);

                int geciciBir = gelenOrjinalKromozom[i];
                int geciciiki = gelenOrjinalKromozom[i+1];

                gelenOrjinalKromozom[i] = geciciiki;
                gelenOrjinalKromozom[i+1] = geciciBir;

                // en iyi bireyimin yan yana cozumlerinin yerini değiştirdim tek tek
                Cozum yeniCozum = new Cozum(gelenOrjinalKromozom,0);

                //bu swaplanmış olan bıreyın uygunlugu hesaplanıyor
                yeniCozum.Uygunluk = uygunlukFonk(yeniCozum);

                //eger yenı buldugum oncekınden iyiyse 
                if(yeniCozum.Uygunluk<buNeslinEnIyibireyi.Uygunluk)
                {
                    //daha iyiye sebep olan kriteri tabuye eklıyorum 
                    // ekleme işleminde fifo uygulanıyor. (first in first out, ilk giren ilk çıkar)
                    Tabu tabu = new Tabu(geciciiki, geciciBir);
                    try
                    {
                        tabuListemiz[3] = tabuListemiz[2];
                    }
                    catch (Exception){}
                    try
                    {
                        tabuListemiz[2] = tabuListemiz[1];
                    }
                    catch (Exception) { }
                    try
                    {
                        tabuListemiz[1] = tabuListemiz[0];
                    }
                    catch (Exception) { }
                    try
                    {
                        tabuListemiz[0] = tabu;
                    }
                    catch (Exception) { }

                }

                //daha ıyı cozumu de kısa hafızaya alıyorum
                ilkRastgeleCozum.Add(yeniCozum);
            }

           /* if (eniyiler.Count != 0)
            {
                Cozum enSonCozum = eniyiler[eniyiler.Count - 1];

                if (buNeslinEnIyibireyi.Uygunluk < enSonCozum.Uygunluk)
                {
                }
            }
            */
            return ilkRastgeleCozum;
        }

        public List<Cozum> rastgeleCozumOlustur()
        {
            List<Cozum> ilkRastgeleCozum = new List<Cozum>();

            Random rastgele = new Random();
            while (ilkRastgeleCozum.Count < cozumSayisi)
            {
                Cozum cozum = new Cozum(new List<int>(),  0);
  
                while (cozum.Kromozom.Count < sehirSayisi)
                {
                    int rastint = rastgele.Next(sehirSayisi);
                    int sira = tumSehirListesi[rastint].Sira;

                    if (!cozum.Kromozom.Contains(sira))
                    {
                        cozum.Kromozom.Add(sira);
                    }
                }

                ilkRastgeleCozum.Add(cozum);

            }
            return ilkRastgeleCozum;
        }

        public int uygunlukFonk(Cozum cozum)
        {
            for (int i_kromozom = 0; i_kromozom < cozum.Kromozom.Count; i_kromozom++)
            {
                int ilce = cozum.Kromozom[i_kromozom];
                int oncekiIlce = cozum.Kromozom[i_kromozom == 0 ? i_kromozom : i_kromozom - 1];

                Sehir suankiSehir = tumSehirListesi.Where(c => c.Sira == ilce).FirstOrDefault();
                Sehir oncekiSehir = tumSehirListesi.Where(c => c.Sira == oncekiIlce).FirstOrDefault();

                double aradakiMesafe = Geography.CalculateDistance(suankiSehir.Enlem, suankiSehir.Boylam, oncekiSehir.Enlem, oncekiSehir.Boylam);

                // uygunluk fonksıyorunu hesaplanırken tabu da o durum varsa o cozum ceza puanıyle uzaklastırılıyor
                for (int i = 0; i < tabuListemiz.Count; i++)
                {
                    Tabu temp = tabuListemiz[i];
                    if(temp.kimden== oncekiSehir.Sira && temp.kime== suankiSehir.Sira)
                    {
                        aradakiMesafe += 1000 * 100;
                    }
                }
                cozum.Uygunluk += (int)aradakiMesafe / 1000;

            }
            return cozum.Uygunluk;
        }

        //tavlama benzetimi
        private void button2_Click(object sender, EventArgs e)
        {
            yeniCozumListesi = new List<Cozum>();
            // ılk cozum hızlı basladı
            suankiCozumListesi = rastgeleCozumOlustur();
            foreach (Cozum cozum in suankiCozumListesi)
            {
                //ılk cozumun uygunlukları hesaplandı
                cozum.Uygunluk = uygunlukFonk(cozum);

            }
            var minUygunluk = suankiCozumListesi.Min(obj => obj.Uygunluk);
            // en uygun bırey seçildi
            Cozum buNeslinEnIyibireyi = suankiCozumListesi.Where(obj => obj.Uygunluk == minUygunluk).FirstOrDefault();



            listBox1.Items.Clear();
            String sonucekraniyazisi = "Tavlama Benzetimi ile Çözüm";
            listBox1.Items.Add(sonucekraniyazisi);

            listBox1.Items.Add("Başlangıç Çözüm Mesafesi: " + buNeslinEnIyibireyi.Uygunluk);
            Random rastgele = new Random();

            // Sistem soğuana kadar döngüye sok
            while (temp > 1)
            {
                 minUygunluk = suankiCozumListesi.Min(obj => obj.Uygunluk);
                 buNeslinEnIyibireyi = suankiCozumListesi.Where(obj => obj.Uygunluk == minUygunluk).FirstOrDefault();


                List<int> gelenOrjinalKromozom = new List<int>(buNeslinEnIyibireyi.Kromozom);


                int rastint1 = rastgele.Next(sehirSayisi);
                int rastint2 = rastgele.Next(sehirSayisi);

                int geciciBir = gelenOrjinalKromozom[rastint1];
                int geciciiki = gelenOrjinalKromozom[rastint2];

                gelenOrjinalKromozom[rastint1] = geciciiki;
                gelenOrjinalKromozom[rastint2] = geciciBir;

                //rastgele genler değiştirilerek yenı cozum bulundu
                Cozum yeniCozum = new Cozum(gelenOrjinalKromozom, 0);

                //yenı cozumun uygunlugu hesaplandı
                yeniCozum.Uygunluk = uygunlukFonk(yeniCozum);


                // il bulunan en iyi Çözüm enerji alın
                int currentEnergy = buNeslinEnIyibireyi.Uygunluk;

                // sonradan rastgele degıstırılerek bulunan en ıyı cozum enerjısı hesaplandı
                int neighbourEnergy = yeniCozum.Uygunluk;


                // Komşuyu kabul edip edemeyeceğimize karar verin
                //butun olay bu methodda oluyor
                if (acceptanceProbability(currentEnergy, neighbourEnergy, temp) > rastgele.NextDouble())
                {
                    buNeslinEnIyibireyi.Kromozom = gelenOrjinalKromozom;
                    buNeslinEnIyibireyi.Uygunluk = yeniCozum.Uygunluk;
                }


                // Soğuk sistem
                temp *= 1 - coolingRate;

            

            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < buNeslinEnIyibireyi.Kromozom.Count; i++)
            {
                sb.Append(buNeslinEnIyibireyi.Kromozom[i].ToString() + "-");
            }

            listBox1.Items.Add("Son Çözüm Mesafesi: " + buNeslinEnIyibireyi.Uygunluk);

            listBox1.Items.Add("Tur Detayı: " + sb);

        }

        public static double acceptanceProbability(int energy, int newEnergy, double temperature)
        {
            // Yeni çözüm daha iyi ise, kabul edin.
            if (newEnergy < energy)
            {
                return 1.0;
            }
            // Yeni çözümün daha kötü olması durumunda bir kabul olasılığı hesaplayın
            return Math.Exp((energy - newEnergy) / temperature);
        }

    }
}
