using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clipart_Ovn_2_4
{

    //Skapar variablerna för höjd och bredd och skapar en konstruktor för vad en figur är.
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
        //en konstruktor för vad en triangel är.
        public Triangel(float bredd, float höjd) : base(bredd, höjd)
        {

        }

        //En metod för hur triangels area ska beräknas.
        public float BeräknaArea()
        {
            return (bredd * höjd) / 2;
        }

        //En metod för vad som ska skrivas i listboxen.
        public override string ToString()
        {
            return "Triangel: " + bredd + " x " + höjd;
        }
    }

    class Cirkel : Figur
    {
        //en konstruktor för vad en cirkel är.
        public Cirkel(float bredd, float höjd) : base(bredd, höjd)
        {

        }

        //En metod för hur triangels area ska beräknas.
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