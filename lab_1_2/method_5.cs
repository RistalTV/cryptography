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
        private void panelMethod_5_p_keys_key_1_Leave(object sender, EventArgs e)
        {
            if(panelMethod_5_p_keys_key_1.Text == "")
            {
                this.panelMethod_5_p_keys_key_1.Text = "Введите секретный ключ";
                this.panelMethod_5_p_keys_key_1.ForeColor = System.Drawing.Color.Silver;
            }
        }


        private void panelMethod_5_p_keys_key_2_Leave(object sender, EventArgs e)
        {
            if (panelMethod_5_p_keys_key_2.Text == "")
            {
                this.panelMethod_5_p_keys_key_2.Text = "Введите секретный ключ";
                this.panelMethod_5_p_keys_key_2.ForeColor = System.Drawing.Color.Silver;
            }
        }


        private void panelMethod_5_p_encrypt_in_Leave(object sender, EventArgs e)
        {
            if (panelMethod_5_p_encrypt_in.Text == "")
            {
                this.panelMethod_5_p_encrypt_in.Text = "Введите сообщение, которое надо зашифровать";
                this.panelMethod_5_p_encrypt_in.ForeColor = System.Drawing.Color.Silver;
            }
        }


        private void panelMethod_5_p_keys_key_1_Enter(object sender, EventArgs e)
        {
            if (panelMethod_5_p_keys_key_1.Text == "Введите секретный ключ")
            {
                this.panelMethod_5_p_keys_key_1.Text = "";
                this.panelMethod_5_p_keys_key_1.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void panelMethod_5_p_keys_key_2_Enter(object sender, EventArgs e)
        {
            if (panelMethod_5_p_keys_key_2.Text == "Введите секретный ключ")
            {
                this.panelMethod_5_p_keys_key_2.Text = "";
                this.panelMethod_5_p_keys_key_2.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void panelMethod_5_p_encrypt_in_Enter(object sender, EventArgs e)
        {
            if (panelMethod_5_p_encrypt_in.Text == "Введите сообщение, которое надо зашифровать")
            {
                this.panelMethod_5_p_encrypt_in.Text = "";
                this.panelMethod_5_p_encrypt_in.ForeColor = System.Drawing.Color.Black;
            }
        }

        
        private void panelMethod_5_p_encrypt_btn_Click(object sender, EventArgs e)
        {

        }


        private void panelMethod_5_btn_back_slide_Click(object sender, EventArgs e)
        {
            int Num_Slide = Convert.ToInt32(panelMethod_5_addLabel.Text.ToLower());
            Num_Slide--;
            if (Num_Slide == 0) { Num_Slide = 1; }
            this.panelMethod_5_addLabel.Text = Convert.ToString(Num_Slide);
            switch (Num_Slide)
            {
                case 1: panelMethod_5_generate_table(1); break;
                case 2: panelMethod_5_generate_table(2); break;
                case 3: panelMethod_5_generate_table(3); break;
            }
            panelMethod_5_select_slide(Num_Slide);
        }


        private void panelMethod_5_slide_label_1_MouseEnter(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_1.BackColor = System.Drawing.Color.Gray;
        }


        private void panelMethod_5_slide_label_2_MouseEnter(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_2.BackColor = System.Drawing.Color.Gray;
        }


        private void panelMethod_5_slide_label_3_MouseEnter(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_3.BackColor = System.Drawing.Color.Gray;
        }


        private void panelMethod_5_slide_label_1_MouseLeave(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_1.BackColor = System.Drawing.Color.DimGray;
        }


        private void panelMethod_5_slide_label_2_MouseLeave(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_2.BackColor = System.Drawing.Color.DimGray;
        }


        private void panelMethod_5_slide_label_3_MouseLeave(object sender, EventArgs e)
        {
            panelMethod_5_slide_label_3.BackColor = System.Drawing.Color.DimGray;
        }


        private void panelMethod_5_slide_label_1_Click(object sender, EventArgs e)
        {
            panelMethod_5_generate_table(1);
            panelMethod_5_select_slide(1);
        }


        private void panelMethod_5_slide_label_2_Click(object sender, EventArgs e)
        {
            panelMethod_5_generate_table(2);
            panelMethod_5_select_slide(2);
        }


        private void panelMethod_5_slide_label_3_Click(object sender, EventArgs e)
        {
            panelMethod_5_generate_table(3);
            panelMethod_5_select_slide(3);
        }


        private void panelMethod_5_btn_next_slide_Click(object sender, EventArgs e)
        {
            int Num_Slide = Convert.ToInt32(panelMethod_5_addLabel.Text.ToLower());
            Num_Slide++;
            if (Num_Slide == 4) { Num_Slide = 3; }
            this.panelMethod_5_addLabel.Text = Convert.ToString(Num_Slide);
            switch(Num_Slide)
            {
                case 1: panelMethod_5_generate_table(1); break;
                case 2: panelMethod_5_generate_table(2); break;
                case 3: panelMethod_5_generate_table(3); break;
            }
            panelMethod_5_select_slide(Num_Slide);
        }

        private void panelMethod_5_generate_table(int v)
        {
        
        }

        private void panelMethod_5_select_slide(int num_Slide)
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
    }

}