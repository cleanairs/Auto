using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDefinieren
{

    class Program
    {
        static void Main(string[] args)
        {
            Auto deinAuto = new Auto("Audi");
            Auto meinAuto = new Auto("Porsche");
            

            meinAuto.alterInJahren = 13;
            deinAuto.alterInJahren = 1;
            
            Console.WriteLine("Mein Auto fährt aktuell {0} km/h.", meinAuto.sageAktuelleGeschwindikeit());
            Console.WriteLine("Dein Auto fährt aktuell {0} km/h.", deinAuto.sageAktuelleGeschwindikeit());
            meinAuto.BeschleunigeAuf100KmH();
            deinAuto.BeschleunigeAuf100KmH();
            Console.WriteLine("Mein Auto fährt aktuell {0} km/h.", meinAuto.sageAktuelleGeschwindikeit());
            Console.WriteLine("Dein Auto fährt aktuell {0} km/h.", deinAuto.sageAktuelleGeschwindikeit());


            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
