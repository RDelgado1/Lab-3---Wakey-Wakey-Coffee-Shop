
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
            this.SuspendLayout();
            // 
            // dessertBackButton
            // 
            this.dessertBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dessertBackButton.Location = new System.Drawing.Point(12, 415);
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
            // DessertMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dessertMenuTitleLabel);
            this.Controls.Add(this.dessertBackButton);
            this.Name = "DessertMenu";
            this.Text = "DessertMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dessertBackButton;
        private System.Windows.Forms.Label dessertMenuTitleLabel;
    }
}