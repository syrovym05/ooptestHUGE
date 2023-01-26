using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUGEtestOOP
{
    class Hrac : HerniPostava
    {
        public int xp;
        string specializace;
        int oblicej;
        int vlasy;
        int barvavlasu;

        public string Specializace { get => specializace; set => specializace = value; }

        enum Oblicej
        {
            velkynos, usoplesk, makeup
        }
        enum Vlasy
        {
            drdol, culik, pleska
        }
        enum BarvaVlasu
        {
            kastanova, blond, červena
        }


        public Hrac(string jmeno, string specializace, int oblicej, int vlasy, int barvavlasu) : base(jmeno)
        {
            this.specializace = Specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvavlasu = barvavlasu;
        }
        
        public void PridejXP(int x)
        {
            xp += x;
            if (xp >= 100 * level)
            {
                level++;
                xp = 0;
            }
        }

        

        public override string ToString()
        {

            Oblicej face = new Oblicej();
            Vlasy hair = new Vlasy();
            BarvaVlasu dye = new BarvaVlasu();
            switch (oblicej)
            {
                case 0: face = Oblicej.velkynos; break;
                case 1: face = Oblicej.usoplesk; break;
                case 2: face = Oblicej.makeup; break;
            }
            switch (vlasy)
            {
                case 0: hair = Vlasy.drdol; break;
                case 1: hair = Vlasy.culik; break;
                case 2: hair = Vlasy.pleska; break;
            }
            switch (barvavlasu)
            {
                case 0: dye = BarvaVlasu.kastanova; break;
                case 1: dye = BarvaVlasu.blond; break;
                case 2: dye = BarvaVlasu.červena; break;
            }

            return base.ToString() + String.Format("\nXP: {0}\nOblicej: {1}\nVlasy: {2}\nBarva vlasu: {3}\n", xp, face,hair,dye );
        }



    }
}
