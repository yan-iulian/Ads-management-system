namespace PROIECT_PRACTICA
{
    partial class ProduseForm
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
            this.produseGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produseGridView
            // 
            this.produseGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.produseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.produseGridView.Location = new System.Drawing.Point(12, 24);
            this.produseGridView.Name = "produseGridView";
            this.produseGridView.RowHeadersWidth = 51;
            this.produseGridView.RowTemplate.Height = 24;
            this.produseGridView.Size = new System.Drawing.Size(827, 285);
            this.produseGridView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(745, 387);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 41);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Terminat";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(690, 329);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(149, 41);
            this.totalButton.TabIndex = 2;
            this.totalButton.Text = "Genereaza total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // ProduseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::PROIECT_PRACTICA.Properties.Resources.blue5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 452);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.produseGridView);
            this.Name = "ProduseForm";
            this.Text = "PRODUSE";
            ((System.ComponentModel.ISupportInitialize)(this.produseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView produseGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button totalButton;
    }
}