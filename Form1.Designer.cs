namespace IFSconnectChallange
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
            this.components = new System.ComponentModel.Container();
            this.Draw = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sChar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontFaml = new System.Windows.Forms.Label();
            this.fontSz = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.enChar = new System.Windows.Forms.TextBox();
            this.strtChar = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.fontFam = new System.Windows.Forms.ComboBox();
            this.fontSize = new System.Windows.Forms.ComboBox();
            this.Default_Draw = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Draw
            // 
            this.Draw.BackColor = System.Drawing.Color.BlueViolet;
            this.Draw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Draw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Draw.Location = new System.Drawing.Point(570, 361);
            this.Draw.Name = "Draw";
            this.Draw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Draw.Size = new System.Drawing.Size(102, 45);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = false;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(62, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Digital Paint With Characters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "File path of the image :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "File path of the output file :";
            // 
            // sChar
            // 
            this.sChar.AutoSize = true;
            this.sChar.Location = new System.Drawing.Point(155, 178);
            this.sChar.Name = "sChar";
            this.sChar.Size = new System.Drawing.Size(61, 15);
            this.sChar.TabIndex = 13;
            this.sChar.Text = "startChar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "endChar :";
            // 
            // fontFaml
            // 
            this.fontFaml.AutoSize = true;
            this.fontFaml.Location = new System.Drawing.Point(143, 245);
            this.fontFaml.Name = "fontFaml";
            this.fontFaml.Size = new System.Drawing.Size(73, 15);
            this.fontFaml.TabIndex = 15;
            this.fontFaml.Text = "Font family :";
            // 
            // fontSz
            // 
            this.fontSz.AutoSize = true;
            this.fontSz.Location = new System.Drawing.Point(158, 277);
            this.fontSz.Name = "fontSz";
            this.fontSz.Size = new System.Drawing.Size(59, 15);
            this.fontSz.TabIndex = 16;
            this.fontSz.Text = "Font size :";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(227, 100);
            this.input.Name = "input";
            this.input.PlaceholderText = "C:\\Users\\GihanS\\Desktop\\baby.jpg";
            this.input.Size = new System.Drawing.Size(445, 23);
            this.input.TabIndex = 17;
            // 
            // enChar
            // 
            this.enChar.Location = new System.Drawing.Point(227, 208);
            this.enChar.Name = "enChar";
            this.enChar.Size = new System.Drawing.Size(49, 23);
            this.enChar.TabIndex = 18;
            // 
            // strtChar
            // 
            this.strtChar.Location = new System.Drawing.Point(227, 175);
            this.strtChar.Name = "strtChar";
            this.strtChar.Size = new System.Drawing.Size(49, 23);
            this.strtChar.TabIndex = 19;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(227, 138);
            this.output.Name = "output";
            this.output.PlaceholderText = "C:\\Users\\GihanS\\Desktop\\baby.txt";
            this.output.Size = new System.Drawing.Size(445, 23);
            this.output.TabIndex = 20;
            // 
            // fontFam
            // 
            this.fontFam.FormattingEnabled = true;
            this.fontFam.Location = new System.Drawing.Point(227, 243);
            this.fontFam.Name = "fontFam";
            this.fontFam.Size = new System.Drawing.Size(179, 23);
            this.fontFam.TabIndex = 21;
            // 
            // fontSize
            // 
            this.fontSize.FormattingEnabled = true;
            this.fontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.fontSize.Location = new System.Drawing.Point(227, 274);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(49, 23);
            this.fontSize.TabIndex = 22;
            // 
            // Default_Draw
            // 
            this.Default_Draw.BackColor = System.Drawing.Color.BlueViolet;
            this.Default_Draw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Default_Draw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Default_Draw.Location = new System.Drawing.Point(378, 361);
            this.Default_Draw.Name = "Default_Draw";
            this.Default_Draw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Default_Draw.Size = new System.Drawing.Size(169, 45);
            this.Default_Draw.TabIndex = 23;
            this.Default_Draw.Text = "Default Draw";
            this.Default_Draw.UseVisualStyleBackColor = false;
            this.Default_Draw.Click += new System.EventHandler(this.Default_Draw_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fill all input fields";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fill only 1st and 2nd input fields";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 448);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Default_Draw);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.fontFam);
            this.Controls.Add(this.output);
            this.Controls.Add(this.strtChar);
            this.Controls.Add(this.enChar);
            this.Controls.Add(this.input);
            this.Controls.Add(this.fontSz);
            this.Controls.Add(this.fontFaml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Draw);
            this.Name = "Form1";
            this.Text = "Digital Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Draw;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private FontDialog fontDialog1;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label1;
        private Label label2;
        private Label sChar;
        private Label label3;
        private Label fontFaml;
        private Label fontSz;
        private TextBox input;
        private TextBox enChar;
        private TextBox strtChar;
        private TextBox output;
        private ComboBox fontFam;
        private ComboBox fontSize;
        private Button Default_Draw;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label6;
        private Label label4;
    }
}