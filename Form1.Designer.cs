﻿
namespace Lab_3___Wakey_Wakey_Coffee_Shop
{
    partial class mainMenu
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
            this.menuTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.foodLabel = new System.Windows.Forms.Label();
            this.foodButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dessertButton = new System.Windows.Forms.Button();
            this.dessertLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.drinkButton = new System.Windows.Forms.Button();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.cartButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // menuTable
            // 
            this.menuTable.ColumnCount = 3;
            this.menuTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuTable.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.menuTable.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.menuTable.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.menuTable.Controls.Add(this.cartButton, 2, 3);
            this.menuTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTable.Location = new System.Drawing.Point(0, 0);
            this.menuTable.Margin = new System.Windows.Forms.Padding(6);
            this.menuTable.Name = "menuTable";
            this.menuTable.RowCount = 4;
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuTable.Size = new System.Drawing.Size(1600, 865);
            this.menuTable.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.foodLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.foodButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 269);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 251);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // foodLabel
            // 
            this.foodLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foodLabel.AutoSize = true;
            this.foodLabel.Location = new System.Drawing.Point(230, 226);
            this.foodLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(61, 25);
            this.foodLabel.TabIndex = 3;
            this.foodLabel.Text = "Food";
            // 
            // foodButton
            // 
            this.foodButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.foodButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.foodButton.Image = global::Lab_3___Wakey_Wakey_Coffee_Shop.Properties.Resources.foodMenuPhoto;
            this.foodButton.Location = new System.Drawing.Point(6, 6);
            this.foodButton.Margin = new System.Windows.Forms.Padding(6);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(509, 214);
            this.foodButton.TabIndex = 2;
            this.foodButton.UseVisualStyleBackColor = true;
            this.foodButton.Click += new System.EventHandler(this.foodButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dessertButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dessertLabel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(539, 269);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(521, 251);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // dessertButton
            // 
            this.dessertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dessertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dessertButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dessertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dessertButton.Image = global::Lab_3___Wakey_Wakey_Coffee_Shop.Properties.Resources.dessertMenuPhoto;
            this.dessertButton.Location = new System.Drawing.Point(6, 6);
            this.dessertButton.Margin = new System.Windows.Forms.Padding(6);
            this.dessertButton.Name = "dessertButton";
            this.dessertButton.Size = new System.Drawing.Size(509, 214);
            this.dessertButton.TabIndex = 4;
            this.dessertButton.UseVisualStyleBackColor = true;
            this.dessertButton.Click += new System.EventHandler(this.dessertButton_Click);
            // 
            // dessertLabel
            // 
            this.dessertLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dessertLabel.AutoSize = true;
            this.dessertLabel.Location = new System.Drawing.Point(217, 226);
            this.dessertLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dessertLabel.Name = "dessertLabel";
            this.dessertLabel.Size = new System.Drawing.Size(86, 25);
            this.dessertLabel.TabIndex = 5;
            this.dessertLabel.Text = "Dessert";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.drinkButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.drinksLabel, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1072, 269);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(522, 251);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // drinkButton
            // 
            this.drinkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drinkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.drinkButton.Image = global::Lab_3___Wakey_Wakey_Coffee_Shop.Properties.Resources.drinksMenuPhoto;
            this.drinkButton.Location = new System.Drawing.Point(6, 6);
            this.drinkButton.Margin = new System.Windows.Forms.Padding(6);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(510, 214);
            this.drinkButton.TabIndex = 3;
            this.drinkButton.UseVisualStyleBackColor = true;
            this.drinkButton.Click += new System.EventHandler(this.drinkButton_Click);
            // 
            // drinksLabel
            // 
            this.drinksLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Location = new System.Drawing.Point(224, 226);
            this.drinksLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(73, 25);
            this.drinksLabel.TabIndex = 4;
            this.drinksLabel.Text = "Drinks";
            // 
            // cartButton
            // 
            this.cartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cartButton.Location = new System.Drawing.Point(1440, 797);
            this.cartButton.Margin = new System.Windows.Forms.Padding(6);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(154, 62);
            this.cartButton.TabIndex = 5;
            this.cartButton.Text = "Cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1600, 87);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(6, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(849, 76);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Wakey Wakey Coffee Shop";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTable);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "mainMenu";
            this.Text = "Wakey Wakey Coffee Shop";
            this.menuTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button foodButton;
        private System.Windows.Forms.Button drinkButton;
        private System.Windows.Forms.Button dessertButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.TableLayoutPanel menuTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label dessertLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label titleLabel;
    }
}

