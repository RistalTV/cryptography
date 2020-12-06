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
        private void PanelMethod_5_p_keys_key_1_Leave(object sender, EventArgs e)
        {
            if(panelMethod_5_p_keys_key_1.Text == "")
            {
                this.panelMethod_5_p_keys_key_1.Text = "Введите секретный ключ";
                this.panelMethod_5_p_keys_key_1.ForeColor = System.Drawing.Color.Silver;
            }
            if(panelMethod_5_p_keys_key_1.Text != "Введите секретный ключ" && panelMethod_5_p_keys_key_2.Text != "Введите секретный ключ")
            {
                PanelMethod_5_change_status_enable_onother_elements(true);
                panelMethod_5_p_encrypt_in.MaxLength = panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length;
                if(panelMethod_5_p_encrypt_in.Text.Length < panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length)
                {
                    int count_add_null_elem = Math.Abs(panelMethod_5_p_encrypt_in.Text.Length - panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length);
                    for (int i = 0; i < count_add_null_elem;i++)
                    {
                        panelMethod_5_p_encrypt_in.Text += " ";
                    }
                }
            }
            else
            {
                PanelMethod_5_change_status_enable_onother_elements(false);
            }
            if(this.panelMethod_5_p_keys_key_1.Text != "Введите секретный ключ")
            {

                var alph = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                this.panelMethod_5_p_keys_key_1.Text = this.panelMethod_5_p_keys_key_1.Text.ToLower();
                foreach(var c in panelMethod_5_p_keys_key_1.Text)
                {
                    var f = false;
                    foreach (var ch in alph)
                    {
                        if (c == ch)
                            f = true;
                    }
                    if (!f)
                    {
                        this.panelMethod_5_p_keys_key_1.Text = "Введите секретный ключ";
                        this.panelMethod_5_p_keys_key_1.ForeColor = System.Drawing.Color.Silver;
                        MessageBox.Show(
                            "Вводите только буквы",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        break;
                    }
                    else
                    {
                        var text = this.panelMethod_5_p_keys_key_1.Text;
                        // отчистили повторения букв
                        int i = 0;
                        while (true)
                        {
                            var tmp = text[i].ToString();
                            text = text.Replace(tmp, "");
                            text = text.Insert(i, tmp);
                            i++;
                            if (text.Length - 1 < i)
                                break;
                        }
                        this.panelMethod_5_p_keys_key_1.Text = text;
                    }
                }
                PanelMethod_5_view_count_column(this.panelMethod_5_p_keys_key_1.Text.Length+1);
            }

        }


        private void PanelMethod_5_view_count_column(int length)
        {
            var pos = 1;
            // выключаем все колонки
            while (pos != 26)
            {
                switch (pos)
                {
                    case 1: panelMethod_5_p_table_dataGrid_Column_1.Visible = false; break;
                    case 2: panelMethod_5_p_table_dataGrid_Column_2.Visible = false; break;
                    case 3: panelMethod_5_p_table_dataGrid_Column_3.Visible = false; break;
                    case 4: panelMethod_5_p_table_dataGrid_Column_4.Visible = false; break;
                    case 5: panelMethod_5_p_table_dataGrid_Column_5.Visible = false; break;
                    case 6: panelMethod_5_p_table_dataGrid_Column_6.Visible = false; break;
                    case 7: panelMethod_5_p_table_dataGrid_Column_7.Visible = false; break;
                    case 8: panelMethod_5_p_table_dataGrid_Column_8.Visible = false; break;
                    case 9: panelMethod_5_p_table_dataGrid_Column_9.Visible = false; break;
                    case 10: panelMethod_5_p_table_dataGrid_Column_10.Visible = false; break;
                    case 11: panelMethod_5_p_table_dataGrid_Column_11.Visible = false; break;
                    case 12: panelMethod_5_p_table_dataGrid_Column_12.Visible = false; break;
                    case 13: panelMethod_5_p_table_dataGrid_Column_13.Visible = false; break;
                    case 14: panelMethod_5_p_table_dataGrid_Column_14.Visible = false; break;
                    case 15: panelMethod_5_p_table_dataGrid_Column_15.Visible = false; break;
                    case 16: panelMethod_5_p_table_dataGrid_Column_16.Visible = false; break;
                    case 17: panelMethod_5_p_table_dataGrid_Column_17.Visible = false; break;
                    case 18: panelMethod_5_p_table_dataGrid_Column_18.Visible = false; break;
                    case 19: panelMethod_5_p_table_dataGrid_Column_19.Visible = false; break;
                    case 20: panelMethod_5_p_table_dataGrid_Column_20.Visible = false; break;
                    case 21: panelMethod_5_p_table_dataGrid_Column_21.Visible = false; break;
                    case 22: panelMethod_5_p_table_dataGrid_Column_22.Visible = false; break;
                    case 23: panelMethod_5_p_table_dataGrid_Column_23.Visible = false; break;
                    case 24: panelMethod_5_p_table_dataGrid_Column_24.Visible = false; break;
                    case 25: panelMethod_5_p_table_dataGrid_Column_25.Visible = false; break;
                    case 26: panelMethod_5_p_table_dataGrid_Column_26.Visible = false; break;
                }
                pos++;
            }

            // Включаем определённые колонки
            pos = 1;
            length++;
            while (pos != length)
            { 
                switch (pos)
                {
                    case 1: panelMethod_5_p_table_dataGrid_Column_1.Visible = true; break;
                    case 2: panelMethod_5_p_table_dataGrid_Column_2.Visible = true; break; 
                    case 3: panelMethod_5_p_table_dataGrid_Column_3.Visible = true; break; 
                    case 4: panelMethod_5_p_table_dataGrid_Column_4.Visible = true; break; 
                    case 5: panelMethod_5_p_table_dataGrid_Column_5.Visible = true; break; 
                    case 6: panelMethod_5_p_table_dataGrid_Column_6.Visible = true; break; 
                    case 7: panelMethod_5_p_table_dataGrid_Column_7.Visible = true; break; 
                    case 8: panelMethod_5_p_table_dataGrid_Column_8.Visible = true; break; 
                    case 9: panelMethod_5_p_table_dataGrid_Column_9.Visible = true; break; 
                    case 10: panelMethod_5_p_table_dataGrid_Column_10.Visible = true; break; 
                    case 11: panelMethod_5_p_table_dataGrid_Column_11.Visible = true; break; 
                    case 12: panelMethod_5_p_table_dataGrid_Column_12.Visible = true; break; 
                    case 13: panelMethod_5_p_table_dataGrid_Column_13.Visible = true; break; 
                    case 14: panelMethod_5_p_table_dataGrid_Column_14.Visible = true; break; 
                    case 15: panelMethod_5_p_table_dataGrid_Column_15.Visible = true; break; 
                    case 16: panelMethod_5_p_table_dataGrid_Column_16.Visible = true; break; 
                    case 17: panelMethod_5_p_table_dataGrid_Column_17.Visible = true; break; 
                    case 18: panelMethod_5_p_table_dataGrid_Column_18.Visible = true; break; 
                    case 19: panelMethod_5_p_table_dataGrid_Column_19.Visible = true; break; 
                    case 20: panelMethod_5_p_table_dataGrid_Column_20.Visible = true; break; 
                    case 21: panelMethod_5_p_table_dataGrid_Column_21.Visible = true; break; 
                    case 22: panelMethod_5_p_table_dataGrid_Column_22.Visible = true; break; 
                    case 23: panelMethod_5_p_table_dataGrid_Column_23.Visible = true; break; 
                    case 24: panelMethod_5_p_table_dataGrid_Column_24.Visible = true; break; 
                    case 25: panelMethod_5_p_table_dataGrid_Column_25.Visible = true; break;
                    case 26: panelMethod_5_p_table_dataGrid_Column_26.Visible = true; break;
                }
                pos++;
                    }
        }


        private void PanelMethod_5_p_keys_key_2_Leave(object sender, EventArgs e)
        {
            if (panelMethod_5_p_keys_key_2.Text == "")
            {
                this.panelMethod_5_p_keys_key_2.Text = "Введите секретный ключ";
                this.panelMethod_5_p_keys_key_2.ForeColor = System.Drawing.Color.Silver;
            }
            if (panelMethod_5_p_keys_key_1.Text != "Введите секретный ключ" && panelMethod_5_p_keys_key_2.Text != "Введите секретный ключ")
            {
                PanelMethod_5_change_status_enable_onother_elements(true);

                panelMethod_5_p_encrypt_in.MaxLength = panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length;
                if (panelMethod_5_p_encrypt_in.Text.Length < panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length)
                {
                    int count_add_null_elem = Math.Abs(panelMethod_5_p_encrypt_in.Text.Length - panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length);
                    for (int i = 0; i < count_add_null_elem; i++)
                    {
                        panelMethod_5_p_encrypt_in.Text += " ";
                    }
                }
            }
            else 
            {
                PanelMethod_5_change_status_enable_onother_elements(false);
            }
            if (this.panelMethod_5_p_keys_key_2.Text != "Введите секретный ключ")
            {
                var alph = "0123456789";
                this.panelMethod_5_p_keys_key_2.Text = this.panelMethod_5_p_keys_key_2.Text.ToLower();
                foreach (var c in panelMethod_5_p_keys_key_2.Text)
                {
                    var f = false;
                    foreach (var ch in alph)
                    {
                        if (c == ch)
                            f = true;
                    }
                    if (!f)
                    {
                        this.panelMethod_5_p_keys_key_2.Text = "Введите секретный ключ";
                        this.panelMethod_5_p_keys_key_2.ForeColor = System.Drawing.Color.Silver;
                        MessageBox.Show(
                            "Вводите только цифры",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                        break;
                    }
                    else
                    {
                        var text = this.panelMethod_5_p_keys_key_2.Text;
                        // отчистили повторения букв
                        int i = 0;
                        while (true)
                        {
                            var tmp = text[i].ToString();
                            text = text.Replace(tmp, "");
                            text = text.Insert(i, tmp);
                            i++;
                            if (text.Length - 1 < i)
                                break;
                        }
                        this.panelMethod_5_p_keys_key_2.Text = text;
                    }
                }
            }
        }


        private void PanelMethod_5_p_encrypt_in_Leave(object sender, EventArgs e)
        {
            if (panelMethod_5_p_encrypt_in.Text == "")
            {
                this.panelMethod_5_p_encrypt_in.Text = "Введите сообщение, которое надо зашифровать";
                this.panelMethod_5_p_encrypt_in.ForeColor = System.Drawing.Color.Silver;
                if (panelMethod_5_p_encrypt_in.Text.Length < panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length)
                {
                    int count_add_null_elem = Math.Abs(panelMethod_5_p_encrypt_in.Text.Length - panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length);
                    for (int i = 0; i < count_add_null_elem; i++)
                    {
                        panelMethod_5_p_encrypt_in.Text += " ";
                    }
                }
            }
            if(this.panelMethod_5_p_encrypt_in.Text != "Введите сообщение, которое надо зашифровать")
            {
                panelMethod_5_p_encrypt_in.Text = panelMethod_5_p_encrypt_in.Text.Replace(" ", "_");
                if (panelMethod_5_p_encrypt_in.Text.Length < panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length)
                {
                    int count_add_null_elem = Math.Abs(panelMethod_5_p_encrypt_in.Text.Length - panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length);
                    for (int i = 0; i < count_add_null_elem; i++)
                    {
                        panelMethod_5_p_encrypt_in.Text += " ";
                    }
                }
            }
        }


        private void PanelMethod_5_p_keys_key_1_Enter(object sender, EventArgs e)
        {
            if (panelMethod_5_p_keys_key_1.Text == "Введите секретный ключ")
            {
                this.panelMethod_5_p_keys_key_1.Text = "";
                this.panelMethod_5_p_keys_key_1.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void PanelMethod_5_p_keys_key_2_Enter(object sender, EventArgs e)
        {
            if (panelMethod_5_p_keys_key_2.Text == "Введите секретный ключ")
            {
                this.panelMethod_5_p_keys_key_2.Text = "";
                this.panelMethod_5_p_keys_key_2.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void PanelMethod_5_p_encrypt_in_Enter(object sender, EventArgs e)
        {
            if (panelMethod_5_p_encrypt_in.Text == "Введите сообщение, которое надо зашифровать" || panelMethod_5_p_encrypt_in.Text.Replace(" ", "") == "Введитесообщение,котороенадозашифровать" || panelMethod_5_p_encrypt_in.Text.Replace("_", "") == "Введитесообщение,котороенадозашифровать")
            {
                this.panelMethod_5_p_encrypt_in.Text = "";
                this.panelMethod_5_p_encrypt_in.ForeColor = System.Drawing.Color.Black;
            }


        }


        private void PanelMethod_5_add_row_to_table(List<string> row)
        {
            var count_Elem = row.Count;
            switch(count_Elem)
            {
                case 1:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0]);break;
                    }
                case 2:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1]);break;
                    }
                case 3:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2]);break;
                    }
                case 4:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3]);break;
                    }
                case 5:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4]);break;
                    }
                case 6:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);break;
                    }
                case 7:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);break;
                    }
                case 8:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);break;
                    }
                case 9:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);break;
                    }
                case 10:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);break;
                    }
                case 11:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10]);break;
                    }
                case 12:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11]);break;
                    }
                case 13:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12]);break;
                    }
                case 14:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13]);break;
                    }
                case 15:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13], row[14]);break;
                    }
                case 16:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13], row[14], row[15]);break;
                    }
                case 17:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13], row[14], row[15], row[16]);break;
                    }
                case 18:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17]);break;
                    }
                case 19:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18]);break;
                    }
                case 20:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19]);break;
                    }
                case 21:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19],row[20]);break;
                    }
                case 22:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19],row[20], row[21]);break;
                    }
                case 23:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19],row[20], row[21], row[22]);break;
                    }
                case 24:{panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9],row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19],row[20], row[21], row[22], row[23]);break;
                    }
                case 25:{
                        panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24]); break;
                    }
                case 26:{
                        panelMethod_5_p_table_dataGrid.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], row[20], row[21], row[22], row[23], row[24], row[25]); break;
                    }

            }

        }


        private void PanelMethod_5_btn_back_slide_Click(object sender, EventArgs e)
        {
            int Num_Slide = Convert.ToInt32(panelMethod_5_addLabel.Text.ToLower());
            Num_Slide--;
            if (Num_Slide == 0) { Num_Slide = 1; }
            this.panelMethod_5_addLabel.Text = Convert.ToString(Num_Slide);
            switch (Num_Slide)
            {
                case 1: PanelMethod_5_generate_table(1); break;
                case 2: PanelMethod_5_generate_table(2); break;
                case 3: PanelMethod_5_generate_table(3); break;
            }
            PanelMethod_5_select_slide(Num_Slide);
        }


        private void PanelMethod_5_slide_label_1_MouseEnter(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_1.BackColor = System.Drawing.Color.Gray;
        }


        private void PanelMethod_5_slide_label_2_MouseEnter(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_2.BackColor = System.Drawing.Color.Gray;
        }


        private void PanelMethod_5_slide_label_3_MouseEnter(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_3.BackColor = System.Drawing.Color.Gray;
        }


        private void PanelMethod_5_slide_label_1_MouseLeave(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_1.BackColor = System.Drawing.Color.DimGray;
        }


        private void PanelMethod_5_slide_label_2_MouseLeave(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_2.BackColor = System.Drawing.Color.DimGray;
        }


        private void PanelMethod_5_slide_label_3_MouseLeave(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_3.BackColor = System.Drawing.Color.DimGray;
        }


        private void PanelMethod_5_slide_label_1_Click(object sender, EventArgs e)
        {
            PanelMethod_5_generate_table(1);
            PanelMethod_5_select_slide(1);
        }


        private void PanelMethod_5_slide_label_2_Click(object sender, EventArgs e)
        {
            PanelMethod_5_generate_table(2);
            PanelMethod_5_select_slide(2);
        }


        private void PanelMethod_5_slide_label_3_Click(object sender, EventArgs e)
        {
            PanelMethod_5_generate_table(3);
            PanelMethod_5_select_slide(3);
        }


        private void PanelMethod_5_btn_next_slide_Click(object sender, EventArgs e)
        {
            int Num_Slide = Convert.ToInt32(panelMethod_5_addLabel.Text.ToLower());
            Num_Slide++;
            if (Num_Slide == 4) { Num_Slide = 3; }
            this.panelMethod_5_addLabel.Text = Convert.ToString(Num_Slide);
            switch(Num_Slide)
            {
                case 1: PanelMethod_5_generate_table(1); break;
                case 2: PanelMethod_5_generate_table(2); break;
                case 3: PanelMethod_5_generate_table(3); break;
            }
            PanelMethod_5_select_slide(Num_Slide);
        }


        class List_Rows_Comparer : IComparer<List<string>>
        {
            public int Compare(List<string> p1, List<string> p2)
            {
                if (Convert.ToInt32(p1[1]) > Convert.ToInt32(p2[1]))
                    return 1;
                else if (Convert.ToInt32(p1[1]) < Convert.ToInt32(p2[1]))
                    return -1;
                else
                    return 0;
            }
            public int Compare(List<List<string>> p1, List<List<string>> p2)
            {
                if (Convert.ToInt32(p1[1][1]) > Convert.ToInt32(p2[1][1]))
                    return 1;
                else if (Convert.ToInt32(p1[1][1]) < Convert.ToInt32(p2[1][1]))
                    return -1;
                else
                    return 0;
            }

        }


        private void PanelMethod_5_generate_table(int v)
        {
            panelMethod_5_p_table_dataGrid.Rows.Clear();
            if (panelMethod_5_p_encrypt_in.Text.Length < panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length)
            {
                int count_add_null_elem = Math.Abs(panelMethod_5_p_encrypt_in.Text.Length - panelMethod_5_p_keys_key_1.Text.Length * panelMethod_5_p_keys_key_2.Text.Length);
                for (int i = 0; i < count_add_null_elem; i++)
                {
                    panelMethod_5_p_encrypt_in.Text += " ";
                }
            }
            List<List<string>> rows = new List<List<string>>() { };
            List<string> row = new List<string>() { };
            switch (v)
            {
                case 1:
                    {
                        // добавление первую строчку
                        row.Add(" ");
                        foreach (var c in panelMethod_5_p_keys_key_1.Text)
                        {
                            row.Add(c.ToString());
                        }
                        rows.Add(row);
                        row = new List<string>() { };
                        // добавление цифр из текста
                        row.Add(" ");
                        foreach (var c in panelMethod_5_p_keys_key_1.Text)
                        {
                            row.Add(Convert.ToString(Convert.ToInt32(c)));
                        }
                        rows.Add(row);
                        row = new List<string>() { };
                        int Count_Elem_in_rows = 0;
                        foreach(var First_column in panelMethod_5_p_keys_key_2.Text)
                        {
                            row.Add(First_column.ToString());
                            for(int i = 0; i< panelMethod_5_p_keys_key_1.Text.Length; i++ )
                            {
                                row.Add(panelMethod_5_p_encrypt_in.Text[i+Count_Elem_in_rows].ToString());
                            }
                            rows.Add(row);
                            Count_Elem_in_rows += panelMethod_5_p_keys_key_1.Text.Length;
                            row = new List<string>() { };
                        }
                        break;
                    }
                case 2:
                    {
                        // Создаём первую таблицу
                        List<List<string>> First_rows = new List<List<string>>() { };
                        // Создаём первоначальную таблицу
                        {
                            row = new List<string>() { };
                            // добавление первую строчку
                            row.Add(" ");
                            foreach (var c in panelMethod_5_p_keys_key_1.Text)
                            {
                                row.Add(c.ToString());
                            }
                            First_rows.Add(row);
                            row = new List<string>() { };
                            // добавление цифр из текста
                            row.Add(" ");
                            foreach (var c in panelMethod_5_p_keys_key_1.Text)
                            {
                                row.Add(Convert.ToString(Convert.ToInt32(c)));
                            }
                            First_rows.Add(row);
                            row = new List<string>() { };
                            int Count_Elem_in_rows = 0;
                            foreach (var First_column in panelMethod_5_p_keys_key_2.Text)
                            {
                                row.Add(First_column.ToString());
                                for (int i = 0; i < panelMethod_5_p_keys_key_1.Text.Length; i++)
                                {
                                    row.Add(panelMethod_5_p_encrypt_in.Text[i + Count_Elem_in_rows].ToString());
                                }
                                First_rows.Add(row);
                                Count_Elem_in_rows += panelMethod_5_p_keys_key_1.Text.Length;
                                row = new List<string>() { };
                            }
                        }
                        // Создаём вторую таблицу
                        List<List<string>> Second_rows = new List<List<string>>() { };
                        // переворачиваем таблицу
                        row = new List<string>() { };
                        for(int i = 0; i < First_rows[0].Count; i++)
                        {
                            for(int j = 0; j < First_rows.Count; j++)
                            {
                                row.Add(First_rows[j][i]);
                            }
                            Second_rows.Add(row);
                            row = new List<string>() { };

                        }
                        // сортируем
                        First_rows.Clear();
                        Second_rows[0][1] = "0";
                        List_Rows_Comparer lrC = new List_Rows_Comparer();
                        Second_rows.Sort(lrC);
                        Second_rows[0][1] = " ";
                        // переворачиваем обратно
                        row = new List<string>() { };
                        for (int i = 0; i < Second_rows[0].Count; i++)
                        {
                            for (int j = 0; j < Second_rows.Count; j++)
                            {
                                row.Add(Second_rows[j][i]);
                            }
                            rows.Add(row);
                            row = new List<string>() { };

                        }

                        break;
                    }
                case 3:
                    {
                        // создаём вторую таблицу
                        List<List<string>> Second_rows = new List<List<string>>() { };
                        // записываев информацию в 2 таблицу
                        {
                            // Создаём первую таблицу
                            List<List<string>> First_rows = new List<List<string>>() { };
                            // Создаём первоначальную таблицу
                            {
                                row = new List<string>() { };
                                // добавление первую строчку
                                row.Add(" ");
                                foreach (var c in panelMethod_5_p_keys_key_1.Text)
                                {
                                    row.Add(c.ToString());
                                }
                                First_rows.Add(row);
                                row = new List<string>() { };
                                // добавление цифр из текста
                                row.Add(" ");
                                foreach (var c in panelMethod_5_p_keys_key_1.Text)
                                {
                                    row.Add(Convert.ToString(Convert.ToInt32(c)));
                                }
                                First_rows.Add(row);
                                row = new List<string>() { };
                                int Count_Elem_in_rows = 0;
                                foreach (var First_column in panelMethod_5_p_keys_key_2.Text)
                                {
                                    row.Add(First_column.ToString());
                                    for (int i = 0; i < panelMethod_5_p_keys_key_1.Text.Length; i++)
                                    {
                                        row.Add(panelMethod_5_p_encrypt_in.Text[i + Count_Elem_in_rows].ToString());
                                    }
                                    First_rows.Add(row);
                                    Count_Elem_in_rows += panelMethod_5_p_keys_key_1.Text.Length;
                                    row = new List<string>() { };
                                }
                            }
                            // Создаём вторую таблицу
                            List<List<string>> tmp = new List<List<string>>() { };
                            // переворачиваем таблицу
                            row = new List<string>() { };
                            for (int i = 0; i < First_rows[0].Count; i++)
                            {
                                for (int j = 0; j < First_rows.Count; j++)
                                {
                                    row.Add(First_rows[j][i]);
                                }
                                tmp.Add(row);
                                row = new List<string>() { };

                            }
                            // сортируем
                            First_rows.Clear();
                            tmp[0][1] = "0";
                            List_Rows_Comparer lrC = new List_Rows_Comparer();
                            tmp.Sort(lrC);
                            tmp[0][1] = " ";
                            // переворачиваем обратно
                            row = new List<string>() { };
                            for (int i = 0; i < tmp[0].Count; i++)
                            {
                                for (int j = 0; j < tmp.Count; j++)
                                {
                                    row.Add(tmp[j][i]);
                                }
                                Second_rows.Add(row);
                                row = new List<string>() { };
                            }
                        }
                        // Сортируем 2 таблицу
                        Second_rows[0][0] = "-1";
                        Second_rows[1][0] = "0";
                        for(int i = 0; i < Second_rows.Count; i++)
                        {
                            Second_rows[i].Insert(1, Second_rows[i][0]);
                        }
                        List_Rows_Comparer lrC1 = new List_Rows_Comparer();
                        Second_rows.Sort(lrC1);
                        Second_rows[0][0] = " ";
                        Second_rows[1][0] = " ";
                        for (int i = 0; i < Second_rows.Count; i++)
                        {
                            Second_rows[i].RemoveAt(1);
                        }
                        rows = Second_rows;
                        break;
                    }
            }
            
            
            //// Вносим даные в лист Table
            //for (var i = 0; i < 30; i++)
            //    Table.Insert(i, tmp[i].ToString());
            foreach (var _row in rows)
            {
                PanelMethod_5_add_row_to_table(_row);
            }
        }


        private void PanelMethod_5_change_status_enable_onother_elements(bool v)
        {
            this.panelMethod_5_btn_back_slide.Enabled = v;
            this.panelMethod_5_btn_next_slide.Enabled = v;
            this.panelMethod_5_p_slide_1.Enabled = v;
            this.panelMethod_5_p_slide_2.Enabled = v;
            this.panelMethod_5_p_slide_3.Enabled = v;
            this.panelMethod_5_p_table_dataGrid.Enabled = v;
            this.panelMethod_5_p_encrypt_in.Enabled = v;
        }


        private void PanelMethod_5_select_slide(int num_Slide)
        {
            panelMethod_5_slide_label_1.BackColor = System.Drawing.Color.DimGray;
            panelMethod_5_slide_label_2.BackColor = System.Drawing.Color.DimGray;
            panelMethod_5_slide_label_3.BackColor = System.Drawing.Color.DimGray;
            panelMethod_5_slide_label_1.Font = new System.Drawing.Font("Impact", 14.25F);
            panelMethod_5_slide_label_2.Font = new System.Drawing.Font("Impact", 14.25F);
            panelMethod_5_slide_label_3.Font = new System.Drawing.Font("Impact", 14.25F);
            switch(num_Slide)
            {
                case 1:
                    {
                        panelMethod_5_slide_label_1.BackColor = System.Drawing.Color.Gray;
                        panelMethod_5_slide_label_1.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Bold);
                        break;
                    }
                case 2:
                    {
                        panelMethod_5_slide_label_2.BackColor = System.Drawing.Color.Gray;
                        panelMethod_5_slide_label_2.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Bold);
                        break;
                    }
                case 3:
                    {
                        panelMethod_5_slide_label_3.BackColor = System.Drawing.Color.Gray;
                        panelMethod_5_slide_label_3.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Bold);
                        break;
                    }
            }


        }


        private void PanelMethod_5_p_encrypt_btn_Click(object sender, EventArgs e)
        {
            panelMethod_5_p_encrypt_out.Text = "";
            // создаём таблцу
            List<List<string>> table;
            // записываем инфу в таблицу
            {
                List<string> row;
                // создаём вторую таблицу
                List<List<string>> Second_rows = new List<List<string>>() { };
                // записываев информацию в 2 таблицу
                {
                    // Создаём первую таблицу
                    List<List<string>> First_rows = new List<List<string>>() { };
                    // Создаём первоначальную таблицу
                    {
                        row = new List<string>() { };
                        // добавление первую строчку
                        row.Add(" ");
                        foreach (var c in panelMethod_5_p_keys_key_1.Text)
                        {
                            row.Add(c.ToString());
                        }
                        First_rows.Add(row);
                        row = new List<string>() { };
                        // добавление цифр из текста
                        row.Add(" ");
                        foreach (var c in panelMethod_5_p_keys_key_1.Text)
                        {
                            row.Add(Convert.ToString(Convert.ToInt32(c)));
                        }
                        First_rows.Add(row);
                        row = new List<string>() { };
                        int Count_Elem_in_rows = 0;
                        foreach (var First_column in panelMethod_5_p_keys_key_2.Text)
                        {
                            row.Add(First_column.ToString());
                            for (int i = 0; i < panelMethod_5_p_keys_key_1.Text.Length; i++)
                            {
                                row.Add(panelMethod_5_p_encrypt_in.Text[i + Count_Elem_in_rows].ToString());
                            }
                            First_rows.Add(row);
                            Count_Elem_in_rows += panelMethod_5_p_keys_key_1.Text.Length;
                            row = new List<string>() { };
                        }
                    }
                    // Создаём вторую таблицу
                    List<List<string>> tmp = new List<List<string>>() { };
                    // переворачиваем таблицу
                    row = new List<string>() { };
                    for (int i = 0; i < First_rows[0].Count; i++)
                    {
                        for (int j = 0; j < First_rows.Count; j++)
                        {
                            row.Add(First_rows[j][i]);
                        }
                        tmp.Add(row);
                        row = new List<string>() { };

                    }
                    // сортируем
                    First_rows.Clear();
                    tmp[0][1] = "0";
                    List_Rows_Comparer lrC = new List_Rows_Comparer();
                    tmp.Sort(lrC);
                    tmp[0][1] = " ";
                    // переворачиваем обратно
                    row = new List<string>() { };
                    for (int i = 0; i < tmp[0].Count; i++)
                    {
                        for (int j = 0; j < tmp.Count; j++)
                        {
                            row.Add(tmp[j][i]);
                        }
                        Second_rows.Add(row);
                        row = new List<string>() { };
                    }
                }
                // Сортируем 2 таблицу
                Second_rows[0][0] = "-1";
                Second_rows[1][0] = "0";
                for (int i = 0; i < Second_rows.Count; i++)
                {
                    Second_rows[i].Insert(1, Second_rows[i][0]);
                }
                List_Rows_Comparer lrC1 = new List_Rows_Comparer();
                Second_rows.Sort(lrC1);
                Second_rows[0][0] = " ";
                Second_rows[1][0] = " ";
                for (int i = 0; i < Second_rows.Count; i++)
                {
                    Second_rows[i].RemoveAt(1);
                }
                table = Second_rows;
            }
            for(int i = 2; i<table.Count; i++)
            {
                for(int j = 1; j < table[i].Count; j++)
                {
                    panelMethod_5_p_encrypt_out.Text += table[i][j];
                }
            }
        }
    }

}