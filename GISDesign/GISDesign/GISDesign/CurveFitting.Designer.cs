namespace MapControlApplication1
{
    partial class CurveFitting
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Raster = new System.Windows.Forms.PictureBox();
            this.FileOp = new System.Windows.Forms.Button();
            this.FileshowBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Raster)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "CurveFitting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parameters:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // Raster
            // 
            this.Raster.Location = new System.Drawing.Point(375, 12);
            this.Raster.Name = "Raster";
            this.Raster.Size = new System.Drawing.Size(497, 309);
            this.Raster.TabIndex = 3;
            this.Raster.TabStop = false;
            // 
            // FileOp
            // 
            this.FileOp.Location = new System.Drawing.Point(47, 154);
            this.FileOp.Name = "FileOp";
            this.FileOp.Size = new System.Drawing.Size(75, 23);
            this.FileOp.TabIndex = 4;
            this.FileOp.Text = "Open Files:";
            this.FileOp.UseVisualStyleBackColor = true;
            this.FileOp.Click += new System.EventHandler(this.FileOp_Click);
            // 
            // FileshowBox
            // 
            this.FileshowBox.Location = new System.Drawing.Point(148, 154);
            this.FileshowBox.Name = "FileshowBox";
            this.FileshowBox.Size = new System.Drawing.Size(162, 21);
            this.FileshowBox.TabIndex = 5;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(235, 259);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // CurveFitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 333);
            this.Controls.Add(this.save);
            this.Controls.Add(this.FileshowBox);
            this.Controls.Add(this.FileOp);
            this.Controls.Add(this.Raster);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "CurveFitting";
            this.Text = "CurveFitting";
            ((System.ComponentModel.ISupportInitialize)(this.Raster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Raster;
        private System.Windows.Forms.Button FileOp;
        private System.Windows.Forms.TextBox FileshowBox;
        private System.Windows.Forms.Button save;
    }
}