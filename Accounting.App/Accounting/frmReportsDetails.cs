using System.Windows.Forms;
using Accounting.Business;
using Accounting.ViewModels.Accounting;

namespace Accounting.App.Accounting
{
    public partial class frmReportsDetails : Form
    {

        public int typeId = 0;
        public frmReportsDetails()
        {
            InitializeComponent();
        }

        private void frmReportsDetails_Load(object sender, System.EventArgs e)
        {
            if (typeId == 1)
            {
                this.Text = "گزارش تمام ادوار";

                AccountingViewModel rp = Account.TotalReport();
                lblPay.Text = rp.Pay.ToString("#,0");
                lblRecieve.Text = rp.Recieve.ToString("#,0");
                lblBalance.Text = rp.AccountBalance.ToString("#,0");
            }
            else
            {
                this.Text = "گزارش تمام ادوار";

                AccountingViewModel rp = Account.MonthlyReport();
                lblPay.Text = rp.Pay.ToString("#,0");
                lblRecieve.Text = rp.Recieve.ToString("#,0");
                lblBalance.Text = rp.AccountBalance.ToString("#,0");
            }
        }
    }
}

