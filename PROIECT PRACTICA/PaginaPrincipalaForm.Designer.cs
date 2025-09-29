namespace PROIECT_PRACTICA
{
    partial class PaginaPrincipalaForm
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
            this.titluLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.functieLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.clientiButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.produseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titluLabel
            // 
            this.titluLabel.AutoSize = true;
            this.titluLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titluLabel.Location = new System.Drawing.Point(57, 28);
            this.titluLabel.Name = "titluLabel";
            this.titluLabel.Size = new System.Drawing.Size(107, 20);
            this.titluLabel.TabIndex = 0;
            this.titluLabel.Text = "BINE AI VENIT!";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(57, 99);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(67, 17);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // functieLabel
            // 
            this.functieLabel.AutoSize = true;
            this.functieLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functieLabel.Location = new System.Drawing.Point(57, 162);
            this.functieLabel.Name = "functieLabel";
            this.functieLabel.Size = new System.Drawing.Size(48, 17);
            this.functieLabel.TabIndex = 2;
            this.functieLabel.Text = "Functie";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(259, 253);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 36);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "LogOut";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // clientiButton
            // 
            this.clientiButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientiButton.Location = new System.Drawing.Point(485, 69);
            this.clientiButton.Name = "clientiButton";
            this.clientiButton.Size = new System.Drawing.Size(101, 46);
            this.clientiButton.TabIndex = 5;
            this.clientiButton.Text = "Clienti ";
            this.clientiButton.UseVisualStyleBackColor = true;
            this.clientiButton.Click += new System.EventHandler(this.clientiButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(128, 253);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 36);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Inchide";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // produseButton
            // 
            this.produseButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produseButton.Location = new System.Drawing.Point(485, 147);
            this.produseButton.Name = "produseButton";
            this.produseButton.Size = new System.Drawing.Size(101, 47);
            this.produseButton.TabIndex = 7;
            this.produseButton.Text = "Produse";
            this.produseButton.UseVisualStyleBackColor = true;
            this.produseButton.Click += new System.EventHandler(this.produseButton_Click);
            // 
            // PaginaPrincipalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::PROIECT_PRACTICA.Properties.Resources.blue5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 359);
            this.Controls.Add(this.produseButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clientiButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.functieLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.titluLabel);
            this.Name = "PaginaPrincipalaForm";
            this.Text = "PAGINA PRINCIPALA";
            this.Load += new System.EventHandler(this.PaginaPrincipalaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titluLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label functieLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button clientiButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button produseButton;
    }
}