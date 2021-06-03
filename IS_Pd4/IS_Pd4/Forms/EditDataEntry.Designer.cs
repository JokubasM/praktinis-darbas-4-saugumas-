
namespace IS_Pd4
{
    partial class EditDataEntry
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
            this.CopyTextButton = new System.Windows.Forms.Button();
            this.FoundPasswordLabel = new System.Windows.Forms.Label();
            this.DecryptPassword = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PasswordSearchTexBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.DeleteDataEntryButton = new System.Windows.Forms.Button();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CopyTextButton
            // 
            this.CopyTextButton.Location = new System.Drawing.Point(430, 347);
            this.CopyTextButton.Margin = new System.Windows.Forms.Padding(4);
            this.CopyTextButton.Name = "CopyTextButton";
            this.CopyTextButton.Size = new System.Drawing.Size(141, 44);
            this.CopyTextButton.TabIndex = 23;
            this.CopyTextButton.Text = "Kopijuoti į iškarpinę";
            this.CopyTextButton.UseVisualStyleBackColor = true;
            this.CopyTextButton.Click += new System.EventHandler(this.CopyTextButton_Click);
            // 
            // FoundPasswordLabel
            // 
            this.FoundPasswordLabel.AutoSize = true;
            this.FoundPasswordLabel.Location = new System.Drawing.Point(109, 298);
            this.FoundPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FoundPasswordLabel.Name = "FoundPasswordLabel";
            this.FoundPasswordLabel.Size = new System.Drawing.Size(78, 17);
            this.FoundPasswordLabel.TabIndex = 22;
            this.FoundPasswordLabel.Text = "(password)";
            // 
            // DecryptPassword
            // 
            this.DecryptPassword.Location = new System.Drawing.Point(217, 347);
            this.DecryptPassword.Margin = new System.Windows.Forms.Padding(4);
            this.DecryptPassword.Name = "DecryptPassword";
            this.DecryptPassword.Size = new System.Drawing.Size(141, 44);
            this.DecryptPassword.TabIndex = 21;
            this.DecryptPassword.Text = "Iššifruoti slaptažodį";
            this.DecryptPassword.UseVisualStyleBackColor = true;
            this.DecryptPassword.Click += new System.EventHandler(this.DecryptPassword_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(16, 347);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(137, 44);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Ieškoti";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PasswordSearchTexBox
            // 
            this.PasswordSearchTexBox.Location = new System.Drawing.Point(217, 253);
            this.PasswordSearchTexBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordSearchTexBox.Name = "PasswordSearchTexBox";
            this.PasswordSearchTexBox.Size = new System.Drawing.Size(354, 22);
            this.PasswordSearchTexBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ieškoti slaptažodžio sistemoje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Slaptažodis:";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(38, 497);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(184, 44);
            this.ChangePasswordButton.TabIndex = 25;
            this.ChangePasswordButton.Text = "Keisti slaptažodį";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // DeleteDataEntryButton
            // 
            this.DeleteDataEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteDataEntryButton.Location = new System.Drawing.Point(349, 497);
            this.DeleteDataEntryButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteDataEntryButton.Name = "DeleteDataEntryButton";
            this.DeleteDataEntryButton.Size = new System.Drawing.Size(184, 44);
            this.DeleteDataEntryButton.TabIndex = 26;
            this.DeleteDataEntryButton.Text = "Ištrinti įrašą";
            this.DeleteDataEntryButton.UseVisualStyleBackColor = false;
            this.DeleteDataEntryButton.Click += new System.EventHandler(this.DeleteDataEntryButton_Click);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(217, 446);
            this.NewPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(354, 22);
            this.NewPasswordTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Įvesti naują slaptažodį";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 50);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(555, 179);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pavadinimas";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Slaptažodis";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "URL";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Komentaras";
            this.columnHeader4.Width = 195;
            // 
            // EditDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 554);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.DeleteDataEntryButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopyTextButton);
            this.Controls.Add(this.FoundPasswordLabel);
            this.Controls.Add(this.DecryptPassword);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PasswordSearchTexBox);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditDataEntry";
            this.Text = "EditDataEntry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditDataEntry_FormClosed);
            this.Load += new System.EventHandler(this.EditDataEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CopyTextButton;
        private System.Windows.Forms.Label FoundPasswordLabel;
        private System.Windows.Forms.Button DecryptPassword;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox PasswordSearchTexBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button DeleteDataEntryButton;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}