using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
                Change_Status_Enable_Elements_PanelMethod_4(false);
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
                        Change_Status_Enable_Elements_PanelMethod_4(false);
                        break;
                    }
                    else
                    {
                        Change_Status_Enable_Elements_PanelMethod_4();
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
                        Change_Status_Enable_Elements_PanelMethod_4(false);
                        break;
                    }
                    else
                    {
                        Change_Status_Enable_Elements_PanelMethod_4();
                    }
                }
            }
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text.ToLower();
        }


        private void PanelMethod_4_p_generate_table_p_lang_EN_Click(object sender, EventArgs e)
        {
            panelMethod_4_p_table_dataGrid.Rows.Clear();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 25";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = "введите секретное слово";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_En_options.Enabled = true;
            this.panelMethod_4_p_generate_table_En_options.Visible = true;
            this.panelMethod_4_p_table_dataGrid_Column_5.Visible = true;
            Change_Status_Enable_Elements_PanelMethod_4(false);
            this.panelMethod_4_p_generate_table_GenerateBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMethod_4_p_encrypt_in.Text = "Введите сообщение, которое надо зашифровать";
            this.panelMethod_4_p_encrypt_in.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_encrypt_out.Text = "";
            this.panelMethod_4_p_encrypt_out.ForeColor = System.Drawing.Color.Black;
            this.panelMethod_4_p_table_dataGrid.Visible = false;

        }


        private void PanelMethod_4_p_generate_table_p_lang_RU_Click(object sender, EventArgs e)
        {
            panelMethod_4_p_table_dataGrid.Rows.Clear();
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 33";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text = "введите секретное слово";
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_generate_table_En_options.Enabled = false;
            this.panelMethod_4_p_generate_table_En_options.Visible = false;
            Change_Status_Enable_Elements_PanelMethod_4(false);
            this.panelMethod_4_p_table_dataGrid_Column_5.Visible = false;
            this.panelMethod_4_p_generate_table_GenerateBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_encrypt_in.Text = "Введите сообщение, которое надо зашифровать";
            this.panelMethod_4_p_encrypt_in.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_encrypt_out.Text = "";
            this.panelMethod_4_p_table_dataGrid.Visible = false;
            this.panelMethod_4_p_encrypt_out.ForeColor = System.Drawing.Color.Black;
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
                {
                    this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 25";
                }
                else
                {
                    this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 33";
                }
                Change_Status_Enable_Elements_PanelMethod_4(false);
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
                        Change_Status_Enable_Elements_PanelMethod_4(false);
                        break;
                    }
                    Change_Status_Enable_Elements_PanelMethod_4();

                }
        }

        
        private void PanelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb_Enter(object sender, EventArgs e)
        {
            if (panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text == "введите число семени рандомайзера или не трогайте данное поле для генерации случайного семени")
            {
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text = "";
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void PanelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb_Leave(object sender, EventArgs e)
        {
            if (panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text == "")
            {
                Change_Status_Enable_Elements_PanelMethod_4(false);
                this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text = "введите число семени рандомайзера или не трогайте данное поле для генерации случайного семени";
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
                    Change_Status_Enable_Elements_PanelMethod_4();
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
            this.panelMethod_4_p_table_dataGrid.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Enabled = true;
            Change_Status_Enable_Elements_PanelMethod_4(false);
            this.panelMethod_4_p_encrypt_in.Text = "Введите сообщение, которое надо зашифровать";
            this.panelMethod_4_p_encrypt_in.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_encrypt_out.Text = "";
            this.panelMethod_4_p_encrypt_out.ForeColor = System.Drawing.Color.Black;


        }


        private void PanelMethod_4_p_generate_table_p_Method_generate_offset_Click(object sender, EventArgs e)
        {
            this.panelMethod_4_p_table_dataGrid.Visible = false;
            panelMethod_4_p_table_dataGrid.Rows.Clear();
            Change_Status_Enable_Elements_PanelMethod_4(false);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Visible = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Enabled = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Enabled = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Enabled = true;
            this.panelMethod_4_p_encrypt_in.Text = "Введите сообщение, которое надо зашифровать";
            this.panelMethod_4_p_encrypt_in.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_encrypt_out.Text = "";
            this.panelMethod_4_p_encrypt_out.ForeColor = System.Drawing.Color.Black;
        }


        private void PanelMethod_4_p_generate_table_p_Method_generate_randomize_Click(object sender, EventArgs e)
        {
            this.panelMethod_4_p_table_dataGrid.Visible = false;
            panelMethod_4_p_table_dataGrid.Rows.Clear();
            Change_Status_Enable_Elements_PanelMethod_4(false);
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Visible = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Visible = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_3.Enabled = true;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2.Enabled = false;
            this.panelMethod_4_p_generate_table_p_Method_otions_Method_1.Enabled = false;
            this.panelMethod_4_p_encrypt_in.Text = "Введите сообщение, которое надо зашифровать";
            this.panelMethod_4_p_encrypt_in.ForeColor = System.Drawing.Color.Silver;
            this.panelMethod_4_p_encrypt_out.Text = "";
            this.panelMethod_4_p_encrypt_out.ForeColor = System.Drawing.Color.Black;
        }


        private void Change_Status_Enable_Elements_PanelMethod_4(bool status = true)
        {
            this.panelMethod_4_p_encrypt_btn.Enabled = status;
            this.panelMethod_4_p_encrypt_in.Enabled = status;
            this.panelMethod_4_p_encrypt_out.Enabled = status;
            this.panelMethod_4_p_table_label.Visible = true;
        }


        private void PanelMethod_4_p_generate_table_GenerateBTN_Click(object sender, EventArgs e)
        {
            List<string> table = new List<string>() { };
            bool flag = false;
            // нажата клавиша "Секретный ключ"
            if (this.panelMethod_4_p_generate_table_p_Method_generate_key.Checked)
            {
                if (this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text == "введите секретное слово")
                {
                    MessageBox.Show(
                    "Введите секретное слово",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                    Change_Status_Enable_Elements_PanelMethod_4(false);
                }
                else
                {
                    Change_Status_Enable_Elements_PanelMethod_4();
                    table = PanelMethod_4_generate_table(
                        1,
                        Convert.ToString(this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text),
                        this.panelMethod_4_p_generate_table_p_lang_EN.Checked
                        );
                    flag = true;
                }
            }
            // нажата клавиша "Смещения"
            else if (this.panelMethod_4_p_generate_table_p_Method_generate_offset.Checked)
            {
                if (this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text == "Введите число от 0 до 25" || this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text == "Введите число от 0 до 33")
                {
                    // нажата клавиша "Латиница"
                    if (this.panelMethod_4_p_generate_table_p_lang_EN.Checked) 
                    { 
                        MessageBox.Show(
                            "Введите число от 0 до 25",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    Change_Status_Enable_Elements_PanelMethod_4(false);
                    }
                    // нажата клавиша "Кириллица"
                    else
                    {
                        MessageBox.Show(
                            "Введите число от 0 до 33",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        Change_Status_Enable_Elements_PanelMethod_4(false);
                    }
                }
            // нажата клавиша "Рандом"
            else
                {
                    bool fla = true;
                    int offset = Convert.ToInt32(this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text);
                    // нажата клавиша "Латиница"
                    if (this.panelMethod_4_p_generate_table_p_lang_EN.Checked)
                    {
                        if (offset < 0 || offset > 25)
                        {
                            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 25";
                            MessageBox.Show(
                                "Введите число от 0 до 25",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            Change_Status_Enable_Elements_PanelMethod_4(false);
                            fla = false;
                        } 
                    }
                    // нажата клавиша "Кириллица"
                    else
                    {
                        if (offset < 0 || offset > 33)
                        {
                            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 33";
                            MessageBox.Show(
                                "Введите число от 0 до 33",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            Change_Status_Enable_Elements_PanelMethod_4(false);
                            fla = false;
                        }
                    }
                    // клавиша "Рандом" прошла проверки на правильность числа
                    if (fla)
                    {
                        Change_Status_Enable_Elements_PanelMethod_4();
                        table = PanelMethod_4_generate_table(
                            2,
                            Convert.ToString(this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text),
                            this.panelMethod_4_p_generate_table_p_lang_EN.Checked
                            );
                        flag = true;
                    }
                }
            }
            // нажата клавиша "Рандом"
            else if (this.panelMethod_4_p_generate_table_p_Method_generate_randomize.Checked)
            {
                // система генерит сама семя
                if (this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text == "введите число семени рандомайзера или не трогайте данное поле для генерации случайного семени")
                {
                    Random rnd = new Random();
                    int chRnd = rnd.Next(0, 99999);
                    this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed.Text = $@"Выбрано семя: {chRnd}";
                    table = PanelMethod_4_generate_table(
                    3,
                    Convert.ToString(chRnd),
                    this.panelMethod_4_p_generate_table_p_lang_EN.Checked
                    );
                    flag = true;
                }
                // пользователь вводит своё семя
                else
                {
                    Random rnd = new Random(Convert.ToInt32(this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text));
                    table = PanelMethod_4_generate_table(
                    3,
                    Convert.ToString(rnd.Next(0, 99999)),
                    this.panelMethod_4_p_generate_table_p_lang_EN.Checked
                    );
                    flag = true;
                }
            }
            // заполнение данных в data grid
            if (flag)
            {
                // отчищаем дада грид
                panelMethod_4_p_table_dataGrid.Rows.Clear();
                // узнаём кол-во строк
                int rows = panelMethod_4_p_generate_table_p_lang_EN.Checked ? 5 : 8;
                // узнаём кол-во столбцов
                int column = panelMethod_4_p_generate_table_p_lang_EN.Checked ? 5 : 4;
                // заполняем грид
                for (var i = 0; i < column * rows; i+=column)
                {
                    if (column == 5)
                        panelMethod_4_p_table_dataGrid.Rows.Add
                        (
                        table[i + 0], table[i + 1], table[i + 2], table[i + 3], table[i + 4]
                        );
                    else
                        panelMethod_4_p_table_dataGrid.Rows.Add
                        (
                        table[i + 0], table[i + 1], table[i + 2], table[i + 3]
                        );
                }
                // включаем текст бокс шифрования
                Change_Status_Enable_Elements_PanelMethod_4();
                // включаем дата грид
                panelMethod_4_p_table_dataGrid.Visible = true;
                // выключаем боковую надпись
                this.panelMethod_4_p_table_label.Visible = false;
            }
        }


        private List<string> PanelMethod_4_generate_table(int pos, string text, bool en)
        {
            // подготовка переменных
            text.ToLower();
            string alph;
            List<string> table = new List<string>() { };
            // проверка на не ту позицию
            if (pos > 3 || pos < 1)
            {
                pos = 2;
                text = "0";
            }
            // проверка и замена i и j или опускание q
            if (pos == 1 && this.panelMethod_4_p_generate_table_En_options_i_and_j.Checked)
            {  text = text.Replace('j', 'i');  }
            else if(pos == 1 && !this.panelMethod_4_p_generate_table_En_options_i_and_j.Checked)
            { text = text.Replace('q', Convert.ToChar("")); }
            // чистый алфавит
            if (en)
            {
                if(this.panelMethod_4_p_generate_table_En_options_i_and_j.Checked)
                    alph = "abcdefghiklmnopqrstuvwxyz";
                else
                    alph = "abcdefghijklmnoprstuvwxyz";
            }
            else
            {
                alph = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
            }
            // генерация листа таблицы
            switch (pos)
            {
                // Выбрано генерация по ключу
                case 1: 
                    {
                        // добавили ключ к алфавиту
                        text += alph;
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
                        // Записываем алфавит в лист
                        foreach (var c in text)
                        {
                            switch(c)
                            {
                                case ('i'): table.Add("i/j"); break;
                                default: table.Add(c.ToString()); break;
                            }
                            
                        }
                        // Конец кейса
                        break;
                    }
                // Выбрано генерация по смещению
                case 2: 
                    {
                        string tmp = "";
                        int offset = Convert.ToInt32(text);
                        for(var i = 0; i < alph.Length;i++)
                        {
                            if (offset >= alph.Length)
                                offset = 0;
                            tmp+=alph[offset].ToString();
                            offset++;
                        }
                        foreach (var c in tmp)
                        {
                            switch (c)
                            {

                                case ('i'): if (this.panelMethod_4_p_generate_table_En_options_i_and_j.Checked) { table.Add("i/j"); } else { table.Add("i"); } break;
                                default: table.Add(c.ToString()); break;
                            }
                        }

                        // Конец кейса
                        break;
                    }
                // Выбрано генерация по рандом числу
                case 3: 
                    {
                        Random rnd = new Random(Convert.ToInt32(text));
                        int offset;
                        if (en)
                            offset = rnd.Next(0, 25);
                        else
                            offset = rnd.Next(0, 32);
                        this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed.Text += $@", число смещения: {offset}";
                        this.panelMethod_4_add_label_1.Text = offset.ToString();
                        string tmp = "";
                        for (var i = 0; i < alph.Length; i++)
                        {
                            if (offset >= alph.Length)
                                offset = 0;
                            tmp += alph[offset].ToString();
                            offset++;
                        }
                        foreach (var c in tmp)
                        {
                            switch (c)
                            {
                                case ('i'): if (this.panelMethod_4_p_generate_table_En_options_i_and_j.Checked) { table.Add("i/j"); } else { table.Add("i"); } break;
                         default: table.Add(c.ToString()); break;
                            }

                        }
                        // Конец кейса
                        break;
                    }
                default: break;
            }
            return table;
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
                panelMethod_4_p_encrypt_in.Text = tmp;
            }
        }


        private void PanelMethod_4_p_encrypt_btn_Click(object sender, EventArgs e)
        {
            if (this.panelMethod_4_p_encrypt_in.Text == "Введите сообщение, которое надо зашифровать")
            {
                MessageBox.Show(
                        "Введите сообщение, которое надо зашифровать",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                this.panelMethod_4_p_encrypt_out.Text = "";
            }
            else 
            {
            // создаём лист таблицы
            List<string> table = new List<string>() { };
            // генерим лист таблицы
            bool flag = false;
            // нажата клавиша "Секретный ключ"
            if (this.panelMethod_4_p_generate_table_p_Method_generate_key.Checked)
            {
                if (this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text == "введите секретное слово")
                {
                    MessageBox.Show(
                    "Введите секретное слово",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                    Change_Status_Enable_Elements_PanelMethod_4(false);
                }
                else
                {
                    Change_Status_Enable_Elements_PanelMethod_4();
                    table = PanelMethod_4_generate_table(
                        1,
                        Convert.ToString(this.panelMethod_4_p_generate_table_p_Method_otions_Method_1_key.Text),
                        this.panelMethod_4_p_generate_table_p_lang_EN.Checked
                        );
                    flag = true;
                }
            }
            // нажата клавиша "Смещения"
            else if (this.panelMethod_4_p_generate_table_p_Method_generate_offset.Checked)
            {
                if (this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text == "Введите число от 0 до 25" || this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text == "Введите число от 0 до 33")
                {
                    // нажата клавиша "Латиница"
                    if (this.panelMethod_4_p_generate_table_p_lang_EN.Checked)
                    {
                        MessageBox.Show(
                            "Введите число от 0 до 25",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        Change_Status_Enable_Elements_PanelMethod_4(false);
                    }
                    // нажата клавиша "Кириллица"
                    else
                    {
                        MessageBox.Show(
                            "Введите число от 0 до 33",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        Change_Status_Enable_Elements_PanelMethod_4(false);
                    }
                }
                // нажата клавиша "Рандом"
                else
                {
                    bool fla = true;
                    int offset = Convert.ToInt32(this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text);
                    // нажата клавиша "Латиница"
                    if (this.panelMethod_4_p_generate_table_p_lang_EN.Checked)
                    {
                        if (offset < 0 || offset > 25)
                        {
                            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 25";
                            MessageBox.Show(
                                "Введите число от 0 до 25",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            Change_Status_Enable_Elements_PanelMethod_4(false);
                            fla = false;
                        }
                    }
                    // нажата клавиша "Кириллица"
                    else
                    {
                        if (offset < 0 || offset > 33)
                        {
                            this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text = "Введите число от 0 до 33";
                            MessageBox.Show(
                                "Введите число от 0 до 33",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            Change_Status_Enable_Elements_PanelMethod_4(false);
                            fla = false;
                        }
                    }
                    // клавиша "Рандом" прошла проверки на правильность числа
                    if (fla)
                    {
                        Change_Status_Enable_Elements_PanelMethod_4();
                        table = PanelMethod_4_generate_table(
                            2,
                            Convert.ToString(this.panelMethod_4_p_generate_table_p_Method_otions_Method_2_offset.Text),
                            this.panelMethod_4_p_generate_table_p_lang_EN.Checked
                            );
                        flag = true;
                    }
                }
            }
            // нажата клавиша "Рандом"
            else if (this.panelMethod_4_p_generate_table_p_Method_generate_randomize.Checked)
            {
                // система генерит сама семя
                if (this.panelMethod_4_p_generate_table_p_Method_otions_Method_3_seed_tb.Text == "введите число семени рандомайзера или не трогайте данное поле для генерации случайного семени")
                {
                    table = PanelMethod_4_generate_table(
                    2,
                    Convert.ToString(this.panelMethod_4_add_label_1.Text),
                    this.panelMethod_4_p_generate_table_p_lang_EN.Checked
                    );
                    flag = true;
                }
            }
                // заполнение данных в data grid
                if (flag)
                {
                    // Получаем текст
                    string text = this.panelMethod_4_p_encrypt_in.Text.ToLower();
                    // Удаляем лишние пробелы из текста
                    text = text.Replace(" ", string.Empty);
                    // узнаём количество биграмм
                    double tmp = text.Length / 2.0;
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
                                Bigramms bigramms = new Bigramms(Convert.ToString(text[tmp1]), "x");
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

                    // Отчищаем поле вывода
                    this.panelMethod_4_p_encrypt_out.Text = "";

                    // Шифровка биграмм
                    foreach (var b in Bigramm)
                    {
                        this.panelMethod_4_p_encrypt_out.Text += Encrypt_bigramms(b, table);
                    }
                    this.panelMethod_4_p_table_label.Visible = false;
                }
            }
        }

        private string Encrypt_bigramms(Bigramms b, List<string> table)
        {
            string Crypt_Bigrams;
            int pos_A_x = 0, pos_A_y = 0, pos_B_x = 0, pos_B_y = 0, pos_A, pos_B;
            int i = 0;
            // узнаём кол-во строк
            int rows = panelMethod_4_p_generate_table_p_lang_EN.Checked ? 5 : 8;
            // узнаём кол-во столбцов
            int column = panelMethod_4_p_generate_table_p_lang_EN.Checked ? 5 : 4;
            // проверяем на одинаковые символы
            if(b.A == b.B)
            { b.SetB("x"); }
            // флаги закрытия поиска позиций
            bool f1 = false, f2 = false;
            // ищем позиции биграммы
            foreach (var c in table)
            {
                if (c == b.A)
                {
                    var CountPos = i;
                    for (var x = 0; CountPos >= column; pos_A_x++)
                    {
                        CountPos -= column;
                        x++;
                    }
                    pos_A_y = CountPos;
                    f1 = true;
                }
                if (c == b.B)
                {
                    var CountPos = i;
                    for (var x = 0; CountPos >= column; pos_B_x++)
                    {
                        CountPos -= column;
                        x++;
                    }
                    pos_B_y = CountPos;
                    f2 = true;
                }
                if(f1 && f2)
                { break; }
                i++;
            }
            // Проверка на нахождение в 1 строке
            if(pos_A_x == pos_B_x)
            {
                pos_A_y++;
                pos_B_y++;
                if (pos_A_y >= column)
                    pos_A_y = 0;
                if (pos_B_y >= column)
                    pos_B_y = 0;
            }
            // Проверка на нахождение в 1 столбце
            else if (pos_A_y == pos_B_y)
            {
                pos_A_x++;
                pos_B_x++;
                if (pos_A_x >= rows)
                    pos_A_x = 0;
                if (pos_B_x >= rows)
                    pos_B_x = 0;
            }
            // Окончательное нахождение
            else
            {
                var tmp2 = pos_A_y;
                pos_A_y = pos_B_y;
                pos_B_y = tmp2;
            }
            // нахождение новых позиций
            pos_A = pos_A_y + (pos_A_x * column);
            pos_B = pos_B_y + (pos_B_x * column);
            // Находим новые буквы
            Crypt_Bigrams = table[pos_A] + table[pos_B];
            return Crypt_Bigrams+" ";
        }
    }
}