using System;
using System.Windows.Forms;
using Accounting.App.Accounting;
using Accounting.Business;
using Accounting.Utilities.Conventor;
using Accounting.ViewModels.Accounting;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MonthlyReport();
            TotalReport();
            DateTime now = DateTime.Now;
            lblDate.Text = now.ToShamsi();

        }

        void MonthlyReport()
        {
            AccountingViewModel rp = Account.MonthlyReport();
            lblMonthlyPay.Text = rp.Pay.ToString("#,0");
            lblMonthlyRecieve.Text = rp.Recieve.ToString("#,0");
            lblMonthlyBalance.Text = rp.AccountBalance.ToString("#,0");
        }

        void TotalReport()
        {
            AccountingViewModel rp = Account.TotalReport();
            lblTotalPay.Text = rp.Pay.ToString("#,0");
            lblTotalRecieve.Text = rp.Recieve.ToString("#,0");
            lblTotalBalance.Text = rp.AccountBalance.ToString("#,0");
        }

        private void newTransaction_Click(object sender, EventArgs e)
        {
            frmNewTransaction frm = new frmNewTransaction();
            frm.ShowDialog();

        }

        private void btnReportPay_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.typeId = 2;
            frm.ShowDialog();

        }

        private void btnReportRecieve_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.typeId = 1;
            frm.ShowDialog();
        }

        private void lblTimeTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }



        private void monthlyReportBtn_Click(object sender, EventArgs e)
        {
            frmReportsDetails frm = new frmReportsDetails();
            frm.typeId = 0;
            frm.ShowDialog();
        }

        private void totalReportBtn_Click(object sender, EventArgs e)
        {
            frmReportsDetails frm = new frmReportsDetails();
            frm.typeId = 1;
            frm.ShowDialog();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
