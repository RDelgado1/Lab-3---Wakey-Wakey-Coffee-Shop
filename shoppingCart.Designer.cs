
namespace Lab_3___Wakey_Wakey_Coffee_Shop
{
    partial class ShoppingCart
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.foodCheckList = new System.Windows.Forms.CheckedListBox();
            this.foodCartLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.drinkCartLabel = new System.Windows.Forms.Label();
            this.drinkCheckList = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dessertCartLabel = new System.Windows.Forms.Label();
            this.dessertCheckList = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartBackButton
            // 
            this.cartBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cartBackButton.Location = new System.Drawing.Point(3, 6);
            this.cartBackButton.Name = "cartBackButton";
            this.cartBackButton.Size = new System.Drawing.Size(75, 24);
            this.cartBackButton.TabIndex = 0;
            this.cartBackButton.Text = "Back";
            this.cartBackButton.UseVisualStyleBackColor = true;
            this.cartBackButton.Click += new System.EventHandler(this.cartBackButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.foodCheckList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.foodCartLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 131);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // foodCheckList
            // 
            this.foodCheckList.BackColor = System.Drawing.SystemColors.Control;
            this.foodCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodCheckList.FormattingEnabled = true;
            this.foodCheckList.Location = new System.Drawing.Point(3, 34);
            this.foodCheckList.Name = "foodCheckList";
            this.foodCheckList.Size = new System.Drawing.Size(788, 94);
            this.foodCheckList.TabIndex = 0;
            // 
            // foodCartLabel
            // 
            this.foodCartLabel.AutoSize = true;
            this.foodCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodCartLabel.Location = new System.Drawing.Point(3, 0);
            this.foodCartLabel.Name = "foodCartLabel";
            this.foodCartLabel.Size = new System.Drawing.Size(86, 31);
            this.foodCartLabel.TabIndex = 2;
            this.foodCartLabel.Text = "label1";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.cartBackButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.deleteButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.checkOutButton, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 414);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(794, 33);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.Location = new System.Drawing.Point(358, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 24);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkOutButton.Location = new System.Drawing.Point(717, 7);
            this.checkOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(75, 24);
            this.checkOutButton.TabIndex = 2;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.drinkCartLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.drinkCheckList, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 140);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 131);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // drinkCartLabel
            // 
            this.drinkCartLabel.AutoSize = true;
            this.drinkCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkCartLabel.Location = new System.Drawing.Point(3, 0);
            this.drinkCartLabel.Name = "drinkCartLabel";
            this.drinkCartLabel.Size = new System.Drawing.Size(86, 31);
            this.drinkCartLabel.TabIndex = 0;
            this.drinkCartLabel.Text = "label1";
            // 
            // drinkCheckList
            // 
            this.drinkCheckList.BackColor = System.Drawing.SystemColors.Control;
            this.drinkCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drinkCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drinkCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkCheckList.FormattingEnabled = true;
            this.drinkCheckList.Location = new System.Drawing.Point(3, 34);
            this.drinkCheckList.Name = "drinkCheckList";
            this.drinkCheckList.Size = new System.Drawing.Size(788, 94);
            this.drinkCheckList.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dessertCartLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dessertCheckList, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 277);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(794, 131);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // dessertCartLabel
            // 
            this.dessertCartLabel.AutoSize = true;
            this.dessertCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertCartLabel.Location = new System.Drawing.Point(3, 0);
            this.dessertCartLabel.Name = "dessertCartLabel";
            this.dessertCartLabel.Size = new System.Drawing.Size(86, 31);
            this.dessertCartLabel.TabIndex = 0;
            this.dessertCartLabel.Text = "label1";
            // 
            // dessertCheckList
            // 
            this.dessertCheckList.BackColor = System.Drawing.SystemColors.Control;
            this.dessertCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dessertCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dessertCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertCheckList.FormattingEnabled = true;
            this.dessertCheckList.Location = new System.Drawing.Point(3, 34);
            this.dessertCheckList.Name = "dessertCheckList";
            this.dessertCheckList.Size = new System.Drawing.Size(788, 94);
            this.dessertCheckList.TabIndex = 1;
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShoppingCart";
            this.Text = "shoppingCart";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cartBackButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckedListBox foodCheckList;
        private System.Windows.Forms.Label foodCartLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label drinkCartLabel;
        private System.Windows.Forms.CheckedListBox drinkCheckList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label dessertCartLabel;
        private System.Windows.Forms.CheckedListBox dessertCheckList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button checkOutButton;
    }
}