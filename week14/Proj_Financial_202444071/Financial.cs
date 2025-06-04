using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Financial_202444071
{
    abstract class Financial
    {
        protected Dictionary<DateTime, Info> _incomes = new Dictionary<DateTime, Info>();
        protected Dictionary<DateTime, Info> _expenditures = new Dictionary<DateTime, Info>();

        public int TotalIncomes { get; }
        public int TotalExpenditures { get; }

        public virtual bool RegIncome(DateTime date, string content, int money)
        {
            if (money > 0)
            {
                Info info = new Info(content, money);
                _incomes.Add(date, info);
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool RegIncome(string content, int money)
        {
            if (money > 0)
            {
                Info info = new Info(content, money);
                _incomes.Add(DateTime.Now, info);
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool RegExpenditure(DateTime date, string content, int money)
        {
            if (money > 0)
            {
                Info info = new Info(content, money);
                _expenditures.Add(date, info);
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool RegExpenditure(string content, int money)
        {
            if (money > 0)
            {
                Info info = new Info(content, money);
                _expenditures.Add(DateTime.Now, info);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
