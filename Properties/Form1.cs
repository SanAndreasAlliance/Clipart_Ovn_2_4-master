using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        List<Figur> figurer = new List<Figur>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTriangel_Click(object sender, EventArgs e)
        {
            float bredd;
            float höjd;
            bool breddOk = float.TryParse(tbxBredd.Text, out bredd);
            bool höjdOk = float.TryParse(tbxHöjd.Text, out höjd);

            if(breddOk && höjdOk)
            {
                Triangel triangel = new Triangel(bredd, höjd);
                figurer.Add(triangel);
                lbxFigurLista.Items.Add(triangel.ToString());
            }
        }

        private void btnCirkel_Click(object sender, EventArgs e)
        {
            float bredd;
            float höjd;
            bool breddOk = float.TryParse(tbxBredd.Text, out bredd);
            bool höjdOk = float.TryParse(tbxHöjd.Text, out höjd);

            if (breddOk && höjdOk)
            {
                Cirkel cirkel = new Cirkel(bredd, höjd);
                figurer.Add(cirkel);
                lbxFigurLista.Items.Add(cirkel.ToString());
            }
        }

        private void btnLinje_Click(object sender, EventArgs e)
        {
            float bredd;
            float höjd;
            bool breddOk = float.TryParse(tbxBredd.Text, out bredd);
            bool höjdOk = float.TryParse(tbxHöjd.Text, out höjd);

            if (breddOk && höjdOk)
            {
                Linje linje= new Linje(bredd, höjd);
                figurer.Add(linje);
                lbxFigurLista.Items.Add(linje.ToString());
            }
        }

        public void btnArea_Click(object sender, EventArgs e)
        {
            float summa = 0;

            foreach(Figur figur in figurer)
            {
                //--------------------------------------
                if(figur is Triangel)
                {
                    summa += (figur as Triangel).BeräknaArea();
                }
                else if(figur is Cirkel)
                {
                    summa += (figur as Cirkel).BeräknaArea();
                }

            }

            tbxArea.Text = Math.Round(summa, 2).ToString() + " Kvadratmeter";
        }
    }
}
