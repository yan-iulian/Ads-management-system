namespace PROIECT_PRACTICA
{
    partial class AdaugaProdusNouForm
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
            this.adaugaButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.numeLabel = new System.Windows.Forms.Label();
            this.tipProdusLabel = new System.Windows.Forms.Label();
            this.pretUnitarLabel = new System.Windows.Forms.Label();
            this.idNumeric = new System.Windows.Forms.NumericUpDown();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.tipProdusTextBox = new System.Windows.Forms.TextBox();
            this.pretUnitarTextBox = new System.Windows.Forms.TextBox();
            this.titluLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // adaugaButton
            // 
            this.adaugaButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaButton.Location = new System.Drawing.Point(558, 302);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(97, 37);
            this.adaugaButton.TabIndex = 0;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(437, 302);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 37);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Anuleaza";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(51, 84);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(132, 17);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID-UL PRODUSULUI  :";
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeLabel.Location = new System.Drawing.Point(51, 137);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(57, 17);
            this.numeLabel.TabIndex = 3;
            this.numeLabel.Text = "NUME  :";
            // 
            // tipProdusLabel
            // 
            this.tipProdusLabel.AutoSize = true;
            this.tipProdusLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipProdusLabel.Location = new System.Drawing.Point(51, 179);
            this.tipProdusLabel.Name = "tipProdusLabel";
            this.tipProdusLabel.Size = new System.Drawing.Size(90, 17);
            this.tipProdusLabel.TabIndex = 4;
            this.tipProdusLabel.Text = "TIP PRODUS  :";
            // 
            // pretUnitarLabel
            // 
            this.pretUnitarLabel.AutoSize = true;
            this.pretUnitarLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretUnitarLabel.Location = new System.Drawing.Point(51, 229);
            this.pretUnitarLabel.Name = "pretUnitarLabel";
            this.pretUnitarLabel.Size = new System.Drawing.Size(96, 17);
            this.pretUnitarLabel.TabIndex = 5;
            this.pretUnitarLabel.Text = "PRET UNITAR  :";
            // 
            // idNumeric
            // 
            this.idNumeric.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.idNumeric.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumeric.Location = new System.Drawing.Point(397, 84);
            this.idNumeric.Name = "idNumeric";
            this.idNumeric.ReadOnly = true;
            this.idNumeric.Size = new System.Drawing.Size(258, 25);
            this.idNumeric.TabIndex = 6;
            // 
            // numeTextBox
            // 
            this.numeTextBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeTextBox.Location = new System.Drawing.Point(397, 131);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(258, 25);
            this.numeTextBox.TabIndex = 7;
            // 
            // tipProdusTextBox
            // 
            this.tipProdusTextBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipProdusTextBox.Location = new System.Drawing.Point(397, 173);
            this.tipProdusTextBox.Name = "tipProdusTextBox";
            this.tipProdusTextBox.Size = new System.Drawing.Size(258, 25);
            this.tipProdusTextBox.TabIndex = 8;
            // 
            // pretUnitarTextBox
            // 
            this.pretUnitarTextBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretUnitarTextBox.Location = new System.Drawing.Point(397, 223);
            this.pretUnitarTextBox.Name = "pretUnitarTextBox";
            this.pretUnitarTextBox.Size = new System.Drawing.Size(258, 25);
            this.pretUnitarTextBox.TabIndex = 9;
            // 
            // titluLabel
            // 
            this.titluLabel.AutoSize = true;
            this.titluLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titluLabel.Location = new System.Drawing.Point(51, 27);
            this.titluLabel.Name = "titluLabel";
            this.titluLabel.Size = new System.Drawing.Size(169, 17);
            this.titluLabel.TabIndex = 10;
            this.titluLabel.Text = "ADAUGA UN PRODUS NOU";
            // 
            // AdaugaProdusNouForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::PROIECT_PRACTICA.Properties.Resources.digital_marketing_abstract_technology_background_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 370);
            this.Controls.Add(this.titluLabel);
            this.Controls.Add(this.pretUnitarTextBox);
            this.Controls.Add(this.tipProdusTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.idNumeric);
            this.Controls.Add(this.pretUnitarLabel);
            this.Controls.Add(this.tipProdusLabel);
            this.Controls.Add(this.numeLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.adaugaButton);
            this.Name = "AdaugaProdusNouForm";
            this.Text = "ADAUGA PRODUS NOU";
            this.Load += new System.EventHandler(this.AdaugaProdusNouForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.Label tipProdusLabel;
        private System.Windows.Forms.Label pretUnitarLabel;
        private System.Windows.Forms.NumericUpDown idNumeric;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox tipProdusTextBox;
        private System.Windows.Forms.TextBox pretUnitarTextBox;
        private System.Windows.Forms.Label titluLabel;
    }
}