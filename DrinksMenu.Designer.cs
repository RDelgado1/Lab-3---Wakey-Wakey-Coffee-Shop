
namespace Lab_3___Wakey_Wakey_Coffee_Shop
{
    partial class DrinksMenu
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
            this.drinksBackButton = new System.Windows.Forms.Button();
            this.drinksMenuTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sodaLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.waterLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.beerButton = new System.Windows.Forms.Button();
            this.beerLabel = new System.Windows.Forms.Label();
            this.sodaButton = new System.Windows.Forms.Button();
            this.waterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // drinksBackButton
            // 
            this.drinksBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.drinksBackButton.Location = new System.Drawing.Point(3, 424);
            this.drinksBackButton.Name = "drinksBackButton";
            this.drinksBackButton.Size = new System.Drawing.Size(75, 23);
            this.drinksBackButton.TabIndex = 0;
            this.drinksBackButton.Text = "Back";
            this.drinksBackButton.UseVisualStyleBackColor = true;
            this.drinksBackButton.Click += new System.EventHandler(this.drinksBackButton_Click);
            // 
            // drinksMenuTitleLabel
            // 
            this.drinksMenuTitleLabel.AutoSize = true;
            this.drinksMenuTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksMenuTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.drinksMenuTitleLabel.Name = "drinksMenuTitleLabel";
            this.drinksMenuTitleLabel.Size = new System.Drawing.Size(114, 39);
            this.drinksMenuTitleLabel.TabIndex = 1;
            this.drinksMenuTitleLabel.Text = "Drinks";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.drinksBackButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.sodaButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sodaLabel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 134);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // sodaLabel
            // 
            this.sodaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sodaLabel.AutoSize = true;
            this.sodaLabel.Location = new System.Drawing.Point(114, 121);
            this.sodaLabel.Name = "sodaLabel";
            this.sodaLabel.Size = new System.Drawing.Size(32, 13);
            this.sodaLabel.TabIndex = 1;
            this.sodaLabel.Text = "Soda";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.waterButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.waterLabel, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(269, 143);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(260, 134);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // waterLabel
            // 
            this.waterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterLabel.AutoSize = true;
            this.waterLabel.Location = new System.Drawing.Point(112, 121);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(36, 13);
            this.waterLabel.TabIndex = 1;
            this.waterLabel.Text = "Water";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.beerButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.beerLabel, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(535, 143);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(262, 134);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // beerButton
            // 
            this.beerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.beerButton.Image = global::Lab_3___Wakey_Wakey_Coffee_Shop.Properties.Resources.beerDrinkMenu;
            this.beerButton.Location = new System.Drawing.Point(3, 3);
            this.beerButton.Name = "beerButton";
            this.beerButton.Size = new System.Drawing.Size(256, 115);
            this.beerButton.TabIndex = 0;
            this.beerButton.UseVisualStyleBackColor = true;
            this.beerButton.Click += new System.EventHandler(this.beerButton_Click);
            // 
            // beerLabel
            // 
            this.beerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beerLabel.AutoSize = true;
            this.beerLabel.Location = new System.Drawing.Point(116, 121);
            this.beerLabel.Name = "beerLabel";
            this.beerLabel.Size = new System.Drawing.Size(29, 13);
            this.beerLabel.TabIndex = 1;
            this.beerLabel.Text = "Beer";
            // 
            // sodaButton
            // 
            this.sodaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sodaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sodaButton.Image = global::Lab_3___Wakey_Wakey_Coffee_Shop.Properties.Resources.sodaDrinkMenu;
            this.sodaButton.Location = new System.Drawing.Point(3, 3);
            this.sodaButton.Name = "sodaButton";
            this.sodaButton.Size = new System.Drawing.Size(254, 115);
            this.sodaButton.TabIndex = 0;
            this.sodaButton.UseVisualStyleBackColor = true;
            this.sodaButton.Click += new System.EventHandler(this.sodaButton_Click);
            // 
            // waterButton
            // 
            this.waterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.waterButton.Image = global::Lab_3___Wakey_Wakey_Coffee_Shop.Properties.Resources.waterDrinkMenu;
            this.waterButton.Location = new System.Drawing.Point(3, 3);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(254, 115);
            this.waterButton.TabIndex = 0;
            this.waterButton.UseVisualStyleBackColor = true;
            this.waterButton.Click += new System.EventHandler(this.waterButton_Click);
            // 
            // DrinksMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drinksMenuTitleLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DrinksMenu";
            this.Text = "DrinksMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
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

        private System.Windows.Forms.Button drinksBackButton;
        private System.Windows.Forms.Label drinksMenuTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button sodaButton;
        private System.Windows.Forms.Label sodaLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button waterButton;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button beerButton;
        private System.Windows.Forms.Label beerLabel;
    }
}