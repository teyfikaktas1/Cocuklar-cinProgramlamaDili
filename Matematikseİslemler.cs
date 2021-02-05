using System;
using System.Collections.Generic;
using System.Text;

namespace CocuklarİcinProgramlamaDili
{
    public static class Matematikselİslemler
    {
        public static float toplam = 0;
        public static float toplamCP = 1;
        public static float Yuzdesonuc = 0;
        public static float KalanSonuc = 0;




        public static float Toplama(params float[] İslemler)
        {
            for (int i = 0; i < İslemler.Length; i++)

            {

                toplam += İslemler[i];

            }
            return toplam;
        }
        public static float Çıkarma(params float[] İslemler)
        {
            for (int i = 0; i < İslemler.Length; i++)

            {

                toplam -= İslemler[i];

            }
            return toplam;
        }
        public static float Çarpma(params float[] İslemler)
        {
            for (int i = 0; i < İslemler.Length; i++)

            {

                toplamCP *= İslemler[i];

            }
            return toplamCP;
        }
        public static float Bölme(params float[] İslemler)
        {
            for (int i = 0; i < İslemler.Length; i++)

            {

                toplamCP /= İslemler[i];

            }
            return toplamCP;
        }
        public static float YüzdeAl(float sayi, float yüzde)
        {
            Yuzdesonuc = ((sayi * yüzde / 100));

            return Yuzdesonuc;
        }
        public static float KalanBul(float sayi, float yüzde)
        {
            KalanSonuc = sayi % yüzde;
            return KalanSonuc;

        }
        public static void ToplamTemizle()
        {
            Matematikselİslemler.toplam = 0;
        }
        public static class İleriMatematikselİslemler
        {


            public static float KareKokAl(float degisken)
            {

                float KareKokDegisken = (float)Math.Sqrt(degisken);
                return KareKokDegisken;
            }
            public static float MutlakDegerAl(float degisken)
            {

                float MutlakDeger = (float)Math.Abs(degisken);
                return MutlakDeger;
            }
            public static float ÜsAl(float a, float b)
            {

                float MutlakDeger = (float)Math.Pow(a, b);
                return MutlakDeger;
            }
            public static float LogaritmaAl(float a)
            {

                float MutlakDeger = (float)Math.Log10(a);
                return MutlakDeger;
            }

            public static float YuvarlamaYap(float a)
            {

                float MutlakDeger = (float)Math.Round(a);
                return MutlakDeger;
            }
        }
    }
    }