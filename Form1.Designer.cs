namespace cs_256color
{
    partial class Form1
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
            this.button_openfile = new System.Windows.Forms.Button();
            this.numericUpDown_block_size = new System.Windows.Forms.NumericUpDown();
            this.label_filepath = new System.Windows.Forms.Label();
            this.button_gen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_block_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_openfile
            // 
            this.button_openfile.Location = new System.Drawing.Point(29, 21);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(94, 29);
            this.button_openfile.TabIndex = 0;
            this.button_openfile.Text = "打开图片";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // numericUpDown_block_size
            // 
            this.numericUpDown_block_size.Location = new System.Drawing.Point(29, 70);
            this.numericUpDown_block_size.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_block_size.Name = "numericUpDown_block_size";
            this.numericUpDown_block_size.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown_block_size.TabIndex = 1;
            this.numericUpDown_block_size.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label_filepath
            // 
            this.label_filepath.AutoSize = true;
            this.label_filepath.Location = new System.Drawing.Point(144, 25);
            this.label_filepath.Name = "label_filepath";
            this.label_filepath.Size = new System.Drawing.Size(68, 20);
            this.label_filepath.TabIndex = 2;
            this.label_filepath.Text = "<none>";
            // 
            // button_gen
            // 
            this.button_gen.Location = new System.Drawing.Point(215, 68);
            this.button_gen.Name = "button_gen";
            this.button_gen.Size = new System.Drawing.Size(94, 29);
            this.button_gen.TabIndex = 3;
            this.button_gen.Text = "生成";
            this.button_gen.UseVisualStyleBackColor = true;
            this.button_gen.Click += new System.EventHandler(this.button_gen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(29, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 636);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 784);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_gen);
            this.Controls.Add(this.label_filepath);
            this.Controls.Add(this.numericUpDown_block_size);
            this.Controls.Add(this.button_openfile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_block_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_openfile;
        private NumericUpDown numericUpDown_block_size;
        private Label label_filepath;
        private Button button_gen;
        private PictureBox pictureBox1;
    }
}