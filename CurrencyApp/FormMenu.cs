using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyApp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonCurrecnyPair_Click(object sender, EventArgs e)
        {
            FormCurrency formCurrency = new FormCurrency();
            this.Hide();
            formCurrency.Show();
        }

        private void buttonCaulcCI_Click(object sender, EventArgs e)
        {
            FormCalcCI formCalcCI = new FormCalcCI();
            this.Hide();
            formCalcCI.Show();
        }
    }
}
