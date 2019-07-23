using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Order_Automizer
{
    public partial class frmRemoteMessage : Form
    {
        public frmRemoteMessage()
        {
            InitializeComponent();
        }

        private void frmRemoteMessage_Load(object sender, EventArgs e)
        {
            string title = "Программа заблокирована";
            string messg = "Ваша копия программы заблокирована. Свяжитесь с разработчиком для исправления ошибки лицензирования.";
            try
            {
                WebClient client = new WebClient();
                title = client.DownloadString(Constants.getApiUrl() + "msg_title");
                messg = client.DownloadString(Constants.getApiUrl() + "msg_messg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Text = title;
                lblRemoteMessage.Text = messg;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
