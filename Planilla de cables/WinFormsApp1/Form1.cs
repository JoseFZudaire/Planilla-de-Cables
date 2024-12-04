using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public List<string> origin_list = new List<string>();
        public List<string> destination_list = new List<string>();
        public List<string> distance_list = new List<string>();
        //Form2 frmDistance;

        public Form1()
        {
            InitializeComponent();

            estado.Text = "";

            button1.Enabled = false;
            string current_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string[] save_directory = current_path.Split(new string[] { "Documentos" }, StringSplitOptions.None);
            textBox2.Text = save_directory[0] + "Descargas\\Descarga.xlsx";

            if (save_directory.Length == 1)
            {
                save_directory = current_path.Split(new string[] { "Documents" }, StringSplitOptions.None);
                textBox2.Text = save_directory[0] + "Downloads\\Descarga.xlsx";
            }

            for (int i = 0; i < 8; i++)
            {
                origin_list.Add("");
                destination_list.Add("");
                distance_list.Add("");
            }

            //frmDistance = new Form2(origin_list, destination_list, distance_list);

            //textBox2.Text = "C:\\Downloads\\Descarga.xlsx";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "C:\\Users\\JZ4874\\Desktop\\";
            saveFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                string selectedFileName = saveFileDialog1.FileName;
                textBox2.Text = selectedFileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Users\\JZ4874\\Desktop\\";
            openFileDialog1.Filter = "Excel Files(.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                button1.Enabled = true;
                string selectedFileName = openFileDialog1.FileName;
                textBox1.Text = selectedFileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCmdText;

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string[] directory = path.Split(new string[] { "WinFormsApp1" }, StringSplitOptions.None);

            estado.Text = "Procesando ...";

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("/C",
            //    "node \"" + directory[0] + "readAndWrite.js\"  \"" + textBox1.Text + "\" \"" + textBox2.Text + "\" \"[" + Newtonsoft.Json.JsonConvert.SerializeObject(origin_list) + ";" + Newtonsoft.Json.JsonConvert.SerializeObject(destination_list) + ";" + Newtonsoft.Json.JsonConvert.SerializeObject(distance_list) + "]\"");

            //startInfo.RedirectStandardOutput = true;
            //startInfo.RedirectStandardError = true;

            //02-12-24 UNCOMMENT LATER
            //startInfo.UseShellExecute = false;
            //startInfo.CreateNoWindow = true;

            //process.StartInfo.UseShellExecute = false;
            //process.StartInfo.CreateNoWindow = true;
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;

            MessageBox.Show("Origin List: " + Newtonsoft.Json.JsonConvert.SerializeObject(origin_list));
            MessageBox.Show("Destination List: " + Newtonsoft.Json.JsonConvert.SerializeObject(destination_list));
            MessageBox.Show("Distance List: " + Newtonsoft.Json.JsonConvert.SerializeObject(distance_list));

            //02-12-24 UNCOMMENT LATER
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            MessageBox.Show("The value of the directory is: " + directory[0]);

            startInfo.Arguments = "/C node \"" + directory[0] + "readAndWrite.js\"  \"" + textBox1.Text + "\" \"" + textBox2.Text + "\" \"[" + Newtonsoft.Json.JsonConvert.SerializeObject(origin_list) + ";" + Newtonsoft.Json.JsonConvert.SerializeObject(destination_list) + ";" + Newtonsoft.Json.JsonConvert.SerializeObject(distance_list) + "]\"";
            process.StartInfo = startInfo;

            //process.OutputDataReceived += (sender, EventArgs) =>
            //{
            //    estado.Text = EventArgs.Data;
            //};

            process.Start();

            process.WaitForExit();

            MessageBox.Show("Se ha terminado el proceso", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            FileInfo fi = new FileInfo(textBox2.Text);
            if (fi.Exists)
            {
                estado.Text = "";

                System.Diagnostics.Process processFile = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfoFile = new System.Diagnostics.ProcessStartInfo();

                startInfoFile.RedirectStandardOutput = true;
                startInfoFile.RedirectStandardError = true;
                startInfoFile.UseShellExecute = false;
                startInfoFile.CreateNoWindow = true;

                startInfoFile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfoFile.FileName = "cmd.exe";
                startInfoFile.Arguments = "/C \"" + textBox2.Text + "\"";
                processFile.StartInfo = startInfoFile;

                processFile.Start();

                //System.Diagnostics.Process.Start("CMD.exe", "/C \"" + textBox2.Text + "\"");

                //System.Diagnostics.Process.Start("/C", "\"" + textBox2.Text + "\"");
            }
            else
            {
                MessageBox.Show("El archivo no pudo ser abierto", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            //if (process.Start())
            //{
            //    System.Threading.Thread.Sleep(1000);
            //    MessageBox.Show("Se ha terminado el proceso", "Mensaje", MessageBoxButtons.OKCancel);
            //    FileInfo fi = new FileInfo(textBox2.Text);
            //    if (fi.Exists)
            //    {
            //        System.Diagnostics.Process.Start("CMD.exe", "/C \"" + textBox2.Text + "\"");
            //        //System.Diagnostics.Process.Start("/C", "\"" + textBox2.Text + "\"");
            //    }
            //    else
            //    {
            //        MessageBox.Show("El archivo no pudo ser abierto", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 example = new Form3(origin_list, destination_list, distance_list);

            estado.Text = "Abriendo la ventana ...";

            this.Hide();

            example.FormClosed += (s, args) =>
            {
                this.Show();
                origin_list = example.origin_list;
                destination_list = example.destination_list;
                distance_list = example.distance_list;

                estado.Text = "";
            };

            example.Show();


            ////Form2 frm = new Form2();
            ////frm.Show();
            //////this.Close();
            ////this.Hide();

            //var frmDistance = new Form2(origin_list, destination_list, distance_list);

            ////public List<string> origin_list = new List<string>();
            ////public List<string> destination_list = new List<string>();
            ////public List<string> distance_list = new List<string>();
            //this.Hide();

            //frmDistance.Closed += (s, args) =>
            //{
            //    this.Show();

            //    origin_list = frmDistance.origin_list;
            //    destination_list = frmDistance.destination_list;
            //    distance_list = frmDistance.distance_list;

            //    //for(int j = 0; j < 8; j++)
            //    //{
            //    //    MessageBox.Show("Origin " + j + ": " + frmDistance.origin_list[j]);
            //    //    MessageBox.Show("Destination " + j + ": " + frmDistance.destination_list[j]);
            //    //    MessageBox.Show("Distance  " + j + ": " + frmDistance.distance_list[j]);
            //    //}

            //    //string[] values = { };

            //    //if (frmDistance.DocValues != "")
            //    //{
            //    //    values = formAddShts.DocValues.Split('\n');
            //    //}

            //    //for (int i = 0; i < values.Length; i++)
            //    //{
            //    //    System.Drawing.Bitmap icon = Properties.Resources.check;
            //    //    icon = new Bitmap(icon, new Size(24, 24));
            //    //    object[] tmp_data = new object[] {
            //    //        values[i],
            //    //        excelfilepath,
            //    //        1,
            //    //        icon};
            //    //    this.dataGridView1.Rows.Add(tmp_data);
            //    //    tmp_data = null;
            //    //    icon = null;
            //    //    this.st_label.Text = "Documento agregado a la lista";
            //    //    this.mensaje.Update();
            //    //}
            //};

            //frmDistance.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}