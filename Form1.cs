using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipart_Ovn_2_4
{
    public partial class frmClipart : Form
    {
        List<Figur> figurer = new List<Figur>();

        public frmClipart()
        {
            InitializeComponent();
        }

        private void btnTriangel_Click(object sender, EventArgs e)
        {
            float bredd;
            float höjd;
            bool breddOk = float.TryParse(tbxBredd.Text, out bredd);
            bool höjdOk = float.TryParse(tbxHöjd.Text, out höjd);

            if (breddOk && höjdOk)
            {
                Triangel triangel = new Triangel(bredd, höjd);
                figurer.Add(triangel);
                lbxFigurer.Items.Add(triangel.ToString());
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
                lbxFigurer.Items.Add(cirkel.ToString());
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
                Linje linje = new Linje(bredd, höjd);
                figurer.Add(linje);
                lbxFigurer.Items.Add(linje.ToString());
            }
        }

        private void btnSummeraArea_Click(object sender, EventArgs e)
        {
            float summa = 0;

            foreach (Figur figur in figurer)
            {
                //--------------------------------------
                if (figur is Triangel)
                {
                    summa += (figur as Triangel).BeräknaArea();
                }
                else if (figur is Cirkel)
                {
                    summa += (figur as Cirkel).BeräknaArea();
                }

            }

            tbxArea.Text = Math.Round(summa, 2).ToString() + " Kvadratmeter";
        }
    }
}
