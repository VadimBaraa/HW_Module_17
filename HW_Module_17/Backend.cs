using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_17
{
    internal class Backend
    {
        // Абстрактный базовый класс для учетной записи
        public abstract class Account
        {
            // Баланс учетной записи
            public double Balance { get; set; }

            // Процентная ставка
            public double Interest { get; protected set; }

            // Абстрактный метод для расчета процентной ставки
            public abstract void CalculateInterest();
        }

        // Обычная учетная запись
        public class RegularAccount : Account
        {
            public override void CalculateInterest()
            {
                // Основной расчет
                Interest = Balance * 0.4;

                // Коррекция процентной ставки
                if (Balance < 1000)
                {
                    Interest = Balance * 0.2;
                }
                else
                {
                    Interest = Balance * 0.4;
                }
            }
        }

        // Зарплатная учетная запись
        public class SalaryAccount : Account
        {
            public override void CalculateInterest()
            {
                Interest = Balance * 0.5;
            }
        }

        // Калькулятор
        public static class Calculator
        {
            public static void CalculateInterest(Account account)
            {
                account.CalculateInterest();
            }
        }

    }
}
