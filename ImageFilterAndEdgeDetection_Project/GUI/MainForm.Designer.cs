
namespace ImageFilterAndEdgeDetection_Project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sobelBtn = new System.Windows.Forms.Button();
            this.kirschBtn = new System.Windows.Forms.Button();
            this.prewittBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorSwapBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BaWBox = new System.Windows.Forms.CheckBox();
            this.rainbowBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 419);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sobelBtn);
            this.tabPage2.Controls.Add(this.kirschBtn);
            this.tabPage2.Controls.Add(this.prewittBtn);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 102);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "edge recognition";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sobelBtn
            // 
            this.sobelBtn.Location = new System.Drawing.Point(6, 76);
            this.sobelBtn.Name = "sobelBtn";
            this.sobelBtn.Size = new System.Drawing.Size(157, 23);
            this.sobelBtn.TabIndex = 12;
            this.sobelBtn.Text = "Sobel 3x3";
            this.sobelBtn.UseVisualStyleBackColor = true;
            this.sobelBtn.Click += new System.EventHandler(this.sobelBtn_Click);
            // 
            // kirschBtn
            // 
            this.kirschBtn.Location = new System.Drawing.Point(6, 47);
            this.kirschBtn.Name = "kirschBtn";
            this.kirschBtn.Size = new System.Drawing.Size(157, 23);
            this.kirschBtn.TabIndex = 11;
            this.kirschBtn.Text = "Kirsch 3x3";
            this.kirschBtn.UseVisualStyleBackColor = true;
            this.kirschBtn.Click += new System.EventHandler(this.kirschBtn_Click);
            // 
            // prewittBtn
            // 
            this.prewittBtn.Location = new System.Drawing.Point(6, 18);
            this.prewittBtn.Name = "prewittBtn";
            this.prewittBtn.Size = new System.Drawing.Size(157, 23);
            this.prewittBtn.TabIndex = 10;
            this.prewittBtn.Text = "Prewitt 3x3";
            this.prewittBtn.UseVisualStyleBackColor = true;
            this.prewittBtn.Click += new System.EventHandler(this.prewittBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 46);
            this.button3.TabIndex = 9;
            this.button3.Text = "load image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(267, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 46);
            this.button4.TabIndex = 8;
            this.button4.Text = "save image";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "choose filter:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.colorSwapBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.BaWBox);
            this.tabPage1.Controls.Add(this.rainbowBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 102);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "image filter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "load image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "choose filters:";
            // 
            // colorSwapBox
            // 
            this.colorSwapBox.AutoSize = true;
            this.colorSwapBox.Location = new System.Drawing.Point(21, 74);
            this.colorSwapBox.Name = "colorSwapBox";
            this.colorSwapBox.Size = new System.Drawing.Size(112, 19);
            this.colorSwapBox.TabIndex = 2;
            this.colorSwapBox.Text = "Color swap filter";
            this.colorSwapBox.UseVisualStyleBackColor = true;
            this.colorSwapBox.CheckedChanged += new System.EventHandler(this.colorSwapBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "save image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BaWBox
            // 
            this.BaWBox.AutoSize = true;
            this.BaWBox.Location = new System.Drawing.Point(21, 49);
            this.BaWBox.Name = "BaWBox";
            this.BaWBox.Size = new System.Drawing.Size(138, 19);
            this.BaWBox.TabIndex = 1;
            this.BaWBox.Text = "Black and White filter";
            this.BaWBox.UseVisualStyleBackColor = true;
            this.BaWBox.CheckedChanged += new System.EventHandler(this.BaWBox_CheckedChanged);
            // 
            // rainbowBox
            // 
            this.rainbowBox.AutoSize = true;
            this.rainbowBox.Location = new System.Drawing.Point(21, 24);
            this.rainbowBox.Name = "rainbowBox";
            this.rainbowBox.Size = new System.Drawing.Size(99, 19);
            this.rainbowBox.TabIndex = 0;
            this.rainbowBox.Text = "Rainbow filter";
            this.rainbowBox.UseVisualStyleBackColor = true;
            this.rainbowBox.CheckedChanged += new System.EventHandler(this.rainbowBox_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 437);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 130);
            this.tabControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 579);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox colorSwapBox;
        private System.Windows.Forms.CheckBox BaWBox;
        private System.Windows.Forms.CheckBox rainbowBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button sobelBtn;
        private System.Windows.Forms.Button kirschBtn;
        private System.Windows.Forms.Button prewittBtn;
    }
}

