using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurrencyApp.DAL.Wallet;
//using System.Collections.Generic; // Para listas
//using System.Linq; // Para LINQ
using CurrencyApp.DAL; // Para acessar o contexto e as entidades
//using global::CurrencyApp.DAL;


namespace CurrencyApp.BLL
{
    // Construtor que inicializa o contexto
    public class BLLWallet
    {
        private readonly DALWallet _dalWallet;

        public BLLWallet()
        {
            _dalWallet = new DALWallet();
        }

        public void AddWallet(string name, decimal fixedExpenses, decimal fixedIncomes, decimal extraExpenses, decimal extraIncomes, decimal investment)
        {
            var wallet = new Wallet
            {
                Name = name,
                FixedExpenses = fixedExpenses,
                FixedIncomes = fixedIncomes,
                ExtraExpenses = extraExpenses,
                ExtraIncomes = extraIncomes,
                Investment = investment
            };

            _dalWallet.AddWallet(wallet);
        }

        public Wallet GetWalletByName(string name)
        {
            return _dalWallet.GetWalletByName(name);
        }

        public List<Wallet> GetAllWallets()
        {
            return _dalWallet.GetAllWallets();
        }

        public void UpdateWallet(int id, decimal fixedExpenses, decimal fixedIncomes, decimal extraExpenses, decimal extraIncomes, decimal investment)
        {
            var wallet = _dalWallet.GetWalletById(id);
            if (wallet != null)
            {
                wallet.FixedExpenses += fixedExpenses;
                wallet.FixedIncomes += fixedIncomes;
                wallet.ExtraExpenses += extraExpenses;
                wallet.ExtraIncomes += extraIncomes;
                wallet.Investment += investment;

                _dalWallet.UpdateWallet(wallet);
            }
        }

        public void DeleteWallet(string name)
        {
            var wallet = _dalWallet.GetWalletByName(name);
            if (wallet != null)
            {
                _dalWallet.DeleteWallet(wallet);
            }
        }

        public decimal GetTotalInvestments()
        {
            return _dalWallet.GetTotalInvestments();
        }
    }
}

