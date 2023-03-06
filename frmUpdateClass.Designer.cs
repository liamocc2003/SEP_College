
namespace GymSYS
{
    partial class frmUpdateClass
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassTeacher = new System.Windows.Forms.TextBox();
            this.txtClassFee = new System.Windows.Forms.TextBox();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpClassDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClassDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClassSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboClassId = new System.Windows.Forms.ComboBox();
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
            this.scheduleClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scheduleClassToolStripMenuItem.Text = "Schedule Class";
            this.scheduleClassToolStripMenuItem.Click += new System.EventHandler(this.scheduleClassToolStripMenuItem_Click);
            // 
            // updateClassToolStripMenuItem
            // 
            this.updateClassToolStripMenuItem.Name = "updateClassToolStripMenuItem";
            this.updateClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateClassToolStripMenuItem.Text = "Update Class";
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
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Class Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Class Teacher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Class Fee:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(172, 66);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(163, 20);
            this.txtClassName.TabIndex = 23;
            // 
            // txtClassTeacher
            // 
            this.txtClassTeacher.Location = new System.Drawing.Point(172, 127);
            this.txtClassTeacher.Name = "txtClassTeacher";
            this.txtClassTeacher.Size = new System.Drawing.Size(163, 20);
            this.txtClassTeacher.TabIndex = 24;
            // 
            // txtClassFee
            // 
            this.txtClassFee.Location = new System.Drawing.Point(172, 367);
            this.txtClassFee.Name = "txtClassFee";
            this.txtClassFee.Size = new System.Drawing.Size(163, 20);
            this.txtClassFee.TabIndex = 25;
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClass.Location = new System.Drawing.Point(677, 381);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(82, 35);
            this.btnUpdateClass.TabIndex = 26;
            this.btnUpdateClass.Text = "Update";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Class ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(677, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 34);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpClassDate
            // 
            this.dtpClassDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClassDate.Location = new System.Drawing.Point(171, 243);
            this.dtpClassDate.Name = "dtpClassDate";
            this.dtpClassDate.Size = new System.Drawing.Size(150, 20);
            this.dtpClassDate.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(40, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Date of Class:";
            // 
            // txtClassDuration
            // 
            this.txtClassDuration.Location = new System.Drawing.Point(171, 305);
            this.txtClassDuration.Name = "txtClassDuration";
            this.txtClassDuration.Size = new System.Drawing.Size(163, 20);
            this.txtClassDuration.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Class Duration:";
            // 
            // txtClassSize
            // 
            this.txtClassSize.Location = new System.Drawing.Point(171, 186);
            this.txtClassSize.Name = "txtClassSize";
            this.txtClassSize.Size = new System.Drawing.Size(163, 20);
            this.txtClassSize.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Class Size:";
            // 
            // cboClassId
            // 
            this.cboClassId.FormattingEnabled = true;
            this.cboClassId.Location = new System.Drawing.Point(614, 65);
            this.cboClassId.Name = "cboClassId";
            this.cboClassId.Size = new System.Drawing.Size(145, 21);
            this.cboClassId.TabIndex = 38;
            // 
            // frmUpdateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboClassId);
            this.Controls.Add(this.dtpClassDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtClassDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClassSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.txtClassFee);
            this.Controls.Add(this.txtClassTeacher);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmUpdateClass";
            this.Text = "Update Class";
            this.Load += new System.EventHandler(this.frmUpdateClass_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassTeacher;
        private System.Windows.Forms.TextBox txtClassFee;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpClassDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClassDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClassSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboClassId;
    }
}