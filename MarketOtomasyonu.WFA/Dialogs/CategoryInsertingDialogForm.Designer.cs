﻿namespace MarketOtomasyonu.WFA.Dialogs
{
    partial class CategoryInsertingDialogForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnCategoryCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategori Adı :";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(138, 94);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(100, 23);
            this.btnCategoryAdd.TabIndex = 11;
            this.btnCategoryAdd.Text = "Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(92, 38);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(135, 20);
            this.txtCategory.TabIndex = 10;
            // 
            // btnCategoryCancel
            // 
            this.btnCategoryCancel.Location = new System.Drawing.Point(12, 94);
            this.btnCategoryCancel.Name = "btnCategoryCancel";
            this.btnCategoryCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCategoryCancel.TabIndex = 13;
            this.btnCategoryCancel.Text = "Vazgeç";
            this.btnCategoryCancel.UseVisualStyleBackColor = true;
            this.btnCategoryCancel.Click += new System.EventHandler(this.btnCategoryCancel_Click);
            // 
            // CategoryInsertingDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 153);
            this.Controls.Add(this.btnCategoryCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCategoryAdd);
            this.Controls.Add(this.txtCategory);
            this.Name = "CategoryInsertingDialogForm";
            this.Text = "CategryInserting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnCategoryCancel;
    }
}