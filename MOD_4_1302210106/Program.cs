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

            Console.WriteLine("=============================Status player===========================");

            PosisiKarakterGame player = new PosisiKarakterGame();
            player.gerak();
        }
    }




    class PosisiKarakterGame
    {
        enum State {Jongkok, Tengkurap, Berdiri, Terbang };

        public void gerak()
        {
            State state = State.Jongkok;
            String[] Player_stat = { "Jongkok", "Tengkurap", "Berdiri", "Terbang" };


            while (true)
            {

                Console.WriteLine("Posisi player " + Player_stat[(int)state]);
                Console.Write("Masukan : ");
                String keyword = Console.ReadLine();
                switch (state)
                {
                    case State.Tengkurap:
                        if (keyword == "W")
                        {
                            Console.WriteLine("Posisi istirahat");
                            state = State.Jongkok;
                        }
                        break;
                case State.Jongkok:
                        if (keyword == "W")
                        {
                            state= State.Berdiri;
                        }
                        if (keyword == "S")
                        {
                            state = State.Tengkurap;
                        }
                        break;
                 case State.Berdiri:
                        if (keyword == "W")
                        {
                            state = State.Terbang; 
                            Console.WriteLine("Posisi Standby");
                        }
                        if (keyword == "S")
                        {
                            state = State.Jongkok;
                        }
                        break;
                 case State.Terbang:
                        
                        if (keyword == "S")
                        {
                            state = State.Berdiri;
                        }
                        if (keyword == "x")
                        {
                            state = State.Jongkok;
                        }
                        break;

                }
              



            }
        }
    }




}
