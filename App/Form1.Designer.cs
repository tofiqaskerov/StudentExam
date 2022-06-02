namespace App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.VariantA = new System.Windows.Forms.RadioButton();
            this.VariantD = new System.Windows.Forms.RadioButton();
            this.VariantC = new System.Windows.Forms.RadioButton();
            this.VariantB = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlExam = new System.Windows.Forms.Panel();
            this.LblCorrect = new System.Windows.Forms.Label();
            this.BtnStartQuize = new System.Windows.Forms.Button();
            this.PnlStartQuiz = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PnlExam.SuspendLayout();
            this.PnlStartQuiz.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(19, 16);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(71, 37);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Sual";
            // 
            // VariantA
            // 
            this.VariantA.AutoSize = true;
            this.VariantA.Location = new System.Drawing.Point(46, 100);
            this.VariantA.Name = "VariantA";
            this.VariantA.Size = new System.Drawing.Size(102, 24);
            this.VariantA.TabIndex = 1;
            this.VariantA.TabStop = true;
            this.VariantA.Text = "A) Cavab 1";
            this.VariantA.UseVisualStyleBackColor = true;
            // 
            // VariantD
            // 
            this.VariantD.AutoSize = true;
            this.VariantD.Location = new System.Drawing.Point(426, 159);
            this.VariantD.Name = "VariantD";
            this.VariantD.Size = new System.Drawing.Size(103, 24);
            this.VariantD.TabIndex = 3;
            this.VariantD.TabStop = true;
            this.VariantD.Text = "D) Cavab 4";
            this.VariantD.UseVisualStyleBackColor = true;
            // 
            // VariantC
            // 
            this.VariantC.AutoSize = true;
            this.VariantC.Location = new System.Drawing.Point(46, 159);
            this.VariantC.Name = "VariantC";
            this.VariantC.Size = new System.Drawing.Size(101, 24);
            this.VariantC.TabIndex = 4;
            this.VariantC.TabStop = true;
            this.VariantC.Text = "C) Cavab 3";
            this.VariantC.UseVisualStyleBackColor = true;
            // 
            // VariantB
            // 
            this.VariantB.AutoSize = true;
            this.VariantB.Location = new System.Drawing.Point(428, 100);
            this.VariantB.Name = "VariantB";
            this.VariantB.Size = new System.Drawing.Size(101, 24);
            this.VariantB.TabIndex = 5;
            this.VariantB.TabStop = true;
            this.VariantB.Text = "B) Cavab 2";
            this.VariantB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cavabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlExam
            // 
            this.PnlExam.BackColor = System.Drawing.Color.Gray;
            this.PnlExam.Controls.Add(this.button1);
            this.PnlExam.Controls.Add(this.lblQuestion);
            this.PnlExam.Controls.Add(this.VariantB);
            this.PnlExam.Controls.Add(this.VariantA);
            this.PnlExam.Controls.Add(this.VariantC);
            this.PnlExam.Controls.Add(this.VariantD);
            this.PnlExam.Location = new System.Drawing.Point(1273, 3);
            this.PnlExam.Name = "PnlExam";
            this.PnlExam.Size = new System.Drawing.Size(584, 516);
            this.PnlExam.TabIndex = 7;
            this.PnlExam.Visible = false;
            // 
            // LblCorrect
            // 
            this.LblCorrect.AutoSize = true;
            this.LblCorrect.Location = new System.Drawing.Point(1108, 9);
            this.LblCorrect.Name = "LblCorrect";
            this.LblCorrect.Size = new System.Drawing.Size(17, 20);
            this.LblCorrect.TabIndex = 7;
            this.LblCorrect.Text = "0";
            // 
            // BtnStartQuize
            // 
            this.BtnStartQuize.Location = new System.Drawing.Point(21, 385);
            this.BtnStartQuize.Name = "BtnStartQuize";
            this.BtnStartQuize.Size = new System.Drawing.Size(181, 50);
            this.BtnStartQuize.TabIndex = 7;
            this.BtnStartQuize.Text = "Imtahana basla";
            this.BtnStartQuize.UseVisualStyleBackColor = true;
            this.BtnStartQuize.Click += new System.EventHandler(this.BtnStartQuize_Click);
            // 
            // PnlStartQuiz
            // 
            this.PnlStartQuiz.BackColor = System.Drawing.Color.IndianRed;
            this.PnlStartQuiz.Controls.Add(this.label1);
            this.PnlStartQuiz.Controls.Add(this.BtnStartQuize);
            this.PnlStartQuiz.Location = new System.Drawing.Point(1232, 525);
            this.PnlStartQuiz.Name = "PnlStartQuiz";
            this.PnlStartQuiz.Size = new System.Drawing.Size(625, 516);
            this.PnlStartQuiz.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imtahan Haqqinda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 652);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1030, 652);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 646);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(724, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 646);
            this.panel2.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(274, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(24, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(97)))), ((int)(((byte)(125)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(32, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(32, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.Transparent;
            this.textBox2.Location = new System.Drawing.Point(32, 308);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(231, 34);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(32, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Transparent;
            this.textBox1.Location = new System.Drawing.Point(32, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 34);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sign In to your accaount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(53, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 52);
            this.label5.TabIndex = 0;
            this.label5.Text = "Welcome !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 1065);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlStartQuiz);
            this.Controls.Add(this.LblCorrect);
            this.Controls.Add(this.PnlExam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlExam.ResumeLayout(false);
            this.PnlExam.PerformLayout();
            this.PnlStartQuiz.ResumeLayout(false);
            this.PnlStartQuiz.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQuestion;
        private RadioButton VariantA;
        private RadioButton VariantD;
        private RadioButton VariantC;
        private RadioButton VariantB;
        private Button button1;
        private Panel PnlExam;
        private Label LblCorrect;
        private Button BtnStartQuize;
        private Panel PnlStartQuiz;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button BtnClose;
        private Button button2;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label5;
    }
}