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
            change_Dock(1);
            change_Enabled(1);
            change_Visible(1);
        }

        private void RadButMethod_2_Click(object sender, EventArgs e)
        {
            change_Dock(2);
            change_Enabled(2);
            change_Visible(2);
        }

        private void RadButMethod_3_Click(object sender, EventArgs e)
        {
            change_Dock(3);
            change_Enabled(3);
            change_Visible(3);
        }

        private void RadButMethod_4_Click(object sender, EventArgs e)
        {
            change_Dock(4);
            change_Enabled(4);
            change_Visible(4);
        }

        private void RadButMethod_5_Click(object sender, EventArgs e)
        {
            change_Dock(5);
            change_Enabled(5);
            change_Visible(5);
        }

        private void change_Dock(Int16 num)
        {
            this.panelMethod_1.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_2.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_3.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_4.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMethod_5.Dock = System.Windows.Forms.DockStyle.None;
            switch (num)
            {
                case 1:
                    {
                        this.panelMethod_1.Dock = System.Windows.Forms.DockStyle.Fill;
                        break;
                    }
                case 2:
                    {
                        this.panelMethod_2.Dock = System.Windows.Forms.DockStyle.Fill;
                        break;
                    }
                case 3:
                    {
                        this.panelMethod_3.Dock = System.Windows.Forms.DockStyle.Fill;
                        break;
                    }
                case 4:
                    {
                        this.panelMethod_4.Dock = System.Windows.Forms.DockStyle.Fill;
                        break;
                    }
                case 5:
                    {
                        this.panelMethod_5.Dock = System.Windows.Forms.DockStyle.Fill;
                        break;
                    }

            }

        }
        private void change_Visible(Int16 num)
        {
            this.panelMethod_1.Visible = false;
            this.panelMethod_2.Visible = false;
            this.panelMethod_3.Visible = false;
            this.panelMethod_4.Visible = false;
            this.panelMethod_5.Visible = false;
            switch (num)
            {
                case 1:
                    {
                        this.panelMethod_1.Visible = true;
                        break;
                    }
                case 2:
                    {
                        this.panelMethod_2.Visible = true;
                        break;
                    }
                case 3:
                    {
                        this.panelMethod_3.Visible = true;
                        break;
                    }
                case 4:
                    {
                        this.panelMethod_4.Visible = true;
                        break;
                    }
                case 5:
                    {
                        this.panelMethod_5.Visible = true;
                        break;
                    }

            }

        }
        private void change_Enabled(Int16 num)
        {
            this.panelMethod_1.Enabled = false;
            this.panelMethod_2.Enabled = false;
            this.panelMethod_3.Enabled = false;
            this.panelMethod_4.Enabled = false;
            this.panelMethod_5.Enabled = false;
            switch(num)
            {
                case 1:
                    {
                        this.panelMethod_1.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        this.panelMethod_2.Enabled = true;
                        break;
                    }
                case 3:
                    {
                        this.panelMethod_3.Enabled = true;
                        break;
                    }
                case 4:
                    {
                        this.panelMethod_4.Enabled = true;
                        break;
                    }
                case 5:
                    {
                        this.panelMethod_5.Enabled = true;
                        break;
                    }

            }
        }


    }
}
