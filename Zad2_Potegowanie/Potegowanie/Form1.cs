using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Potegowanie
{
    public partial class Form1 : Form
    {
        private readonly POW_Check FormaLiczenia = new POW_Check(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            IRequest oblicz = null;      
            oblicz = new Iteracyjny { podstawa = (long)this.Podstawa.Value, wykladnik = (long)this.Wykladnik.Value };
            var rezultat = this.FormaLiczenia.WykonajMetode(oblicz);
            this.WynikObliczen.Text = rezultat.Wynik.ToString();
            this.CzasObliczen.Text = rezultat.CzasWykonania.TotalMilliseconds.ToString() + " ms";
            this.UndoButton.Enabled = true;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {            
            var danePoprzednie = FormaLiczenia.PobierzOstatnia();
            if (danePoprzednie != null)
            {
                this.Podstawa.Value = danePoprzednie.podstawa;
                this.Wykladnik.Value = danePoprzednie.wykladnik;
                this.WynikObliczen.Text = "";
            }
            else
            {
                this.UndoButton.Enabled = false;
            }
        }
    }
}
