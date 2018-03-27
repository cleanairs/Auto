using System;

namespace KlassenDefinieren
{
    public class Auto
    {
        private int aktuelleGeschwindigkeit;
        private string marke;

        public Auto(string marke)
        {
            Marke = marke;
            AlterInJahren = 0;
            aktuelleGeschwindigkeit = 0;
        }

        public int AlterInJahren { get; set; }
                
        public string Marke
        {
            get { return marke; }
            set
            {
                if (value == "Porsche")
                {
                    marke = value;
                }
                else
                {
                    marke = "Nicht unterstützt!!!";
                }
            }
        } 

        public void BeschleunigeAuf100KmH()
        {
            aktuelleGeschwindigkeit = 100;

            if (IstSchnell())
            {
                Console.WriteLine("Der {0} hat schnell beschleunigt! Yeah!", marke);
            }
            else
            {
                Console.WriteLine("Der {0} hat normal beschleunigt!", marke);
            }
        }

        public int sageAktuelleGeschwindikeit()
        {
            return aktuelleGeschwindigkeit;
        }

        private bool IstSchnell()
        {
            if (marke == "Porsche")
            {
                return true;
            }
            return false;
        }

    }

}
