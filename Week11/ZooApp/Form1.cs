using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class Form1: Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dog d = new Dog("개1", COLOR.BLACK, 1);
            Animal a = new Dog("개2", COLOR.WHITE, 1);
            // 추상 클래스는 단독 인스턴스 생성 불가능
            //Animal c = new Animal("동3", COLOR.WHITE);
            //Dog b = new Animal("동4", COLOR.WHITE);

            d.Bark(3);

            //a.Bark(3);
            ((Dog)a).Bark(3);

            tbxResult.Text = $"{a.Level} {d.Level}\r\n";
            a.Eat(); d.Eat(); // 오버라이딩
            tbxResult.Text += $"{a.Level} {d.Level}\r\n";
            a.Play(); d.Play(); // 하이딩
            tbxResult.Text += $"{a.Level} {d.Level}\r\n";
        }
    }
}
