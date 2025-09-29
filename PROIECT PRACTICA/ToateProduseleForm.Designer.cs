namespace PROIECT_PRACTICA
{
    partial class ToateProduseleForm
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
            this.toateProduseleGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.adaugaProdusButton = new System.Windows.Forms.Button();
            this.cautaLabel = new System.Windows.Forms.Label();
            this.cautaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.toateProduseleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toateProduseleGridView
            // 
            this.toateProduseleGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.toateProduseleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toateProduseleGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.toateProduseleGridView.Location = new System.Drawing.Point(23, 94);
            this.toateProduseleGridView.Name = "toateProduseleGridView";
            this.toateProduseleGridView.RowHeadersWidth = 51;
            this.toateProduseleGridView.RowTemplate.Height = 24;
            this.toateProduseleGridView.Size = new System.Drawing.Size(764, 343);
            this.toateProduseleGridView.TabIndex = 0;
            this.toateProduseleGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.toateProduseleGridView_CellContentClick);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(704, 464);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 42);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Terminat";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // adaugaProdusButton
            // 
            this.adaugaProdusButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaProdusButton.Location = new System.Drawing.Point(23, 464);
            this.adaugaProdusButton.Name = "adaugaProdusButton";
            this.adaugaProdusButton.Size = new System.Drawing.Size(143, 42);
            this.adaugaProdusButton.TabIndex = 2;
            this.adaugaProdusButton.Text = "Adauga produs nou";
            this.adaugaProdusButton.UseVisualStyleBackColor = true;
            this.adaugaProdusButton.Click += new System.EventHandler(this.adaugaProdusButton_Click);
            // 
            // cautaLabel
            // 
            this.cautaLabel.AutoSize = true;
            this.cautaLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cautaLabel.Location = new System.Drawing.Point(20, 41);
            this.cautaLabel.Name = "cautaLabel";
            this.cautaLabel.Size = new System.Drawing.Size(62, 17);
            this.cautaLabel.TabIndex = 3;
            this.cautaLabel.Text = "CAUTA   :";
            // 
            // cautaTextBox
            // 
            this.cautaTextBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cautaTextBox.Location = new System.Drawing.Point(111, 38);
            this.cautaTextBox.Name = "cautaTextBox";
            this.cautaTextBox.Size = new System.Drawing.Size(291, 25);
            this.cautaTextBox.TabIndex = 4;
            this.cautaTextBox.TextChanged += new System.EventHandler(this.cautaTextBox_TextChanged);
            // 
            // ToateProduseleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::PROIECT_PRACTICA.Properties.Resources.blue5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 519);
            this.Controls.Add(this.cautaTextBox);
            this.Controls.Add(this.cautaLabel);
            this.Controls.Add(this.adaugaProdusButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.toateProduseleGridView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ToateProduseleForm";
            this.Text = "TOATE PRODUSELE";
            this.Load += new System.EventHandler(this.ToateProduseleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toateProduseleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView toateProduseleGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button adaugaProdusButton;
        private System.Windows.Forms.Label cautaLabel;
        private System.Windows.Forms.TextBox cautaTextBox;
    }
}