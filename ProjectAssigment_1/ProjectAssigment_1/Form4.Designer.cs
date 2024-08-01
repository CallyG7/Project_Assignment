
namespace ProjectAssigment_1
{
    partial class frmStaff
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
            this.tbpUpdate = new System.Windows.Forms.TabPage();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.lblP = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbpReports = new System.Windows.Forms.TabPage();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbItem_ID = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgLogin = new System.Windows.Forms.TabPage();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tbpData = new System.Windows.Forms.TabPage();
            this.lstData = new System.Windows.Forms.ListBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.tbpUpdate.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbpReports.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.gbDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbgLogin.SuspendLayout();
            this.tbpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpUpdate
            // 
            this.tbpUpdate.BackColor = System.Drawing.Color.Beige;
            this.tbpUpdate.Controls.Add(this.gbUpdate);
            this.tbpUpdate.Controls.Add(this.label4);
            this.tbpUpdate.Controls.Add(this.dataGridView1);
            this.tbpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tbpUpdate.Name = "tbpUpdate";
            this.tbpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUpdate.Size = new System.Drawing.Size(957, 458);
            this.tbpUpdate.TabIndex = 1;
            this.tbpUpdate.Text = "Update";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.lblP);
            this.gbUpdate.Controls.Add(this.cmbItem);
            this.gbUpdate.Controls.Add(this.txtUpdate);
            this.gbUpdate.Controls.Add(this.btnUpdate);
            this.gbUpdate.Location = new System.Drawing.Point(532, 49);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(200, 193);
            this.gbUpdate.TabIndex = 6;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(25, 27);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(159, 29);
            this.lblP.TabIndex = 7;
            this.lblP.Text = "Update Price:";
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(30, 100);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(153, 21);
            this.cmbItem.TabIndex = 6;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmdItem_SelectedIndexChanged);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(28, 59);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(153, 20);
            this.txtUpdate.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(28, 127);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 37);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 298);
            this.dataGridView1.TabIndex = 2;
            // 
            // tbpReports
            // 
            this.tbpReports.BackColor = System.Drawing.Color.Khaki;
            this.tbpReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbpReports.Controls.Add(this.gbFilter);
            this.tbpReports.Controls.Add(this.gbDelete);
            this.tbpReports.Controls.Add(this.dataGridView2);
            this.tbpReports.Controls.Add(this.lstReports);
            this.tbpReports.Location = new System.Drawing.Point(4, 22);
            this.tbpReports.Name = "tbpReports";
            this.tbpReports.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReports.Size = new System.Drawing.Size(957, 458);
            this.tbpReports.TabIndex = 0;
            this.tbpReports.Text = "Reports";
            this.tbpReports.Click += new System.EventHandler(this.tabPage1_Click);
            this.tbpReports.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(684, 32);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(147, 106);
            this.gbFilter.TabIndex = 15;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(9, 56);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(119, 20);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter database by price :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.lblDelete);
            this.gbDelete.Controls.Add(this.btnDelete);
            this.gbDelete.Controls.Add(this.cmbItem_ID);
            this.gbDelete.Location = new System.Drawing.Point(504, 32);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(147, 185);
            this.gbDelete.TabIndex = 14;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Delete";
            this.gbDelete.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(18, 27);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(109, 13);
            this.lblDelete.TabIndex = 14;
            this.lblDelete.Text = "Select item to delete :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 43);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbItem_ID
            // 
            this.cmbItem_ID.FormattingEnabled = true;
            this.cmbItem_ID.Location = new System.Drawing.Point(18, 55);
            this.cmbItem_ID.Name = "cmbItem_ID";
            this.cmbItem_ID.Size = new System.Drawing.Size(109, 21);
            this.cmbItem_ID.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(32, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(449, 185);
            this.dataGridView2.TabIndex = 1;
            // 
            // lstReports
            // 
            this.lstReports.FormattingEnabled = true;
            this.lstReports.Location = new System.Drawing.Point(32, 236);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(799, 147);
            this.lstReports.TabIndex = 3;
            this.lstReports.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpReports);
            this.tabControl1.Controls.Add(this.tbpUpdate);
            this.tabControl1.Controls.Add(this.tbgLogin);
            this.tabControl1.Controls.Add(this.tbpData);
            this.tabControl1.Location = new System.Drawing.Point(2, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 484);
            this.tabControl1.TabIndex = 4;
            // 
            // tbgLogin
            // 
            this.tbgLogin.BackgroundImage = global::ProjectAssigment_1.Properties.Resources.images__5_;
            this.tbgLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbgLogin.Controls.Add(this.lblDetails);
            this.tbgLogin.Controls.Add(this.lblPassword);
            this.tbgLogin.Controls.Add(this.lblUsername);
            this.tbgLogin.Controls.Add(this.btnLogin);
            this.tbgLogin.Controls.Add(this.txtPassword);
            this.tbgLogin.Controls.Add(this.txtUsername);
            this.tbgLogin.Location = new System.Drawing.Point(4, 22);
            this.tbgLogin.Name = "tbgLogin";
            this.tbgLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbgLogin.Size = new System.Drawing.Size(957, 458);
            this.tbgLogin.TabIndex = 2;
            this.tbgLogin.Text = "Login";
            this.tbgLogin.UseVisualStyleBackColor = true;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(703, 32);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(208, 13);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "Username: Thomas458     Password: 1234";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(351, 231);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 24);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(351, 155);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 24);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(411, 293);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(482, 236);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(482, 155);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // tbpData
            // 
            this.tbpData.BackColor = System.Drawing.Color.Tan;
            this.tbpData.Controls.Add(this.lblData);
            this.tbpData.Controls.Add(this.lstData);
            this.tbpData.Controls.Add(this.dataGridView4);
            this.tbpData.Controls.Add(this.dataGridView3);
            this.tbpData.Location = new System.Drawing.Point(4, 22);
            this.tbpData.Name = "tbpData";
            this.tbpData.Padding = new System.Windows.Forms.Padding(3);
            this.tbpData.Size = new System.Drawing.Size(957, 458);
            this.tbpData.TabIndex = 3;
            this.tbpData.Text = "Data";
            this.tbpData.Enter += new System.EventHandler(this.tbp_Enter);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(6, 252);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(942, 134);
            this.lstData.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(513, 49);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(435, 188);
            this.dataGridView4.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 49);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(437, 188);
            this.dataGridView3.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 3);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(211, 33);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "BeetleCaf Data";
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 460);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmStaff";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tbpUpdate.ResumeLayout(false);
            this.tbpUpdate.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbpReports.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbDelete.ResumeLayout(false);
            this.gbDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbgLogin.ResumeLayout(false);
            this.tbgLogin.PerformLayout();
            this.tbpData.ResumeLayout(false);
            this.tbpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbgLogin;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TabPage tbpUpdate;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tbpReports;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ListBox lstReports;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbItem_ID;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TabPage tbpData;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblData;
    }
}