namespace LinqMethods
{
    partial class Form1
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
            this.NewsText1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewsTitle1 = new System.Windows.Forms.TextBox();
            this.NewsImage1 = new System.Windows.Forms.PictureBox();
            this.NewsImage2 = new System.Windows.Forms.PictureBox();
            this.NewsTitle2 = new System.Windows.Forms.TextBox();
            this.NewsText2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NewsImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // NewsText1
            // 
            this.NewsText1.Location = new System.Drawing.Point(12, 67);
            this.NewsText1.Multiline = true;
            this.NewsText1.Name = "NewsText1";
            this.NewsText1.Size = new System.Drawing.Size(372, 517);
            this.NewsText1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(638, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(821, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(767, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // NewsTitle1
            // 
            this.NewsTitle1.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsTitle1.Location = new System.Drawing.Point(12, 12);
            this.NewsTitle1.Multiline = true;
            this.NewsTitle1.Name = "NewsTitle1";
            this.NewsTitle1.Size = new System.Drawing.Size(753, 49);
            this.NewsTitle1.TabIndex = 4;
            this.NewsTitle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewsImage1
            // 
            this.NewsImage1.Location = new System.Drawing.Point(424, 67);
            this.NewsImage1.Name = "NewsImage1";
            this.NewsImage1.Size = new System.Drawing.Size(341, 520);
            this.NewsImage1.TabIndex = 5;
            this.NewsImage1.TabStop = false;
            // 
            // NewsImage2
            // 
            this.NewsImage2.Location = new System.Drawing.Point(1193, 67);
            this.NewsImage2.Name = "NewsImage2";
            this.NewsImage2.Size = new System.Drawing.Size(341, 520);
            this.NewsImage2.TabIndex = 8;
            this.NewsImage2.TabStop = false;
            // 
            // NewsTitle2
            // 
            this.NewsTitle2.Font = new System.Drawing.Font("Monospac821 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsTitle2.Location = new System.Drawing.Point(781, 12);
            this.NewsTitle2.Multiline = true;
            this.NewsTitle2.Name = "NewsTitle2";
            this.NewsTitle2.Size = new System.Drawing.Size(753, 49);
            this.NewsTitle2.TabIndex = 7;
            this.NewsTitle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewsText2
            // 
            this.NewsText2.Location = new System.Drawing.Point(781, 67);
            this.NewsText2.Multiline = true;
            this.NewsText2.Name = "NewsText2";
            this.NewsText2.Size = new System.Drawing.Size(372, 517);
            this.NewsText2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 628);
            this.Controls.Add(this.NewsImage2);
            this.Controls.Add(this.NewsTitle2);
            this.Controls.Add(this.NewsText2);
            this.Controls.Add(this.NewsImage1);
            this.Controls.Add(this.NewsTitle1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewsText1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NewsImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewsText1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewsTitle1;
        private System.Windows.Forms.PictureBox NewsImage1;
        private System.Windows.Forms.PictureBox NewsImage2;
        private System.Windows.Forms.TextBox NewsTitle2;
        private System.Windows.Forms.TextBox NewsText2;
    }
}

