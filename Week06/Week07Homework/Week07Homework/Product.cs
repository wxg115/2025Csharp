using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07Homework
{
    internal class Product
    {
        public string productCode;
        public string productName;
        public int productPrice;
        public int productCount;
        public DateTime productRegDate;

        public override string ToString()
        {
            return $"[{this.productCode}] {this.productName}";
        }

        public int SalePrice()
        {
            if (DateTime.Now > this.productRegDate.AddDays(30))
            {
                return (int)(this.productPrice * 0.8);
            }
            else
            {
                return this.productPrice;
            }
        }

        public int CalPrice(int count)
        {
            return count * SalePrice();
        }
    }
}
