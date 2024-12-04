namespace WinFormsApp1
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            estado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Dubai", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 39);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 0;
            label1.Text = "Cargue el Excel de conexionado";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(176, 191);
            button1.Name = "button1";
            button1.Size = new Size(151, 43);
            button1.TabIndex = 3;
            button1.Text = "Procesar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Dubai", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(112, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 32);
            textBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(157, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 269);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(344, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 143);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "<";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(135, 83);
            button2.Name = "button2";
            button2.Size = new Size(170, 46);
            button2.TabIndex = 2;
            button2.Text = "Guardar como...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(82, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 30);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(754, 269);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 493);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Dubai", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(61, 417);
            button3.Name = "button3";
            button3.Size = new Size(185, 46);
            button3.TabIndex = 9;
            button3.Text = "Distancia de cables";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // estado
            // 
            estado.Location = new Point(25, 544);
            estado.Name = "estado";
            estado.Size = new Size(700, 15);
            estado.TabIndex = 10;
            estado.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(778, 568);
            Controls.Add(estado);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox4);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Planilla de cableado";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Button button3;
        private Label estado;
    }
}