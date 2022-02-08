namespace BankingApp
{
    partial class editDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editDetails));
            this.eircodeBox = new System.Windows.Forms.TextBox();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.eircodeLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // eircodeBox
            // 
            this.eircodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eircodeBox.Location = new System.Drawing.Point(362, 498);
            this.eircodeBox.Name = "eircodeBox";
            this.eircodeBox.Size = new System.Drawing.Size(185, 29);
            this.eircodeBox.TabIndex = 13;
            this.mainToolTip.SetToolTip(this.eircodeBox, "Edit your eircode here");
            // 
            // pinBox
            // 
            this.pinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBox.Location = new System.Drawing.Point(362, 534);
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(185, 29);
            this.pinBox.TabIndex = 12;
            this.mainToolTip.SetToolTip(this.pinBox, "Edit your PIN here");
            this.pinBox.TextChanged += new System.EventHandler(this.ibanBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(362, 463);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(185, 29);
            this.nameBox.TabIndex = 11;
            this.mainToolTip.SetToolTip(this.nameBox, "Edit your name here");
            // 
            // eircodeLabel
            // 
            this.eircodeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eircodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eircodeLabel.Location = new System.Drawing.Point(169, 498);
            this.eircodeLabel.Name = "eircodeLabel";
            this.eircodeLabel.Size = new System.Drawing.Size(185, 29);
            this.eircodeLabel.TabIndex = 10;
            this.eircodeLabel.Text = "Eircode:";
            this.eircodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pinLabel
            // 
            this.pinLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinLabel.Location = new System.Drawing.Point(169, 533);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(185, 29);
            this.pinLabel.TabIndex = 9;
            this.pinLabel.Text = "PIN:";
            this.pinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(169, 463);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(185, 29);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Full Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(562, 499);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(60, 40);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "SAVE";
            this.mainToolTip.SetToolTip(this.saveBtn, "Click here to save");
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(562, 540);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(60, 40);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "CANCEL";
            this.mainToolTip.SetToolTip(this.cancelButton, "Click here to cancel and go back");
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Location = new System.Drawing.Point(562, 338);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(86, 40);
            this.helpBtn.TabIndex = 16;
            this.helpBtn.Text = "CLICK HERE FOR HELP";
            this.mainToolTip.SetToolTip(this.helpBtn, "Read the user guide");
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // editDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(962, 997);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.eircodeBox);
            this.Controls.Add(this.pinBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.eircodeLabel);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "editDetails";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eircodeBox;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label eircodeLabel;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.ToolTip mainToolTip;
    }
}