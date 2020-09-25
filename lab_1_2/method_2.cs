using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace lab_1_2
{
    public partial class MainForm : Form
    {

        private void PanelMethod_2_generate_alphavite_afin()
        {
            List<char> alph_EN_u = new List<char> { };
            List<char> alph_EN_l = new List<char> { };
            List<char> alph_EN_o = new List<char> { };
            List<char> alph_RU_u = new List<char> { };
            List<char> alph_RU_l = new List<char> { };
            List<char> alph_RU_o_u = new List<char> { };
            List<char> alph_RU_o_l = new List<char> { };
            List<int> alph_RU_offset = new List<int> { };
            //00 - никто;01 - латинский;10 - кириллица;11 - оба;
            Int16 chisl = Convert.ToInt16(panelMethod_2_textBox_A.Text);
            if (this.panelMethod_2_l9_stata.Text == "00")
            {
                MessageBox.Show("Введите простые числа в окно A:\n\n\nВот список простых чисел\n  Если надо зашифровать только латинцу: 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 26;\n\n  Если надо зашифровать только кириллицу: 1, 2, 4, 5, 7, 8, 10, 13, 14, 16, 17, 19, 20, 23, 25, 26, 28, 29, 31, 32;\n\n  Если надо зашифровать смешенно(кирилица и латиница): 1, 5, 7, 17, 19, 23, 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panelMethod_2_textBox_A.Text = "1";
            }
            else if (this.panelMethod_2_l9_stata.Text == "01")
            {
                int NumCharU, NumCharL;
                for (var i = 1; i<=26; i++)
                {
                    NumCharU = PanelMethod_2_main_func
                                (
                                    Convert.ToInt32(chisl),
                                    Convert.ToInt32(panelMethod_2_textBox_B.Text),
                                    26,
                                    i
                                ) +
                                64 +
                                i
                            ;
                    NumCharL = PanelMethod_2_main_func
                                (
                                    Convert.ToInt32(chisl),
                                    Convert.ToInt32(panelMethod_2_textBox_B.Text),
                                    26,
                                    i
                                ) +
                                96 +
                                i
                            ;
                    if( NumCharU > 90 )
                    {
                        NumCharU -= 26;
                    }
                    if (NumCharL > 122)
                    {
                        NumCharL -= 26;
                    }
                    alph_EN_o.Add(Convert.ToChar(64+i));
                    alph_EN_u.Add(Convert.ToChar(NumCharU));
                    alph_EN_l.Add(Convert.ToChar(NumCharL));


                }
                panelMethod_2_dataGridView.Rows.Clear();
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Латин",
                    alph_EN_o[0],  alph_EN_o[1],  alph_EN_o[2],  alph_EN_o[3],  alph_EN_o[4], 
                    alph_EN_o[5],  alph_EN_o[6],  alph_EN_o[7],  alph_EN_o[8],  alph_EN_o[9],
                    alph_EN_o[10], alph_EN_o[11], alph_EN_o[12], alph_EN_o[13], alph_EN_o[14], 
                    alph_EN_o[15], alph_EN_o[16], alph_EN_o[17], alph_EN_o[18], alph_EN_o[19],
                    alph_EN_o[20], alph_EN_o[21], alph_EN_o[22], alph_EN_o[23], alph_EN_o[24], 
                    alph_EN_o[25]
                    );
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Латин",
                    alph_EN_l[0],  alph_EN_l[1],  alph_EN_l[2],  alph_EN_l[3],  alph_EN_l[4], 
                    alph_EN_l[5],  alph_EN_l[6],  alph_EN_l[7],  alph_EN_l[8],  alph_EN_l[9],
                    alph_EN_l[10], alph_EN_l[11], alph_EN_l[12], alph_EN_l[13], alph_EN_l[14], 
                    alph_EN_l[15], alph_EN_l[16], alph_EN_l[17], alph_EN_l[18], alph_EN_l[19],
                    alph_EN_l[20], alph_EN_l[21], alph_EN_l[22], alph_EN_l[23], alph_EN_l[24], 
                    alph_EN_l[25]
                    );
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Латин",
                    alph_EN_u[0],  alph_EN_u[1],  alph_EN_u[2],  alph_EN_u[3],  alph_EN_u[4],  
                    alph_EN_u[5],  alph_EN_u[6],  alph_EN_u[7],  alph_EN_u[8],  alph_EN_u[9],
                    alph_EN_u[10], alph_EN_u[11], alph_EN_u[12], alph_EN_u[13], alph_EN_u[14], 
                    alph_EN_u[15], alph_EN_u[16], alph_EN_u[17], alph_EN_u[18], alph_EN_u[19],
                    alph_EN_u[20], alph_EN_u[21], alph_EN_u[22], alph_EN_u[23], alph_EN_u[24], 
                    alph_EN_u[25]
                    );
            }
            else if (this.panelMethod_2_l9_stata.Text == "10")
            {
                for (var i = 1; i <= 6; i++)
                {
                    alph_RU_o_u.Add(Convert.ToChar(1039 + i));
                    alph_RU_o_l.Add(Convert.ToChar(1071 + i));
                }
                alph_RU_o_u.Add(Convert.ToChar(1025));
                alph_RU_o_l.Add(Convert.ToChar(1105));

                for (var i = 7; i <= 33; i++)
                {
                    alph_RU_o_u.Add(Convert.ToChar(1039 + i));
                    alph_RU_o_l.Add(Convert.ToChar(1071 + i));
                }
                for (var i = 1; i <= 33; i++)
                {
                    alph_RU_offset.Add(PanelMethod_2_main_func(Convert.ToInt32(chisl),Convert.ToInt32(panelMethod_2_textBox_B.Text),33,i));
                }

                for (var i = 0; i < 33; i++)
                {
                    alph_RU_u.Add(alph_RU_o_u[alph_RU_offset[i]]);
                    alph_RU_l.Add(alph_RU_o_l[alph_RU_offset[i]]);
                }
                panelMethod_2_dataGridView.Rows.Clear();
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Кириллица",
                    alph_RU_o_u[0],  alph_RU_o_u[1],  alph_RU_o_u[2],  alph_RU_o_u[3],  alph_RU_o_u[4], 
                    alph_RU_o_u[5],  alph_RU_o_u[6],  alph_RU_o_u[7],  alph_RU_o_u[8],  alph_RU_o_u[9], 
                    alph_RU_o_u[10], alph_RU_o_u[11], alph_RU_o_u[12], alph_RU_o_u[13], alph_RU_o_u[14],
                    alph_RU_o_u[15], alph_RU_o_u[16], alph_RU_o_u[17], alph_RU_o_u[18], alph_RU_o_u[19],
                    alph_RU_o_u[20], alph_RU_o_u[21], alph_RU_o_u[22], alph_RU_o_u[23], alph_RU_o_u[24],
                    alph_RU_o_u[25], alph_RU_o_u[26], alph_RU_o_u[27], alph_RU_o_u[28], alph_RU_o_u[29],
                    alph_RU_o_u[30], alph_RU_o_u[31], alph_RU_o_u[32]
                    );
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Кириллица",
                    alph_RU_l[0],  alph_RU_l[1],  alph_RU_l[2],  alph_RU_l[3],  alph_RU_l[4], 
                    alph_RU_l[5],  alph_RU_l[6],  alph_RU_l[7],  alph_RU_l[8],  alph_RU_l[9], 
                    alph_RU_l[10], alph_RU_l[11], alph_RU_l[12], alph_RU_l[13], alph_RU_l[14],
                    alph_RU_l[15], alph_RU_l[16], alph_RU_l[17], alph_RU_l[18], alph_RU_l[19],
                    alph_RU_l[20], alph_RU_l[21], alph_RU_l[22], alph_RU_l[23], alph_RU_l[24],
                    alph_RU_l[25], alph_RU_l[26], alph_RU_l[27], alph_RU_l[28], alph_RU_l[29],
                    alph_RU_l[30], alph_RU_l[31], alph_RU_l[32]
                    );
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Кириллица",
                    alph_RU_u[0],  alph_RU_u[1],  alph_RU_u[2],  alph_RU_u[3],  alph_RU_u[4], 
                    alph_RU_u[5],  alph_RU_u[6],  alph_RU_u[7],  alph_RU_u[8],  alph_RU_u[9], 
                    alph_RU_u[10], alph_RU_u[11], alph_RU_u[12], alph_RU_u[13], alph_RU_u[14],
                    alph_RU_u[15], alph_RU_u[16], alph_RU_u[17], alph_RU_u[18], alph_RU_u[19],
                    alph_RU_u[20], alph_RU_u[21], alph_RU_u[22], alph_RU_u[23], alph_RU_u[24],
                    alph_RU_u[25], alph_RU_u[26], alph_RU_u[27], alph_RU_u[28], alph_RU_u[29],
                    alph_RU_u[30], alph_RU_u[31], alph_RU_u[32]
                    );
            }
            else if (this.panelMethod_2_l9_stata.Text == "11")
            {
                int NumCharU, NumCharL;
                for (var i = 1; i <= 26; i++)
                {
                    NumCharU = PanelMethod_2_main_func
                                (
                                    Convert.ToInt32(chisl),
                                    Convert.ToInt32(panelMethod_2_textBox_B.Text),
                                    26,
                                    i
                                ) +
                                64 +
                                i
                            ;
                    NumCharL = PanelMethod_2_main_func
                                (
                                    Convert.ToInt32(chisl),
                                    Convert.ToInt32(panelMethod_2_textBox_B.Text),
                                    26,
                                    i
                                ) +
                                96 +
                                i
                            ;
                    if (NumCharU > 90)
                    {
                        NumCharU -= 26;
                    }
                    if (NumCharL > 122)
                    {
                        NumCharL -= 26;
                    }
                    alph_EN_o.Add(Convert.ToChar(64 + i));
                    alph_EN_u.Add(Convert.ToChar(NumCharU));
                    alph_EN_l.Add(Convert.ToChar(NumCharL));


                }
                panelMethod_2_dataGridView.Rows.Clear();
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Латин",
                    alph_EN_o[0], alph_EN_o[1], alph_EN_o[2], alph_EN_o[3], alph_EN_o[4],
                    alph_EN_o[5], alph_EN_o[6], alph_EN_o[7], alph_EN_o[8], alph_EN_o[9],
                    alph_EN_o[10], alph_EN_o[11], alph_EN_o[12], alph_EN_o[13], alph_EN_o[14],
                    alph_EN_o[15], alph_EN_o[16], alph_EN_o[17], alph_EN_o[18], alph_EN_o[19],
                    alph_EN_o[20], alph_EN_o[21], alph_EN_o[22], alph_EN_o[23], alph_EN_o[24],
                    alph_EN_o[25]
                    );
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Латин",
                    alph_EN_l[0], alph_EN_l[1], alph_EN_l[2], alph_EN_l[3], alph_EN_l[4],
                    alph_EN_l[5], alph_EN_l[6], alph_EN_l[7], alph_EN_l[8], alph_EN_l[9],
                    alph_EN_l[10], alph_EN_l[11], alph_EN_l[12], alph_EN_l[13], alph_EN_l[14],
                    alph_EN_l[15], alph_EN_l[16], alph_EN_l[17], alph_EN_l[18], alph_EN_l[19],
                    alph_EN_l[20], alph_EN_l[21], alph_EN_l[22], alph_EN_l[23], alph_EN_l[24],
                    alph_EN_l[25]
                    );
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Латин",
                    alph_EN_u[0], alph_EN_u[1], alph_EN_u[2], alph_EN_u[3], alph_EN_u[4],
                    alph_EN_u[5], alph_EN_u[6], alph_EN_u[7], alph_EN_u[8], alph_EN_u[9],
                    alph_EN_u[10], alph_EN_u[11], alph_EN_u[12], alph_EN_u[13], alph_EN_u[14],
                    alph_EN_u[15], alph_EN_u[16], alph_EN_u[17], alph_EN_u[18], alph_EN_u[19],
                    alph_EN_u[20], alph_EN_u[21], alph_EN_u[22], alph_EN_u[23], alph_EN_u[24],
                    alph_EN_u[25]
                    );
                for (var i = 1; i <= 6; i++)
                {
                    alph_RU_o_u.Add(Convert.ToChar(1039 + i));
                    alph_RU_o_l.Add(Convert.ToChar(1071 + i));
                }
                alph_RU_o_u.Add(Convert.ToChar(1025));
                alph_RU_o_l.Add(Convert.ToChar(1105));

                for (var i = 7; i <= 33; i++)
                {
                    alph_RU_o_u.Add(Convert.ToChar(1039 + i));
                    alph_RU_o_l.Add(Convert.ToChar(1071 + i));
                }
                for (var i = 1; i <= 33; i++)
                {
                    alph_RU_offset.Add(PanelMethod_2_main_func(Convert.ToInt32(chisl), Convert.ToInt32(panelMethod_2_textBox_B.Text), 33, i));
                }
                for (var i = 0; i < 33; i++)
                {
                    alph_RU_u.Add(alph_RU_o_u[alph_RU_offset[i]]);
                    alph_RU_l.Add(alph_RU_o_l[alph_RU_offset[i]]);
                }
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Кириллица",
                    alph_RU_o_u[0],  alph_RU_o_u[1],  alph_RU_o_u[2],  alph_RU_o_u[3],  alph_RU_o_u[4],
                    alph_RU_o_u[5],  alph_RU_o_u[6],  alph_RU_o_u[7],  alph_RU_o_u[8],  alph_RU_o_u[9],
                    alph_RU_o_u[10], alph_RU_o_u[11], alph_RU_o_u[12], alph_RU_o_u[13], alph_RU_o_u[14],
                    alph_RU_o_u[15], alph_RU_o_u[16], alph_RU_o_u[17], alph_RU_o_u[18], alph_RU_o_u[19],
                    alph_RU_o_u[20], alph_RU_o_u[21], alph_RU_o_u[22], alph_RU_o_u[23], alph_RU_o_u[24],
                    alph_RU_o_u[25], alph_RU_o_u[26], alph_RU_o_u[27], alph_RU_o_u[28], alph_RU_o_u[29],
                    alph_RU_o_u[30], alph_RU_o_u[31], alph_RU_o_u[32]
                    );
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Кириллица",
                    alph_RU_l[0], alph_RU_l[1], alph_RU_l[2], alph_RU_l[3], alph_RU_l[4],
                    alph_RU_l[5], alph_RU_l[6], alph_RU_l[7], alph_RU_l[8], alph_RU_l[9],
                    alph_RU_l[10], alph_RU_l[11], alph_RU_l[12], alph_RU_l[13], alph_RU_l[14],
                    alph_RU_l[15], alph_RU_l[16], alph_RU_l[17], alph_RU_l[18], alph_RU_l[19],
                    alph_RU_l[20], alph_RU_l[21], alph_RU_l[22], alph_RU_l[23], alph_RU_l[24],
                    alph_RU_l[25], alph_RU_l[26], alph_RU_l[27], alph_RU_l[28], alph_RU_l[29],
                    alph_RU_l[30], alph_RU_l[31], alph_RU_l[32]
                    );
                panelMethod_2_dataGridView.Rows.Add
                    (
                    "Кириллица",
                    alph_RU_u[0], alph_RU_u[1], alph_RU_u[2], alph_RU_u[3], alph_RU_u[4],
                    alph_RU_u[5], alph_RU_u[6], alph_RU_u[7], alph_RU_u[8], alph_RU_u[9],
                    alph_RU_u[10], alph_RU_u[11], alph_RU_u[12], alph_RU_u[13], alph_RU_u[14],
                    alph_RU_u[15], alph_RU_u[16], alph_RU_u[17], alph_RU_u[18], alph_RU_u[19],
                    alph_RU_u[20], alph_RU_u[21], alph_RU_u[22], alph_RU_u[23], alph_RU_u[24],
                    alph_RU_u[25], alph_RU_u[26], alph_RU_u[27], alph_RU_u[28], alph_RU_u[29],
                    alph_RU_u[30], alph_RU_u[31], alph_RU_u[32]
                    );
            }
        }


        private int PanelMethod_2_nod(int val1, int val2)
        {
            while ((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2)
                    val1 %= val2;
                else
                    val2 %= val1;
            }
            return Math.Max(val1, val2);
        }


        private int PanelMethod_2_main_func(int a, int b, int m, int x)
        {
            return (a * x + b) % m;
        }


        private void PanelMethod_2_textBox_A_Leave(object sender, EventArgs e)
        {
            if (panelMethod_2_textBox_A.Text == "")
            {
                MessageBox.Show("Введите простые числа:\n\n\nВот список простых чисел\n  Если надо зашифровать только латинцу: 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 26;\n\n  Если надо зашифровать только кириллицу: 1, 2, 4, 5, 7, 8, 10, 13, 14, 16, 17, 19, 20, 23, 25, 26, 28, 29, 31, 32;\n\n  Если надо зашифровать смешенно(кирилица и латиница): 1, 5, 7, 17, 19, 23, 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panelMethod_2_textBox_A.Text = "1";
            }
            else if (PanelMethod_2_validatecisl(panelMethod_2_textBox_A.Text))
            {
                //List<int> possibleValEN = new List<int> { 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 25 };
                //List<int> possibleValRU = new List<int> { 1, 2, 4, 5, 7, 8, 10, 13, 14, 16, 17, 19, 20, 23, 25, 26, 28, 29, 31, 32 };
                //00 - никто;01 - латинский;10 - кириллица;11 - оба;
                Int16 chisl = Convert.ToInt16(panelMethod_2_textBox_A.Text);
                if(chisl > 32)
                {
                    MessageBox.Show("Введите простые числа:\n\n\nВот список простых чисел\n  Если надо зашифровать только латинцу: 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 26;\n\n  Если надо зашифровать только кириллицу: 1, 2, 4, 5, 7, 8, 10, 13, 14, 16, 17, 19, 20, 23, 25, 26, 28, 29, 31, 32;\n\n  Если надо зашифровать смешенно(кирилица и латиница): 1, 5, 7, 17, 19, 23, 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.panelMethod_2_textBox_A.Text = "25";
                    chisl = Convert.ToInt16(panelMethod_2_textBox_A.Text);
                    int nodEN = PanelMethod_2_nod(chisl, 26), nodRU = PanelMethod_2_nod(chisl, 33);
                    this.panelMethod_2_l5.Text = "НОД (" + chisl + ", 33) = " + Convert.ToString(PanelMethod_2_nod(chisl, 33));
                    if (chisl <26)
                        this.panelMethod_2_l6.Text = "НОД (" + chisl + ", 26) = " + Convert.ToString(PanelMethod_2_nod(chisl, 26));
                    else
                        this.panelMethod_2_l6.Text = "НОД (" + chisl + ", 26) = ???";
                    if (nodEN == 1 && nodRU != 1)
                    { this.panelMethod_2_l9_stata.Text = "01"; }
                    else if (nodEN == 1 && nodRU == 1 && chisl < 26)
                    { this.panelMethod_2_l9_stata.Text = "11"; }
                    else if (nodEN != 1 && nodRU == 1 || nodEN == 1 && chisl >= 26)
                    { this.panelMethod_2_l9_stata.Text = "10"; }
                    else if (nodEN != 1 && nodRU != 1)
                    { this.panelMethod_2_l9_stata.Text = "00"; }
                    MessageBox.Show(this.panelMethod_2_l9_stata.Text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else 
                {
                    int nodEN = PanelMethod_2_nod(chisl, 26), nodRU = PanelMethod_2_nod(chisl, 33);
                    this.panelMethod_2_l5.Text = "НОД (" + chisl + ", 33) = " + Convert.ToString(PanelMethod_2_nod(chisl, 33));
                    if (chisl < 26)
                        this.panelMethod_2_l6.Text = "НОД (" + chisl + ", 26) = " + Convert.ToString(PanelMethod_2_nod(chisl, 26));
                    else
                        this.panelMethod_2_l6.Text = "НОД (" + chisl + ", 26) = ???"; 
                    if (nodEN == 1 && nodRU != 1)
                    { this.panelMethod_2_l9_stata.Text = "01"; }
                    else if (nodEN == 1 && nodRU == 1 && chisl < 26)
                        { this.panelMethod_2_l9_stata.Text = "11"; }
                        else if (nodEN != 1 && nodRU == 1 || nodEN == 1 && chisl >= 26)
                            { this.panelMethod_2_l9_stata.Text = "10"; }
                            else if (nodEN != 1 && nodRU != 1)
                                { this.panelMethod_2_l9_stata.Text = "00"; }
                    if(panelMethod_2_textBox_B.Text == "1")
                        PanelMethod_2_generate_alphavite_afin();
                }
            }
            else
            {
                MessageBox.Show("Введите простые числа:\n\n\nВот список простых чисел\n  Если надо зашифровать только латинцу: 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 26;\n\n  Если надо зашифровать только кириллицу: 1, 2, 4, 5, 7, 8, 10, 13, 14, 16, 17, 19, 20, 23, 25, 26, 28, 29, 31, 32;\n\n  Если надо зашифровать смешенно(кирилица и латиница): 1, 5, 7, 17, 19, 23, 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panelMethod_2_textBox_A.Text = "1";
            }
        }
        
        
        private bool PanelMethod_2_validatecisl(string Text)
        {
            if ( Text[0] >= '0'  &&  Text[0] <= '9' )
            {
                if ( Text.Length == 1 )
                    return true;
                else if ( Text[1] >= '0'  &&  Text[1] <= '9' )
                    if (Text.Length == 2)
                        return true;
                    else if (Text[2] >= '0' && Text[2] <= '9')
                            if (Text.Length == 3)
                                return true;
                            else if (Text[3] >= '0' && Text[3] <= '9')
                                if (Text.Length == 4)
                                    return true;

            }
            return false;
        }
        
        
        private void PanelMethod_2_textBox_B_Leave(object sender, EventArgs e)
        {
            if ( panelMethod_2_textBox_B.Text == "" )
            {
                MessageBox.Show("Введите числа от 0 до 9999", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PanelMethod_2_validatecisl(panelMethod_2_textBox_B.Text))
            {
                PanelMethod_2_generate_alphavite_afin();
            }
            else
            {
                MessageBox.Show("Введите числа от 0 до 9999", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panelMethod_2_textBox_B.Text = "1";
            }

        }
        
        
        private void PanelMethod_2_pictureBoxHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите в поле A простое число:\n\n\nВот список простых чисел\n  Если надо зашифровать только латинцу: 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 26;\n\n  Если надо зашифровать только кириллицу: 1, 2, 4, 5, 7, 8, 10, 13, 14, 16, 17, 19, 20, 23, 25, 26, 28, 29, 31, 32;\n\n  Если надо зашифровать смешенно(кирилица и латиница): 1, 5, 7, 17, 19, 23, 25", "Справочная информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void PanelMethod_2_btn_encrypt_Click(object sender, EventArgs e)
        {
            if(panelMethod_2_l9_stata.Text == "00")
            {
                MessageBox.Show("Введите в поле А простые числа:\n\n\nВот список простых чисел\n  Если надо зашифровать только латинцу: 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 26;\n\n  Если надо зашифровать только кириллицу: 1, 2, 4, 5, 7, 8, 10, 13, 14, 16, 17, 19, 20, 23, 25, 26, 28, 29, 31, 32;\n\n  Если надо зашифровать смешенно(кирилица и латиница): 1, 5, 7, 17, 19, 23, 25", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panelMethod_2_textBox_A.Text = "1";
            }
            else 
            {
                // Generate lists offset and alfavite

                List<char> alph_EN_u = new List<char> { };
                List<char> alph_EN_l = new List<char> { };
                List<char> alph_EN_o = new List<char> { };
                List<char> alph_RU_u = new List<char> { };
                List<char> alph_RU_l = new List<char> { };
                List<char> alph_RU_o_u = new List<char> { };
                List<char> alph_RU_o_l = new List<char> { };
                List<int> alph_RU_offset = new List<int> { };
                Int16 chisl = Convert.ToInt16(panelMethod_2_textBox_A.Text);


                int NumCharU, NumCharL;
                for (var i = 1; i <= 26; i++)
                {
                    NumCharU = PanelMethod_2_main_func
                                (
                                    Convert.ToInt32(chisl),
                                    Convert.ToInt32(panelMethod_2_textBox_B.Text),
                                    26,
                                    i
                                ) +
                                64 +
                                i
                            ;
                    NumCharL = PanelMethod_2_main_func
                                (
                                    Convert.ToInt32(chisl),
                                    Convert.ToInt32(panelMethod_2_textBox_B.Text),
                                    26,
                                    i
                                ) +
                                96 +
                                i
                            ;
                    if (NumCharU > 90)
                    {
                        NumCharU -= 26;
                    }
                    if (NumCharL > 122)
                    {
                        NumCharL -= 26;
                    }
                    alph_EN_o.Add(Convert.ToChar(64 + i));
                    alph_EN_u.Add(Convert.ToChar(NumCharU));
                    alph_EN_l.Add(Convert.ToChar(NumCharL));


                }
                for (var i = 1; i <= 6; i++)
                {
                    alph_RU_o_u.Add(Convert.ToChar(1039 + i));
                    alph_RU_o_l.Add(Convert.ToChar(1071 + i));
                }
                alph_RU_o_u.Add(Convert.ToChar(1025));
                alph_RU_o_l.Add(Convert.ToChar(1105));
                // Кириллица
                for (var i = 7; i <= 33; i++)
                {
                    alph_RU_o_u.Add(Convert.ToChar(1039 + i));
                    alph_RU_o_l.Add(Convert.ToChar(1071 + i));
                }
                for (var i = 1; i <= 33; i++)
                {
                    alph_RU_offset.Add(PanelMethod_2_main_func(Convert.ToInt32(chisl), Convert.ToInt32(panelMethod_2_textBox_B.Text), 33, i));
                }
                for (var i = 0; i < 33; i++)
                {
                    alph_RU_u.Add(alph_RU_o_u[alph_RU_offset[i]]);
                    alph_RU_l.Add(alph_RU_o_l[alph_RU_offset[i]]);
                }
                
                // Encrypte
                string outText = "";
                if (panelMethod_2_l9_stata.Text == "01") //01 - латинский
                {
                    foreach (var charText in panelMethod_2_textBox_in.Text)
                    {
                        if (charText >= 'A' && charText <= 'Z')
                        {
                            outText += alph_EN_u[charText - 65];
                        }
                        else if (charText >= 'a' && charText <= 'z')
                        {
                            outText += alph_EN_l[charText - 97];
                        }
                        else
                            outText += charText;
                    }
                }
                else 
                {
                    if (panelMethod_2_l9_stata.Text == "10")// 10 - кириллица
                    {
                        foreach (var charText in panelMethod_2_textBox_in.Text)
                        {
                            if (charText >= 'А'  &&  charText <= 'Я'  ||  charText == 'Ё')
                            {
                                if (charText == 'Ё')
                                    outText += alph_RU_u[6];
                                else
                                {
                                    if (charText >= 'Ж')
                                        outText += alph_RU_u[charText - 1039];
                                    else
                                        outText += alph_RU_u[charText - 1040];
                                }
                            }
                            else if (charText >= 'а' && charText <= 'я' || charText == 'ё')
                            {
                                if (charText == 'ё')
                                    outText += alph_RU_l[6];
                                else
                                {
                                    if (charText >= 'ж')
                                        outText += alph_RU_l[charText - 1071];
                                    else
                                        outText += alph_RU_l[charText - 1072];
                                }    
                                    
                            }
                            else
                                outText += charText;
                        }
                    }
                    else// 11 - Все
                    {
                        foreach (var charText in panelMethod_2_textBox_in.Text)
                        {
                            if (charText >= 'A' && charText <= 'Z')
                            {
                                outText += alph_EN_u[charText - 65];
                            }
                            else if (charText >= 'a' && charText <= 'z')
                            {
                                outText += alph_EN_l[charText - 97];
                            }
                            else if (charText >= 'А' && charText <= 'Я' || charText == 'Ё')
                            {
                                if (charText == 'Ё')
                                    outText += alph_RU_u[6];
                                else
                                {
                                    if (charText >= 'Ж')
                                        outText += alph_RU_u[charText - 1039];
                                    else
                                        outText += alph_RU_u[charText - 1040];
                                }
                            }
                            else if (charText >= 'а' && charText <= 'я' || charText == 'ё')
                            {
                                if (charText == 'ё')
                                    outText += alph_RU_l[6];
                                else
                                {
                                    if (charText >= 'ж')
                                        outText += alph_RU_l[charText - 1071];
                                    else
                                        outText += alph_RU_l[charText - 1072];
                                }

                            }
                            else
                                outText += charText;
                        }
                    }
                }
                
                this.panelMethod_2_textBox_out.Text = outText;
            }

        }


    }
}