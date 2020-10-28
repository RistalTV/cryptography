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

        private void PanelMethod_1_textBox_k_Leave(object sender, EventArgs e)
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
                if ((c < 48) || (c > 58))
                {
                    if (this.panelMethod_1_rbRU.Checked)
                        MessageBox.Show("Введите число от 0 до 33", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Введите число от 0 до 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.panelMethod_1_textBox_k.Text = "0";
                    break;
                }
                for (var i = 48; i < 59; i++)
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


        private void PanelMethod_1_rbEN_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(this.panelMethod_1_textBox_k.Text) > 25)
            {
                MessageBox.Show("Введите число от 0 до 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panelMethod_1_textBox_k.Text = "25";
            }
        }


        private void PanelMethod_1_btn_encrypt_Click(object sender, EventArgs e)
        {
            if (panelMethod_1_textBox_k.Text != "")
            {
                var k = Convert.ToInt16(panelMethod_1_textBox_k.Text);
                var text = "";
                foreach (char c in panelMethod_1_textBox_in.Text)
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
        }

        private void PanelMethod_1_textBox_in_Leave(object sender, EventArgs e)
        {
            if (!this.panelMethod_1_rbEN.Checked)
            {
                if (Convert.ToInt16(this.panelMethod_1_textBox_k.Text) > 25)
                    foreach (char c in panelMethod_1_textBox_in.Text)
                    {
                        if ((c > 64 && c < 90) || (c > 96 && c < 122))
                        {
                            MessageBox.Show("Была введена латинница и смещение больше чем 25. Для латиницы максимальное смещение равно 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.panelMethod_1_textBox_k.Text = "25";
                        }
                    }
            }
        }


        private void PanelMethod_1_textBox_in_Enter(object sender, EventArgs e)
        {
            if(this.panelMethod_1_textBox_k.Text == "")
            {
                this.panelMethod_1_textBox_k.Text = "0";
            }
        }
        
        
        private void PanelMethod_1_rbRU_Click(object sender, EventArgs e)
        {
            this.panelMethod_1_l3.Text = "Введите число(смещение) от 0 до 33:";
        }


        private void PanelMethod_1_rbEN_Click(object sender, EventArgs e)
        {
            this.panelMethod_1_l3.Text = "Введите число(смещение) от 0 до 25:";
        }

    }
}
