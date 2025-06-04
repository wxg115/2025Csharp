using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Financial_202444071
{
    public partial class Form1: Form
    {
        public string PATH
        {
            get
            {
                var path = "c:\\C_Class";
                if (false == Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                return path;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetYearNewReset_Click(object sender, EventArgs e)
        {
            tbxSetYearYear.Text = "";
            tbxSetYearTargetAmount.Text = "";
        }

        private void btnSetYearSave_Click(object sender, EventArgs e)
        {

        }
    }
}
