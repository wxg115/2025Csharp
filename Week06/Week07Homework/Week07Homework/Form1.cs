using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week07Homework
{
    public partial class Form1 : Form
    {
        List<Product> products;

        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (tbxInputProductName.Text.Trim() == "")
            {
                MessageBox.Show("이름이 입력되지 않았습니다.");
                tbxInputProductName.Focus();
                return;
            }
            if (tbxInputProductPrice.Text.Trim() == ""
                && !int.TryParse(tbxInputProductPrice.Text, out int qqq))
            {
                MessageBox.Show("가격이 유효하지 않습니다.");
                tbxInputProductPrice.Focus();
                return;
            }
            if (tbxInputProductStock.Text.Trim() == ""
                && !int.TryParse(tbxInputProductStock.Text, out int www))
            {
                MessageBox.Show("재고가 유효하지 않습니다.");
                tbxInputProductStock.Focus();
                return;
            }

            Product product = new Product();
            product.productName = tbxInputProductName.Text.Trim();
            product.productPrice = int.Parse(tbxInputProductPrice.Text.Trim());
            product.productCount = int.Parse(tbxInputProductStock.Text.Trim());
            //-20일 ~ -99일
            DateTime d = DateTime.Now.AddDays(-(new Random()).Next(20, 100));
            product.productRegDate = d;
            //등록날짜 8자리 + 랜덤숫자 3자리
            string dateCode;
            bool isDuplicate;
            do {
                dateCode = d.ToString("yyyyMMdd") + new Random().Next(1000).ToString("D3");
                isDuplicate = false;
                foreach (var item in products)
                {
                    if (item.productCode == dateCode)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    break;
                }
            }
            while (true);

            product.productCode = dateCode;

            products.Add(product);
            MessageBox.Show("등록 완료");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxSearchProduct.Items.Clear();
            ClearSearchProduct();

            bool foundItems = false;
            foreach (var productsItem in products)
            {
                if (productsItem.productName.Contains(tbxSearchNameCode.Text.Trim().ToLower())
                    || productsItem.productCode.Contains(tbxSearchNameCode.Text.Trim().ToLower()))
                {
                    lbxSearchProduct.Items.Add(productsItem);
                    foundItems = true;
                }
            }
            if(foundItems == false)
            {
                MessageBox.Show("해당하는 상품이 존재하지 않습니다.");
            }
        }

        private void ClearSearchProduct()
        {
            lblSearchProductName.Text = "";
            lblSearchProductCode.Text = "";
            lblSearchProductPrice.Text = "";
            lblSearchProductSalePrice.Text = "";
            lblSearchProductStock.Text = "";
            lblSearchProductRegDate.Text = "";
            tbxSearchProductCount.Text = "";
            lblSearchProductTotalPrice.Text = "";
        }

        private void lbxSearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = lbxSearchProduct.SelectedItem;
            Product product = selectedItem as Product;
            lblSearchProductName.Text = product.productName;
            lblSearchProductCode.Text = product.productCode;
            lblSearchProductPrice.Text = product.productPrice.ToString();
            lblSearchProductSalePrice.Text = product.SalePrice().ToString();
            lblSearchProductStock.Text = product.productCount.ToString();
            lblSearchProductRegDate.Text = product.productRegDate.ToString("yyyy-MM-dd");
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            lblSearchProductTotalPrice.Text = "";
            var selectedItem = lbxSearchProduct.SelectedItem;
            Product product = selectedItem as Product;

            if (int.Parse(tbxSearchProductCount.Text) <= 0 
                || int.Parse(tbxSearchProductCount.Text) >= product.productCount)
            {
                MessageBox.Show("수량이 유효하지 않습니다.");
                return;
            }

            lblSearchProductTotalPrice.Text = product.CalPrice(int.Parse(tbxSearchProductCount.Text)).ToString();
        }

    }
}
