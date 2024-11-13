namespace Binary_File
{
    partial class DisplayForm
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
            this.displayFNtextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayFNtextBox
            // 
            this.displayFNtextBox.Enabled = false;
            this.displayFNtextBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayFNtextBox.Location = new System.Drawing.Point(11, 11);
            this.displayFNtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.displayFNtextBox.Multiline = true;
            this.displayFNtextBox.Name = "displayFNtextBox";
            this.displayFNtextBox.Size = new System.Drawing.Size(588, 312);
            this.displayFNtextBox.TabIndex = 21;
            this.displayFNtextBox.TextChanged += new System.EventHandler(this.displayFNtextBox_TextChanged);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(24, 358);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(93, 32);
            this.BackBtn.TabIndex = 37;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Binary_File.Properties.Resources.students_desk_wooden_background_54256611;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 401);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.displayFNtextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Form";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

















        private System.Windows.Forms.TextBox displayFNtextBox;
        private System.Windows.Forms.Button BackBtn;
    }
}