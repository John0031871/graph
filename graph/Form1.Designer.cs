namespace graph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelFy = new System.Windows.Forms.Label();
            this.labelFx = new System.Windows.Forms.Label();
            this.LabelF = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(289, 357);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 3;
            // 
            // labelFy
            // 
            this.labelFy.AutoSize = true;
            this.labelFy.Location = new System.Drawing.Point(139, 270);
            this.labelFy.Name = "labelFy";
            this.labelFy.Size = new System.Drawing.Size(27, 13);
            this.labelFy.TabIndex = 4;
            this.labelFy.Text = "Fy =";
            // 
            // labelFx
            // 
            this.labelFx.AutoSize = true;
            this.labelFx.Location = new System.Drawing.Point(257, 411);
            this.labelFx.Name = "labelFx";
            this.labelFx.Size = new System.Drawing.Size(27, 13);
            this.labelFx.TabIndex = 5;
            this.labelFx.Text = "Fx =";
            // 
            // LabelF
            // 
            this.LabelF.AutoSize = true;
            this.LabelF.Location = new System.Drawing.Point(260, 185);
            this.LabelF.Name = "LabelF";
            this.LabelF.Size = new System.Drawing.Size(22, 13);
            this.LabelF.TabIndex = 6;
            this.LabelF.Text = "F =";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(330, 185);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(15, 13);
            this.labelN.TabIndex = 7;
            this.labelN.Text = "N";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(507, 289);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.LabelF);
            this.Controls.Add(this.labelFx);
            this.Controls.Add(this.labelFy);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelFy;
        private System.Windows.Forms.Label labelFx;
        private System.Windows.Forms.Label LabelF;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

