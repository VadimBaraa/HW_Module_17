using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW_Module_17.Backend;

namespace HW_Module_17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Создание обычного аккаунта
            Account regularAccount = new RegularAccount { Balance = 2500 };
            Calculator.CalculateInterest(regularAccount);
            Console.WriteLine($"Процентная ставка для первого обычного аккаунта: {regularAccount.Interest}");

            regularAccount = new RegularAccount { Balance = 500 };
            Calculator.CalculateInterest(regularAccount);
            Console.WriteLine($"Процентная ставка для второго обычного аккаунта: {regularAccount.Interest}");

            // Создание зарплатного аккаунта
            Account salaryAccount = new SalaryAccount { Balance = 4000 };
            Calculator.CalculateInterest(salaryAccount);
            Console.WriteLine($"Процентная ставка для зарплатного аккаунта: {salaryAccount.Interest}");
        }
    }
}