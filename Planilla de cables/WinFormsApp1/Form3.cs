using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public List<string> origin_list = new List<string>();
        public List<string> destination_list = new List<string>();
        public List<string> distance_list = new List<string>();

        int cmbbx_num = 0;

        List<string> option_values = new List<string>()
        {
            "U03", "U04", "U05", "U06", "U07", "U08", "U09", "U10", "U11", "U12", "U13", "U14", "U15",
            "U16", "U17", "U18", "U19", "U20", "U21", "U22", "U23", "U24", "U25", "U26", "U27", "U28",
            "U29", "U30", "U31", "U32", "U33", "U34", "U35", "U36", "U37", "U38", "U39", "U40", "U41",
            "U42", "U43", "U44", "U45",
            "B03", "B04", "B05", "B06", "B07", "B08", "B09", "B10", "B11", "B12", "B13", "B14", "B15",
            "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25", "B26", "B27", "B28",
            "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40", "B41",
            "B42", "B43", "B44", "B45"
        };
        public Form3(List<string> init_origin_list, List<string> init_destination_list, List<string> init_distance_list)
        {
            InitializeComponent();

            int nmb_cmb_bx = 0;

            for (int k = 0; k < 8; k++)
            {
                //if ((init_origin_list[k] != "") && (init_destination_list[k] != "") && (init_distance_list[k] != ""))
                if (((init_origin_list[k] != "") || (init_destination_list[k] != "")) && (init_distance_list[k] != ""))
                {
                    nmb_cmb_bx++;
                }
                else
                {
                    init_origin_list[k] = "";
                    init_destination_list[k] = "";
                    init_distance_list[k] = "";
                }
            }

            if (nmb_cmb_bx == 0) nmb_cmb_bx++;

            for (int n = 0; n < nmb_cmb_bx; n++)
            {

                ComboBox cmbbx_origin;

                cmbbx_origin = new ComboBox();
                cmbbx_origin.Location = new Point(183, 131 + cmbbx_num * 30);
                cmbbx_origin.Visible = true;
                cmbbx_origin.Text = "";
                cmbbx_origin.Name = "origin" + (cmbbx_num + 1);
                cmbbx_origin.Size = new Size(110, 25);

                for (int j = 0; j < option_values.Count; j++)
                {
                    cmbbx_origin.Items.Add(option_values[j]);
                }

                Controls.Add(cmbbx_origin);
                cmbbx_origin.BringToFront();

                ComboBox cmbbx_dest;

                cmbbx_dest = new ComboBox();
                cmbbx_dest.Location = new Point(300, 131 + cmbbx_num * 30);
                cmbbx_dest.Visible = true;
                cmbbx_dest.Text = "";
                cmbbx_dest.Name = "dest" + (cmbbx_num + 1);
                cmbbx_dest.Size = new Size(110, 25);

                for (int j = 0; j < option_values.Count; j++)
                {
                    cmbbx_dest.Items.Add(option_values[j]);
                }

                Controls.Add(cmbbx_dest);
                cmbbx_dest.BringToFront();

                Label label_equal;

                label_equal = new Label();
                label_equal.Location = new Point(418, 134 + cmbbx_num * 30);
                label_equal.Visible = true;
                label_equal.Text = "=";
                label_equal.BackColor = Color.White;
                label_equal.Size = new Size(19, 19);
                Controls.Add(label_equal);
                label_equal.BringToFront();

                TextBox txtbx_length;

                txtbx_length = new TextBox();
                txtbx_length.Location = new Point(445, 131 + cmbbx_num * 30);
                txtbx_length.Visible = true;
                txtbx_length.Text = "";
                txtbx_length.Name = "distance" + (cmbbx_num + 1);
                txtbx_length.Size = new Size(145, 25);
                Controls.Add(txtbx_length);
                txtbx_length.BringToFront();

                Label label_unit;

                label_unit = new Label();
                label_unit.Location = new Point(596, 134 + cmbbx_num * 30);
                label_unit.Visible = true;
                label_unit.Text = "m";
                label_unit.BackColor = Color.White;
                label_unit.Size = new Size(21, 19);
                Controls.Add(label_unit);
                label_unit.BringToFront();
                //}

                cmbbx_num++;

                origin_list = init_origin_list;
                destination_list = init_destination_list;
                distance_list = init_distance_list;

                foreach (var control in this.Controls)
                {
                    var combobox = control as ComboBox;
                    if (combobox != null)
                    {
                        if (combobox.Name.Contains("origin"))
                        {
                            //MessageBox.Show("Origin: last character is " + Int32.Parse((combobox.Name).Last().ToString()));
                            //MessageBox.Show("Origin: value is " + origin_list[Int32.Parse((combobox.Name).Last().ToString()) - 1]);
                            combobox.Text = origin_list[Int32.Parse((combobox.Name).Last().ToString()) - 1];
                        }
                        else if (combobox.Name.Contains("dest"))
                        {
                            //MessageBox.Show("Destination: last character is " + Int32.Parse((combobox.Name).Last().ToString()));
                            //MessageBox.Show("Destination: value is " + origin_list[Int32.Parse((combobox.Name).Last().ToString()) - 1]);
                            combobox.Text = destination_list[Int32.Parse((combobox.Name).Last().ToString()) - 1];
                        }
                        else
                        {
                            MessageBox.Show("Hay un error.");
                        }
                    }

                    var textbox = control as TextBox;
                    if (textbox != null)
                    {
                        textbox.Text = distance_list[Int32.Parse((textbox.Name).Last().ToString()) - 1];
                    }
                }

            }

            //List<ComboBox> cmbbx_origin = new List<ComboBox> ();

            //for (int i = 0; i < 8; i++)
            //for (int i = 0; i < 1; i++)
            //{
            //cmbbx_origin.Add();

            //for (int i = 0; i < 8; i++)
            //{
            //    origin_list.Add("");
            //    destination_list.Add("");
            //    distance_list.Add("");
            //}

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //docValues = "";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                var combobox = control as ComboBox;
                if (combobox != null)
                {
                    //MessageBox.Show(combobox.Name);

                    //MessageBox.Show((this.GetType().GetField("origin" + i.ToString())).GetValue(this).ToString());

                    if (combobox.Name.Contains("origin"))
                    {
                        origin_list[Int32.Parse((combobox.Name).Last().ToString()) - 1] = combobox.Text;
                    }
                    else if (combobox.Name.Contains("dest"))
                    {
                        destination_list[Int32.Parse((combobox.Name).Last().ToString()) - 1] = combobox.Text;
                    }
                    else
                    {
                        MessageBox.Show("Hay un error.");
                    }
                }

                var textbox = control as TextBox;
                if (textbox != null)
                {
                    distance_list[Int32.Parse((textbox.Name).Last().ToString()) - 1] = textbox.Text;
                }
            }

            ////docValues = "";
            //for (int i = 1; i < 9; i++)
            //{
            //    //var field = this.GetType().GetField("origin" + i);
            //    //var code = field.GetValue(this);

            //    MessageBox.Show((this.GetType().GetField("origin" + i.ToString())).GetValue(this).ToString());

            //    origin_list[i - 1] = (this.GetType().GetField("origin" + i)).GetValue(this).ToString();
            //    destination_list.Add("");
            //    distance_list.Add("");
            //}

            this.Close();
        }

        private void origin2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dest2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbbx_num < 8)
            {
                System.Windows.Forms.ComboBox cmbbx_origin;

                cmbbx_origin = new System.Windows.Forms.ComboBox();
                cmbbx_origin.Location = new Point(183, 131 + cmbbx_num * 30);
                cmbbx_origin.Visible = true;
                cmbbx_origin.Name = "origin" + (cmbbx_num + 1);
                cmbbx_origin.Text = origin_list[Int32.Parse((cmbbx_origin.Name).Last().ToString()) - 1];
                //cmbbx_origin.Text = "";
                cmbbx_origin.Size = new Size(110, 25);

                for (int j = 0; j < option_values.Count; j++)
                {
                    cmbbx_origin.Items.Add(option_values[j]);
                }

                Controls.Add(cmbbx_origin);
                cmbbx_origin.BringToFront();

                System.Windows.Forms.ComboBox cmbbx_dest;

                cmbbx_dest = new System.Windows.Forms.ComboBox();
                cmbbx_dest.Location = new Point(300, 131 + cmbbx_num * 30);
                cmbbx_dest.Visible = true;
                cmbbx_dest.Name = "dest" + (cmbbx_num + 1);
                cmbbx_dest.Text = destination_list[Int32.Parse((cmbbx_dest.Name).Last().ToString()) - 1]; ;
                //cmbbx_dest.Text = "";
                cmbbx_dest.Size = new Size(110, 25);

                for (int j = 0; j < option_values.Count; j++)
                {
                    cmbbx_dest.Items.Add(option_values[j]);
                }

                Controls.Add(cmbbx_dest);
                cmbbx_dest.BringToFront();

                Label label_equal;

                label_equal = new Label();
                label_equal.Location = new Point(418, 134 + cmbbx_num * 30);
                label_equal.Visible = true;
                label_equal.Text = "=";
                label_equal.BackColor = Color.White;
                label_equal.Size = new Size(19, 19);
                Controls.Add(label_equal);
                label_equal.BringToFront();

                System.Windows.Forms.TextBox txtbx_length;

                txtbx_length = new System.Windows.Forms.TextBox();
                txtbx_length.Location = new Point(445, 131 + cmbbx_num * 30);
                txtbx_length.Visible = true;
                txtbx_length.Name = "distance" + (cmbbx_num + 1);
                //txtbx_length.Text = "";
                txtbx_length.Text = distance_list[Int32.Parse((txtbx_length.Name).Last().ToString()) - 1]; ;
                txtbx_length.Size = new Size(145, 25);
                Controls.Add(txtbx_length);
                txtbx_length.BringToFront();

                Label label_unit;

                label_unit = new Label();
                label_unit.Location = new Point(596, 134 + cmbbx_num * 30);
                label_unit.Visible = true;
                label_unit.Text = "m";
                label_unit.BackColor = Color.White;
                label_unit.Size = new Size(21, 19);
                Controls.Add(label_unit);
                label_unit.BringToFront();
                //}

                cmbbx_num++;


                //foreach (var control in this.Controls)
                //{
                //    var combobox = control as System.Windows.Forms.ComboBox;
                //    if (combobox != null)
                //    {
                //        if (combobox.Name.Contains("origin"))
                //        {
                //            //MessageBox.Show("Origin: last character is " + Int32.Parse((combobox.Name).Last().ToString()));
                //            //MessageBox.Show("Origin: value is " + origin_list[Int32.Parse((combobox.Name).Last().ToString()) - 1]);
                //            combobox.Text = origin_list[Int32.Parse((combobox.Name).Last().ToString()) - 1];
                //        }
                //        else if (combobox.Name.Contains("dest"))
                //        {
                //            //MessageBox.Show("Destination: last character is " + Int32.Parse((combobox.Name).Last().ToString()));
                //            //MessageBox.Show("Destination: value is " + origin_list[Int32.Parse((combobox.Name).Last().ToString()) - 1]);
                //            combobox.Text = destination_list[Int32.Parse((combobox.Name).Last().ToString()) - 1];
                //        }
                //        else
                //        {
                //            MessageBox.Show("Hay un error.");
                //        }
                //    }

                //    var textbox = control as TextBox;
                //    if (textbox != null)
                //    {
                //        textbox.Text = distance_list[Int32.Parse((textbox.Name).Last().ToString()) - 1];
                //    }
                //}

            }
            else
            {
                MessageBox.Show("No se pueden agregar más filas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                var combobox = control as ComboBox;
                if (combobox != null)
                {
                    //MessageBox.Show(combobox.Name);

                    //MessageBox.Show((this.GetType().GetField("origin" + i.ToString())).GetValue(this).ToString());

                    if (combobox.Name.Contains("origin"))
                    {
                        origin_list[Int32.Parse((combobox.Name).Last().ToString()) - 1] = combobox.Text;
                    }
                    else if (combobox.Name.Contains("dest"))
                    {
                        destination_list[Int32.Parse((combobox.Name).Last().ToString()) - 1] = combobox.Text;
                    }
                    else
                    {
                        MessageBox.Show("Hay un error.");
                    }
                }

                var textbox = control as TextBox;
                if (textbox != null)
                {
                    distance_list[Int32.Parse((textbox.Name).Last().ToString()) - 1] = textbox.Text;
                }
            }

            int pointer = 0;

            for (int j = 0; j < 8; j++)
            {
                //option_values
                //if ((origin_list[j] != "" && destination_list[j] != "" && distance_list[j] != "") && (pointer != j))

                decimal number;

                // if (((option_values.IndexOf(origin_list[j]) >= 0) && (option_values.IndexOf(destination_list[j]) >= 0) && (Decimal.TryParse(distance_list[j], out number))) && (pointer != j))
                if (((option_values.IndexOf(origin_list[j]) >= 0) || (option_values.IndexOf(destination_list[j]) >= 0)) && (Decimal.TryParse(distance_list[j], out number)) && (pointer != j))
                    {
                    origin_list[pointer] = origin_list[j];
                    destination_list[pointer] = destination_list[j];
                    distance_list[pointer] = distance_list[j];
                    pointer++;
                    origin_list[j] = "";
                    destination_list[j] = "";
                    distance_list[j] = "";
                }
                //else if ((origin_list[j] != "" && destination_list[j] != "" && distance_list[j] != "") && (pointer == j))
                //else if (((option_values.IndexOf(origin_list[j]) >= 0) && (option_values.IndexOf(destination_list[j]) >= 0) && (Decimal.TryParse(distance_list[j], out number))) && (pointer == j))
                else if (((option_values.IndexOf(origin_list[j]) >= 0) || (option_values.IndexOf(destination_list[j]) >= 0)) && (Decimal.TryParse(distance_list[j], out number)) && (pointer == j))
                {
                    pointer++;
                }
                else
                {
                    origin_list[j] = "";
                    destination_list[j] = "";
                    distance_list[j] = "";
                }
            }

            ////docValues = "";
            //for (int i = 1; i < 9; i++)
            //{
            //    //var field = this.GetType().GetField("origin" + i);
            //    //var code = field.GetValue(this);

            //    MessageBox.Show((this.GetType().GetField("origin" + i.ToString())).GetValue(this).ToString());

            //    origin_list[i - 1] = (this.GetType().GetField("origin" + i)).GetValue(this).ToString();
            //    destination_list.Add("");
            //    distance_list.Add("");
            //}

            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
