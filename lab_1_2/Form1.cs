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


        private void ButtonAcceptMainLeft_Click(object sender, EventArgs e)
        {
            if (this.panelMainLeft_rb_Method_1.Checked == true)
            {
                RadButMethod_1_Click(sender, e);
            }
            else if (this.panelMainLeft_rb_Method_2.Checked == true)
            {
                RadButMethod_2_Click(sender, e);
            }
            else if (this.panelMainLeft_rb_Method_3.Checked == true)
            {
                RadButMethod_3_Click(sender, e);
            }
            else if(this.panelMainLeft_rb_Method_4.Checked == true)
            {
                RadButMethod_4_Click(sender, e);
            }
            else if (this.panelMainLeft_rb_Method_5.Checked == true)
            {
                RadButMethod_5_Click(sender, e);
            }
            
        }


        private void RadButMethod_1_Click(object sender, EventArgs e)
        {
            Change_Dock(1);
            Change_Enabled(1);
            Change_Visible(1);
        }


        private void RadButMethod_2_Click(object sender, EventArgs e)
        {

            Change_Dock(2);
            Change_Enabled(2);
            Change_Visible(2);

        }


        private void RadButMethod_3_Click(object sender, EventArgs e)
        {
            Change_Dock(3);
            Change_Enabled(3);
            Change_Visible(3);
        }


        private void RadButMethod_4_Click(object sender, EventArgs e)
        {
            Change_Dock(4);
            Change_Enabled(4);
            Change_Visible(4);
        }


        private void RadButMethod_5_Click(object sender, EventArgs e)
        {
            Change_Dock(5);
            Change_Enabled(5);
            Change_Visible(5);
        }


        private void Change_Dock(Int16 num)
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
        

        private void Change_Visible(Int16 num)
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
        
        
        private void Change_Enabled(Int16 num)
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