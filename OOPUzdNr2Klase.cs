using System;

namespace UzdNr2 {
    public class SekosSkaiciavimas // Sekos skaiciavimo klase
    {
        public SekosSkaiciavimas(int n)
        {
            Skaiciavimas(n);
            Example.Datetime();
        }

        static void Skaiciavimas(int n)
        {
            long pirmasSk = 1;
            long antrasSk = 2;
            for (int i = 2; i < n; i++)
            {
                long sk = pirmasSk * antrasSk;
                if (sk > 1000000000000000)
                {
                    Console.WriteLine("Eil. nr. atsakymo: " + i);
                    Console.WriteLine("Galutinis atsakymas: " + sk);
                }

                pirmasSk = antrasSk;
                antrasSk = sk;
            }
        }
    }
}
