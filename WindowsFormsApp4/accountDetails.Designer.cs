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
            this.nameLabel = new System.Windows.Forms.Label();
            this.accNumLabel = new System.Windows.Forms.Label();
            this.ibanLabel = new System.Windows.Forms.Label();
            this.eircodeLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.accNumBox = new System.Windows.Forms.TextBox();
            this.ibanBox = new System.Windows.Forms.TextBox();
            this.eircodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(192, 92);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(115, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Full Name:";
            // 
            // accNumLabel
            // 
            this.accNumLabel.AutoSize = true;
            this.accNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNumLabel.Location = new System.Drawing.Point(130, 132);
            this.accNumLabel.Name = "accNumLabel";
            this.accNumLabel.Size = new System.Drawing.Size(177, 25);
            this.accNumLabel.TabIndex = 1;
            this.accNumLabel.Text = "Account Number:";
            // 
            // ibanLabel
            // 
            this.ibanLabel.AutoSize = true;
            this.ibanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibanLabel.Location = new System.Drawing.Point(241, 175);
            this.ibanLabel.Name = "ibanLabel";
            this.ibanLabel.Size = new System.Drawing.Size(66, 25);
            this.ibanLabel.TabIndex = 2;
            this.ibanLabel.Text = "IBAN:";
            // 
            // eircodeLabel
            // 
            this.eircodeLabel.AutoSize = true;
            this.eircodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eircodeLabel.Location = new System.Drawing.Point(216, 218);
            this.eircodeLabel.Name = "eircodeLabel";
            this.eircodeLabel.Size = new System.Drawing.Size(91, 25);
            this.eircodeLabel.TabIndex = 3;
            this.eircodeLabel.Text = "Eircode:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(336, 97);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(129, 20);
            this.nameBox.TabIndex = 4;
            // 
            // accNumBox
            // 
            this.accNumBox.Location = new System.Drawing.Point(336, 132);
            this.accNumBox.Name = "accNumBox";
            this.accNumBox.Size = new System.Drawing.Size(129, 20);
            this.accNumBox.TabIndex = 5;
            // 
            // ibanBox
            // 
            this.ibanBox.Location = new System.Drawing.Point(336, 175);
            this.ibanBox.Name = "ibanBox";
            this.ibanBox.Size = new System.Drawing.Size(129, 20);
            this.ibanBox.TabIndex = 6;
            // 
            // eircodeBox
            // 
            this.eircodeBox.Location = new System.Drawing.Point(336, 218);
            this.eircodeBox.Name = "eircodeBox";
            this.eircodeBox.Size = new System.Drawing.Size(129, 20);
            this.eircodeBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "BALANCE:";
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(559, 137);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(100, 20);
            this.balanceBox.TabIndex = 9;
            // 
            // accountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox balanceBox;
    }
}