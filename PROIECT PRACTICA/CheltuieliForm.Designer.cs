namespace PROIECT_PRACTICA
{
    partial class CheltuieliForm
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
            this.cheltuieliGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.totalCheltuieliButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cheltuieliGridView
            // 
            this.cheltuieliGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.cheltuieliGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cheltuieliGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.cheltuieliGridView.Location = new System.Drawing.Point(68, 77);
            this.cheltuieliGridView.Name = "cheltuieliGridView";
            this.cheltuieliGridView.RowHeadersWidth = 51;
            this.cheltuieliGridView.RowTemplate.Height = 24;
            this.cheltuieliGridView.Size = new System.Drawing.Size(859, 302);
            this.cheltuieliGridView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(841, 459);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(86, 38);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Terminat";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // totalCheltuieliButton
            // 
            this.totalCheltuieliButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCheltuieliButton.Location = new System.Drawing.Point(788, 402);
            this.totalCheltuieliButton.Name = "totalCheltuieliButton";
            this.totalCheltuieliButton.Size = new System.Drawing.Size(139, 38);
            this.totalCheltuieliButton.TabIndex = 2;
            this.totalCheltuieliButton.Text = "Total cheltuieli";
            this.totalCheltuieliButton.UseVisualStyleBackColor = true;
            this.totalCheltuieliButton.Click += new System.EventHandler(this.totalCheltuieliButton_Click);
            // 
            // CheltuieliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::PROIECT_PRACTICA.Properties.Resources.blue5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 509);
            this.Controls.Add(this.totalCheltuieliButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.cheltuieliGridView);
            this.Name = "CheltuieliForm";
            this.Text = "CHELTUIELI SUPLIMENTARE";
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cheltuieliGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button totalCheltuieliButton;
    }
}