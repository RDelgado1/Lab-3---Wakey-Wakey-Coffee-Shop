
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
            // DrinksMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drinksBackButton);
            this.Name = "DrinksMenu";
            this.Text = "DrinksMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drinksBackButton;
    }
}