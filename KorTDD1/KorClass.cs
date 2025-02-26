using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace KorTDD

{

    public class KorClass

    {

        public double sugar = 0.0,

            kerulet = 0.0,

            terulet = 0.0;

        public KorClass(double r) { this.sugar = r; }

        public void setSugar(double r) { this.sugar = r; }

        public double setKerulet(double r)
        { //return this.kerulet = 2 * r * Math.PI;

            return 2 * this.sugar *Math.Round( Math.PI,2);

        }

        public double setTerulet(double r)
        {// return this.kerulet = 2 * r * Math.PI;

            return 0;

        }

        public double getsugar() { return sugar; }

        public double getterulet() { return kerulet; }
    }

}

