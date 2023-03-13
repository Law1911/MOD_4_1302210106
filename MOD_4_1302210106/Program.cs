// See https://aka.ms/new-console-template for more information
namespace MOD_4_1302210106
{
    class KodeBuah
    {
        Dictionary<String, String> dic_buah = new Dictionary<string, String>()
        {
            {"Apel","A00" },
            {"Aprikot", "B00"},
            {"Alpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "H00"},
            {"Kelapa", "I00"},
            {"jagung", "J00"},
            {"Kurma", "K00"},
            {"Durian", "L00"},
            {"Angggur", "M00"},
            {"Melon", "N00"},
            {"Semangka", "O00"},
        };

        public void getKodeBuah(String Buah)
        {
            if (dic_buah.ContainsKey(Buah))
            {
                Console.WriteLine(Buah + " : " + dic_buah[Buah]);
            }
            else
            {
                Console.WriteLine("Kode "+ Buah + " tidak terdaftar");
            }
        }


    }


    class Mainprogram
    {
        public static void Main(String[] args)
        {
            KodeBuah kode = new KodeBuah();
            Console.Write("Masukan Buah yang ingin dilihat Kode nya : ");
            String buah = Console.ReadLine();
            kode.getKodeBuah(buah);
        }
    }






}
