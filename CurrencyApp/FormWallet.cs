using CurrencyApp.DAL;
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
    public partial class FormWallet : Form
    {
        public FormWallet()
        {
            InitializeComponent();
        }
        //Register Tab
        #region
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicializar o serviço de Wallet
                BLLWallet walletService = new BLLWallet();

                // Criar a carteira com os dados fornecidos
                string name = textBoxRegisterName.Text;
                decimal fixedExpenses = Convert.ToDecimal(textBoxRegisterExpenses.Text);
                decimal fixedIncomes = Convert.ToDecimal(textBoxRegisterIncomes.Text);
                decimal extraExpenses = Convert.ToDecimal(textBoxRegisterExtraExpenses.Text);
                decimal extraIncomes = Convert.ToDecimal(textBoxRegisterExtraIncomes.Text);
                decimal investment = Convert.ToDecimal(textBoxRegisterInvestments.Text);

                // Adicionar a carteira no banco
                walletService.AddWallet(name, fixedExpenses, fixedIncomes, extraExpenses, extraIncomes, investment);

                // Atualizar o ListBox com o nome da nova carteira
                listBoxWalletName.Items.Add(name);

                MessageBox.Show("Wallet registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering wallet: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegisterCancel_Click(object sender, EventArgs e)
        {
            textBoxRegisterName.Clear();
            textBoxRegisterExpenses.Clear();
            textBoxRegisterIncomes.Clear();
            textBoxRegisterExtraExpenses.Clear();
            textBoxRegisterExtraIncomes.Clear();
            textBoxRegisterInvestments.Clear();
        }

        private void buttonRegisterExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegisterHome_Click(object sender, EventArgs e)
        {
            FormMenu f1 = new FormMenu();
            this.Close();
            f1.Show();
        }

        #endregion

        private void buttonUpdateListName_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonLoadList_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicializar o serviço de Wallet
                BLLWallet walletService = new BLLWallet();

                // Obter todas as carteiras do banco de dados
                var wallets = walletService.GetAllWallets();

                // Limpar o ListBox antes de preencher
                listBoxWalletName.Items.Clear();

                // Adicionar os nomes das carteiras no ListBox
                foreach (var wallet in wallets)
                {
                    listBoxWalletName.Items.Add(wallet.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating wallet list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            if (listBoxWalletName.SelectedItem == null)
            {
                MessageBox.Show("Please select a wallet from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter o nome da wallet selecionada
            string selectedWalletName = listBoxWalletName.SelectedItem.ToString();

            // Buscar as informações da wallet
            BLLWallet walletService = new BLLWallet();
            var wallet = walletService.GetWalletByName(selectedWalletName);

            if (wallet != null)
            {
                // Exibir os detalhes da carteira no DataGridView
                var walletDetails = new List<Wallet> { wallet }; // Criar uma lista com um único item
                dataGridViewShowInfo.DataSource = null; // Limpar a fonte de dados anterior
                dataGridViewShowInfo.DataSource = walletDetails; // Definir a nova fonte de dados
            }
            else
            {
                MessageBox.Show("Wallet not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelpRegisterNewWallet_Click(object sender, EventArgs e)
        {
            string message = "This field it is to create a new wallet!";
            labelRegisterHelp.Text = message;
        }

        private void buttonHelpInsertInfo_Click(object sender, EventArgs e)
        {
            string message = "This field will add information to the previous informartion on a \n" +
                "choosen wallet, ex.: investments was 1000 + 1000 = 2000.";
            labelInsertInfoHelp.Text = message;
        }

        private void buttonLoadListInsertInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicializar o serviço de Wallet
                BLLWallet walletService = new BLLWallet();

                // Obter todas as carteiras do banco de dados
                var wallets = walletService.GetAllWallets();

                // Limpar o ListBox antes de preencher
                listBoxInsertInfo.Items.Clear();

                // Adicionar os nomes das carteiras no ListBox
                foreach (var wallet in wallets)
                {
                    listBoxInsertInfo.Items.Add(wallet.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating wallet list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        { 
            textBoxInsertExpenses.Clear();
            textBoxInsertIncomes.Clear();
            textBoxInsertExtraEx.Clear();
            textBoxInsertExtraInc.Clear();
            textBoxInsertInvest.Clear();
        }

        private void buttonInsertRegister_Click(object sender, EventArgs e)
        {
            {
                if (listBoxInsertInfo.SelectedItem == null)
                {
                    MessageBox.Show("Please select a wallet from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obter o nome da wallet selecionada
                string selectedWalletName = listBoxInsertInfo.SelectedItem.ToString();

                // Buscar a carteira pelo nome
                BLLWallet walletService = new BLLWallet();
                var wallet = walletService.GetWalletByName(selectedWalletName);

                if (wallet != null)
                {
                    try
                    {
                        // Coletar os valores adicionais do usuário
                        decimal extraFixedExpenses = Convert.ToDecimal(textBoxInsertExpenses.Text);
                        decimal extraFixedIncomes = Convert.ToDecimal(textBoxInsertIncomes.Text);
                        decimal extraExtraExpenses = Convert.ToDecimal(textBoxInsertExtraEx.Text);
                        decimal extraExtraIncomes = Convert.ToDecimal(textBoxInsertExtraInc.Text);
                        decimal extraInvestment = Convert.ToDecimal(textBoxInsertInvest.Text);

                        // Atualizar a carteira
                        walletService.UpdateWallet(wallet.Id,wallet.Name,extraFixedExpenses, extraFixedIncomes, extraExtraExpenses, extraExtraIncomes, extraInvestment);

                        MessageBox.Show("Information added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wallet not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonShowInfoHome_Click(object sender, EventArgs e)
        {
            FormMenu f1 = new FormMenu();
            f1.Show();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            if (listBoxWalletName.SelectedItem == null)
            {
                MessageBox.Show("Please select a wallet from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter o nome da wallet selecionada
            string selectedWalletName = listBoxWalletName.SelectedItem.ToString();

            // Deleta a Wallet
            BLLWallet walletService = new BLLWallet();
            int idToDelete = walletService.GetWalletIdByName(selectedWalletName);
            walletService.DeleteWallet(idToDelete);
        }

        private void buttonAllInvestmentos_Click(object sender, EventArgs e)
        {
            BLLWallet walletTotalInvest = new BLLWallet();
            string resultOfAllinvestmentsWallets =(Convert.ToString(walletTotalInvest.GetTotalInvestments()));
            MessageBox.Show($"The sum of all investments in all wallets are: {resultOfAllinvestmentsWallets}");
        }
    }
}
