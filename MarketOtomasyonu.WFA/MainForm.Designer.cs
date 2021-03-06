﻿namespace MarketOtomasyonu.WFA
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnProductOrder = new System.Windows.Forms.Button();
            this.btnGoodsAcceptance = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductOrder
            // 
            this.btnProductOrder.AutoEllipsis = true;
            this.btnProductOrder.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnProductOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductOrder.ForeColor = System.Drawing.Color.Yellow;
            this.btnProductOrder.Location = new System.Drawing.Point(452, 25);
            this.btnProductOrder.Name = "btnProductOrder";
            this.btnProductOrder.Size = new System.Drawing.Size(400, 135);
            this.btnProductOrder.TabIndex = 0;
            this.btnProductOrder.Text = "Sipariş Ver";
            this.btnProductOrder.UseVisualStyleBackColor = false;
            this.btnProductOrder.Click += new System.EventHandler(this.btnProductOrder_Click);
            // 
            // btnGoodsAcceptance
            // 
            this.btnGoodsAcceptance.AutoEllipsis = true;
            this.btnGoodsAcceptance.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnGoodsAcceptance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoodsAcceptance.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoodsAcceptance.ForeColor = System.Drawing.Color.Yellow;
            this.btnGoodsAcceptance.Location = new System.Drawing.Point(452, 205);
            this.btnGoodsAcceptance.Name = "btnGoodsAcceptance";
            this.btnGoodsAcceptance.Size = new System.Drawing.Size(400, 135);
            this.btnGoodsAcceptance.TabIndex = 1;
            this.btnGoodsAcceptance.Text = "Mal Kabul";
            this.btnGoodsAcceptance.UseVisualStyleBackColor = false;
            this.btnGoodsAcceptance.Click += new System.EventHandler(this.btnGoodsAcceptance_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.AutoEllipsis = true;
            this.btnSelling.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelling.ForeColor = System.Drawing.Color.Yellow;
            this.btnSelling.Location = new System.Drawing.Point(452, 385);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(400, 135);
            this.btnSelling.TabIndex = 2;
            this.btnSelling.Text = "Satış Yap";
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnBills
            // 
            this.btnBills.AutoEllipsis = true;
            this.btnBills.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBills.ForeColor = System.Drawing.Color.Yellow;
            this.btnBills.Location = new System.Drawing.Point(452, 566);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(400, 135);
            this.btnBills.TabIndex = 3;
            this.btnBills.Text = "Fişler";
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnBills);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnGoodsAcceptance);
            this.Controls.Add(this.btnProductOrder);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductOrder;
        private System.Windows.Forms.Button btnGoodsAcceptance;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnBills;
    }
}

