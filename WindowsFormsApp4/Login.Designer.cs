namespace BankingApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.accountLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.accountInput = new System.Windows.Forms.TextBox();
            this.pinInput = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // accountLabel
            // 
            this.accountLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountLabel.Location = new System.Drawing.Point(200, 409);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(143, 38);
            this.accountLabel.TabIndex = 1;
            this.accountLabel.Text = "Account:";
            this.accountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pinLabel
            // 
            this.pinLabel.BackColor = System.Drawing.Color.Transparent;
            this.pinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pinLabel.Location = new System.Drawing.Point(200, 471);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(143, 38);
            this.pinLabel.TabIndex = 2;
            this.pinLabel.Text = "Pin:";
            this.pinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountInput
            // 
            this.accountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInput.Location = new System.Drawing.Point(360, 409);
            this.accountInput.Name = "accountInput";
            this.accountInput.Size = new System.Drawing.Size(150, 38);
            this.accountInput.TabIndex = 3;
            this.mainToolTip.SetToolTip(this.accountInput, "Enter your account number here");
            // 
            // pinInput
            // 
            this.pinInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinInput.Location = new System.Drawing.Point(360, 471);
            this.pinInput.Name = "pinInput";
            this.pinInput.Size = new System.Drawing.Size(150, 38);
            this.pinInput.TabIndex = 4;
            this.pinInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainToolTip.SetToolTip(this.pinInput, "Enter your PIN here");
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(274, 550);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(177, 55);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.mainToolTip.SetToolTip(this.loginButton, "Click to log in");
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 991);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pinInput);
            this.Controls.Add(this.accountInput);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.accountLabel);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.TextBox accountInput;
        private System.Windows.Forms.TextBox pinInput;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.ToolTip mainToolTip;
    }
}

