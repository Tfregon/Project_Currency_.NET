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
}
