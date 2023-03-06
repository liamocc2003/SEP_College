
namespace GymSYS
{
    partial class frmTopUpMemberWallet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTopUpMemberWallet = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCurrentAmount = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.cboMemberId = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMembers,
            this.classesToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMembers
            // 
            this.mnuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterMember,
            this.mnuUpdateMember,
            this.mnuTopUpMemberWallet});
            this.mnuMembers.Name = "mnuMembers";
            this.mnuMembers.Size = new System.Drawing.Size(69, 20);
            this.mnuMembers.Text = "Members";
            // 
            // mnuRegisterMember
            // 
            this.mnuRegisterMember.Name = "mnuRegisterMember";
            this.mnuRegisterMember.Size = new System.Drawing.Size(196, 22);
            this.mnuRegisterMember.Text = "Register Member";
            this.mnuRegisterMember.Click += new System.EventHandler(this.mnuRegisterMember_Click);
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(196, 22);
            this.mnuUpdateMember.Text = "Update Member";
            // 
            // mnuTopUpMemberWallet
            // 
            this.mnuTopUpMemberWallet.Name = "mnuTopUpMemberWallet";
            this.mnuTopUpMemberWallet.Size = new System.Drawing.Size(196, 22);
            this.mnuTopUpMemberWallet.Text = "Top-up Member Wallet";
            this.mnuTopUpMemberWallet.Click += new System.EventHandler(this.mnuTopUpMemberWallet_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleClassToolStripMenuItem,
            this.updateClassToolStripMenuItem,
            this.cancelClassToolStripMenuItem});
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // scheduleClassToolStripMenuItem
            // 
            this.scheduleClassToolStripMenuItem.Name = "scheduleClassToolStripMenuItem";
            this.scheduleClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scheduleClassToolStripMenuItem.Text = "Schedule Class";
            this.scheduleClassToolStripMenuItem.Click += new System.EventHandler(this.scheduleClassToolStripMenuItem_Click);
            // 
            // updateClassToolStripMenuItem
            // 
            this.updateClassToolStripMenuItem.Name = "updateClassToolStripMenuItem";
            this.updateClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateClassToolStripMenuItem.Text = "Update Class";
            this.updateClassToolStripMenuItem.Click += new System.EventHandler(this.updateClassToolStripMenuItem_Click);
            // 
            // cancelClassToolStripMenuItem
            // 
            this.cancelClassToolStripMenuItem.Name = "cancelClassToolStripMenuItem";
            this.cancelClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelClassToolStripMenuItem.Text = "Cancel Class";
            this.cancelClassToolStripMenuItem.Click += new System.EventHandler(this.cancelClassToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBookingToolStripMenuItem,
            this.cancelBookingToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // makeBookingToolStripMenuItem
            // 
            this.makeBookingToolStripMenuItem.Name = "makeBookingToolStripMenuItem";
            this.makeBookingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.makeBookingToolStripMenuItem.Text = "Make Booking";
            this.makeBookingToolStripMenuItem.Click += new System.EventHandler(this.makeBookingToolStripMenuItem_Click);
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            this.cancelBookingToolStripMenuItem.Click += new System.EventHandler(this.cancelBookingToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            this.yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.yearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.backToolStripMenuItem.Text = "<--Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Member Id:";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMoney.Location = new System.Drawing.Point(44, 352);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(77, 34);
            this.btnAddMoney.TabIndex = 20;
            this.btnAddMoney.Text = "Add Money";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Amount:           €";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(162, 240);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(133, 22);
            this.txtAmount.TabIndex = 23;
            // 
            // txtCurrentAmount
            // 
            this.txtCurrentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentAmount.Location = new System.Drawing.Point(194, 149);
            this.txtCurrentAmount.Name = "txtCurrentAmount";
            this.txtCurrentAmount.ReadOnly = true;
            this.txtCurrentAmount.Size = new System.Drawing.Size(101, 22);
            this.txtCurrentAmount.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(334, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 22);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Current amount is €";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(624, 402);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(150, 20);
            this.dtpDOB.TabIndex = 39;
            this.dtpDOB.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSurname.Location = new System.Drawing.Point(624, 368);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(150, 23);
            this.txtSurname.TabIndex = 41;
            this.txtSurname.Visible = false;
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtForename.Location = new System.Drawing.Point(624, 326);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(150, 23);
            this.txtForename.TabIndex = 40;
            this.txtForename.Visible = false;
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Revolut"});
            this.cboPaymentType.Location = new System.Drawing.Point(624, 283);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(150, 24);
            this.cboPaymentType.TabIndex = 44;
            this.cboPaymentType.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEmail.Location = new System.Drawing.Point(624, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 23);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.Visible = false;
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEircode.Location = new System.Drawing.Point(624, 186);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(150, 23);
            this.txtEircode.TabIndex = 42;
            this.txtEircode.Visible = false;
            // 
            // cboMemberId
            // 
            this.cboMemberId.FormattingEnabled = true;
            this.cboMemberId.Location = new System.Drawing.Point(162, 67);
            this.cboMemberId.Name = "cboMemberId";
            this.cboMemberId.Size = new System.Drawing.Size(133, 21);
            this.cboMemberId.TabIndex = 45;
            // 
            // frmTopUpMemberWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMemberId);
            this.Controls.Add(this.cboPaymentType);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEircode);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCurrentAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmTopUpMemberWallet";
            this.Text = "Top-Up Member Wallet";
            this.Load += new System.EventHandler(this.frmTopUpMemberWallet_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMembers;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuTopUpMemberWallet;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtCurrentAmount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.ComboBox cboMemberId;
    }
}