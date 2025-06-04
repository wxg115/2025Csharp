using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Financial_202444071
{
    class Info
    {
        public string Content { get; set; }
        public int Money { get; set; }

        public Info(string content, int money)
        {
            this.Content = content;
            this.Money = money;
        }

        public override string ToString()
        {
            return $"{Content},{Money}";
        }
    }
}
