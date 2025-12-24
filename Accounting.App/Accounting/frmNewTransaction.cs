using System;
using System.Windows.Forms;
using Accounting.DataLayer.Context;

using ValidationComponents;


namespace Accounting.App
{



    public partial class frmNewTransaction : Form
    {
        UnitOfWork db;
        public int accountId = 0;
        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dgCustomers.AutoGenerateColumns = false;
            dgCustomers.DataSource = db.CustomerRepository.GetNameCustomers();
            if (accountId != 0)
            {
                var account = db.AccountingRepository.GetById(accountId);
                txtAmount.Text = account.Amount.ToString();
                txtDescription.Text = account.Description;
                txtName.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
                if (account.TypeID == 1)
                {
                    rbRecieve.Checked = true;
                }
                else
                {
                    rbPay.Checked = true;
                }
                this.Text = "ویرایش";
                btnSave.Text = "ویرایش";
                db.Dispose();
            }
        }

        private void filterCustomer_TextChanged(object sender, EventArgs e)
        {
            dgCustomers.AutoGenerateColumns = false;
            dgCustomers.DataSource = db.CustomerRepository.GetNameCustomers(filterCustomer.Text);
        }

        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgCustomers.CurrentRow.Cells[0].Value.ToString();
            txtId.Text = dgCustomers.CurrentRow.Cells[1].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            db = new UnitOfWork();
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbRecieve.Checked)
                {
                    db = new UnitOfWork();
                    DataLayer.Accounting accounting = new DataLayer.Accounting()
                    {

                        Amount = int.Parse(txtAmount.Value.ToString()),
                        CustomerID = db.CustomerRepository.GetCustomerIdByName(txtName.Text),
                        TypeID = (rbRecieve.Checked) ? 1 : 2,
                        DateTime = DateTime.Now,
                        Description = txtDescription.Text,
                    };
                    if (accountId == 0)
                    {
                        db.AccountingRepository.InsertAccount(accounting);

                    }
                    else
                    {
                        accounting.ID = accountId;
                        db.AccountingRepository.Update(accounting);
                    }
                    db.Save();
                    db.Dispose();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را حساب کنید");
                }
            }
        }
    }
}
