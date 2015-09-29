namespace MapControlApplication1
{
    partial class CannyExatraction
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtTH = new System.Windows.Forms.TextBox();
            this.TxtTL = new System.Windows.Forms.TextBox();
            this.Canny = new System.Windows.Forms.Button();
            this.OPEN = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cannyPic = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pg1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Clear = new System.Windows.Forms.Button();
            this.cannyPicRe = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cannyPic)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cannyPicRe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 811);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1087, 811);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "High Threshold(TH)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1087, 871);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Low Threshold(TL)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(651, 811);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 4;
            // 
            // TxtTH
            // 
            this.TxtTH.Location = new System.Drawing.Point(1272, 859);
            this.TxtTH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTH.Name = "TxtTH";
            this.TxtTH.Size = new System.Drawing.Size(293, 22);
            this.TxtTH.TabIndex = 5;
            this.TxtTH.Text = "10";
            this.TxtTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtTL
            // 
            this.TxtTL.Location = new System.Drawing.Point(1272, 807);
            this.TxtTL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTL.Name = "TxtTL";
            this.TxtTL.Size = new System.Drawing.Size(293, 22);
            this.TxtTL.TabIndex = 6;
            this.TxtTL.Text = "5";
            this.TxtTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Canny
            // 
            this.Canny.Location = new System.Drawing.Point(1488, 895);
            this.Canny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Canny.Name = "Canny";
            this.Canny.Size = new System.Drawing.Size(100, 31);
            this.Canny.TabIndex = 8;
            this.Canny.Text = "Run";
            this.Canny.UseVisualStyleBackColor = true;
            this.Canny.Click += new System.EventHandler(this.Canny_Click);
            // 
            // OPEN
            // 
            this.OPEN.Location = new System.Drawing.Point(912, 811);
            this.OPEN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(33, 31);
            this.OPEN.TabIndex = 9;
            this.OPEN.Text = "...";
            this.OPEN.UseVisualStyleBackColor = true;
            this.OPEN.Click += new System.EventHandler(this.OPEN_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "O";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cannyPic
            // 
            this.cannyPic.Location = new System.Drawing.Point(17, 41);
            this.cannyPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cannyPic.Name = "cannyPic";
            this.cannyPic.Size = new System.Drawing.Size(849, 713);
            this.cannyPic.TabIndex = 11;
            this.cannyPic.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pg1,
            this.toolStripStatusLabel2,
            this.time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 940);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1732, 27);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 22);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // pg1
            // 
            this.pg1.Name = "pg1";
            this.pg1.Size = new System.Drawing.Size(133, 21);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(98, 22);
            this.toolStripStatusLabel2.Text = "Process Time:";
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 22);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1349, 895);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 31);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // cannyPicRe
            // 
            this.cannyPicRe.Location = new System.Drawing.Point(875, 41);
            this.cannyPicRe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cannyPicRe.Name = "cannyPicRe";
            this.cannyPicRe.Size = new System.Drawing.Size(849, 713);
            this.cannyPicRe.TabIndex = 15;
            this.cannyPicRe.TabStop = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1215, 895);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 31);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CannyExatraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 967);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.cannyPicRe);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cannyPic);
            this.Controls.Add(this.OPEN);
            this.Controls.Add(this.Canny);
            this.Controls.Add(this.TxtTL);
            this.Controls.Add(this.TxtTH);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CannyExatraction";
            this.Text = "CannyExatraction";
            this.Load += new System.EventHandler(this.CannyExatraction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cannyPic)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cannyPicRe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtTH;
        private System.Windows.Forms.TextBox TxtTL;
        private System.Windows.Forms.Button Canny;
        private System.Windows.Forms.Button OPEN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox cannyPic;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pg1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.PictureBox cannyPicRe;
        private System.Windows.Forms.Button Save;
    }
}