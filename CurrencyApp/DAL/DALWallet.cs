using System; // Funcionalidades gerais do .NET
using System.Collections.Generic; // Coleções genéricas
using System.Collections.ObjectModel; // Coleções observáveis
using System.Data.Entity; // Necessário para Entity Framework e .Load()
using System.Linq; // Operações LINQ
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp.DAL
{
    // Contexto do banco de dados
    public class CurrencyDbContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; } // Representa a tabela Wallets no banco

        // Construtor para usar a string de conexão definida no App.config
        public CurrencyDbContext() : base("CurrencyDbContext") { }
    }

    // Classe que representa a tabela Wallets no banco
    public class Wallet
    {
        public int Id { get; set; } // Primary key
        public string Name { get; set; } // Nome do usuário ou carteira
        public decimal FixedExpenses { get; set; } // Despesas fixas
        public decimal FixedIncomes { get; set; } // Receitas fixas
        public decimal ExtraExpenses { get; set; } // Despesas extras
        public decimal ExtraIncomes { get; set; } // Receitas extras
        public decimal Investment { get; set; } // Investimento do mês
    }
    public class DALWallet
    {
        private readonly CurrencyDbContext _dbContext;

        public DALWallet()
        {
            _dbContext = new CurrencyDbContext();
        }

        public void AddWallet(Wallet wallet)
        {
            _dbContext.Wallets.Add(wallet);
            _dbContext.SaveChanges();
        }

        public Wallet GetWalletById(int id)
        {
            return _dbContext.Wallets.FirstOrDefault(w => w.Id == id);
        }

        public Wallet GetWalletByName(string name)
        {
            return _dbContext.Wallets.FirstOrDefault(w => w.Name == name);
        }

        public List<Wallet> GetAllWallets()
        {
            return _dbContext.Wallets.ToList();
        }

        public void UpdateWallet(Wallet wallet)
        {
            _dbContext.Entry(wallet).State = System.Data.Entity.EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteWallet(Wallet wallet)
        {
            _dbContext.Wallets.Remove(wallet);
            _dbContext.SaveChanges();
        }

        public decimal GetTotalInvestments()
        {
            return _dbContext.Wallets.Sum(w => w.Investment);
        }
    }
}