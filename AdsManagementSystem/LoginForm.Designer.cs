namespace PROIECT_PRACTICA
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.parolaLabel = new System.Windows.Forms.Label();
            this.anulareButton = new System.Windows.Forms.Button();
            this.conectareButton = new System.Windows.Forms.Button();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTENTIFICATI-VA!";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(337, 135);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(240, 25);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(337, 214);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(240, 25);
            this.passwordTextBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(93, 138);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 17);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "USERNAME  :";
            // 
            // parolaLabel
            // 
            this.parolaLabel.AutoSize = true;
            this.parolaLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaLabel.Location = new System.Drawing.Point(93, 220);
            this.parolaLabel.Name = "parolaLabel";
            this.parolaLabel.Size = new System.Drawing.Size(65, 17);
            this.parolaLabel.TabIndex = 4;
            this.parolaLabel.Text = "PAROLA  :";
            // 
            // anulareButton
            // 
            this.anulareButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.anulareButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anulareButton.Location = new System.Drawing.Point(461, 382);
            this.anulareButton.Name = "anulareButton";
            this.anulareButton.Size = new System.Drawing.Size(99, 37);
            this.anulareButton.TabIndex = 5;
            this.anulareButton.Text = "Inchide";
            this.anulareButton.UseVisualStyleBackColor = true;
            this.anulareButton.Click += new System.EventHandler(this.anulareButton_Click);
            // 
            // conectareButton
            // 
            this.conectareButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.conectareButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectareButton.Location = new System.Drawing.Point(609, 382);
            this.conectareButton.Name = "conectareButton";
            this.conectareButton.Size = new System.Drawing.Size(114, 37);
            this.conectareButton.TabIndex = 6;
            this.conectareButton.Text = "Conectare";
            this.conectareButton.UseVisualStyleBackColor = true;
            this.conectareButton.Click += new System.EventHandler(this.conectareButton_Click);
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberCheckBox.Location = new System.Drawing.Point(96, 301);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(170, 21);
            this.rememberCheckBox.TabIndex = 7;
            this.rememberCheckBox.Text = "Tine minte username-ul!";
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::PROIECT_PRACTICA.Properties.Resources.blue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 453);
            this.Controls.Add(this.rememberCheckBox);
            this.Controls.Add(this.conectareButton);
            this.Controls.Add(this.anulareButton);
            this.Controls.Add(this.parolaLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label parolaLabel;
        private System.Windows.Forms.Button anulareButton;
        private System.Windows.Forms.Button conectareButton;
        private System.Windows.Forms.CheckBox rememberCheckBox;
    }
}

