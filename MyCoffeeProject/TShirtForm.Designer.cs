namespace MyCoffeeProject
{
    partial class TShirtForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxTShirts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyCoffeeProject.Properties.Resources.Yoda_Coffee3;
            this.pictureBox1.Location = new System.Drawing.Point(230, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxTShirts
            // 
            this.comboBoxTShirts.FormattingEnabled = true;
            this.comboBoxTShirts.Location = new System.Drawing.Point(91, 333);
            this.comboBoxTShirts.Name = "comboBoxTShirts";
            this.comboBoxTShirts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTShirts.TabIndex = 1;
            // 
            // TShirtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 504);
            this.Controls.Add(this.comboBoxTShirts);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TShirtForm";
            this.Text = "TShirtForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxTShirts;
    }
}