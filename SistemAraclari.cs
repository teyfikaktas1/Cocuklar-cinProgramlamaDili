using System;
using System.Collections.Generic;
using System.Text;

namespace CocuklarİcinProgramlamaDili
{
    public static class SistemAracları
    {
        public static void KonsoluEkrandaTut()
        {
            Console.ReadKey();
        }
        public static void EkranaYazdir()
        {
            Console.WriteLine("Herhangi Bir Şey göndermediniz.Lütfen Herhangi bir şey göndermeyi deneyiniz.");

        }
        public static void EkranaYazdir(String S)
        {
            Console.WriteLine(S);

        }
        public static void EkranaYazdir(int S)
        {
            Console.WriteLine(S);

        }
        public static void EkranaYazdir(float S)
        {
            Console.WriteLine(S);

        }
        static public float Hafıza1 = 0; static public float Hafıza2 = 0;
        static public float Hafıza3 = 0; static public float Hafıza4 = 0;

        public static float HafizadaTut(float a)
        {
            Hafıza1 = a;
            return a;
        }
        public static float HafizadaTut()
        {
            return 0;
        }
        public static float HafizadaTut2()
        {
            return 0;

        }
        public static float HafizadaTut3()
        {

            return 0;

        }
        public static float HafizadaTut4()
        {
            return 0;
        }
        public static float HafizadaTut2(float a)
        {
            Hafıza2 = a;
            return a;
        }
        public static float HafizadaTut3(float a)
        {
            Hafıza3 = a;
            return a;
        }
        public static float HafizadaTut4(float a)
        {
            Hafıza4 = a;
            return a;
        }
        public static void Hafıza1Temizle()
        {
            Hafıza1 = 0;
        }
        public static void Hafıza2Temizle()
        {
            Hafıza2 = 0;
        }
        public static void Hafıza3Temizle()
        {
            Hafıza3 = 0;
        }
        public static void Hafıza4Temizle()
        {
            Hafıza4 = 0;
        }
        public static void TümHafızalarıTemizle()
        {
            Hafıza1 = 0;
            Hafıza2 = 0;
            Hafıza3 = 0;
            Hafıza4 = 0;
        }


    }
    
}
