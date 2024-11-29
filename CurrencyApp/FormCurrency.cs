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
using System.Windows.Forms.DataVisualization.Charting;

namespace CurrencyApp
{
    public partial class FormCurrency : Form
    {
        public FormCurrency()
        {
            InitializeComponent();
        }
       
        private async void btnLoadList_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém as cotações da API
                var cotacoes = await Currency.ObterCotacao();

                // Preenche a ListBox com os nomes das moedas
                listBoxCoins.Items.Clear();
                foreach (var moeda in cotacoes.Keys)
                {
                    listBoxCoins.Items.Add(moeda); // Adiciona "USDBRL", "EURBRL", etc.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error to load the currency: {ex.Message}");
            }
        }

        private async void buttonShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se uma moeda foi selecionada
                if (listBoxCoins.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione uma moeda na lista.");
                    return;
                }

                // Obtém o nome da moeda selecionada (ex: "USDBRL")
                string moedaSelecionada = listBoxCoins.SelectedItem.ToString();

                // Obtém os dados das cotações
                var cotacoes = await Currency.ObterCotacao();

                // Verifica se a moeda está nos dados retornados
                if (cotacoes.ContainsKey(moedaSelecionada))
                {
                    // Obtém os detalhes da moeda selecionada
                    var detalhes = cotacoes[moedaSelecionada];

                    // Monta a string com as informações da moeda
                    string resultado = $"{moedaSelecionada}:\n";
                    foreach (var detalhe in detalhes)
                    {
                        resultado += $"{detalhe.Key}: {detalhe.Value}\n";
                    }

                    // Exibe as informações na label
                    labelResult.Text = resultado;
                }
                else
                {
                    MessageBox.Show("Information of the currency not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error to get the information: {ex.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            FormMenu f1 = new FormMenu();
            f1.Show();
            this.Close();
        }
    }
}