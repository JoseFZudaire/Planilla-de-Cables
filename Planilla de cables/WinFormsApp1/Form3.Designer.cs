namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            label18 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 463);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(445, 435);
            button2.Name = "button2";
            button2.Size = new Size(151, 43);
            button2.TabIndex = 57;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(232, 435);
            button1.Name = "button1";
            button1.Size = new Size(151, 43);
            button1.TabIndex = 56;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(144, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 369);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(465, 37);
            button3.Name = "button3";
            button3.Size = new Size(29, 29);
            button3.TabIndex = 51;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(39, 337);
            label18.Name = "label18";
            label18.Size = new Size(392, 13);
            label18.TabIndex = 50;
            label18.Text = "*Ingrese el valor constante que desea agregar a las distancias de los cables";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Dubai", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(154, 28);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 0;
            label1.Text = "Distancia de cables VA";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(776, 245);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 55;
            pictureBox4.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Modificación de distancia de cableado";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label18;
        private Label label1;
        private PictureBox pictureBox4;
        private Button button3;
    }
}