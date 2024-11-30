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


public class BLLWallet
{
    private readonly CurrencyDbContext _dbContext;

    // Construtor que inicializa o contexto
    public BLLWallet()
    {
        _dbContext = new CurrencyDbContext();
    }

    // Adiciona uma nova carteira
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

        _dbContext.Wallets.Add(wallet);
        _dbContext.SaveChanges(); // Salva as alterações no banco
    }

    // Retorna todas as carteiras
    public List<Wallet> GetAllWallets()
    {
        return _dbContext.Wallets.ToList(); // Retorna todas as carteiras do banco
    }
    // Busca uma carteira pelo nome
    public Wallet GetWalletByName(string name)
    {
        return _dbContext.Wallets.FirstOrDefault(w => w.Name == name);
    }

    // Atualiza uma carteira existente
    public void UpdateWallet(int id, string name, decimal fixedExpenses, decimal fixedIncomes, decimal extraExpenses, decimal extraIncomes, decimal investment)
    {
        var wallet = _dbContext.Wallets.FirstOrDefault(w => w.Id == id);
        if (wallet != null)
        {
            wallet.Name = name;
            wallet.FixedExpenses += fixedExpenses;
            wallet.FixedIncomes += fixedIncomes;
            wallet.ExtraExpenses += extraExpenses;
            wallet.ExtraIncomes += extraIncomes;
            wallet.Investment += investment;

            _dbContext.SaveChanges(); // Salva as alterações
        }
    }

    // Deleta uma carteira
    public void DeleteWallet(int id)
    {
        var wallet = _dbContext.Wallets.FirstOrDefault(w => w.Id == id);
        if (wallet != null)
        {
            _dbContext.Wallets.Remove(wallet); // Remove a carteira
            _dbContext.SaveChanges(); // Salva as alterações
        }
    }

    
    // Calcula o total de investimentos de todas as carteiras
    public decimal GetTotalInvestments()
    {
        return _dbContext.Wallets.Sum(w => w.Investment); // Soma os investimentos de todas as carteiras
    }
}

