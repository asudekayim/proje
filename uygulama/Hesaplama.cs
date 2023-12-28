﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama
{
    internal class Hesaplama
    {
        string bilirKisi;
        double davaMiktari;
        int ID, tanikSayisi, avukatSayisi, tarafSayisi;

        public Hesaplama(string bilirKisi, double davaMiktari, int ID, int tanikSayisi, int avukatSayisi, int tarafSayisi)
        {
            this.bilirKisi = bilirKisi;
            this.davaMiktari = davaMiktari;
            this.ID = ID;
            this.tarafSayisi = tarafSayisi;
            this.avukatSayisi = avukatSayisi;
            this.tanikSayisi = tanikSayisi;
        }

        const double dosyaGideri = 13.95;
        const double kesif = 1912.35;
        const double shmBasvuruHarci = 123.60;
        const double ahmBasvuruHarci = 269.85;
        const double tanikUcreti = 60;
        const double vekaletSuretHarci = 38.40;

        //sulh ve icra = shm
        //diğerleri = ahm

        //public const double tebligat = 87; 
        //public const double bilirKisi1 = 580;
        //public const double bilirKisi2 = 960;
        //public const double bilirKisi3 = 770;
        //public const double bilirKisi4 = 1160;
        //public const double bilirKisi5 = 0;

        /* bilirkişi ücretleri
           1-)sulh hukuk , icra hukuk icra ceza 580
           2-)asliye hukuk 960
           3-)aile mahkemesi , iş mahkemesi , kadastro mahkemesi 770
           4-)fikri ve sinai , ticaret mahkemesi , denizcilik ihtisas 1160
           5-)tüketici mahkemesi 0
           
        */


        double BilirkisiUcreti()
        {
            if (bilirKisi == "bilirkisi1")
            {
                return 580;
            }
            else if (bilirKisi == "bilirkisi2")
            {
                return 960;
            }
            else if (bilirKisi == "bilirkisi3")
            {
                return 770;
            }
            else if (bilirKisi == "bilirkisi4")
            {
                return 1160;
            }
            return 0;
        }



        double nispiHarcHesapla()
        {
            return davaMiktari * 68.31 / 1000 / 4;
        }

        public double maktuHarcHesapla()
        {
            //maktu harcı girilen miktar üzerinden hesaplıyoruz
            double gelenMiktar = nispiHarcHesapla();
            if (gelenMiktar > 269.85)
            {
                return gelenMiktar;
            }

            return ahmBasvuruHarci;
        }


        double secilenMahkeme()
        {
            if ((ID == 0) || (ID == 1))
            {
                return shmBasvuruHarci;
            }
            else if ((ID == 2) || (ID == 3) || (ID == 4) || (ID == 5) || (ID == 6) || (ID == 7) || (ID == 8) || (ID == 9))
            {
                return ahmBasvuruHarci;
            }

            return 0;
        }

        double tanikUcretiHesapla(int tanikSayisi)
        {
            return tanikSayisi * tanikUcreti;
        }

        double bilirkisiUcretiHesapla(int cmbID, int bilirkisiSayisi)
        {
            if (cmbID == 0)
            {
                return 580 * bilirkisiSayisi;
            }
            return 0;
        }

        double avukatHarci(int avukatSayisi)
        {
            return avukatSayisi * vekaletSuretHarci;
        }

        double tebligatGideri()
        {
            return (tarafSayisi * 5 * 87) + 150;
        }
    }
}
