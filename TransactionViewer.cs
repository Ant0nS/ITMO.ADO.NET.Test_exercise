using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace ITMO.ADO.NET.Test_exercise
{
    public partial class CustomerTransactionViewer : Form
    {
        ApressFinancialEntities financialContext = new ApressFinancialEntities();
        public CustomerTransactionViewer()
        {
            InitializeComponent();
            textBoxDate.Text = DateTime.Now.ToShortDateString();
            textBoxClearBalance.Text = "0,00";
            textBoxUnclearBalance.Text = "0,00";
        }
        private void buttonShowData_Click(object sender, EventArgs e)
        {
            try
            {
                radioButtonCheck();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void radioButtonCheck()
        {
            if (this.radioButtonCustomer.Checked == true)
                transactionGridView.DataSource = financialContext.Customers.ToList();
            else if (this.radioButtonTransaction.Checked == true)
                transactionGridView.DataSource = financialContext.Transactions.ToList();
        }

        private void transactionGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (transactionGridView.CurrentRow == null) return;

            var customer = transactionGridView.CurrentRow.DataBoundItem as Customer;

            if (customer == null) return;

            labelId.Text = Convert.ToString(customer.CustomerId);
            textBoxTitleId.Text = Convert.ToString(customer.CustomerTitleId);
            textBoxFirstName.Text = customer.CustomerFirstName;
            textBoxLastName.Text = customer.CustomerLastName;
            textBoxMiddleName.Text = customer.CustomerOtherInitials;
            textBoxAddress.Text = Convert.ToString(customer.AddressId);
            textBoxAccountNum.Text = customer.AccountNumber;
            textBoxAccountTypeId.Text = Convert.ToString(customer.AccountTypeId);
            textBoxClearBalance.Text = Convert.ToString (customer.CleareBalance);
            textBoxUnclearBalance.Text = Convert.ToString(customer.UncleareBalance);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    CustomerTitleId = Int32.Parse(this.textBoxTitleId.Text),
                    CustomerFirstName = this.textBoxFirstName.Text,
                    CustomerOtherInitials = this.textBoxMiddleName.Text,
                    CustomerLastName = this.textBoxLastName.Text,
                    AddressId = long.Parse(this.textBoxAddress.Text),
                    AccountNumber = this.textBoxAccountNum.Text,
                    AccountTypeId = Int32.Parse(this.textBoxAccountTypeId.Text),
                    CleareBalance = Decimal.Parse(this.textBoxClearBalance.Text),
                    UncleareBalance = Decimal.Parse(this.textBoxUnclearBalance.Text),
                    DateAdded = DateTime.Parse(this.textBoxDate.Text),
                };
                financialContext.Customers.Add(customer);
                financialContext.SaveChanges();
                radioButtonCheck();

                textBoxTitleId.Text = String.Empty;
                textBoxFirstName.Text = String.Empty;
                textBoxLastName.Text = String.Empty;
                textBoxMiddleName.Text = String.Empty;
                textBoxAddress.Text = String.Empty;
                textBoxAccountNum.Text = String.Empty;
                textBoxAccountTypeId.Text = String.Empty;
                textBoxClearBalance.Text = String.Empty;
                textBoxUnclearBalance.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelId.Text == String.Empty) return;

            var id = Convert.ToInt32(labelId.Text);

            var customer = financialContext.Customers.Find(id);

            if (customer == null) return;

            customer.CustomerTitleId = Int32.Parse(this.textBoxTitleId.Text);
            customer.CustomerFirstName = this.textBoxFirstName.Text;
            customer.CustomerOtherInitials = this.textBoxMiddleName.Text;
            customer.CustomerLastName = this.textBoxLastName.Text;
            customer.AddressId = long.Parse(this.textBoxAddress.Text);
            customer.AccountNumber = this.textBoxAccountNum.Text;
            customer.AccountTypeId = Int32.Parse(this.textBoxAccountTypeId.Text);
            customer.CleareBalance = Decimal.Parse(this.textBoxClearBalance.Text);
            customer.UncleareBalance = Decimal.Parse(this.textBoxUnclearBalance.Text);
            customer.DateAdded = DateTime.Parse(this.textBoxDate.Text);

            financialContext.Entry(customer).State = EntityState.Modified;

            financialContext.SaveChanges();

            radioButtonCheck();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (labelId.Text == String.Empty) return;

            var id = Convert.ToInt32(labelId.Text);

            var customer = financialContext.Customers.Find(id);

            financialContext.Entry(customer).State = EntityState.Deleted;

            financialContext.SaveChanges();

            radioButtonCheck();
        }
    }
}
