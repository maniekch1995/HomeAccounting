using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccounting
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncomes_Click(object sender, EventArgs e)
        {
            frmIncomes frm = new frmIncomes();
            frm.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayments frm = new frmPayments();
            frm.ShowDialog();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCharts_Click_1(object sender, EventArgs e)
        {
            frmCharts frm = new frmCharts("",null,null,true);
            frm.ShowDialog();
        }
    }
}
