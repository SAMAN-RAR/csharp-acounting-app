namespace Accounting.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnReportsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.totalReportBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.newTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnReportPay = new System.Windows.Forms.ToolStripButton();
            this.btnReportRecieve = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMonthlyBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMonthlyPay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonthlyRecieve = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalRecieve = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReportsSettings,
            this.aboutBtn});
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(63, 22);
            this.btnSettings.Text = "تنظیمات";
            this.btnSettings.ToolTipText = "تنظیمات";
            // 
            // btnReportsSettings
            // 
            this.btnReportsSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyReportBtn,
            this.totalReportBtn});
            this.btnReportsSettings.Name = "btnReportsSettings";
            this.btnReportsSettings.Size = new System.Drawing.Size(119, 22);
            this.btnReportsSettings.Text = "گزارش ها";
            // 
            // monthlyReportBtn
            // 
            this.monthlyReportBtn.Name = "monthlyReportBtn";
            this.monthlyReportBtn.Size = new System.Drawing.Size(155, 22);
            this.monthlyReportBtn.Text = "گزارش این ماه";
            this.monthlyReportBtn.Click += new System.EventHandler(this.monthlyReportBtn_Click);
            // 
            // totalReportBtn
            // 
            this.totalReportBtn.Name = "totalReportBtn";
            this.totalReportBtn.Size = new System.Drawing.Size(155, 22);
            this.totalReportBtn.Text = "گزارش تمام ادوار";
            this.totalReportBtn.Click += new System.EventHandler(this.totalReportBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(119, 22);
            this.aboutBtn.Text = "درباره";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomer,
            this.newTransaction,
            this.btnReportPay,
            this.btnReportRecieve});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(71, 59);
            this.btnCustomer.Text = "طرف حساب";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // newTransaction
            // 
            this.newTransaction.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.newTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTransaction.Name = "newTransaction";
            this.newTransaction.Size = new System.Drawing.Size(72, 59);
            this.newTransaction.Text = "تراکنش جدید";
            this.newTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newTransaction.Click += new System.EventHandler(this.newTransaction_Click);
            // 
            // btnReportPay
            // 
            this.btnReportPay.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.btnReportPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportPay.Name = "btnReportPay";
            this.btnReportPay.Size = new System.Drawing.Size(80, 59);
            this.btnReportPay.Text = "گزارش پرداخت";
            this.btnReportPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportPay.Click += new System.EventHandler(this.btnReportPay_Click);
            // 
            // btnReportRecieve
            // 
            this.btnReportRecieve.Image = global::Accounting.App.Properties.Resources._1371476193_printers___Faxes;
            this.btnReportRecieve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportRecieve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportRecieve.Name = "btnReportRecieve";
            this.btnReportRecieve.Size = new System.Drawing.Size(81, 59);
            this.btnReportRecieve.Text = "گزارش دریافت";
            this.btnReportRecieve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportRecieve.Click += new System.EventHandler(this.btnReportRecieve_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 17);
            this.lblDate.Text = "1404";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 17);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // lblTimeTimer
            // 
            this.lblTimeTimer.Enabled = true;
            this.lblTimeTimer.Interval = 1000;
            this.lblTimeTimer.Tick += new System.EventHandler(this.lblTimeTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMonthlyBalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblMonthlyPay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMonthlyRecieve);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(450, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش های این ماه";
            // 
            // lblMonthlyBalance
            // 
            this.lblMonthlyBalance.Location = new System.Drawing.Point(35, 125);
            this.lblMonthlyBalance.Name = "lblMonthlyBalance";
            this.lblMonthlyBalance.Size = new System.Drawing.Size(183, 23);
            this.lblMonthlyBalance.TabIndex = 5;
            this.lblMonthlyBalance.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "مانده: ";
            // 
            // lblMonthlyPay
            // 
            this.lblMonthlyPay.Location = new System.Drawing.Point(35, 86);
            this.lblMonthlyPay.Name = "lblMonthlyPay";
            this.lblMonthlyPay.Size = new System.Drawing.Size(183, 23);
            this.lblMonthlyPay.TabIndex = 3;
            this.lblMonthlyPay.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "پرداختی ها: ";
            // 
            // lblMonthlyRecieve
            // 
            this.lblMonthlyRecieve.Location = new System.Drawing.Point(35, 49);
            this.lblMonthlyRecieve.Name = "lblMonthlyRecieve";
            this.lblMonthlyRecieve.Size = new System.Drawing.Size(183, 23);
            this.lblMonthlyRecieve.TabIndex = 1;
            this.lblMonthlyRecieve.Text = "label1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(224, 49);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(63, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "دریافتی ها: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalBalance);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTotalPay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTotalRecieve);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(450, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 230);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "گزارش کامل";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.Location = new System.Drawing.Point(35, 142);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(183, 23);
            this.lblTotalBalance.TabIndex = 11;
            this.lblTotalBalance.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "مانده: ";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.Location = new System.Drawing.Point(35, 103);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(183, 23);
            this.lblTotalPay.TabIndex = 9;
            this.lblTotalPay.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "پرداختی ها: ";
            // 
            // lblTotalRecieve
            // 
            this.lblTotalRecieve.Location = new System.Drawing.Point(35, 66);
            this.lblTotalRecieve.Name = "lblTotalRecieve";
            this.lblTotalRecieve.Size = new System.Drawing.Size(183, 23);
            this.lblTotalRecieve.TabIndex = 7;
            this.lblTotalRecieve.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "دریافتی ها: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources.AccountingBG;
            this.pictureBox1.Location = new System.Drawing.Point(0, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "سامان فرجی - استاد زارعی - دانشگاه قم";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripButton newTransaction;
        private System.Windows.Forms.ToolStripButton btnReportPay;
        private System.Windows.Forms.ToolStripButton btnReportRecieve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer lblTimeTimer;
        private System.Windows.Forms.ToolStripDropDownButton btnSettings;
        private System.Windows.Forms.ToolStripMenuItem btnReportsSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMonthlyRecieve;
        private System.Windows.Forms.Label lblMonthlyBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMonthlyPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalRecieve;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportBtn;
        private System.Windows.Forms.ToolStripMenuItem totalReportBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutBtn;
        private System.Windows.Forms.Label label1;
    }
}

