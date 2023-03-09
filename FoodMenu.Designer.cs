
namespace Lab_3___Wakey_Wakey_Coffee_Shop
{
    partial class FoodMenu
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
            this.foodBackButton = new System.Windows.Forms.Button();
            this.foodMenuTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.burgerButton = new System.Windows.Forms.Button();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodBackButton
            // 
            this.foodBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.foodBackButton.Location = new System.Drawing.Point(12, 415);
            this.foodBackButton.Name = "foodBackButton";
            this.foodBackButton.Size = new System.Drawing.Size(75, 23);
            this.foodBackButton.TabIndex = 0;
            this.foodBackButton.Text = "Back";
            this.foodBackButton.UseVisualStyleBackColor = true;
            this.foodBackButton.Click += new System.EventHandler(this.foodBackButton_Click);
            // 
            // foodMenuTitleLabel
            // 
            this.foodMenuTitleLabel.AutoSize = true;
            this.foodMenuTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodMenuTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.foodMenuTitleLabel.Name = "foodMenuTitleLabel";
            this.foodMenuTitleLabel.Size = new System.Drawing.Size(95, 39);
            this.foodMenuTitleLabel.TabIndex = 1;
            this.foodMenuTitleLabel.Text = "Food";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.burgerButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.burgerLabel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 144);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // burgerButton
            // 
            this.burgerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.burgerButton.Location = new System.Drawing.Point(3, 3);
            this.burgerButton.Name = "burgerButton";
            this.burgerButton.Size = new System.Drawing.Size(254, 125);
            this.burgerButton.TabIndex = 0;
            this.burgerButton.UseVisualStyleBackColor = true;
            this.burgerButton.Click += new System.EventHandler(this.burgerButton_Click);
            // 
            // burgerLabel
            // 
            this.burgerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Location = new System.Drawing.Point(111, 131);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(38, 13);
            this.burgerLabel.TabIndex = 1;
            this.burgerLabel.Text = "Burger";
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foodMenuTitleLabel);
            this.Controls.Add(this.foodBackButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FoodMenu";
            this.Text = "FoodMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button foodBackButton;
        private System.Windows.Forms.Label foodMenuTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button burgerButton;
        private System.Windows.Forms.Label burgerLabel;
    }
}