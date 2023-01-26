using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUGEtestOOP
{
    class NPC : HerniPostava
    {
        public string prace;
        public bool sila;

        public NPC(string jmeno, string prace, bool sila) :base(jmeno)
        {
            this.prace = prace;
            this.sila = sila;
        }

        public override sealed void ZmenaPozice()
        {
            poziceX = 50;
            poziceY = 50;
        }


        public override string ToString()
        {
            return base.ToString() + String.Format("\nPrace: {0}\nBoss: {1}\n", prace, sila == true ? "Ano" : "Ne");
        }
    }
}
