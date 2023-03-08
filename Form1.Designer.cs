
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
            this.storeName = new System.Windows.Forms.Label();
            this.foodButton = new System.Windows.Forms.Button();
            this.drinkButton = new System.Windows.Forms.Button();
            this.dessertButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // storeName
            // 
            this.storeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.storeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeName.Location = new System.Drawing.Point(0, 0);
            this.storeName.Name = "storeName";
            this.storeName.Size = new System.Drawing.Size(800, 39);
            this.storeName.TabIndex = 1;
            this.storeName.Text = "Wakey Wakey Coffee Shop";
            this.storeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodButton
            // 
            this.foodButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foodButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.foodButton.Location = new System.Drawing.Point(71, 193);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(123, 60);
            this.foodButton.TabIndex = 2;
            this.foodButton.Text = "Food";
            this.foodButton.UseVisualStyleBackColor = true;
            this.foodButton.Click += new System.EventHandler(this.foodButton_Click);
            // 
            // drinkButton
            // 
            this.drinkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drinkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drinkButton.Location = new System.Drawing.Point(604, 193);
            this.drinkButton.Name = "drinkButton";
            this.drinkButton.Size = new System.Drawing.Size(123, 60);
            this.drinkButton.TabIndex = 3;
            this.drinkButton.Text = "Drinks";
            this.drinkButton.UseVisualStyleBackColor = true;
            this.drinkButton.Click += new System.EventHandler(this.drinkButton_Click);
            // 
            // dessertButton
            // 
            this.dessertButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dessertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dessertButton.Location = new System.Drawing.Point(337, 193);
            this.dessertButton.Name = "dessertButton";
            this.dessertButton.Size = new System.Drawing.Size(123, 60);
            this.dessertButton.TabIndex = 4;
            this.dessertButton.Text = "Desserts";
            this.dessertButton.UseVisualStyleBackColor = true;
            this.dessertButton.Click += new System.EventHandler(this.dessertButton_Click);
            // 
            // cartButton
            // 
            this.cartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cartButton.Location = new System.Drawing.Point(713, 415);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(75, 23);
            this.cartButton.TabIndex = 5;
            this.cartButton.Text = "Cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.foodButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.drinkButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dessertButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.storeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainMenu";
            this.Text = "Wakey Wakey Coffee Shop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label storeName;
        private System.Windows.Forms.Button foodButton;
        private System.Windows.Forms.Button drinkButton;
        private System.Windows.Forms.Button dessertButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

