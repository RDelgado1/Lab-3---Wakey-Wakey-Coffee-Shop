
namespace Lab_3___Wakey_Wakey_Coffee_Shop
{
    partial class DessertMenu
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
            this.dessertBackButton = new System.Windows.Forms.Button();
            this.dessertMenuTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sliceOfCakeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.souffleButton = new System.Windows.Forms.Button();
            this.souffleLabel = new System.Windows.Forms.Label();
            this.sliceOfCakeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dessertBackButton
            // 
            this.dessertBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dessertBackButton.Location = new System.Drawing.Point(3, 424);
            this.dessertBackButton.Name = "dessertBackButton";
            this.dessertBackButton.Size = new System.Drawing.Size(75, 23);
            this.dessertBackButton.TabIndex = 0;
            this.dessertBackButton.Text = "Back";
            this.dessertBackButton.UseVisualStyleBackColor = true;
            this.dessertBackButton.Click += new System.EventHandler(this.dessertBackButton_Click);
            // 
            // dessertMenuTitleLabel
            // 
            this.dessertMenuTitleLabel.AutoSize = true;
            this.dessertMenuTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertMenuTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.dessertMenuTitleLabel.Name = "dessertMenuTitleLabel";
            this.dessertMenuTitleLabel.Size = new System.Drawing.Size(134, 39);
            this.dessertMenuTitleLabel.TabIndex = 1;
            this.dessertMenuTitleLabel.Text = "Dessert";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dessertBackButton, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.sliceOfCakeButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sliceOfCakeLabel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 134);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // sliceOfCakeLabel
            // 
            this.sliceOfCakeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sliceOfCakeLabel.AutoSize = true;
            this.sliceOfCakeLabel.Location = new System.Drawing.Point(162, 121);
            this.sliceOfCakeLabel.Name = "sliceOfCakeLabel";
            this.sliceOfCakeLabel.Size = new System.Drawing.Size(70, 13);
            this.sliceOfCakeLabel.TabIndex = 1;
            this.sliceOfCakeLabel.Text = "Slice of Cake";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.souffleButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.souffleLabel, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(403, 143);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(394, 134);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // souffleButton
            // 
            this.souffleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.souffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.souffleButton.Image = global::Lab_3___Wakey_Wakey_Coffee_Shop.Properties.Resources.souffleDessertMenu;
            this.souffleButton.Location = new System.Drawing.Point(3, 3);
            this.souffleButton.Name = "souffleButton";
            this.souffleButton.Size = new System.Drawing.Size(388, 115);
            this.souffleButton.TabIndex = 0;
            this.souffleButton.UseVisualStyleBackColor = true;
            this.souffleButton.Click += new System.EventHandler(this.souffleButton_Click);
            // 
            // souffleLabel
            // 
            this.souffleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.souffleLabel.AutoSize = true;
            this.souffleLabel.Location = new System.Drawing.Point(177, 121);
            this.souffleLabel.Name = "souffleLabel";
            this.souffleLabel.Size = new System.Drawing.Size(40, 13);
            this.souffleLabel.TabIndex = 1;
            this.souffleLabel.Text = "Souffle";
            // 
            // sliceOfCakeButton
            // 
            this.sliceOfCakeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sliceOfCakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sliceOfCakeButton.Image = global::Lab_3___Wakey_Wakey_Coffee_Shop.Properties.Resources.cakeDessertMenu;
            this.sliceOfCakeButton.Location = new System.Drawing.Point(3, 3);
            this.sliceOfCakeButton.Name = "sliceOfCakeButton";
            this.sliceOfCakeButton.Size = new System.Drawing.Size(388, 115);
            this.sliceOfCakeButton.TabIndex = 0;
            this.sliceOfCakeButton.UseVisualStyleBackColor = true;
            this.sliceOfCakeButton.Click += new System.EventHandler(this.sliceOfCakeButton_Click);
            // 
            // DessertMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dessertMenuTitleLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DessertMenu";
            this.Text = "DessertMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dessertBackButton;
        private System.Windows.Forms.Label dessertMenuTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button sliceOfCakeButton;
        private System.Windows.Forms.Label sliceOfCakeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button souffleButton;
        private System.Windows.Forms.Label souffleLabel;
    }
}