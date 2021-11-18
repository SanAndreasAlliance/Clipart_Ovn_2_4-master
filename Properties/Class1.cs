using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
        class Figur
        {
            public float bredd;
            public float höjd;

            public Figur(float bredd, float höjd)
            {
                this.bredd = bredd;
                this.höjd = höjd;
            }
        }

        class Triangel : Figur
        {
            public Triangel(float bredd, float höjd) : base(bredd, höjd)
            {

            }

            public float BeräknaArea()
            {
                return (bredd * höjd) / 2;
            }

            public override string ToString()
            {
                return "Triangel: " + bredd + " x " + höjd;
            }
        }

        class Cirkel : Figur
        {
            public Cirkel(float bredd, float höjd) : base(bredd, höjd)
            {

            }

            public float BeräknaArea()
            {
                return bredd * (float)Math.PI;
            }

            public override string ToString()
            {
                return "Cirkel: " + bredd + " x " + höjd;
            }
        }

        class Linje : Figur
        {
            public Linje(float bredd, float höjd) : base(bredd, höjd)
            {

            }

            public override string ToString()
            {
                return "Triangel: " + bredd + " x " + höjd;
            }
        }
}
