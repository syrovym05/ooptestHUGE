using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUGEtestOOP
{
    class HerniPostava
    {
        protected string jmeno;
        protected int level = 1;
        protected int poziceX = 0;
        protected int poziceY = 0;

        public string Jmeno
        {
            get => jmeno;

            set
            {
                if (value.Length > 10)
                {
                    MessageBox.Show("„Příliš dlouhé jméno!“", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                }
                else jmeno = value;
            }
        }

        public int PoziceX { get => poziceX; }
        public int PoziceY { get => poziceY; }

        public HerniPostava(string jmeno)
        {
            this.Jmeno = jmeno;
        }

        public virtual void ZmenaPozice()
        {
            poziceX += 4;
            poziceY += 7;
        }

        public override string ToString()
        {
            return String.Format("Jmeno: {0}\nLevel: {1}\nX: {2}\nY: {3}\n", jmeno, level, PoziceX, PoziceY);
        }
    }
}
