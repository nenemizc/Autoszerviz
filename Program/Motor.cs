using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Motor : Jarmu
    {
        private int kerekekSzama;
        public int KerekekSzama { get => kerekekSzama; set { if (value < 0) { kerekekSzama = 0; } else if (value > 2) { kerekekSzama = 2; } else { kerekekSzama = value; } } }

        public Motor(string rendszam, int kor, int kilometerOra, int uzemanyagSzint) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            this.kerekekSzama = 2;
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves motor, {KilometerOra} km-rel, kerekek száma: {KerekekSzama}.");
        }

        public override void Szervizel(int dij)
        {
            KerekekSzama = 2;
            base.Szervizel(dij);
        }
    }
}
