
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
            this.SuspendLayout();
            // 
            // drinksBackButton
            // 
            this.drinksBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.drinksBackButton.Location = new System.Drawing.Point(12, 415);
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
            // DrinksMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drinksMenuTitleLabel);
            this.Controls.Add(this.drinksBackButton);
            this.Name = "DrinksMenu";
            this.Text = "DrinksMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drinksBackButton;
        private System.Windows.Forms.Label drinksMenuTitleLabel;
    }
}