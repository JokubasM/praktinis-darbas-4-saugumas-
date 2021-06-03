
namespace IS_Pd4
{
    partial class LoggedIn
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
            this.addPasswordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.generatePasswordButton = new System.Windows.Forms.Button();
            this.ManagePasswordsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPasswordButton
            // 
            this.addPasswordButton.Location = new System.Drawing.Point(274, 256);
            this.addPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.addPasswordButton.Name = "addPasswordButton";
            this.addPasswordButton.Size = new System.Drawing.Size(138, 48);
            this.addPasswordButton.TabIndex = 2;
            this.addPasswordButton.Text = "Pridėti ";
            this.addPasswordButton.UseVisualStyleBackColor = true;
            this.addPasswordButton.Click += new System.EventHandler(this.addPasswordButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pavadinimas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Slaptažodis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Svetainė";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Komentaras";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(211, 24);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(276, 22);
            this.nameTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(211, 210);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(276, 22);
            this.passwordTextBox.TabIndex = 8;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(211, 63);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(276, 22);
            this.urlTextBox.TabIndex = 9;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(211, 105);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(276, 82);
            this.commentTextBox.TabIndex = 10;
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.Location = new System.Drawing.Point(60, 256);
            this.generatePasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(138, 48);
            this.generatePasswordButton.TabIndex = 11;
            this.generatePasswordButton.Text = "Sugeneruoti slaptažodį";
            this.generatePasswordButton.UseVisualStyleBackColor = true;
            this.generatePasswordButton.Click += new System.EventHandler(this.generatePasswordButton_Click);
            // 
            // ManagePasswordsButton
            // 
            this.ManagePasswordsButton.Location = new System.Drawing.Point(492, 256);
            this.ManagePasswordsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ManagePasswordsButton.Name = "ManagePasswordsButton";
            this.ManagePasswordsButton.Size = new System.Drawing.Size(138, 48);
            this.ManagePasswordsButton.TabIndex = 18;
            this.ManagePasswordsButton.Text = "Peržiūrėti slaptažodžius";
            this.ManagePasswordsButton.UseVisualStyleBackColor = true;
            this.ManagePasswordsButton.Click += new System.EventHandler(this.ManagePasswordsButton_Click);
            // 
            // LoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 327);
            this.Controls.Add(this.ManagePasswordsButton);
            this.Controls.Add(this.generatePasswordButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPasswordButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoggedIn";
            this.Text = "LogggedIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoggedIn_FormClosed);
            this.Load += new System.EventHandler(this.LoggedIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addPasswordButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button generatePasswordButton;
        private System.Windows.Forms.Button ManagePasswordsButton;
    }
}