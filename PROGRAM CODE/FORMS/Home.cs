using PROJECT.Table;
using PROJECT.Table.PRODUCT;
using PROJECT.Table.PRODUCT.FOOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace PROJECT
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            fManageSell f = new fManageSell();
            f.MdiParent = Home.ActiveForm;
            pnlChildForm.Controls.Add( f );
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }    
        }
    }
}
