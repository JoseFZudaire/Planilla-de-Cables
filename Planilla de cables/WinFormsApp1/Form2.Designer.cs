namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox4 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label18 = new Label();
            groupBox1 = new GroupBox();
            dest1 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            distance1 = new TextBox();
            origin1 = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dest2 = new ComboBox();
            distance2 = new TextBox();
            origin2 = new ComboBox();
            dest3 = new ComboBox();
            distance3 = new TextBox();
            origin3 = new ComboBox();
            dest5 = new ComboBox();
            distance5 = new TextBox();
            origin5 = new ComboBox();
            dest4 = new ComboBox();
            distance4 = new TextBox();
            origin4 = new ComboBox();
            dest8 = new ComboBox();
            distance8 = new TextBox();
            origin8 = new ComboBox();
            dest7 = new ComboBox();
            distance7 = new TextBox();
            origin7 = new ComboBox();
            dest6 = new ComboBox();
            distance6 = new TextBox();
            origin6 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(776, 245);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(232, 435);
            button1.Name = "button1";
            button1.Size = new Size(151, 43);
            button1.TabIndex = 51;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(445, 435);
            button2.Name = "button2";
            button2.Size = new Size(151, 43);
            button2.TabIndex = 52;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 463);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dest8);
            groupBox1.Controls.Add(distance8);
            groupBox1.Controls.Add(origin8);
            groupBox1.Controls.Add(dest7);
            groupBox1.Controls.Add(distance7);
            groupBox1.Controls.Add(origin7);
            groupBox1.Controls.Add(dest6);
            groupBox1.Controls.Add(distance6);
            groupBox1.Controls.Add(origin6);
            groupBox1.Controls.Add(dest5);
            groupBox1.Controls.Add(distance5);
            groupBox1.Controls.Add(origin5);
            groupBox1.Controls.Add(dest4);
            groupBox1.Controls.Add(distance4);
            groupBox1.Controls.Add(origin4);
            groupBox1.Controls.Add(dest3);
            groupBox1.Controls.Add(distance3);
            groupBox1.Controls.Add(origin3);
            groupBox1.Controls.Add(dest2);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(distance2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(origin2);
            groupBox1.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(144, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 369);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // dest1
            // 
            dest1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dest1.FormattingEnabled = true;
            dest1.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            dest1.Location = new Point(300, 131);
            dest1.Name = "dest1";
            dest1.Size = new Size(110, 25);
            dest1.TabIndex = 112;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(418, 134);
            label10.Name = "label10";
            label10.Size = new Size(19, 19);
            label10.TabIndex = 111;
            label10.Text = "=";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(596, 134);
            label11.Name = "label11";
            label11.Size = new Size(21, 19);
            label11.TabIndex = 110;
            label11.Text = "m";
            // 
            // distance1
            // 
            distance1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distance1.Location = new Point(445, 131);
            distance1.Name = "distance1";
            distance1.Size = new Size(145, 25);
            distance1.TabIndex = 109;
            // 
            // origin1
            // 
            origin1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            origin1.FormattingEnabled = true;
            origin1.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            origin1.Location = new Point(183, 131);
            origin1.Name = "origin1";
            origin1.Size = new Size(110, 25);
            origin1.TabIndex = 108;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(418, 351);
            label12.Name = "label12";
            label12.Size = new Size(19, 19);
            label12.TabIndex = 93;
            label12.Text = "=";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(596, 351);
            label13.Name = "label13";
            label13.Size = new Size(21, 19);
            label13.TabIndex = 92;
            label13.Text = "m";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(418, 320);
            label14.Name = "label14";
            label14.Size = new Size(19, 19);
            label14.TabIndex = 90;
            label14.Text = "=";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(596, 320);
            label15.Name = "label15";
            label15.Size = new Size(21, 19);
            label15.TabIndex = 89;
            label15.Text = "m";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(418, 289);
            label16.Name = "label16";
            label16.Size = new Size(19, 19);
            label16.TabIndex = 87;
            label16.Text = "=";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(596, 289);
            label17.Name = "label17";
            label17.Size = new Size(21, 19);
            label17.TabIndex = 86;
            label17.Text = "m";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(418, 258);
            label6.Name = "label6";
            label6.Size = new Size(19, 19);
            label6.TabIndex = 84;
            label6.Text = "=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(596, 258);
            label7.Name = "label7";
            label7.Size = new Size(21, 19);
            label7.TabIndex = 83;
            label7.Text = "m";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(418, 227);
            label8.Name = "label8";
            label8.Size = new Size(19, 19);
            label8.TabIndex = 81;
            label8.Text = "=";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(596, 227);
            label9.Name = "label9";
            label9.Size = new Size(21, 19);
            label9.TabIndex = 80;
            label9.Text = "m";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(418, 196);
            label4.Name = "label4";
            label4.Size = new Size(19, 19);
            label4.TabIndex = 78;
            label4.Text = "=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(596, 196);
            label5.Name = "label5";
            label5.Size = new Size(21, 19);
            label5.TabIndex = 77;
            label5.Text = "m";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(418, 165);
            label3.Name = "label3";
            label3.Size = new Size(19, 19);
            label3.TabIndex = 75;
            label3.Text = "=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(596, 165);
            label2.Name = "label2";
            label2.Size = new Size(21, 19);
            label2.TabIndex = 74;
            label2.Text = "m";
            // 
            // dest2
            // 
            dest2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dest2.FormattingEnabled = true;
            dest2.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            dest2.Location = new Point(156, 116);
            dest2.Name = "dest2";
            dest2.Size = new Size(110, 25);
            dest2.TabIndex = 115;
            // 
            // distance2
            // 
            distance2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distance2.Location = new Point(301, 116);
            distance2.Name = "distance2";
            distance2.Size = new Size(145, 25);
            distance2.TabIndex = 114;
            // 
            // origin2
            // 
            origin2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            origin2.FormattingEnabled = true;
            origin2.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            origin2.Location = new Point(39, 116);
            origin2.Name = "origin2";
            origin2.Size = new Size(110, 25);
            origin2.TabIndex = 113;
            // 
            // dest3
            // 
            dest3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dest3.FormattingEnabled = true;
            dest3.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            dest3.Location = new Point(156, 148);
            dest3.Name = "dest3";
            dest3.Size = new Size(110, 25);
            dest3.TabIndex = 118;
            // 
            // distance3
            // 
            distance3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distance3.Location = new Point(301, 148);
            distance3.Name = "distance3";
            distance3.Size = new Size(145, 25);
            distance3.TabIndex = 117;
            // 
            // origin3
            // 
            origin3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            origin3.FormattingEnabled = true;
            origin3.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            origin3.Location = new Point(39, 148);
            origin3.Name = "origin3";
            origin3.Size = new Size(110, 25);
            origin3.TabIndex = 116;
            // 
            // dest5
            // 
            dest5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dest5.FormattingEnabled = true;
            dest5.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            dest5.Location = new Point(156, 210);
            dest5.Name = "dest5";
            dest5.Size = new Size(110, 25);
            dest5.TabIndex = 124;
            // 
            // distance5
            // 
            distance5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distance5.Location = new Point(301, 210);
            distance5.Name = "distance5";
            distance5.Size = new Size(145, 25);
            distance5.TabIndex = 123;
            // 
            // origin5
            // 
            origin5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            origin5.FormattingEnabled = true;
            origin5.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            origin5.Location = new Point(39, 210);
            origin5.Name = "origin5";
            origin5.Size = new Size(110, 25);
            origin5.TabIndex = 122;
            // 
            // dest4
            // 
            dest4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dest4.FormattingEnabled = true;
            dest4.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            dest4.Location = new Point(156, 179);
            dest4.Name = "dest4";
            dest4.Size = new Size(110, 25);
            dest4.TabIndex = 121;
            // 
            // distance4
            // 
            distance4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distance4.Location = new Point(301, 179);
            distance4.Name = "distance4";
            distance4.Size = new Size(145, 25);
            distance4.TabIndex = 120;
            // 
            // origin4
            // 
            origin4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            origin4.FormattingEnabled = true;
            origin4.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            origin4.Location = new Point(39, 179);
            origin4.Name = "origin4";
            origin4.Size = new Size(110, 25);
            origin4.TabIndex = 119;
            // 
            // dest8
            // 
            dest8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dest8.FormattingEnabled = true;
            dest8.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            dest8.Location = new Point(156, 302);
            dest8.Name = "dest8";
            dest8.Size = new Size(110, 25);
            dest8.TabIndex = 133;
            // 
            // distance8
            // 
            distance8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distance8.Location = new Point(301, 302);
            distance8.Name = "distance8";
            distance8.Size = new Size(145, 25);
            distance8.TabIndex = 132;
            // 
            // origin8
            // 
            origin8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            origin8.FormattingEnabled = true;
            origin8.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            origin8.Location = new Point(39, 302);
            origin8.Name = "origin8";
            origin8.Size = new Size(110, 25);
            origin8.TabIndex = 131;
            // 
            // dest7
            // 
            dest7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dest7.FormattingEnabled = true;
            dest7.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            dest7.Location = new Point(156, 271);
            dest7.Name = "dest7";
            dest7.Size = new Size(110, 25);
            dest7.TabIndex = 130;
            // 
            // distance7
            // 
            distance7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distance7.Location = new Point(301, 271);
            distance7.Name = "distance7";
            distance7.Size = new Size(145, 25);
            distance7.TabIndex = 129;
            // 
            // origin7
            // 
            origin7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            origin7.FormattingEnabled = true;
            origin7.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            origin7.Location = new Point(39, 271);
            origin7.Name = "origin7";
            origin7.Size = new Size(110, 25);
            origin7.TabIndex = 128;
            // 
            // dest6
            // 
            dest6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dest6.FormattingEnabled = true;
            dest6.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            dest6.Location = new Point(156, 240);
            dest6.Name = "dest6";
            dest6.Size = new Size(110, 25);
            dest6.TabIndex = 127;
            // 
            // distance6
            // 
            distance6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distance6.Location = new Point(301, 240);
            distance6.Name = "distance6";
            distance6.Size = new Size(145, 25);
            distance6.TabIndex = 126;
            // 
            // origin6
            // 
            origin6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            origin6.FormattingEnabled = true;
            origin6.Items.AddRange(new object[] { "", "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15", "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28", "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41", "U42", "U43", "U44", "U45", "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41", "B42", "B43", "B44", "B45" });
            origin6.Location = new Point(39, 240);
            origin6.Name = "origin6";
            origin6.Size = new Size(110, 25);
            origin6.TabIndex = 125;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(dest1);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(distance1);
            Controls.Add(origin1);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Modificación de distancia de cableado";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox4;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label18;
        private GroupBox groupBox1;
        private ComboBox dest1;
        private Label label10;
        private Label label11;
        private TextBox distance1;
        private ComboBox origin1;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox dest5;
        private TextBox distance5;
        private ComboBox origin5;
        private ComboBox dest4;
        private TextBox distance4;
        private ComboBox origin4;
        private ComboBox dest3;
        private TextBox distance3;
        private ComboBox origin3;
        private ComboBox dest2;
        private TextBox distance2;
        private ComboBox origin2;
        private ComboBox dest8;
        private TextBox distance8;
        private ComboBox origin8;
        private ComboBox dest7;
        private TextBox distance7;
        private ComboBox origin7;
        private ComboBox dest6;
        private TextBox distance6;
        private ComboBox origin6;
    }
}