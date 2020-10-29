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
        private void PanelMethod_4_p_generate_table_p_Method_otions_Method_1_Enter(object sender, EventArgs e)
        {
            if (panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text == "введите секретное слово")
            {
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = "";
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void PanelMethod_4_p_generate_table_p_Method_otions_Method_1_Leave(object sender, EventArgs e)
        {
            if (panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text == "")
            {
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = "введите секретное слово";
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.ForeColor = System.Drawing.Color.Silver;
            }
            else
                if (this.panelMethod_4_p_generate_table_p_lang_EN.Checked)
            {
                string key = panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text;
                foreach (char c in key)
                {
                    if (c < 'A' || c > 'z' || c == 91 || c == 92 || c == 93 || c == 94 || c == 95 || c == 96)
                    {
                        this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = "введите секретное слово";
                        this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.ForeColor = System.Drawing.Color.Silver;
                        MessageBox.Show(
                            "Вводите только латиницу",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        break;
                    }
                }
            }
                else
            {
                string key = panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text;
                foreach (char c in key)
                {
                    if (c < 'Ё' || c > 'ё' || c == 1026 ||
                        c == 1027 || c == 1028 || c == 1029 ||
                        c == 1030 || c == 1031 || c == 1032 ||
                        c == 1033 || c == 1034 || c == 1035 ||
                        c == 1036 || c == 1037 || c == 1038 ||
                        c == 1039 || c == 1104)
                    {
                        this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = "введите секретное слово";
                        this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.ForeColor = System.Drawing.Color.Silver;
                        MessageBox.Show(
                            "Вводите только кириллицу",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        break;
                    }
                }
            }
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text.ToLower();
        }


        private void PanelMethod_4_p_generate_table_p_lang_EN_Click(object sender, EventArgs e)
        {
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 25";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = "введите секретное слово";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_En_options.Enabled = true;
            this.panelMethod_4_p_generate_table_En_options.Visible = true;
            this.panelMethod_4_p_generate_table_GenerateBTN.Dock = System.Windows.Forms.DockStyle.Left;

        }


        private void PanelMethod_4_p_generate_table_p_lang_RU_Click(object sender, EventArgs e)
        {
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 33";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = "введите секретное слово";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_En_options.Enabled = false;
            this.panelMethod_4_p_generate_table_En_options.Visible = false;
            this.panelMethod_4_p_generate_table_GenerateBTN.Dock = System.Windows.Forms.DockStyle.Fill;
        }


        private void PanelMethod_4_p_generate_table_p_Method_otions_Method_2_offset_Enter(object sender, EventArgs e)
        {
            if (panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text == "Введите число от 0 до 33" || panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text == "Введите число от 0 до 25")
            {
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "";
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void PanelMethod_4_p_generate_table_p_Method_otions_Method_2_offset_Leave(object sender, EventArgs e)
        {
            if (panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text == "")
            {
                if (this.panelMethod_4_p_generate_table_p_lang_EN.Checked)
                    this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 25";
                else
                    this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 33";
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.ForeColor = System.Drawing.Color.Silver;
            }
            else
                foreach (var c in this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text)
                {
                    if (c < '0' || c > '9')
                    {

                        if (this.panelMethod_4_p_generate_table_p_lang_EN.Checked)
                            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 25";
                        else
                            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 33";
                        this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.ForeColor = System.Drawing.Color.Silver;
                        MessageBox.Show(
                            "Вводите только цифры",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        break;
                    }
                }
            }

        
        private void PanelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb_Enter(object sender, EventArgs e)
        {
            if (panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text == "Введите число семени рандомайзера или не трогайте данное поле для генерации случайного семени")
            {
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text = "";
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void PanelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb_Leave(object sender, EventArgs e)
        {
            if (panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text == "")
            {
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text = "Введите число семени рандомайзера или не трогайте данное поле для генерации случайного семени";
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.ForeColor = System.Drawing.Color.Silver;
            }
            else
                foreach (var c in this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text)
                {
                    if (c < '0' || c > '9')
                    {

                        this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text = "Введите число семени рандомайзера или не трогайте данное поле для генерации случайного семени";
                        this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.ForeColor = System.Drawing.Color.Silver;
                        MessageBox.Show(
                            "Вводите только цифры",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        break;
                    }
                }
        }


        private void PanelMethod_4_p_generate_table_p_Method_generate_key_Click(object sender, EventArgs e)
        {
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Visible = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Enabled = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Enabled = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Enabled = true;
        }


        private void PanelMethod_4_p_generate_table_p_Method_generate_offset_Click(object sender, EventArgs e)
        {
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Visible = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Enabled = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Enabled = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Enabled = true;
        }


        private void PanelMethod_4_p_generate_table_p_Method_generate_randomize_Click(object sender, EventArgs e)
        {
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Visible = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Enabled = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Enabled = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Enabled = false;
        }


        private void PanelMethod_4_p_generate_table_GenerateBTN_Click(object sender, EventArgs e)
        {
            List<string> table;
            bool flag = false;
            if (this.panelMethod_4_p_generate_table_p_Method_generate_key.Checked)
            {
                if (this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text == "введите секретное слово")
                {

                }
                else
                {
                    table = PanelMethod_4_generate_table(
                        1,
                        Convert.ToString(this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text),
                        this.panelMethod_4_p_generate_table_p_lang_EN.Checked
                        );
                }
            }
            else if (this.panelMethod_4_p_generate_table_p_Method_generate_offset.Checked)
            {
                if (this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text == "Введите число от 0 до 25" || this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text == "Введите число от 0 до 33")
                {

                }
                else
                {
                    bool fla = true;
                    int offset = Convert.ToInt32(this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text);
                    if (this.panelMethod_4_p_generate_table_p_lang_EN.Checked)
                        if(offset < 0 || offset >  25)
                        {
                            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 25";


                        }
                    if (fla)
                    {
                        flag = true;
                        table = PanelMethod_4_generate_table(
                            2,
                            Convert.ToString(this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text),
                            this.panelMethod_4_p_generate_table_p_lang_EN.Checked
                            );
                    }
                }
            }
            else if (this.panelMethod_4_p_generate_table_p_Method_generate_randomize.Checked)
            {
                if (this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed.Text == "")
                {

                }
                else
                {
                    table = PanelMethod_4_generate_table(
                    31,
                    Convert.ToString(this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed.Text),
                    this.panelMethod_4_p_generate_table_p_lang_EN.Checked
                    );
                }
            }
            if (flag)
            {
            
            }
        }

        private List<string> PanelMethod_4_generate_table(int pos, string text, bool en)
        {
            throw new NotImplementedException();
        }

        private void PanelMethod_4_p_encrypt_in_Enter(object sender, EventArgs e)
        {
            if (panelMethod_4_p_encrypt_in.Text == "Введите сообщение, которое надо зашифровать")
            {
                this.panelMethod_4_p_encrypt_in.Text = "";
                this.panelMethod_4_p_encrypt_in.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void PanelMethod_4_p_encrypt_in_Leave(object sender, EventArgs e)
        {
            if (panelMethod_4_p_encrypt_in.Text == "")
            {
                this.panelMethod_4_p_encrypt_in.Text = "Введите сообщение, которое надо зашифровать";
                this.panelMethod_4_p_encrypt_in.ForeColor = System.Drawing.Color.Silver;
            }
            else
            {
                string tmp = panelMethod_4_p_encrypt_in.Text.ToLower();
                
                if (this.panelMethod_4_p_generate_table_En_options_q.Checked)
                    tmp = tmp.Replace("q", string.Empty);
                else
                    tmp = tmp.Replace("j", "i");
                panelMethod_4_p_encrypt_out.Text = tmp;
            }
        }


        private void PanelMethod_4_p_encrypt_btn_Click(object sender, EventArgs e)
        {

        }





    }
}