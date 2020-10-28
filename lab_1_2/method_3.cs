using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace lab_1_2
{
    public partial class MainForm : Form
    {
        public struct Bigramms 
        {
            private readonly string a;
            private readonly string b;
            private readonly bool Count; // Count = 1 значит полная биграмма

            public Bigramms(string a, string b, bool count = true)
            {
                this.a = a;
                this.b = b;
                this.Count = count;
            }

            public string A => a;
            public string B => b;
            public bool Full => Count;
        };
        
        
        private void PanelMethod_3_textBox_key_1_Enter(object sender, EventArgs e)
        {
            if(panelMethod_3_textBox_key_1.Text == "первый секретный ключ")
            {
                this.panelMethod_3_textBox_key_1.Text = "";
                this.panelMethod_3_textBox_key_1.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void PanelMethod_3_textBox_key_1_Leave(object sender, EventArgs e)
        {
            if (panelMethod_3_textBox_key_1.Text == "")
            {
                this.panelMethod_3_textBox_key_1.ForeColor = System.Drawing.Color.Silver;
                this.panelMethod_3_textBox_key_1.Text = "первый секретный ключ";
                this.panelMethod_3_p7_inout_encrypt.Enabled = false;
                this.panelMethod_3_p7_inout_in.Text = "Введите текст";
                this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;
            }
            else
                if (this.panelMethod_3_rb_lang_EN_1.Checked)
            {
                string key = panelMethod_3_textBox_key_1.Text;
                foreach (char c in key)
                {
                    if (c < 'A' || c > 'z' || c == 91 || c == 92 || c == 93 || c == 94 || c == 95 || c == 96)
                    {
                        this.panelMethod_3_textBox_key_1.Text = "первый секретный ключ";
                        this.panelMethod_3_textBox_key_1.ForeColor = System.Drawing.Color.Silver;
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
                string key = panelMethod_3_textBox_key_1.Text;
                foreach (char c in key)
                {
                    if (c < 'Ё' || c > 'ё' || c == 1026 ||
                        c == 1027 || c == 1028 || c == 1029 ||
                        c == 1030 || c == 1031 || c == 1032 ||
                        c == 1033 || c == 1034 || c == 1035 ||
                        c == 1036 || c == 1037 || c == 1038 ||
                        c == 1039 || c == 1104)
                    {
                        this.panelMethod_3_textBox_key_1.Text = "первый секретный ключ";
                        this.panelMethod_3_textBox_key_1.ForeColor = System.Drawing.Color.Silver;
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
            this.panelMethod_3_textBox_key_1.Text = panelMethod_3_textBox_key_1.Text.ToLower();
        }


        private void PanelMethod_3_textBox_key_2_Enter(object sender, EventArgs e)
        {
            if (panelMethod_3_textBox_key_2.Text == "второй секретный ключ")
            {
                this.panelMethod_3_textBox_key_2.Text = "";
                this.panelMethod_3_textBox_key_2.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void PanelMethod_3_textBox_key_2_Leave(object sender, EventArgs e)
        {
            if (panelMethod_3_textBox_key_2.Text == "")
            {
                this.panelMethod_3_textBox_key_2.Text = "второй секретный ключ";
                this.panelMethod_3_textBox_key_2.ForeColor = System.Drawing.Color.Silver;
                this.panelMethod_3_p7_inout_encrypt.Enabled = false;
                this.panelMethod_3_p7_inout_in.Text = "Введите текст";
                this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;
            }
            else
                if (this.panelMethod_3_rb_lang_EN_1.Checked)
                {
                    string key = panelMethod_3_textBox_key_2.Text;
                    foreach(char c in key)
                    {
                        if (c < 'A' || c > 'z' || c == 91 || c == 92 || c == 93 || c == 94 || c == 95 || c == 96)
                        {
                            this.panelMethod_3_textBox_key_2.Text = "второй секретный ключ";
                            this.panelMethod_3_textBox_key_2.ForeColor = System.Drawing.Color.Silver;
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
                    string key = panelMethod_3_textBox_key_2.Text;
                    foreach (char c in key)
                    {
                    if (c < 'Ё'   || c > 'ё'   || c == 1026 || 
                        c == 1027 || c == 1028 || c == 1029 ||
                        c == 1030 || c == 1031 || c == 1032 ||
                        c == 1033 || c == 1034 || c == 1035 ||
                        c == 1036 || c == 1037 || c == 1038 ||
                        c == 1039 || c == 1104)
                    {
                            this.panelMethod_3_textBox_key_2.Text = "второй секретный ключ";
                            this.panelMethod_3_textBox_key_2.ForeColor = System.Drawing.Color.Silver;
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
            this.panelMethod_3_textBox_key_2.Text = panelMethod_3_textBox_key_2.Text.ToLower();
        }


        private void PanelMethod_3_p7_inout_in_Enter(object sender, EventArgs e)
        {
            if (panelMethod_3_p7_inout_in.Text == "Введите текст")
            {
                this.panelMethod_3_p7_inout_in.Text = "";
                this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void PanelMethod_3_p7_inout_in_Leave(object sender, EventArgs e)
        {
            if (panelMethod_3_p7_inout_in.Text == "")
            {
                this.panelMethod_3_p7_inout_in.Text = "Введите текст";
                this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;
                
            }
        }


        private void PanelMethod_3_rb_rotation_Vertic_1_Click(object sender, EventArgs e)
        {
            this.panelMethod_3_p7_inout.Location = new System.Drawing.Point(0, 26);
            this.panelMethod_3_p7_inout.Size = new System.Drawing.Size(550, 358);
            this.panelMethod_3_p7_inout.Enabled = true;
            this.panelMethod_3_p7_inout.Visible = true;
            this.panelMethod_3_p6_table.Location = new System.Drawing.Point(550, 25);
            this.panelMethod_3_p6_table.Size = new System.Drawing.Size(550, 358);
            this.panelMethod_3_p6_table.Enabled = true;
            this.panelMethod_3_p6_table.Visible = true;

            this.panelMethod_3_p7_inout_in.Size = new System.Drawing.Size(550, 149);
            this.panelMethod_3_p7_inout_in.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_3_p7_inout_encrypt.Size = new System.Drawing.Size(550, 60);
            this.panelMethod_3_p7_inout_encrypt.Location = new System.Drawing.Point(0, 149);
            this.panelMethod_3_p7_inout_out.Size = new System.Drawing.Size(550, 149);
            this.panelMethod_3_p7_inout_out.Location = new System.Drawing.Point(0, 209);

            panelMethod_3_p6_table_datagrid_с7.Visible = false;
            panelMethod_3_p6_table_datagrid_с8.Visible = false;
            panelMethod_3_p6_table_datagrid_с9.Visible = false;
            panelMethod_3_p6_table_datagrid_с10.Visible = false;
            panelMethod_3_p6_table_datagrid_с11.Visible = false;
            panelMethod_3_p6_table_datagrid_с12.Visible = false;
            panelMethod_3_p6_table_datagrid_с13.Visible = false;

            this.panelMethod_3_p7_inout_encrypt.Enabled = false;
            this.panelMethod_3_p7_inout_in.Text = "Введите текст";
            this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_3_p6_table_datagrid.Rows.Clear();
        }


        private void PanelMethod_3_rb_rotation_Gorizont_2_Click(object sender, EventArgs e)
        {
            this.panelMethod_3_p7_inout.Location = new System.Drawing.Point(0, 181);
            this.panelMethod_3_p7_inout.Size = new System.Drawing.Size(1097, 203);
            this.panelMethod_3_p7_inout.Enabled = true;
            this.panelMethod_3_p7_inout.Visible = true;
            this.panelMethod_3_p6_table.Location = new System.Drawing.Point(0, 25);
            this.panelMethod_3_p6_table.Size = new System.Drawing.Size(1100, 154);
            this.panelMethod_3_p6_table.Enabled = true;
            this.panelMethod_3_p6_table.Visible = true;

            

            this.panelMethod_3_p7_inout_in.Size = new System.Drawing.Size(500, 203);
            this.panelMethod_3_p7_inout_in.Location = new System.Drawing.Point(0, 0);
            this.panelMethod_3_p7_inout_encrypt.Size = new System.Drawing.Size(100, 203);
            this.panelMethod_3_p7_inout_encrypt.Location = new System.Drawing.Point(500, 0);
            this.panelMethod_3_p7_inout_out.Size = new System.Drawing.Size(500, 203);
            this.panelMethod_3_p7_inout_out.Location = new System.Drawing.Point(600, 0);


            panelMethod_3_p6_table_datagrid_с7.Visible  = true;
            panelMethod_3_p6_table_datagrid_с8.Visible  = true;
            panelMethod_3_p6_table_datagrid_с9.Visible  = true;
            panelMethod_3_p6_table_datagrid_с10.Visible = true;
            panelMethod_3_p6_table_datagrid_с11.Visible = true;
            panelMethod_3_p6_table_datagrid_с12.Visible = true;
            panelMethod_3_p6_table_datagrid_с13.Visible = true;

            this.panelMethod_3_p7_inout_encrypt.Enabled = false;
            this.panelMethod_3_p7_inout_in.Text = "Введите текст";
            this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;

            this.panelMethod_3_p6_table_datagrid.Rows.Clear();
        }


        private void PanelMethod_3_rb_lang_EN_1_Click(object sender, EventArgs e)
        {
            this.panelMethod_3_p6.Visible = true;
            this.panelMethod_3_p6.Enabled = true;
            this.panelMethod_3_p7_inout_encrypt.Enabled = false;
            this.panelMethod_3_p7_inout_in.Text = "Введите текст";
            this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;

        }


        private void PanelMethod_3_rb_lang_RU_2_Click(object sender, EventArgs e)
        {
            this.panelMethod_3_p6.Visible = false;
            this.panelMethod_3_p6.Enabled = false;
            this.panelMethod_3_p7_inout_encrypt.Enabled = false;
            this.panelMethod_3_p7_inout_in.Text = "Введите текст";
            this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;
        }


        private void PanelMethod_3_Generate_Tables_Click(object sender, EventArgs e)
        {
            bool err = false;
            if (panelMethod_3_textBox_key_1.Text == "первый секретный ключ" || panelMethod_3_textBox_key_2.Text == "второй секретный ключ")
            {
                MessageBox.Show(
                    "Не введён секретный ключ", 
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                    );
                this.panelMethod_3_p7_inout_encrypt.Enabled = false;
                this.panelMethod_3_p7_inout_in.Text = "Введите текст";
                this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;
            }
            else
            {
                if (this.panelMethod_3_rb_lang_EN_1.Checked)
                {
                    string key = panelMethod_3_textBox_key_1.Text;
                    foreach (char c in key)
                    {
                        if (c < 'A' || c > 'z' || c == 91 || c == 92 || c == 93 || c == 94 || c == 95 || c == 96)
                        {
                            this.panelMethod_3_textBox_key_1.Text = "первый секретный ключ";
                            this.panelMethod_3_textBox_key_1.ForeColor = System.Drawing.Color.Silver;
                            MessageBox.Show(
                                "Вводите только латиницу",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
                            err = true;
                            break;
                        }
                    }
                }
                else
                {
                    string key = panelMethod_3_textBox_key_1.Text;
                    foreach (char c in key)
                    {
                        if (c < 'Ё' || c > 'ё' || c == 1026 ||
                            c == 1027 || c == 1028 || c == 1029 ||
                            c == 1030 || c == 1031 || c == 1032 ||
                            c == 1033 || c == 1034 || c == 1035 ||
                            c == 1036 || c == 1037 || c == 1038 ||
                            c == 1039 || c == 1104)
                        {
                            this.panelMethod_3_textBox_key_1.Text = "первый секретный ключ";
                            this.panelMethod_3_textBox_key_1.ForeColor = System.Drawing.Color.Silver;
                            MessageBox.Show(
                                "Вводите только кириллицу",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
                            err = true;
                            break;
                        }
                    }
                }
                if (this.panelMethod_3_rb_lang_EN_1.Checked)
                {
                    string key = panelMethod_3_textBox_key_2.Text;
                    foreach (char c in key)
                    {
                        if (c < 'A' || c > 'z' || c == 91 || c == 92 || c == 93 || c == 94 || c == 95 || c == 96)
                        {
                            this.panelMethod_3_textBox_key_2.Text = "второй секретный ключ";
                            this.panelMethod_3_textBox_key_2.ForeColor = System.Drawing.Color.Silver;
                            MessageBox.Show(
                                "Вводите только латиницу",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
                            err = true;
                            break;
                        }
                    }
                }
                else
                {
                    string key = panelMethod_3_textBox_key_2.Text;
                    foreach (char c in key)
                    {
                        if (c < 'Ё' || c > 'ё' || c == 1026 ||
                            c == 1027 || c == 1028 || c == 1029 ||
                            c == 1030 || c == 1031 || c == 1032 ||
                            c == 1033 || c == 1034 || c == 1035 ||
                            c == 1036 || c == 1037 || c == 1038 ||
                            c == 1039 || c == 1104)
                        {
                            this.panelMethod_3_textBox_key_2.Text = "второй секретный ключ";
                            this.panelMethod_3_textBox_key_2.ForeColor = System.Drawing.Color.Silver;
                            MessageBox.Show(
                                "Вводите только кириллицу",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
                            err = true;
                            break;
                        }
                    }
                }
                if (!err)
                {
                    List<string> table;
                    List<string> table2;
                    // Выбран вертикальный способ
                    if (this.panelMethod_3_rb_rotation_Vertic_1.Checked)
                    {
                        // Если выбран латинский
                        if (this.panelMethod_3_rb_lang_EN_1.Checked)
                        {
                            // Если выбрано " Буквы «I» и «J» объединяются в одной клетке "
                            if (this.panelMethod_3_rb_EN_1.Checked)
                            {
                                table = PanelMethod_3_generate_table(false, false);
                                table2 = PanelMethod_3_generate_table(false, false, true);
                            }
                            // Если выбрано " Букву «Q» опустить "
                            else
                            {
                                table = PanelMethod_3_generate_table(false, true);
                                table2 = PanelMethod_3_generate_table(false, true, true);
                            }
                            this.panelMethod_3_p6_table_datagrid.Rows.Clear();
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table[0], table[1], table[2], table[3], table[4]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table[5], table[6], table[7], table[8], table[9]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table[10], table[11], table[12], table[13], table[14]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table[15], table[16], table[17], table[18], table[19]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table[20], table[21], table[22], table[23], table[24]
                                    );

                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                " ", " ", " ", " ", " "
                                );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table2[0], table2[1], table2[2], table2[3], table2[4]
                                );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table2[5], table2[6], table2[7], table2[8], table2[9]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table2[10], table[11], table2[12], table2[13], table2[14]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table2[15], table2[16], table2[17], table2[18], table2[19]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table2[20], table2[21], table2[22], table2[23], table2[24]
                                    );
                        }
                        // Если выбрана килиллица
                        else
                        {
                            table = PanelMethod_3_generate_table(true);
                            table2 = PanelMethod_3_generate_table(true, false, true);

                            panelMethod_3_p6_table_datagrid.Rows.Clear();
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table[0], table[1], table[2], table[3], table[4], table[5]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table[6], table[7], table[8], table[9], table[10], table[11]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table[12], table[13], table[14], table[15], table[16], table[17]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table[18], table[19], table[20], table[21], table[22], table[23]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table[24], table[25], table[26], table[27], table[28], table[29]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                " ", " ", " ", " ", " ", " "
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table2[0], table2[1], table2[2], table2[3], table2[4], table2[5]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table2[6], table2[7], table2[8], table2[9], table2[10], table2[11]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table2[12], table2[13], table2[14], table2[15], table2[16], table2[17]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table2[18], table2[19], table2[20], table2[21], table2[22], table2[23]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table2[24], table2[25], table2[26], table2[27], table2[28], table2[29]
                                );

                        }
                    }
                    // Выбран горизонтальный способ
                    else
                    {
                        // Если выбран латинский
                        if (this.panelMethod_3_rb_lang_EN_1.Checked)
                        {
                            // Если выбрано " Буквы «I» и «J» объединяются в одной клетке "
                            if (this.panelMethod_3_rb_EN_1.Checked)
                            {
                                table = PanelMethod_3_generate_table(false, false);
                                table2 = PanelMethod_3_generate_table(false, false, true);
                            }
                            // Если выбрано " Букву «Q» опустить "
                            else
                            {
                                table = PanelMethod_3_generate_table(false, true);
                                table2 = PanelMethod_3_generate_table(false, true, true);
                            }
                            this.panelMethod_3_p6_table_datagrid.Rows.Clear();
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table[0], table[1], table[2], table[3], table[4], " ",
                                    table2[0], table2[1], table2[2], table2[3], table2[4]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table[5], table[6], table[7], table[8], table[9], " ",
                                    table2[5], table2[6], table2[7], table2[8], table2[9]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table[10], table[11], table[12], table[13], table[14], " ",
                                    table2[10], table[11], table2[12], table2[13], table2[14]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table[15], table[16], table[17], table[18], table[19], " ",
                                    table2[15], table2[16], table2[17], table2[18], table2[19]
                                    );
                            this.panelMethod_3_p6_table_datagrid.Rows.Add
                                    (
                                    table[20], table[21], table[22], table[23], table[24], " ",
                                    table2[20], table2[21], table2[22], table2[23], table2[24]
                                    );
                        }
                        // Если выбрана килиллица
                        else
                        {
                            table = PanelMethod_3_generate_table(true);
                            table2 = PanelMethod_3_generate_table(true, false, true);

                            panelMethod_3_p6_table_datagrid.Rows.Clear();
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table[0], table[1], table[2], table[3], table[4], table[5], " ",
                                table2[0], table2[1], table2[2], table2[3], table2[4], table2[5]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table[6], table[7], table[8], table[9], table[10], table[11], " ",
                                table2[6], table2[7], table2[8], table2[9], table2[10], table2[11]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table[12], table[13], table[14], table[15], table[16], table[17], " ",
                                table2[12], table2[13], table2[14], table2[15], table2[16], table2[17]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table[18], table[19], table[20], table[21], table[22], table[23], " ",
                                table2[18], table2[19], table2[20], table2[21], table2[22], table2[23]
                                );
                            panelMethod_3_p6_table_datagrid.Rows.Add
                                (
                                table[24], table[25], table[26], table[27], table[28], table[29], " ",
                                table2[24], table2[25], table2[26], table2[27], table2[28], table2[29]
                                );
                            }
                    }
                    

                    this.panelMethod_3_p7_inout.Enabled = true;
                    this.panelMethod_3_p6_table.Enabled = true;
                    this.panelMethod_3_p7_inout.Visible = true;
                    this.panelMethod_3_p6_table.Visible = true;
                    this.panelMethod_3_p7_inout_encrypt.Enabled = true;
                }
                else
                {
                    this.panelMethod_3_p7_inout_encrypt.Enabled = false;
                    this.panelMethod_3_p7_inout_in.Text = "Введите текст";
                    this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;
                    this.panelMethod_3_p7_inout.Enabled = false;
                    this.panelMethod_3_p6_table.Enabled = false;
                    this.panelMethod_3_p7_inout.Visible = false;
                    this.panelMethod_3_p6_table.Visible = false;
                }
            }

        }


        private List<string> PanelMethod_3_generate_table(bool lang, bool add_options = false, bool table = false, bool normal = false)
        {
            List<string> Table;
            string key1 = this.panelMethod_3_textBox_key_1.Text.ToLower(),
                   key2 = this.panelMethod_3_textBox_key_2.Text.ToLower();
            // Удаляем повторяющиеся символы
            {
                int i = 0;
                while (true)
                {
                    var tmp = key1[i].ToString();
                    key1 = key1.Replace(tmp, "");
                    key1 = key1.Insert(i, tmp);
                    i++;
                    if (key1.Length - 1 < i)
                        break;
                }
                i = 0;
                while (true)
                {
                    var tmp = key2[i].ToString();
                    key2 = key2.Replace(tmp, "");
                    key2 = key2.Insert(i, tmp);
                    i++;
                    if (key2.Length - 1 < i)
                        break;
                }
            }
            // добавление дроби
            if (!normal)
            {
                // 1 таблица
                if (!table)
                {
                    // Если выбран латинский
                    if (!lang)
                    {
                        Table = new List<string>(25) { };

                        // Если выбрано " Буквы «I» и «J» объединяются в одной клетке "
                        if (!add_options)
                        {

                            string alph = "abcdefghiklmnopqrstuvwxyz",
                                   tmp = "";
                            // Ввод ключа в временный массив
                            for (var i = 0; i < key1.Length; i++)
                                tmp += key1[i];
                            // Ввод остального алфавита в временный массив
                            tmp += alph;
                            var j = 0;
                            while (true)
                            {
                                var tmp2 = tmp[j].ToString();
                                tmp = tmp.Replace(tmp2, "");
                                tmp = tmp.Insert(j, tmp2);
                                j++;
                                if (tmp.Length - 1 < j)
                                    break;
                            }
                            // Вносим даные в лист Table
                            for (var i = 0; i < 25; i++)
                                if (tmp[i] == 'i')
                                    Table.Insert(i, "i/j");
                                else
                                    Table.Insert(i, tmp[i].ToString());
                        }
                        // Если выбрано " Букву «Q» опустить "
                        else
                        {
                            string alph = "abcdefghijklmnoprstuvwxyz",
                                   tmp = "";
                            // Ввод ключа в временный массив
                            for (var i = 0; i < key1.Length; i++)
                                tmp += key1[i];
                            // Ввод остального алфавита в временный массив
                            tmp += alph;
                            var j = 0;
                            while (true)
                            {
                                var tmp2 = tmp[j].ToString();
                                tmp = tmp.Replace(tmp2, "");
                                tmp = tmp.Insert(j, tmp2);
                                j++;
                                if (tmp.Length - 1 < j)
                                    break;
                            }
                            // Вносим даные в лист Table
                            for (var i = 0; i < 25; i++)
                                Table.Insert(i, tmp[i].ToString());
                        }
                    }
                    // Если выбрана килиллица
                    else
                    {
                        Table = new List<string>(30) { };
                        string alph = "абвгдежзиклмнопрстуфхцчшщыьэюя",// ё й ъ
                                   tmp = "";
                        // Ввод ключа в временный массив
                        for (var i = 0; i < key1.Length; i++)
                            switch (key1[i])
                            {
                                case ('ё'): tmp += "е"; break;
                                case ('й'): tmp += "и"; break;
                                case ('ъ'): tmp += "ъ"; break;
                                default: tmp += key1[i]; break;
                            }
                        // Ввод остального алфавита в временный массив
                        tmp += alph;
                        var j = 0;
                        while (true)
                        {
                            var tmp2 = tmp[j].ToString();
                            tmp = tmp.Replace(tmp2, "");
                            tmp = tmp.Insert(j, tmp2);
                            j++;
                            if (tmp.Length - 1 < j)
                                break;
                        }
                        // Вносим даные в лист Table
                        for (var i = 0; i < 30; i++)
                            switch (tmp[i])
                            {
                                case ('е'): Table.Insert(i, "е/ё"); break;
                                case ('и'): Table.Insert(i, "и/й"); break;
                                case ('ь'): Table.Insert(i, "ь/ъ"); break;
                                default: Table.Insert(i, tmp[i].ToString()); break;
                            }

                    }
                }
                // 2 таблица
                else
                {
                    // Если выбран латинский
                    if (!lang)
                    {
                        Table = new List<string>(25);

                        // Если выбрано " Буквы «I» и «J» объединяются в одной клетке "
                        if (!add_options)
                        {
                            string alph = "abcdefghiklmnopqrstuvwxyz",
                                                           tmp = "";
                            // Ввод ключа в временный массив
                            for (var i = 0; i < key2.Length; i++)
                                tmp += key2[i];
                            // Ввод остального алфавита в временный массив
                            tmp += alph;
                            var j = 0;
                            while (true)
                            {
                                var tmp2 = tmp[j].ToString();
                                tmp = tmp.Replace(tmp2, "");
                                tmp = tmp.Insert(j, tmp2);
                                j++;
                                if (tmp.Length - 1 < j)
                                    break;
                            }
                            // Вносим даные в лист Table
                            for (var i = 0; i < 25; i++)
                                if (tmp[i] == 'i')
                                    Table.Insert(i, "i/j");
                                else
                                    Table.Insert(i, tmp[i].ToString());
                        }
                        // Если выбрано " Букву «Q» опустить "
                        else
                        {
                            string alph = "abcdefghijklmnoprstuvwxyz",
                                   tmp = "";
                            // Ввод ключа в временный массив
                            for (var i = 0; i < key2.Length; i++)
                                tmp += key2[i];
                            // Ввод остального алфавита в временный массив
                            tmp += alph;
                            var j = 0;
                            while (true)
                            {
                                var tmp2 = tmp[j].ToString();
                                tmp = tmp.Replace(tmp2, "");
                                tmp = tmp.Insert(j, tmp2);
                                j++;
                                if (tmp.Length - 1 < j)
                                    break;
                            }
                            // Вносим даные в лист Table
                            for (var i = 0; i < 25; i++)
                                Table.Insert(i, tmp[i].ToString());
                        }
                    }
                    // Если выбрана килиллица
                    else
                    {
                        Table = new List<string>(30);
                        string alph = "абвгдежзиклмнопрстуфхцчшщыьэюя",// ё й ъ
                                   tmp = "";
                        // Ввод ключа в временный массив
                        for (var i = 0; i < key2.Length; i++)
                            switch (key2[i])
                            {
                                case ('ё'): tmp += "е"; break;
                                case ('й'): tmp += "и"; break;
                                case ('ъ'): tmp += "ъ"; break;
                                default: tmp += key2[i]; break;
                            }
                        // Ввод остального алфавита в временный массив
                        tmp += alph;
                        var j = 0;
                        while (true)
                        {
                            var tmp2 = tmp[j].ToString();
                            tmp = tmp.Replace(tmp2, "");
                            tmp = tmp.Insert(j, tmp2);
                            j++;
                            if (tmp.Length - 1 < j)
                                break;
                        }
                        // Вносим даные в лист Table
                        for (var i = 0; i < 30; i++)
                            switch (tmp[i])
                            {
                                case ('е'): Table.Insert(i, "е/ё"); break;
                                case ('и'): Table.Insert(i, "и/й"); break;
                                case ('ь'): Table.Insert(i, "ь/ъ"); break;
                                default: Table.Insert(i, tmp[i].ToString()); break;
                            }
                    }
                }
            }
            else
            {
                // 1 таблица
                if (!table)
                {
                    // Если выбран латинский
                    if (!lang)
                    {
                        Table = new List<string>(25) { };

                        // Если выбрано " Буквы «I» и «J» объединяются в одной клетке "
                        if (!add_options)
                        {

                            string alph = "abcdefghiklmnopqrstuvwxyz",
                                   tmp = "";
                            // Ввод ключа в временный массив
                            for (var i = 0; i < key1.Length; i++)
                                tmp += key1[i];
                            // Ввод остального алфавита в временный массив
                            tmp += alph;
                            var j = 0;
                            while (true)
                            {
                                var tmp2 = tmp[j].ToString();
                                tmp = tmp.Replace(tmp2, "");
                                tmp = tmp.Insert(j, tmp2);
                                j++;
                                if (tmp.Length - 1 < j)
                                    break;
                            }
                            // Вносим даные в лист Table
                            for (var i = 0; i < 25; i++)
                                Table.Insert(i, tmp[i].ToString());
                        }
                        // Если выбрано " Букву «Q» опустить "
                        else
                        {
                            string alph = "abcdefghijklmnoprstuvwxyz",
                                   tmp = "";
                            // Ввод ключа в временный массив
                            for (var i = 0; i < key1.Length; i++)
                                tmp += key1[i];
                            // Ввод остального алфавита в временный массив
                            tmp += alph;
                            var j = 0;
                            while (true)
                            {
                                var tmp2 = tmp[j].ToString();
                                tmp = tmp.Replace(tmp2, "");
                                tmp = tmp.Insert(j, tmp2);
                                j++;
                                if (tmp.Length - 1 < j)
                                    break;
                            }
                            // Вносим даные в лист Table
                            for (var i = 0; i < 25; i++)
                                Table.Insert(i, tmp[i].ToString());
                        }
                    }
                    // Если выбрана килиллица
                    else
                    {
                        Table = new List<string>(30) { };
                        string alph = "абвгдежзиклмнопрстуфхцчшщыьэюя",// ё й ъ
                                   tmp = "";
                        // Ввод ключа в временный массив
                        for (var i = 0; i < key1.Length; i++)
                            switch (key1[i])
                            {
                                case ('ё'): tmp += "е"; break;
                                case ('й'): tmp += "и"; break;
                                case ('ъ'): tmp += "ъ"; break;
                                default: tmp += key1[i]; break;
                            }
                        // Ввод остального алфавита в временный массив
                        tmp += alph;
                        var j = 0;
                        while (true)
                        {
                            var tmp2 = tmp[j].ToString();
                            tmp = tmp.Replace(tmp2, "");
                            tmp = tmp.Insert(j, tmp2);
                            j++;
                            if (tmp.Length - 1 < j)
                                break;
                        }
                        // Вносим даные в лист Table
                        for (var i = 0; i < 30; i++)
                            Table.Insert(i, tmp[i].ToString());

                    }
                }
                // 2 таблица
                else
                {
                    // Если выбран латинский
                    if (!lang)
                    {
                        Table = new List<string>(25);

                        // Если выбрано " Буквы «I» и «J» объединяются в одной клетке "
                        if (!add_options)
                        {
                            string alph = "abcdefghiklmnopqrstuvwxyz",
                                                           tmp = "";
                            // Ввод ключа в временный массив
                            for (var i = 0; i < key2.Length; i++)
                                tmp += key2[i];
                            // Ввод остального алфавита в временный массив
                            tmp += alph;
                            var j = 0;
                            while (true)
                            {
                                var tmp2 = tmp[j].ToString();
                                tmp = tmp.Replace(tmp2, "");
                                tmp = tmp.Insert(j, tmp2);
                                j++;
                                if (tmp.Length - 1 < j)
                                    break;
                            }
                            // Вносим даные в лист Table
                            for (var i = 0; i < 25; i++)
                                Table.Insert(i, tmp[i].ToString());
                        }
                        // Если выбрано " Букву «Q» опустить "
                        else
                        {
                            string alph = "abcdefghijklmnoprstuvwxyz",
                                   tmp = "";
                            // Ввод ключа в временный массив
                            for (var i = 0; i < key2.Length; i++)
                                tmp += key2[i];
                            // Ввод остального алфавита в временный массив
                            tmp += alph;
                            var j = 0;
                            while (true)
                            {
                                var tmp2 = tmp[j].ToString();
                                tmp = tmp.Replace(tmp2, "");
                                tmp = tmp.Insert(j, tmp2);
                                j++;
                                if (tmp.Length - 1 < j)
                                    break;
                            }
                            // Вносим даные в лист Table
                            for (var i = 0; i < 25; i++)
                                Table.Insert(i, tmp[i].ToString());
                        }
                    }
                    // Если выбрана килиллица
                    else
                    {
                        Table = new List<string>(30);
                        string alph = "абвгдежзиклмнопрстуфхцчшщыьэюя",// ё й ъ
                                   tmp = "";
                        // Ввод ключа в временный массив
                        for (var i = 0; i < key2.Length; i++)
                            switch (key2[i])
                            {
                                case ('ё'): tmp += "е"; break;
                                case ('й'): tmp += "и"; break;
                                case ('ъ'): tmp += "ъ"; break;
                                default: tmp += key2[i]; break;
                            }
                        // Ввод остального алфавита в временный массив
                        tmp += alph;
                        var j = 0;
                        while (true)
                        {
                            var tmp2 = tmp[j].ToString();
                            tmp = tmp.Replace(tmp2, "");
                            tmp = tmp.Insert(j, tmp2);
                            j++;
                            if (tmp.Length - 1 < j)
                                break;
                        }
                        // Вносим даные в лист Table
                        for (var i = 0; i < 30; i++)
                            Table.Insert(i, tmp[i].ToString());
                    }
                }
            }
            return Table;
        }


        private void PanelMethod_3_p7_inout_encrypt_Click(object sender, EventArgs e)
        {
            if (this.panelMethod_3_p7_inout_in.Text == "Введите текст")
            {
                MessageBox.Show(
                    "Не введён текст",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else
            {
                // Призываем генерацию таблиц 1 раз, чтобы не вызывать их каждый раз(некая оптимизация кода)
                List<string> table1 = PanelMethod_3_generate_table(this.panelMethod_3_rb_lang_RU_2.Checked, this.panelMethod_3_rb_EN_2.Checked, false, true),
                             table2 = PanelMethod_3_generate_table(this.panelMethod_3_rb_lang_RU_2.Checked, this.panelMethod_3_rb_EN_2.Checked, true, true);
                // Добавляем переменные
                string text = this.panelMethod_3_p7_inout_in.Text.ToLower();
                // Рабиение на биграммы
                // Удаляем лишние пробелы из текста
                text = text.Replace(" ", string.Empty);
                if (this.panelMethod_3_rb_EN_2.Checked)
                    text = text.Replace("q", string.Empty);
                else
                    text = text.Replace("j", "i");
                text = text.Replace("й", "и");
                text = text.Replace("ё", "е");
                text = text.Replace("ъ", "ь");


                double tmp = text.Length / 2.0;
                // узнаём количество биграмм
                int CountBigramm = Convert.ToInt32(Math.Floor(tmp));
                if (tmp != CountBigramm) // Считаем если кол-во символов нечётное, то последнее число неполной биграммой
                    CountBigramm++;
                // Создаём биграммы
                List<Bigramms> Bigramm = new List<Bigramms> { };
                int tmp1 = 0;
                // Вносим в лист биграммы
                for (var i = 0; i < CountBigramm; i++)
                {
                    if (text.Length % 2 != 0)
                    {
                        if (i == CountBigramm - 1)
                        {
                            Bigramms bigramms = new Bigramms(Convert.ToString(text[tmp1]), "", false);
                            Bigramm.Insert(i, bigramms);
                            tmp1 += 2;
                        }
                        else
                        {
                            Bigramms b = new Bigramms(Convert.ToString(text[tmp1]), Convert.ToString(text[tmp1 + 1]));
                            Bigramm.Insert(i, b);
                            tmp1 += 2;
                        }
                    }
                    else
                    {
                        Bigramms b = new Bigramms(Convert.ToString(text[tmp1]), Convert.ToString(text[tmp1 + 1]));
                        Bigramm.Insert(i, b);
                        tmp1 += 2;
                    }

                }
                this.panelMethod_3_p7_inout_out.Text = "";
                // Шифровка биграмм
                foreach (var b in Bigramm)
                {
                    this.panelMethod_3_p7_inout_out.Text += Encrypt_bigramms(b, table1, table2);
                }

            }
        }

        private string Encrypt_bigramms(Bigramms b, List<string> t1, List<string> t2)
        {
            string en_big = "";
            // Проверяем способ(вертикальный или горизональный)
            // вертикальный
            if (this.panelMethod_3_rb_rotation_Vertic_1.Checked)
            {
                // проверка на полноту биграммы
                if (b.Full)
                {
                    int Counter1 = 0, Counter2 = 0;
                    // проверка на язык
                    // Латиница
                    if (this.panelMethod_3_rb_lang_EN_1.Checked)
                    {
                        // находим местоположение A
                        foreach (var c in t1)
                        {
                            if (b.A == c)
                                break;
                            Counter1++;
                        }
                        int y1 = Counter1 % 5;
                        int x1 = (Counter1 - y1) / 5;
                        // находим местоположение B
                        foreach (var c in t2)
                        {
                            if (b.B == c)
                                break;
                            Counter2++;
                        }
                        int y2 = Counter2 % 5;
                        int x2 = (Counter2 - y2) / 5;
                        // This is magic 
                        if (y1 == y2)
                            en_big = t2[Counter1] + t1[Counter2] + " ";
                        else
                            en_big = t2[(x2 * 5) + (y1)] + t1[(x1 * 5) + (y2)] + " ";
                    }
                    // Кириллица
                    else
                    {
                        // находим местоположение A
                        foreach (var c in t1)
                        {
                            if (b.A == c)
                                break;
                            Counter1++;
                        }
                        int y1 = Counter1 % 6;
                        int x1 = (Counter1 - y1) / 5;
                        // находим местоположение B
                        foreach (var c in t2)
                        {
                            if (b.B == c)
                                break;
                            Counter2++;
                        }
                        int y2 = Counter2 % 6;
                        int x2 = (Counter2 - y2) / 5;
                        // This is magic 
                        if (y1 == y2)
                            en_big = t2[Counter1] + t1[Counter2] + " ";
                        else
                            en_big = t2[(x2 * 6) + (y1)] + t1[(x1 * 6) + (y2)] + " ";
                    }
                }
                else
                {
                    en_big += b.A + " ";
                }
            }
            // горизональный
            else
            {
                // проверка на полноту биграммы
                if (b.Full)
                {
                    int Counter1 = 0, Counter2 = 0;
                    // проверка на язык
                    // Латиница
                    if (this.panelMethod_3_rb_lang_EN_1.Checked)
                    {
                        // находим местоположение A
                        foreach (var c in t1)
                        {
                            if (b.A == c)
                                break;
                            Counter1++;
                        }
                        int y1 = Counter1 % 5;
                        int x1 = (Counter1 - y1) / 5;
                        // находим местоположение B
                        foreach (var c in t2)
                        {
                            if (b.B == c)
                                break;
                            Counter2++;
                        }
                        int y2 = Counter2 % 5;
                        int x2 = (Counter2 - y2) / 5;
                        // This is magic 
                        if (y1 == y2)
                            en_big = t2[Counter1] + t1[Counter2] + " ";
                        else
                            en_big = t2[(x1 * 5) + (y2)] + t1[(x2 * 5) + (y1)] + " ";
                    }
                    // Кириллица
                    else
                    {
                        // находим местоположение A
                        foreach (var c in t1)
                        {
                            if (b.A == c)
                                break;
                            Counter1++;
                        }
                        int y1 = Counter1 % 6;
                        int x1 = (Counter1 - y1) / 5;
                        // находим местоположение B
                        foreach (var c in t2)
                        {
                            if (b.B == c)
                                break;
                            Counter2++;
                        }
                        int y2 = Counter2 % 6;
                        int x2 = (Counter2 - y2) / 5;
                        // This is magic 
                        if (y1 == y2)
                            en_big = t2[Counter1] + t1[Counter2] + " ";
                        else
                            en_big = t2[(x1 * 6) + (y2)] + t1[(x2 * 6) + (y1)] + " ";
                    }
                }
                else
                {
                    en_big += b.A + " ";
                }
            }
            return en_big;
        }


        private void PanelMethod_3_rb_EN_1_Click(object sender, EventArgs e)
        {
            this.panelMethod_3_p7_inout_encrypt.Enabled = false;
            this.panelMethod_3_p7_inout_in.Text = "Введите текст";
            this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;
        }


        private void PanelMethod_3_rb_EN_2_Click(object sender, EventArgs e)
        {
            this.panelMethod_3_p7_inout_encrypt.Enabled = false;
            this.panelMethod_3_p7_inout_in.Text = "Введите текст";
            this.panelMethod_3_p7_inout_in.ForeColor = System.Drawing.Color.Silver;
        }



    }
}