
namespace GymSYS
{
    partial class frmCancelBooking
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
            this.btnCancelClass = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
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
            this.cboBookingId = new System.Windows.Forms.ComboBox();
            this.cboMemberId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelClass
            // 
            this.btnCancelClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClass.Location = new System.Drawing.Point(345, 263);
            this.btnCancelClass.Name = "btnCancelClass";
            this.btnCancelClass.Size = new System.Drawing.Size(110, 40);
            this.btnCancelClass.TabIndex = 29;
            this.btnCancelClass.Text = "Cancel";
            this.btnCancelClass.UseVisualStyleBackColor = true;
            this.btnCancelClass.Click += new System.EventHandler(this.btnCancelClass_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(296, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Booking ID:";
            this.label7.Visible = false;
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
            this.menuStrip1.TabIndex = 24;
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
            this.makeBookingToolStripMenuItem.Click += new System.EventHandler(this.makeBookingToolStripMenuItem_Click);
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cancelBookingToolStripMenuItem.Text = "Cancel Booking";
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
            // cboBookingId
            // 
            this.cboBookingId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookingId.FormattingEnabled = true;
            this.cboBookingId.Location = new System.Drawing.Point(394, 208);
            this.cboBookingId.Name = "cboBookingId";
            this.cboBookingId.Size = new System.Drawing.Size(117, 21);
            this.cboBookingId.TabIndex = 30;
            this.cboBookingId.Visible = false;
            // 
            // cboMemberId
            // 
            this.cboMemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberId.FormattingEnabled = true;
            this.cboMemberId.Location = new System.Drawing.Point(342, 108);
            this.cboMemberId.Name = "cboMemberId";
            this.cboMemberId.Size = new System.Drawing.Size(117, 21);
            this.cboMemberId.TabIndex = 32;
            this.cboMemberId.SelectedIndexChanged += new System.EventHandler(this.cboMemberId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(244, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Member ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(481, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(688, 418);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(100, 20);
            this.txtClassId.TabIndex = 34;
            this.txtClassId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(296, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Forename:";
            this.label2.Visible = false;
            // 
            // txtForename
            // 
            this.txtForename.Enabled = false;
            this.txtForename.Location = new System.Drawing.Point(394, 156);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(117, 20);
            this.txtForename.TabIndex = 36;
            this.txtForename.Visible = false;
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboMemberId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBookingId);
            this.Controls.Add(this.btnCancelClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmCancelBooking";
            this.Text = "Cancel Booking";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelClass;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.ToolStripMenuItem yearlyClassAnalysisToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboBookingId;
        private System.Windows.Forms.ComboBox cboMemberId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForename;
    }
}