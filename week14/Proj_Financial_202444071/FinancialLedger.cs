using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Financial_202444071
{
    class FinancialLedger : Financial
    {
        private int _year;
        private int _targetAmount;

        public int Year { get { return _year; } }
        public int TargetAmount { get { return _targetAmount; } }
        public bool IsBlack
        { 
            get 
            {
                if ()
                {

                }
            } 
        }

        public FinancialLedger(int year)
        {
            _year = year;
        }
        public FinancialLedger(int year, int targetAmount)
        {
            _year = year;
            _targetAmount = targetAmount;
        }

        public override bool RegIncome(DateTime date, string content, int money)
        {
            return base.RegIncome(date, content, money);
        }
        public override bool RegIncome(string content, int money)
        {
            return base.RegIncome(DateTime.Now, content, money);
        }
        public override bool RegExpenditure(DateTime date, string content, int money)
        {
            return base.RegExpenditure(date, content, money);
        }
        public override bool RegExpenditure(string content, int money)
        {
            return base.RegExpenditure(DateTime.Now, content, money);
        }
    }
}
