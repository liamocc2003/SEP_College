
namespace GymSYS
{
    partial class frmMakeBooking
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
            this.yearlyClassAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookClass = new System.Windows.Forms.Button();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClassId = new System.Windows.Forms.ComboBox();
            this.cboMemberId = new System.Windows.Forms.ComboBox();
            this.rdbMemberWallet = new System.Windows.Forms.RadioButton();
            this.rdbMemberPoints = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.TabIndex = 18;
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
            this.mnuUpdateMember.Click += new System.EventHandler(this.mnuUpdateMember_Click);
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
            this.yearlyRevenueAnalysisToolStripMenuItem,
            this.yearlyClassAnalysisToolStripMenuItem});
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
            // yearlyClassAnalysisToolStripMenuItem
            // 
            this.yearlyClassAnalysisToolStripMenuItem.Name = "yearlyClassAnalysisToolStripMenuItem";
            this.yearlyClassAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyClassAnalysisToolStripMenuItem.Text = "Yearly Class Analysis";
            this.yearlyClassAnalysisToolStripMenuItem.Click += new System.EventHandler(this.yearlyClassAnalysisToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.backToolStripMenuItem.Text = "<--Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(44, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Member ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(394, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Class ID:";
            // 
            // btnBookClass
            // 
            this.btnBookClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookClass.Location = new System.Drawing.Point(678, 398);
            this.btnBookClass.Name = "btnBookClass";
            this.btnBookClass.Size = new System.Drawing.Size(110, 40);
            this.btnBookClass.TabIndex = 23;
            this.btnBookClass.Text = "Book";
            this.btnBookClass.UseVisualStyleBackColor = true;
            this.btnBookClass.Click += new System.EventHandler(this.btnBookClass_Click);
            // 
            // txtBookingId
            // 
            this.txtBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBookingId.Location = new System.Drawing.Point(167, 69);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.Size = new System.Drawing.Size(150, 23);
            this.txtBookingId.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Booking ID:";
            // 
            // cboClassId
            // 
            this.cboClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassId.FormattingEnabled = true;
            this.cboClassId.Location = new System.Drawing.Point(517, 161);
            this.cboClassId.Name = "cboClassId";
            this.cboClassId.Size = new System.Drawing.Size(150, 21);
            this.cboClassId.TabIndex = 26;
            this.cboClassId.SelectedIndexChanged += new System.EventHandler(this.cboClassId_SelectedIndexChanged);
            // 
            // cboMemberId
            // 
            this.cboMemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberId.FormattingEnabled = true;
            this.cboMemberId.Location = new System.Drawing.Point(167, 160);
            this.cboMemberId.Name = "cboMemberId";
            this.cboMemberId.Size = new System.Drawing.Size(150, 21);
            this.cboMemberId.TabIndex = 27;
            this.cboMemberId.SelectedIndexChanged += new System.EventHandler(this.cboMemberId_SelectedIndexChanged);
            // 
            // rdbMemberWallet
            // 
            this.rdbMemberWallet.AutoSize = true;
            this.rdbMemberWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbMemberWallet.Location = new System.Drawing.Point(48, 301);
            this.rdbMemberWallet.Name = "rdbMemberWallet";
            this.rdbMemberWallet.Size = new System.Drawing.Size(120, 21);
            this.rdbMemberWallet.TabIndex = 28;
            this.rdbMemberWallet.TabStop = true;
            this.rdbMemberWallet.Text = "Member Wallet";
            this.rdbMemberWallet.UseVisualStyleBackColor = true;
            // 
            // rdbMemberPoints
            // 
            this.rdbMemberPoints.AutoSize = true;
            this.rdbMemberPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbMemberPoints.Location = new System.Drawing.Point(48, 324);
            this.rdbMemberPoints.Name = "rdbMemberPoints";
            this.rdbMemberPoints.Size = new System.Drawing.Size(120, 21);
            this.rdbMemberPoints.TabIndex = 29;
            this.rdbMemberPoints.TabStop = true;
            this.rdbMemberPoints.Text = "Member Points";
            this.rdbMemberPoints.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(44, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Select a payment option:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(198, 210);
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(119, 20);
            this.txtForename.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(44, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Member Forename:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(394, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Class Name:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(517, 208);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(150, 20);
            this.txtClassName.TabIndex = 33;
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbMemberPoints);
            this.Controls.Add(this.rdbMemberWallet);
            this.Controls.Add(this.cboMemberId);
            this.Controls.Add(this.cboClassId);
            this.Controls.Add(this.txtBookingId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBookClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMakeBooking";
            this.Text = "Make Booking";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookClass;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClassId;
        private System.Windows.Forms.ComboBox cboMemberId;
        private System.Windows.Forms.ToolStripMenuItem yearlyClassAnalysisToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbMemberWallet;
        private System.Windows.Forms.RadioButton rdbMemberPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClassName;
    }
}