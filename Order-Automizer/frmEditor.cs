using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Order_Automizer
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        bool isChanged = false;
        string currentManufactEdit = "";

        private string GetMD5(string filename)
        {
            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filename))
                    {
                        return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", String.Empty).ToLower(); ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ReloadManufacturers()
        {
            try
            {
                listBox1.Items.Clear();
                foreach (FileSystemInfo file in new DirectoryInfo(System.Windows.Forms.Application.StartupPath + "\\data").GetFiles())
                    listBox1.Items.Add((object)file.Name.ToString().Replace(".txt", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ReloadManufacturers();

            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (isChanged == false)
                {
                    button3.Enabled = true;
                    grpRED.Enabled = false;
                    string Path = Application.StartupPath + "\\data\\" + listBox1.SelectedItem.ToString() + ".txt";
                    FileInfo f = new FileInfo(Path);
                    lblFileSize.Text = f.Length.ToString() + " Байт";
                    lblDateCreated.Text = File.GetCreationTime(Path).ToString();
                    lblDateChanged.Text = File.GetLastWriteTime(Path).ToString();
                    lblHash.Text = GetMD5(Path);
                    button4.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button8.Enabled = true;
                    toolLBL.Text = "Статус: Готово";
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Вы внесли изменения в базу данных производителя "
                        + currentManufactEdit
                        + ", но не сохранили измения."
                        + System.Environment.NewLine + System.Environment.NewLine
                        + "Вы хотите сохранить изменения?",
                        "Order Automizer | Удаление файла",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Save();
                        listBox2.Items.Clear();
                    }
                    button4.Enabled = false;
                    button3.Enabled = true;
                    isChanged = false;
                }
                listBox2.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                grpRED.Enabled = true;
                currentManufactEdit = listBox1.SelectedItem.ToString();
                button3.Enabled = false;
                using (StreamReader sr = new StreamReader(File.Open(Application.StartupPath + "\\data\\" + listBox1.SelectedItem.ToString() + ".txt", FileMode.Open)))
                {
                    while (!sr.EndOfStream)
                        listBox2.Items.Add(sr.ReadLine());
                }
                button4.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button8.Enabled = false;
                toolLBL.Text = "Статус: Редактируется база данных производителя \"" + listBox1.SelectedItem.ToString() + "\"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.Items.Count > 0)
                    textBox1.Text = listBox2.SelectedItem.ToString();
            }
            catch (System.NullReferenceException)
            {
                textBox1.Text = "[ Данные выбранной позиции были изменены ]";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                name = Interaction.InputBox("Введите название поставщика", "Order Automizer | Ввод данных");
                if (name != "")
                {
                    FileStream fs = File.Create(Application.StartupPath + "\\data\\" + name + ".txt");
                    fs.Close();
                    ReloadManufacturers();
                    toolLBL.Text = "Статус: Добавлен новый производитель \"" + name + "\"";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = listBox1.SelectedItem.ToString();
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить производителя " + name + " и все его наимнования?", "Order Automizer | Удаление файла", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(Application.StartupPath + "\\data\\" + name + ".txt");
                    ReloadManufacturers();
                    toolLBL.Text = "Статус: Удален производитель \"" + name + "\"";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string new_pos = "";
                new_pos = Interaction.InputBox("Задайте другое имя наименованию товара", "Order Automizer | Редактирование", listBox2.SelectedItem.ToString());

                if (new_pos != "")
                {
                    listBox2.Items[listBox2.SelectedIndex] = new_pos;
                    isChanged = true;
                }

                toolLBL.Text = "Статус: Вы внесли изменения в базу данных производителя \"" + listBox1.SelectedItem.ToString() + "\"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string new_pos = "";
                new_pos = Interaction.InputBox("Введите новоее наименование товара", "Order Automizer | Ввод данных");

                if (new_pos != "")
                {
                    listBox2.Items.Add(new_pos);
                    isChanged = true;
                }

                toolLBL.Text = "Статус: Вы внесли изменения в базу данных производителя \"" + listBox1.SelectedItem.ToString() + "\"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить наименование?" + System.Environment.NewLine + System.Environment.NewLine + listBox2.SelectedItem.ToString(), "Order Automizer | Удаление наименования", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                    isChanged = true;
                }

                toolLBL.Text = "Статус: Вы внесли изменения в базу данных производителя \"" + listBox1.SelectedItem.ToString() + "\"";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save()
        {
            try
            {
                TextWriter writer = new StreamWriter(Application.StartupPath + "\\data\\" + currentManufactEdit + ".txt");
                foreach (var item in listBox2.Items)
                    writer.WriteLine(item.ToString());
                writer.Close();
                isChanged = false;
                MessageBox.Show("База данных производителя \"" + currentManufactEdit + "\" сохранена!", "Order Automizer | Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolLBL.Text = "Статус: База данных производителя \"" + currentManufactEdit + "\" сохранена.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           // listBox2.Sorted()
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name;
                name = Interaction.InputBox("Введите новое название поставщика", "Order Automizer | Переименование", listBox1.SelectedItem.ToString());
                if (name != "")
                {
                    toolLBL.Text = "Статус: Имя производителя изменено с \"" + listBox1.SelectedItem.ToString() + "\" на \"" + name + "\"";
                    File.Move(Application.StartupPath + "\\data\\" + listBox1.SelectedItem.ToString() + ".txt", Application.StartupPath + "\\data\\" + name + ".txt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ReloadManufacturers();
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            button7_Click(sender, e);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }


    }
}
