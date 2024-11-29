using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp.BLL
{
    internal class CalcCi
    {
        // Classe para cálculo de juros compostos sem aportes
        public class CompoundInterest
        {
            public double Calculate(double principal, double yearlyRate, int months)
            {
                double monthlyRate = yearlyRate / 100/ 12;  // Converte taxa anual para mensal
                int totalMonths = months; // Total de meses
                return principal * Math.Pow(1 + monthlyRate, totalMonths);
            }
        }

        // Classe para cálculo de juros compostos com aportes mensais
        public class CompoundInterestWithDeposits
        {
            public double Calculate(double principal, double monthlyDeposit, double annualRate, int months, out double totalInvested)
            {
                double monthlyRate = annualRate / 100 / 12; // Converte taxa anual para mensal
                int totalMonths = months; // Total de meses
                double futureValue = principal * Math.Pow(1 + monthlyRate, totalMonths); // Valor futuro do principal

                // Calcula o valor total aportado
                totalInvested = principal + (monthlyDeposit * totalMonths);

                // Soma dos valores futuros dos aportes mensais
                for (int i = 1; i <= totalMonths; i++)
                {
                    futureValue += monthlyDeposit * Math.Pow(1 + monthlyRate, totalMonths - i);
                }

                return futureValue;
            }

        }
    }
}
