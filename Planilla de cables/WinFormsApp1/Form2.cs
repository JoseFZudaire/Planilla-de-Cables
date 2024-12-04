using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public List<string> origin_list = new List<string>();
        public List<string> destination_list = new List<string>();
        public List<string> distance_list = new List<string>();

        public Form2(List<string> init_origin_list, List<string> init_destination_list, List<string> init_distance_list)
        {
            InitializeComponent();

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
                        combobox.Text = origin_list[Int32.Parse((combobox.Name).Last().ToString()) - 1];
                    }
                    else if (combobox.Name.Contains("dest"))
                    {
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

            //for (int i = 0; i < 8; i++)
            //{
            //    origin_list.Add("");
            //    destination_list.Add("");
            //    distance_list.Add("");
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
