
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
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foodBackButton);
            this.Name = "FoodMenu";
            this.Text = "FoodMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button foodBackButton;
    }
}