
namespace ProjectAssigment_1
{
    partial class frmWelcome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWelcome.Location = new System.Drawing.Point(106, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(737, 39);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "WELCOME TO BEELTE CAF  COFFEE SHOP";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.BackColor = System.Drawing.Color.Linen;
            this.lstOutput.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 14;
            this.lstOutput.Items.AddRange(new object[] {
            "Customers click on the button ( customer) to make your order",
            "",
            "Staff click o on the button ( staff) to access user data",
            "",
            "Beetle caf",
            "=======================",
            "BeelteCaf is a bustling coffee shop where the smell of fresh-brewed coffee often " +
                "fills the air. The",
            "walls are adorned with colorful murals, blackboards listing the day\'s specials, a" +
                "nd shelves stocked",
            "with coffee beans and brewing equipment. Soft lighting bathes the cozy seating ar" +
                "eas, with",
            "comfortable armchairs and couches arranged in intimate clusters. The sound of gen" +
                "tle jazz music fills",
            "the room, providing a pleasant background ambiance. Behind the counter, baristas " +
                "clad in aprons",
            "and hats work busily, expertly crafting each drink with care and precision. The a" +
                "roma of fresh-baked",
            "pastries mingles with the rich scent of coffee, tempting customers to indulge in " +
                "a sweet treat. I guess",
            "one can say that BeelteCaf feels like a warm and inviting oasis. A place where pe" +
                "ople can come",
            "together and share a moment of relaxation and connection over a delicious cup of " +
                "coffee. It is no",
            "wonder that the shop is constantly filled with customers of all ages sipping thei" +
                "r drinks and chatting",
            "with friends."});
            this.lstOutput.Location = new System.Drawing.Point(201, 87);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(561, 256);
            this.lstOutput.TabIndex = 9;
            this.lstOutput.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(63, 385);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(244, 68);
            this.btnCustomer.TabIndex = 10;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click_1);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(693, 385);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(244, 68);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(365, 385);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(244, 68);
            this.btnStaff.TabIndex = 12;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectAssigment_1.Properties.Resources.Food_Safety_Guide_for_Coffee_Shops;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 481);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Beetle caf";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnHelp;
        public System.Windows.Forms.Button btnStaff;
    }
}