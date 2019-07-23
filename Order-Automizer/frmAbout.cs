using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Automizer
{
    public partial class frmAbout : Form
    {
        private static String URL = "https://moroz.cc";

        public frmAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(URL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Version chk = new Version();
                lblVersion.Text = chk.GetVersion();
                lblCopyright.Text += DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
