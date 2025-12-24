using System;
using System.IO;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmAddOrEditCustomer : Form
    {
        public int customerId = 0;

        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                pcCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string location = pcCustomer.ImageLocation;
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(location);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                };
                pcCustomer.Image.Save(path + imageName);
                Customers customer = new Customers()
                {
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Mobile = txtMobile.Text,
                    FullName = txtName.Text,
                    CustomerImage = imageName
                };

                using (UnitOfWork db = new UnitOfWork())
                {
                    if (customerId == 0)
                    {
                        db.CustomerRepository.InsertCustomer(customer);

                    }
                    else
                    {
                        customer.CustomerID = customerId;
                        db.CustomerRepository.UpdateCustomer(customer);
                    }
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var customer = db.CustomerRepository.GetCustomerById(customerId);
                    txtEmail.Text = customer.Email;
                    txtAddress.Text = customer.Address;
                    txtName.Text = customer.FullName;
                    txtMobile.Text = customer.Mobile;
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                }
            }
        }
    }
}
