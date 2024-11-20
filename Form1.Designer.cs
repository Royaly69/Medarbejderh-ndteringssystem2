namespace Medarbejderhåndteringssystem
{
    partial class Form1
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
            this.Alder = new System.Windows.Forms.Label();
            this.Nummer = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Efternavn = new System.Windows.Forms.Label();
            this.Fornavn = new System.Windows.Forms.Label();
            this.AddAlder = new System.Windows.Forms.TextBox();
            this.AddNummer = new System.Windows.Forms.TextBox();
            this.AddEmail = new System.Windows.Forms.TextBox();
            this.AddEfterNavn = new System.Windows.Forms.TextBox();
            this.AddFornavn = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.BookdataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteButton1 = new System.Windows.Forms.Button();
            this.DeleteNummer = new System.Windows.Forms.Label();
            this.DeleteNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BookdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Alder
            // 
            this.Alder.AutoSize = true;
            this.Alder.Location = new System.Drawing.Point(706, 142);
            this.Alder.Name = "Alder";
            this.Alder.Size = new System.Drawing.Size(39, 16);
            this.Alder.TabIndex = 34;
            this.Alder.Text = "Alder";
            // 
            // Nummer
            // 
            this.Nummer.AutoSize = true;
            this.Nummer.Location = new System.Drawing.Point(551, 142);
            this.Nummer.Name = "Nummer";
            this.Nummer.Size = new System.Drawing.Size(79, 16);
            this.Nummer.TabIndex = 33;
            this.Nummer.Text = "Tlf. Nummer";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(432, 142);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(45, 16);
            this.Email.TabIndex = 32;
            this.Email.Text = "E-mail";
            // 
            // Efternavn
            // 
            this.Efternavn.AutoSize = true;
            this.Efternavn.Location = new System.Drawing.Point(277, 142);
            this.Efternavn.Name = "Efternavn";
            this.Efternavn.Size = new System.Drawing.Size(63, 16);
            this.Efternavn.TabIndex = 31;
            this.Efternavn.Text = "Efternavn";
            // 
            // Fornavn
            // 
            this.Fornavn.AutoSize = true;
            this.Fornavn.Location = new System.Drawing.Point(143, 142);
            this.Fornavn.Name = "Fornavn";
            this.Fornavn.Size = new System.Drawing.Size(56, 16);
            this.Fornavn.TabIndex = 30;
            this.Fornavn.Text = "Fornavn";
            // 
            // AddAlder
            // 
            this.AddAlder.Location = new System.Drawing.Point(677, 161);
            this.AddAlder.Name = "AddAlder";
            this.AddAlder.Size = new System.Drawing.Size(100, 22);
            this.AddAlder.TabIndex = 29;
            // 
            // AddNummer
            // 
            this.AddNummer.Location = new System.Drawing.Point(541, 161);
            this.AddNummer.Name = "AddNummer";
            this.AddNummer.Size = new System.Drawing.Size(100, 22);
            this.AddNummer.TabIndex = 28;
            // 
            // AddEmail
            // 
            this.AddEmail.Location = new System.Drawing.Point(404, 161);
            this.AddEmail.Name = "AddEmail";
            this.AddEmail.Size = new System.Drawing.Size(100, 22);
            this.AddEmail.TabIndex = 27;
            // 
            // AddEfterNavn
            // 
            this.AddEfterNavn.Location = new System.Drawing.Point(264, 161);
            this.AddEfterNavn.Name = "AddEfterNavn";
            this.AddEfterNavn.Size = new System.Drawing.Size(100, 22);
            this.AddEfterNavn.TabIndex = 26;
            // 
            // AddFornavn
            // 
            this.AddFornavn.Location = new System.Drawing.Point(126, 161);
            this.AddFornavn.Name = "AddFornavn";
            this.AddFornavn.Size = new System.Drawing.Size(100, 22);
            this.AddFornavn.TabIndex = 25;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(783, 160);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(151, 23);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Add.Employee";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BookdataGridView1
            // 
            this.BookdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookdataGridView1.Location = new System.Drawing.Point(126, 216);
            this.BookdataGridView1.Name = "BookdataGridView1";
            this.BookdataGridView1.RowHeadersWidth = 51;
            this.BookdataGridView1.RowTemplate.Height = 24;
            this.BookdataGridView1.Size = new System.Drawing.Size(808, 168);
            this.BookdataGridView1.TabIndex = 23;
            // 
            // DeleteButton1
            // 
            this.DeleteButton1.Location = new System.Drawing.Point(783, 96);
            this.DeleteButton1.Name = "DeleteButton1";
            this.DeleteButton1.Size = new System.Drawing.Size(151, 23);
            this.DeleteButton1.TabIndex = 35;
            this.DeleteButton1.Text = "Delete.Employee";
            this.DeleteButton1.UseVisualStyleBackColor = true;
            this.DeleteButton1.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteNummer
            // 
            this.DeleteNummer.AutoSize = true;
            this.DeleteNummer.Location = new System.Drawing.Point(687, 78);
            this.DeleteNummer.Name = "DeleteNummer";
            this.DeleteNummer.Size = new System.Drawing.Size(79, 16);
            this.DeleteNummer.TabIndex = 37;
            this.DeleteNummer.Text = "Tlf. Nummer";
            // 
            // DeleteNumber
            // 
            this.DeleteNumber.Location = new System.Drawing.Point(677, 97);
            this.DeleteNumber.Name = "DeleteNumber";
            this.DeleteNumber.Size = new System.Drawing.Size(100, 22);
            this.DeleteNumber.TabIndex = 36;
            // 
            // DeleteButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.DeleteNummer);
            this.Controls.Add(this.DeleteNumber);
            this.Controls.Add(this.DeleteButton1);
            this.Controls.Add(this.Alder);
            this.Controls.Add(this.Nummer);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Efternavn);
            this.Controls.Add(this.Fornavn);
            this.Controls.Add(this.AddAlder);
            this.Controls.Add(this.AddNummer);
            this.Controls.Add(this.AddEmail);
            this.Controls.Add(this.AddEfterNavn);
            this.Controls.Add(this.AddFornavn);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BookdataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BookdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alder;
        private System.Windows.Forms.Label Nummer;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Efternavn;
        private System.Windows.Forms.Label Fornavn;
        private System.Windows.Forms.TextBox AddAlder;
        private System.Windows.Forms.TextBox AddNummer;
        private System.Windows.Forms.TextBox AddEmail;
        private System.Windows.Forms.TextBox AddEfterNavn;
        private System.Windows.Forms.TextBox AddFornavn;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView BookdataGridView1;
        private System.Windows.Forms.Button DeleteButton1;
        private System.Windows.Forms.Label DeleteNummer;
        private System.Windows.Forms.TextBox DeleteNumber;
    }
}

