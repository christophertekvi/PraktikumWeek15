using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek15
{
    public partial class FormPesen : Form
    {
        public FormPesen()
        {
            InitializeComponent();
        }

        public string[] makanan = new string[4];
        public string[] minuman = new string[4];
        public int[] hargamakan = new int[4];
        public int[] hargaminumjmb = new int[4];
        public int[] hargaminumnorm = new int[4];
        public static int totalharga = 0;
        


        private void radioButtonMakan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMakan.Checked == true)
            {
                labelAngkaHarga.Text = "";
                radioButtonSzNorm.Visible = false;
                radioButtonJumbo.Visible = false;
                comboBoxMenu.Text = "";
                comboBoxMenu.Items.Clear();
                for (int i = 0; i < 4; i++)
                {
                    comboBoxMenu.Items.Add(makanan[i]);
                }
            }
        }
        private void FormPesen_Load(object sender, EventArgs e)
        {
            makanan[0] = "Nasi Goreng";
            makanan[1] = "Nasi Goreng Spesial";
            makanan[2] = "Nasi Goeng Pete";
            makanan[3] = "Ayam Bakar";

            minuman[0] = "Es Teh";
            minuman[1] = "Teh Hangat";
            minuman[2] = "Nutrisari";
            minuman[3] = "Aqua";

            hargamakan[0] = 10000;
            hargamakan[1] = 12000;
            hargamakan[2] = 15000;
            hargamakan[3] = 15000;

            hargaminumnorm[0] = 5000;
            hargaminumnorm[1] = 3000;
            hargaminumnorm[2] = 6000;
            hargaminumnorm[3] = 2000;

            hargaminumjmb[0] = 7000;
            hargaminumjmb[1] = 5000;
            hargaminumjmb[2] = 10000;
            hargaminumjmb[3] = 5000;

            
        }

        private void radioButtonMinum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinum.Checked == true)
            {
                comboBoxMenu.Text = "";
                labelAngkaHarga.Text = "";
                radioButtonSzNorm.Visible = true;
                radioButtonJumbo.Visible = true;
                comboBoxMenu.Items.Clear();
                for (int i = 0; i < 4; i++)
                {
                    comboBoxMenu.Items.Add(minuman[i]);
                }
            }
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonMakan.Checked == true)
            {
                
                if (comboBoxMenu.SelectedIndex == 0)
                {
                    labelAngkaHarga.Text = Convert.ToString(hargamakan[0]);
                }
                if (comboBoxMenu.SelectedIndex == 1)
                {
                    labelAngkaHarga.Text = Convert.ToString(hargamakan[1]);
                }
                if (comboBoxMenu.SelectedIndex == 2)
                {
                    labelAngkaHarga.Text = Convert.ToString(hargamakan[2]);
                }
                if (comboBoxMenu.SelectedIndex == 3)
                {
                    labelAngkaHarga.Text = Convert.ToString(hargamakan[3]);
                }
            }
            if (radioButtonMinum.Checked == true)
            {
                if (comboBoxMenu.SelectedIndex == 0)
                {
                    if (radioButtonJumbo.Checked == true)
                    { 
                        labelAngkaHarga.Text = Convert.ToString(hargaminumjmb[0]);
                    }

                    if (radioButtonSzNorm.Checked == true)
                    {
                        labelAngkaHarga.Text = Convert.ToString(hargaminumnorm[0]);
                    }
                    
                }
                if (comboBoxMenu.SelectedIndex == 1)
                {
                    if (radioButtonJumbo.Checked == true)
                    {
                        labelAngkaHarga.Text = Convert.ToString(hargaminumjmb[1]);
                    }

                    if (radioButtonSzNorm.Checked == true)
                    {
                        labelAngkaHarga.Text = Convert.ToString(hargaminumnorm[1]);
                    }
                    
                }
                if (comboBoxMenu.SelectedIndex == 2)
                {
                    if (radioButtonJumbo.Checked == true)
                    {
                        labelAngkaHarga.Text = Convert.ToString(hargaminumjmb[2]);
                    }

                    if (radioButtonSzNorm.Checked == true)
                    {
                        labelAngkaHarga.Text = Convert.ToString(hargaminumnorm[2]);
                    }
                }
                if (comboBoxMenu.SelectedIndex == 3)
                {
                    if (radioButtonJumbo.Checked == true)
                    {
                        labelAngkaHarga.Text = Convert.ToString(hargaminumjmb[3]);
                    }

                    if (radioButtonSzNorm.Checked == true)
                    {
                        labelAngkaHarga.Text = Convert.ToString(hargaminumnorm[3]);
                    }
                }
                
            }

        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            listBoxMenu.Items.Add(comboBoxMenu.Text);
            listBoxHarga.Items.Add(labelAngkaHarga.Text);

            
        }
        private void ceklistbox()
        {
            if (listBoxMenu.Items.Count == 0)
            {
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = true;
            }
        }
    

        private void radioButtonSzNorm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBoxHarga.Items.RemoveAt(listBoxMenu.SelectedIndex);
            listBoxMenu.Items.RemoveAt(listBoxMenu.SelectedIndex);
            ceklistbox();
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.Items.Count == 0)
            {
                MessageBox.Show("Choose Menu!!");
            }
            else
            {
                var formbayar = new Form2();
                formbayar.Show();
            }
        }
    }
}
