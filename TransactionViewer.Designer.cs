
namespace ITMO.ADO.NET.Test_exercise
{
    partial class CustomerTransactionViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowData = new System.Windows.Forms.Button();
            this.transactionGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCustomer = new System.Windows.Forms.RadioButton();
            this.radioButtonTransaction = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxUnclearBalance = new System.Windows.Forms.TextBox();
            this.textBoxClearBalance = new System.Windows.Forms.TextBox();
            this.textBoxAccountTypeId = new System.Windows.Forms.TextBox();
            this.textBoxAccountNum = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxTitleId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(79, 85);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(150, 172);
            this.buttonShowData.TabIndex = 1;
            this.buttonShowData.Text = "Show Data";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // transactionGridView
            // 
            this.transactionGridView.AllowUserToAddRows = false;
            this.transactionGridView.AllowUserToDeleteRows = false;
            this.transactionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.transactionGridView.Location = new System.Drawing.Point(0, 343);
            this.transactionGridView.Name = "transactionGridView";
            this.transactionGridView.ReadOnly = true;
            this.transactionGridView.RowHeadersWidth = 51;
            this.transactionGridView.RowTemplate.Height = 24;
            this.transactionGridView.Size = new System.Drawing.Size(1126, 338);
            this.transactionGridView.TabIndex = 2;
            this.transactionGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactionGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCustomer);
            this.groupBox1.Controls.Add(this.radioButtonTransaction);
            this.groupBox1.Location = new System.Drawing.Point(245, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonCustomer
            // 
            this.radioButtonCustomer.AutoSize = true;
            this.radioButtonCustomer.Location = new System.Drawing.Point(6, 110);
            this.radioButtonCustomer.Name = "radioButtonCustomer";
            this.radioButtonCustomer.Size = new System.Drawing.Size(96, 21);
            this.radioButtonCustomer.TabIndex = 1;
            this.radioButtonCustomer.TabStop = true;
            this.radioButtonCustomer.Text = "Customers";
            this.radioButtonCustomer.UseVisualStyleBackColor = true;
            // 
            // radioButtonTransaction
            // 
            this.radioButtonTransaction.AutoSize = true;
            this.radioButtonTransaction.Checked = true;
            this.radioButtonTransaction.Location = new System.Drawing.Point(6, 40);
            this.radioButtonTransaction.Name = "radioButtonTransaction";
            this.radioButtonTransaction.Size = new System.Drawing.Size(111, 21);
            this.radioButtonTransaction.TabIndex = 0;
            this.radioButtonTransaction.TabStop = true;
            this.radioButtonTransaction.Text = "Transactions";
            this.radioButtonTransaction.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "Customer ID";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(608, 5);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(164, 17);
            this.labelId.TabIndex = 50;
            this.labelId.Text = "will created automatically";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "Date (by default)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Unclear Balance (by default)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Clear Balance (by default)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Account Type ID (required)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Account Number (required)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Address (required)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Last Name (required)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "First Name (required)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Title ID (required)";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(900, 233);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 82);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(900, 134);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 78);
            this.buttonEdit.TabIndex = 38;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(900, 31);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 82);
            this.buttonAdd.TabIndex = 37;
            this.buttonAdd.Text = "Add Customer";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(611, 293);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(269, 22);
            this.textBoxDate.TabIndex = 36;
            // 
            // textBoxUnclearBalance
            // 
            this.textBoxUnclearBalance.Location = new System.Drawing.Point(611, 264);
            this.textBoxUnclearBalance.Name = "textBoxUnclearBalance";
            this.textBoxUnclearBalance.Size = new System.Drawing.Size(269, 22);
            this.textBoxUnclearBalance.TabIndex = 35;
            // 
            // textBoxClearBalance
            // 
            this.textBoxClearBalance.Location = new System.Drawing.Point(611, 235);
            this.textBoxClearBalance.Name = "textBoxClearBalance";
            this.textBoxClearBalance.Size = new System.Drawing.Size(269, 22);
            this.textBoxClearBalance.TabIndex = 34;
            // 
            // textBoxAccountTypeId
            // 
            this.textBoxAccountTypeId.Location = new System.Drawing.Point(611, 206);
            this.textBoxAccountTypeId.Name = "textBoxAccountTypeId";
            this.textBoxAccountTypeId.Size = new System.Drawing.Size(269, 22);
            this.textBoxAccountTypeId.TabIndex = 33;
            // 
            // textBoxAccountNum
            // 
            this.textBoxAccountNum.Location = new System.Drawing.Point(611, 177);
            this.textBoxAccountNum.Name = "textBoxAccountNum";
            this.textBoxAccountNum.Size = new System.Drawing.Size(269, 22);
            this.textBoxAccountNum.TabIndex = 32;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(611, 148);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(269, 22);
            this.textBoxAddress.TabIndex = 31;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(611, 119);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(269, 22);
            this.textBoxLastName.TabIndex = 30;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(611, 90);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(269, 22);
            this.textBoxMiddleName.TabIndex = 29;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(611, 61);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(269, 22);
            this.textBoxFirstName.TabIndex = 28;
            // 
            // textBoxTitleId
            // 
            this.textBoxTitleId.Location = new System.Drawing.Point(611, 32);
            this.textBoxTitleId.Name = "textBoxTitleId";
            this.textBoxTitleId.Size = new System.Drawing.Size(269, 22);
            this.textBoxTitleId.TabIndex = 27;
            // 
            // CustomerTransactionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 681);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxUnclearBalance);
            this.Controls.Add(this.textBoxClearBalance);
            this.Controls.Add(this.textBoxAccountTypeId);
            this.Controls.Add(this.textBoxAccountNum);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxTitleId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.transactionGridView);
            this.Controls.Add(this.buttonShowData);
            this.Name = "CustomerTransactionViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Transaction Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.DataGridView transactionGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCustomer;
        private System.Windows.Forms.RadioButton radioButtonTransaction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxUnclearBalance;
        private System.Windows.Forms.TextBox textBoxClearBalance;
        private System.Windows.Forms.TextBox textBoxAccountTypeId;
        private System.Windows.Forms.TextBox textBoxAccountNum;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxTitleId;
    }
}

