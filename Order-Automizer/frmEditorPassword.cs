using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Order_Automizer
{
    public partial class frmEditorPassword : Form
    {
        private static String URL = "https://api.moroz.cc/orderautomator/";
        public frmEditorPassword()
        {
            InitializeComponent();
        }

        public string CalculateMD5Hash(string input)
        {
            try
            {
                MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string hash1, hash2;
                hash1 = CalculateMD5Hash(textBox1.Text);

                this.Text = hash1;

                WebClient client = new WebClient();
                hash2 = client.DownloadString(URL + "editor_pass_hash");
                hash2 = hash2.Trim();



                if (hash1.Trim() == hash2.Trim())
                {
                    frmEditor frm = new frmEditor();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пароль введен неправильно!", "Order Automizer | Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Сервер авторизации недоступен, обратитесь к системному администратору.", "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
