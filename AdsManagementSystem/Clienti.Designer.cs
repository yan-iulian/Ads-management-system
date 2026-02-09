namespace PROIECT_PRACTICA
{
    partial class ClientiForm
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
            this.clientiGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.cautaLabel = new System.Windows.Forms.Label();
            this.cautaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientiGridView
            // 
            this.clientiGridView.AllowUserToAddRows = false;
            this.clientiGridView.AllowUserToDeleteRows = false;
            this.clientiGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clientiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientiGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientiGridView.Location = new System.Drawing.Point(12, 73);
            this.clientiGridView.Name = "clientiGridView";
            this.clientiGridView.ReadOnly = true;
            this.clientiGridView.RowHeadersWidth = 51;
            this.clientiGridView.RowTemplate.Height = 24;
            this.clientiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientiGridView.Size = new System.Drawing.Size(1036, 261);
            this.clientiGridView.TabIndex = 0;
            this.clientiGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientiGridView_CellContentClick);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(956, 357);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(92, 43);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Terminat";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(884, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(164, 43);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Adauga client nou";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cautaLabel
            // 
            this.cautaLabel.AutoSize = true;
            this.cautaLabel.Location = new System.Drawing.Point(12, 36);
            this.cautaLabel.Name = "cautaLabel";
            this.cautaLabel.Size = new System.Drawing.Size(65, 16);
            this.cautaLabel.TabIndex = 3;
            this.cautaLabel.Text = "CAUTA   :";
            // 
            // cautaTextBox
            // 
            this.cautaTextBox.Location = new System.Drawing.Point(99, 30);
            this.cautaTextBox.Name = "cautaTextBox";
            this.cautaTextBox.Size = new System.Drawing.Size(351, 22);
            this.cautaTextBox.TabIndex = 4;
            this.cautaTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::PROIECT_PRACTICA.Properties.Resources.blue5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 419);
            this.Controls.Add(this.cautaTextBox);
            this.Controls.Add(this.cautaLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clientiGridView);
            this.Name = "ClientiForm";
            this.Text = "CLIENTI";
            this.Load += new System.EventHandler(this.ClientiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientiGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label cautaLabel;
        private System.Windows.Forms.TextBox cautaTextBox;
    }
}