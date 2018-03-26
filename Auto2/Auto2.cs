using System;

namespace KlassenDefinieren
{
    public class Auto
    {
        private string marke;
        public int alterInJahren;
        private int aktuelleGeschwindigkeit;

        public Auto(string autoMarke)
        {
            if (autoMarke == "Porsche")
            {
                marke = autoMarke;
            }
            else
            {
                marke = "Nicht unterstützt!!";
            }

            alterInJahren = 0;
            aktuelleGeschwindigkeit = 0;
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
