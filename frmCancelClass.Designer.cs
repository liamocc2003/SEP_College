
namespace GymSYS
{
    partial class frmCancelClass
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
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnCancelClass = new System.Windows.Forms.Button();
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
            this.scheduleClassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scheduleClassToolStripMenuItem.Text = "Schedule Class";
            this.scheduleClassToolStripMenuItem.Click += new System.EventHandler(this.scheduleClassToolStripMenuItem_Click);
            // 
            // updateClassToolStripMenuItem
            // 
            this.updateClassToolStripMenuItem.Name = "updateClassToolStripMenuItem";
            this.updateClassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateClassToolStripMenuItem.Text = "Update Class";
            this.updateClassToolStripMenuItem.Click += new System.EventHandler(this.updateClassToolStripMenuItem_Click);
            // 
            // cancelClassToolStripMenuItem
            // 
            this.cancelClassToolStripMenuItem.Name = "cancelClassToolStripMenuItem";
            this.cancelClassToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelClassToolStripMenuItem.Text = "Cancel Class";
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
            this.makeBookingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeBookingToolStripMenuItem.Text = "Make Booking";
            this.makeBookingToolStripMenuItem.Click += new System.EventHandler(this.makeBookingToolStripMenuItem_Click);
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Class Name:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(427, 174);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(163, 20);
            this.txtClassName.TabIndex = 24;
            // 
            // btnCancelClass
            // 
            this.btnCancelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelClass.Location = new System.Drawing.Point(359, 356);
            this.btnCancelClass.Name = "btnCancelClass";
            this.btnCancelClass.Size = new System.Drawing.Size(82, 35);
            this.btnCancelClass.TabIndex = 27;
            this.btnCancelClass.Text = "Cancel";
            this.btnCancelClass.UseVisualStyleBackColor = true;
            // 
            // frmCancelClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelClass);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmCancelClass";
            this.Text = "frmCancelClass";
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
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnCancelClass;
    }
}