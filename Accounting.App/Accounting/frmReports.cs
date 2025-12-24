using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using Accounting.Utilities.Conventor;
using Accounting.ViewModels.Customers;

namespace Accounting.App
{
    public partial class frmReports : Form
    {

        public int typeId = 0;
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, System.EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomersViewModel> list = new List<ListCustomersViewModel>();
                list.Add(new ListCustomersViewModel()
                {
                    CustomerID = 0,
                    FullName = "همه موارد",
                });
                list.AddRange(db.CustomerRepository.GetNameCustomers());
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
            }

            Filter();
            if (typeId == 1)
            {
                this.Text = "گزارش دریافتی ها";
            }
            else
            {
                this.Text = "گزارش پرداختی ها";
            }
        }

        private void btnFilter_Click(object sender, System.EventArgs e)
        {
            Filter();
        }

        void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();
                DateTime? startDate;
                DateTime? endDate;

                if ((int)cbCustomer.SelectedValue == 0)
                {
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID == typeId));
                }
                else
                {
                    int customerId = (int)cbCustomer.SelectedValue;
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID == typeId && a.CustomerID == customerId));
                }

                if (txtFromDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtFromDate.Text);
                    startDate = DateConventor.ToMiladi(startDate.Value);
                    result = result.Where(r => r.DateTime >= startDate.Value).ToList();
                }
                if (txtToDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txtToDate.Text);
                    endDate = DateConventor.ToMiladi(endDate.Value);
                    result = result.Where(r => r.DateTime <= endDate.Value).ToList();
                }

                dgReport.Rows.Clear();
                int total = 0;
                foreach (var accouting in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(accouting.CustomerID);
                    dgReport.Rows.Add(accouting.ID, customerName, accouting.Amount, accouting.DateTime.ToShamsi());

                    total += accouting.Amount;
                }

                txtTotal.Text = total.ToString();
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                frmNewTransaction frm = new frmNewTransaction();
                frm.accountId = id;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void cbCustomer_DropDownClosed(object sender, System.EventArgs e)
        {
            Filter();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");

            foreach (DataGridViewRow item in dgReport.Rows)
            {
                dtPrint.Rows.Add(
                    item.Cells[0].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString()
                    );
            }

            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT", dtPrint);
            stiPrint.Show();


        }
    }
}
