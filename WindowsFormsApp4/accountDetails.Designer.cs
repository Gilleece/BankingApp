namespace BankingApp
{
    partial class accountDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountDetails));
            this.nameLabel = new System.Windows.Forms.Label();
            this.accNumLabel = new System.Windows.Forms.Label();
            this.ibanLabel = new System.Windows.Forms.Label();
            this.eircodeLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.accNumBox = new System.Windows.Forms.TextBox();
            this.ibanBox = new System.Windows.Forms.TextBox();
            this.eircodeBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.editPinBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(169, 503);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(185, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Full Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accNumLabel
            // 
            this.accNumLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNumLabel.Location = new System.Drawing.Point(169, 544);
            this.accNumLabel.Name = "accNumLabel";
            this.accNumLabel.Size = new System.Drawing.Size(185, 29);
            this.accNumLabel.TabIndex = 1;
            this.accNumLabel.Text = "Account Number:";
            this.accNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ibanLabel
            // 
            this.ibanLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ibanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibanLabel.Location = new System.Drawing.Point(169, 586);
            this.ibanLabel.Name = "ibanLabel";
            this.ibanLabel.Size = new System.Drawing.Size(185, 29);
            this.ibanLabel.TabIndex = 2;
            this.ibanLabel.Text = "IBAN:";
            this.ibanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // eircodeLabel
            // 
            this.eircodeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eircodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eircodeLabel.Location = new System.Drawing.Point(169, 626);
            this.eircodeLabel.Name = "eircodeLabel";
            this.eircodeLabel.Size = new System.Drawing.Size(185, 29);
            this.eircodeLabel.TabIndex = 3;
            this.eircodeLabel.Text = "Eircode:";
            this.eircodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(362, 503);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(185, 29);
            this.nameBox.TabIndex = 4;
            this.mainToolTip.SetToolTip(this.nameBox, "This is your name, did you really need that explained to you?");
            // 
            // accNumBox
            // 
            this.accNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNumBox.Location = new System.Drawing.Point(362, 544);
            this.accNumBox.Name = "accNumBox";
            this.accNumBox.ReadOnly = true;
            this.accNumBox.Size = new System.Drawing.Size(185, 29);
            this.accNumBox.TabIndex = 5;
            this.mainToolTip.SetToolTip(this.accNumBox, "This is your account number, at our bank you really are just a number!");
            // 
            // ibanBox
            // 
            this.ibanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibanBox.Location = new System.Drawing.Point(362, 587);
            this.ibanBox.Name = "ibanBox";
            this.ibanBox.ReadOnly = true;
            this.ibanBox.Size = new System.Drawing.Size(185, 29);
            this.ibanBox.TabIndex = 6;
            this.mainToolTip.SetToolTip(this.ibanBox, "Iban, uban, we all ban! This is your internation banking account number.");
            // 
            // eircodeBox
            // 
            this.eircodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eircodeBox.Location = new System.Drawing.Point(362, 626);
            this.eircodeBox.Name = "eircodeBox";
            this.eircodeBox.ReadOnly = true;
            this.eircodeBox.Size = new System.Drawing.Size(185, 29);
            this.eircodeBox.TabIndex = 7;
            this.mainToolTip.SetToolTip(this.eircodeBox, "This is your Eircode, we didn\'t want to bother with full addresses");
            // 
            // balanceLabel
            // 
            this.balanceLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(168, 421);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(186, 33);
            this.balanceLabel.TabIndex = 8;
            this.balanceLabel.Text = "BALANCE:";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // balanceBox
            // 
            this.balanceBox.BackColor = System.Drawing.Color.LightGreen;
            this.balanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceBox.Location = new System.Drawing.Point(362, 421);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.ReadOnly = true;
            this.balanceBox.Size = new System.Drawing.Size(185, 33);
            this.balanceBox.TabIndex = 9;
            this.mainToolTip.SetToolTip(this.balanceBox, "This is your balance, please don\'t cry");
            // 
            // editPinBtn
            // 
            this.editPinBtn.BackColor = System.Drawing.Color.IndianRed;
            this.editPinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPinBtn.Location = new System.Drawing.Point(562, 581);
            this.editPinBtn.Name = "editPinBtn";
            this.editPinBtn.Size = new System.Drawing.Size(86, 40);
            this.editPinBtn.TabIndex = 13;
            this.editPinBtn.Text = "EDIT DETAILS";
            this.mainToolTip.SetToolTip(this.editPinBtn, "Click here to edit your details");
            this.editPinBtn.UseVisualStyleBackColor = false;
            this.editPinBtn.Click += new System.EventHandler(this.editPinBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.IndianRed;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(562, 623);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(86, 40);
            this.logoutBtn.TabIndex = 14;
            this.logoutBtn.Text = "LOG OUT";
            this.mainToolTip.SetToolTip(this.logoutBtn, "Click here to log out");
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Location = new System.Drawing.Point(562, 338);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(86, 40);
            this.helpBtn.TabIndex = 15;
            this.helpBtn.Text = "CLICK HERE FOR HELP";
            this.mainToolTip.SetToolTip(this.helpBtn, "Read the user guide");
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // accountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(959, 994);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.editPinBtn);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.eircodeBox);
            this.Controls.Add(this.ibanBox);
            this.Controls.Add(this.accNumBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.eircodeLabel);
            this.Controls.Add(this.ibanLabel);
            this.Controls.Add(this.accNumLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "accountDetails";
            this.Text = "acccountDetails";
            this.Load += new System.EventHandler(this.acccountDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label accNumLabel;
        private System.Windows.Forms.Label ibanLabel;
        private System.Windows.Forms.Label eircodeLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox accNumBox;
        private System.Windows.Forms.TextBox ibanBox;
        private System.Windows.Forms.TextBox eircodeBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Button editPinBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.ToolTip mainToolTip;
    }
}