using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Python.Runtime;

namespace CurrencyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }
                
        private void buttonBTCBRL_Click(object sender, EventArgs e)
        {
            // Carrega as informações da cotação
            string resultBTCBRL = BTCBRL.ObterCotacaoBTCBRL();
            // Exibe na label
            labelResult.Text = resultBTCBRL;
        }

        private void buttonEURBRL_Click(object sender, EventArgs e)
        {
            // Carrega as informações da cotação
            string resultEURBRL = EURBRL.ObterCotacaoEURBRL();
            // Exibe na label
            labelResult.Text = resultEURBRL;
        }

        private void buttonUSDBRL_Click(object sender, EventArgs e)
        {
            // Carrega as informações da cotação
            string resultUSDBRL = USDBRL.ObterCotacaoUSDBRL();
            // Exibe na label
            labelResult.Text = resultUSDBRL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}