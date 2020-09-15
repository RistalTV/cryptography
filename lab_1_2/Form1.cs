using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAcceptMainLeft_Click(object sender, EventArgs e)
        {
            if (this.RadButMethod_1.Checked == true)
            {
                RadButMethod_1_Click(sender, e);
            }
            else if (this.RadButMethod_2.Checked == true)
            {
                RadButMethod_2_Click(sender, e);
            }
            else if (this.RadButMethod_3.Checked == true)
            {
                RadButMethod_3_Click(sender, e);
            }
            else if(this.RadButMethod_4.Checked == true)
            {
                RadButMethod_4_Click(sender, e);
            }
            else if (this.RadButMethod_5.Checked == true)
            {
                RadButMethod_5_Click(sender, e);
            }
            
        }

        private void RadButMethod_1_Click(object sender, EventArgs e)
        {
            this.panelMethod_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_2.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_3.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_5.Dock = System.Windows.Forms.DockStyle.None;

            this.panelMethod_1.Visible = true;
            this.panelMethod_2.Visible = false;
            this.panelMethod_3.Visible = false;
            this.panelMethod_4.Visible = false;
            this.panelMethod_5.Visible = false;

            this.panelMethod_1.Enabled = true;
            this.panelMethod_2.Enabled = false;
            this.panelMethod_3.Enabled = false;
            this.panelMethod_4.Enabled = false;
            this.panelMethod_5.Enabled = false;
        }

        private void RadButMethod_2_Click(object sender, EventArgs e)
        {
            this.panelMethod_1.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_3.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_5.Dock = System.Windows.Forms.DockStyle.None;

            this.panelMethod_1.Visible = false;
            this.panelMethod_2.Visible = true;
            this.panelMethod_3.Visible = false;
            this.panelMethod_4.Visible = false;
            this.panelMethod_5.Visible = false;

            this.panelMethod_1.Enabled = false;
            this.panelMethod_2.Enabled = true;
            this.panelMethod_3.Enabled = false;
            this.panelMethod_4.Enabled = false;
            this.panelMethod_5.Enabled = false;
        }

        private void RadButMethod_3_Click(object sender, EventArgs e)
        {
            this.panelMethod_1.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_2.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_5.Dock = System.Windows.Forms.DockStyle.None;

            this.panelMethod_1.Visible = false;
            this.panelMethod_2.Visible = false;
            this.panelMethod_3.Visible = true;
            this.panelMethod_4.Visible = false;
            this.panelMethod_5.Visible = false;

            this.panelMethod_1.Enabled = false;
            this.panelMethod_2.Enabled = false;
            this.panelMethod_3.Enabled = true;
            this.panelMethod_4.Enabled = false;
            this.panelMethod_5.Enabled = false;
        }

        private void RadButMethod_4_Click(object sender, EventArgs e)
        {
            this.panelMethod_1.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_2.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_3.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_5.Dock = System.Windows.Forms.DockStyle.None;

            this.panelMethod_1.Visible = false;
            this.panelMethod_2.Visible = false;
            this.panelMethod_3.Visible = false;
            this.panelMethod_4.Visible = true;
            this.panelMethod_5.Visible = false;

            this.panelMethod_1.Enabled = false;
            this.panelMethod_2.Enabled = false;
            this.panelMethod_3.Enabled = false;
            this.panelMethod_4.Enabled = true;
            this.panelMethod_5.Enabled = false;
        }

        private void RadButMethod_5_Click(object sender, EventArgs e)
        {
            this.panelMethod_1.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_2.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_3.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_5.Dock = System.Windows.Forms.DockStyle.Fill;

            this.panelMethod_1.Visible = false; 
            this.panelMethod_2.Visible = false; 
            this.panelMethod_3.Visible = false;
            this.panelMethod_4.Visible = false;
            this.panelMethod_5.Visible = true;

            this.panelMethod_1.Enabled = false;
            this.panelMethod_2.Enabled = false;
            this.panelMethod_3.Enabled = false;
            this.panelMethod_4.Enabled = false;
            this.panelMethod_5.Enabled = true;

        }

        private void panelMethod_1_textBox_k_Leave(object sender, EventArgs e)
        {
            if (this.panelMethod_1_textBox_k.Text == "")
            {
                if (this.panelMethod_1_rbRU.Checked)
                    MessageBox.Show("Введите число от 0 до 33", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Введите число от 0 до 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panelMethod_1_textBox_k.Text = "0";
            }
            bool f = false;
            foreach (var c in this.panelMethod_1_textBox_k.Text)
            {
                if ((c<48) || (c>58))
                {
                    if (this.panelMethod_1_rbRU.Checked)
                        MessageBox.Show("Введите число от 0 до 33", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Введите число от 0 до 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.panelMethod_1_textBox_k.Text = "0";
                    break;
                }
                for(var i=48;i<59;i++)
                {
                    if (c == Convert.ToChar(i))
                    {
                        f = true;
                        break;
                    }
                }
            }
            if (!f)
            {
                if (this.panelMethod_1_rbRU.Checked)
                    MessageBox.Show("Введите число от 0 до 33", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Введите число от 0 до 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panelMethod_1_textBox_k.Text = "0";

            }
            var k = Convert.ToInt16(this.panelMethod_1_textBox_k.Text);
            if (this.panelMethod_1_rbRU.Checked)
            {
                if (k > 33)
                {
                    MessageBox.Show("Введите число от 0 до 33", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.panelMethod_1_textBox_k.Text = "33";
                }
            }
            else
            {
                if (k > 25)
                {
                    MessageBox.Show("Введите число от 0 до 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.panelMethod_1_textBox_k.Text = "25";
                }
            }
        }

        private void panelMethod_1_rbEN_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(this.panelMethod_1_textBox_k.Text) > 25)
            {
                MessageBox.Show("Введите число от 0 до 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panelMethod_1_textBox_k.Text = "25";
            }
        }

        private void panelMethod_1_btn_encrypt_Click(object sender, EventArgs e)
        {
            var k = Convert.ToInt16(panelMethod_1_textBox_k.Text);
            var text = "";
            foreach(char c in panelMethod_1_textBox_in.Text)
            {
                // кириллица
                if (c > 1039 && c < 1103)
                {
                    // большие буквы
                    if (c > 1039 && c < 1071)
                    {
                        if (c + k > 1071)
                        {
                            text += Convert.ToChar(1040 + (c + k - 1071));
                        }
                        else
                        {
                            text += Convert.ToChar(c + k);
                        }
                    }
                    // маленькие  буквы
                    else
                    {
                        if (c + k > 1103)
                        {
                            text += Convert.ToChar(1072 + (c + k - 1103));
                        }
                        else
                        {
                            text += Convert.ToChar(c + k);
                        }
                    }
                }
                // латиница
                else
                {
                    // Большие буквы
                    if (c > 64 && c < 90)
                    {

                        if (c + k > 90)
                        {
                            text += Convert.ToChar(65 + (c + k - 90));
                        }
                        else
                        {
                            text += Convert.ToChar(c + k);
                        }
                    }
                    else
                    {
                        // маленькие буквы
                        if (c > 96 && c < 122)
                        {

                            if (c + k > 122)
                            {
                                text += Convert.ToChar(97 + (c + k - 122));
                            }
                            else
                            {
                                text += Convert.ToChar(c + k);
                            }
                        }
                        // остальной текст
                        else
                        {
                            text += c;
                        }
                    }
                }
            }
            this.panelMethod_1_textBox_out.Text = text;
        }

        private void panelMethod_1_textBox_in_Leave(object sender, EventArgs e)
        {
            if (!this.panelMethod_1_rbEN.Checked)
            {
                if(Convert.ToInt16(this.panelMethod_1_textBox_k.Text)>25)
                foreach (char c in panelMethod_1_textBox_in.Text)
                {
                    if ((c > 64 && c < 90) ||(c > 96 && c < 122))
                    {
                        MessageBox.Show("Была введена латинница и смещение больше чем 25. Для латиницы максимальное смещение равно 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.panelMethod_1_textBox_k.Text = "25";
                    }
                }
            }
        }
    }
}
