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
    }
}
