﻿
namespace Lab_3___Wakey_Wakey_Coffee_Shop
{
    partial class shoppingCart
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
            this.cartBackButton = new System.Windows.Forms.Button();
            this.cartView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cartBackButton
            // 
            this.cartBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cartBackButton.Location = new System.Drawing.Point(12, 415);
            this.cartBackButton.Name = "cartBackButton";
            this.cartBackButton.Size = new System.Drawing.Size(75, 23);
            this.cartBackButton.TabIndex = 0;
            this.cartBackButton.Text = "Back";
            this.cartBackButton.UseVisualStyleBackColor = true;
            this.cartBackButton.Click += new System.EventHandler(this.cartBackButton_Click);
            // 
            // cartView
            // 
            this.cartView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartView.FormattingEnabled = true;
            this.cartView.Location = new System.Drawing.Point(0, 0);
            this.cartView.Name = "cartView";
            this.cartView.Size = new System.Drawing.Size(800, 450);
            this.cartView.TabIndex = 1;
            // 
            // shoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cartView);
            this.Controls.Add(this.cartBackButton);
            this.Name = "shoppingCart";
            this.Text = "shoppingCart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cartBackButton;
        private System.Windows.Forms.ListBox cartView;
    }
}