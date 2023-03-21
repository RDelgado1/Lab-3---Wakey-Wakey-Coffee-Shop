namespace Lab_3___Wakey_Wakey_Coffee_Shop
{
    partial class CheckOut
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.payButton = new System.Windows.Forms.Button();
            this.cancelCheckout = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkOutFoodLabel = new System.Windows.Forms.Label();
            this.foodListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.checkOutDrinkLabel = new System.Windows.Forms.Label();
            this.drinkListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.checkoutDessertLabel = new System.Windows.Forms.Label();
            this.dessertListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1657, 855);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.payButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelCheckout, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 746);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1651, 106);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // payButton
            // 
            this.payButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.payButton.Location = new System.Drawing.Point(1483, 38);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(165, 65);
            this.payButton.TabIndex = 0;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // cancelCheckout
            // 
            this.cancelCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelCheckout.Location = new System.Drawing.Point(3, 38);
            this.cancelCheckout.Name = "cancelCheckout";
            this.cancelCheckout.Size = new System.Drawing.Size(165, 65);
            this.cancelCheckout.TabIndex = 1;
            this.cancelCheckout.Text = "Cancel";
            this.cancelCheckout.UseVisualStyleBackColor = true;
            this.cancelCheckout.Click += new System.EventHandler(this.cancelCheckout_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.totalLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.totalValue, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(553, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(544, 100);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(212, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(120, 46);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total:";
            // 
            // totalValue
            // 
            this.totalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalValue.AutoSize = true;
            this.totalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValue.Location = new System.Drawing.Point(217, 50);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(109, 50);
            this.totalValue.TabIndex = 1;
            this.totalValue.Text = "label1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.checkOutFoodLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.foodListView, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1651, 241);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // checkOutFoodLabel
            // 
            this.checkOutFoodLabel.AutoSize = true;
            this.checkOutFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutFoodLabel.Location = new System.Drawing.Point(3, 0);
            this.checkOutFoodLabel.Name = "checkOutFoodLabel";
            this.checkOutFoodLabel.Size = new System.Drawing.Size(173, 63);
            this.checkOutFoodLabel.TabIndex = 0;
            this.checkOutFoodLabel.Text = "label1";
            // 
            // foodListView
            // 
            this.foodListView.BackColor = System.Drawing.SystemColors.Control;
            this.foodListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodListView.HideSelection = false;
            this.foodListView.Location = new System.Drawing.Point(3, 66);
            this.foodListView.Name = "foodListView";
            this.foodListView.Size = new System.Drawing.Size(1645, 172);
            this.foodListView.TabIndex = 1;
            this.foodListView.UseCompatibleStateImageBehavior = false;
            this.foodListView.View = System.Windows.Forms.View.List;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.checkOutDrinkLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.drinkListView, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 250);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1651, 242);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // checkOutDrinkLabel
            // 
            this.checkOutDrinkLabel.AutoSize = true;
            this.checkOutDrinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutDrinkLabel.Location = new System.Drawing.Point(3, 0);
            this.checkOutDrinkLabel.Name = "checkOutDrinkLabel";
            this.checkOutDrinkLabel.Size = new System.Drawing.Size(173, 63);
            this.checkOutDrinkLabel.TabIndex = 0;
            this.checkOutDrinkLabel.Text = "label1";
            // 
            // drinkListView
            // 
            this.drinkListView.BackColor = System.Drawing.SystemColors.Control;
            this.drinkListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drinkListView.HideSelection = false;
            this.drinkListView.Location = new System.Drawing.Point(3, 66);
            this.drinkListView.Name = "drinkListView";
            this.drinkListView.Size = new System.Drawing.Size(1645, 173);
            this.drinkListView.TabIndex = 1;
            this.drinkListView.UseCompatibleStateImageBehavior = false;
            this.drinkListView.View = System.Windows.Forms.View.List;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.checkoutDessertLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dessertListView, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 498);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1651, 242);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // checkoutDessertLabel
            // 
            this.checkoutDessertLabel.AutoSize = true;
            this.checkoutDessertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDessertLabel.Location = new System.Drawing.Point(3, 0);
            this.checkoutDessertLabel.Name = "checkoutDessertLabel";
            this.checkoutDessertLabel.Size = new System.Drawing.Size(173, 63);
            this.checkoutDessertLabel.TabIndex = 0;
            this.checkoutDessertLabel.Text = "label1";
            // 
            // dessertListView
            // 
            this.dessertListView.BackColor = System.Drawing.SystemColors.Control;
            this.dessertListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dessertListView.HideSelection = false;
            this.dessertListView.Location = new System.Drawing.Point(3, 66);
            this.dessertListView.Name = "dessertListView";
            this.dessertListView.Size = new System.Drawing.Size(1645, 173);
            this.dessertListView.TabIndex = 1;
            this.dessertListView.UseCompatibleStateImageBehavior = false;
            this.dessertListView.View = System.Windows.Forms.View.List;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 855);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label checkOutFoodLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label checkOutDrinkLabel;
        private System.Windows.Forms.ListView foodListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label checkoutDessertLabel;
        private System.Windows.Forms.ListView drinkListView;
        private System.Windows.Forms.ListView dessertListView;
        private System.Windows.Forms.Button cancelCheckout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalValue;
    }
}