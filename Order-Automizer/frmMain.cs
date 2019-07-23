using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Order_Automizer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private int stat_zakaz = 0;
        private int stat_naim = 0;
        private int stat_count = 0;

        private void reload_database()
        {
            try
            {
                cmbManufacturers.Items.Clear();
                foreach (FileSystemInfo file in new DirectoryInfo(System.Windows.Forms.Application.StartupPath + "\\data").GetFiles())
                    this.cmbManufacturers.Items.Add((object)file.Name.ToString().Replace(".txt", ""));
                this.cmbManufacturers.SelectedIndex = 0;
                this.dgvDocumentTable.RowHeadersVisible = false;
                tsslblManufacturer.Text = "Производитель: " + cmbManufacturers.SelectedItem.ToString();
                tsslblPosition.Text = "| Наименование: не выбрано";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void init_stats()
        {
            try
            {
                stat_zakaz = 0;
                stat_naim = 0;
                using (StreamReader streamReader = new StreamReader(System.Windows.Forms.Application.StartupPath + "\\stat.dat"))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                stat_zakaz = Convert.ToInt32(streamReader.ReadLine());
                                break;
                            case 1:
                                stat_naim = Convert.ToInt32(streamReader.ReadLine());
                                break;
                            case 2:
                                stat_count = Convert.ToInt32(streamReader.ReadLine());
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stat_save()
        {
            try
            {
                TextWriter writer = new StreamWriter(Application.StartupPath + "\\stat.dat");
                for (int i = 0; i < 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            writer.WriteLine(stat_zakaz.ToString());
                            break;
                        case 1:
                            writer.WriteLine(stat_naim.ToString());
                            break;
                        case 2:
                            writer.WriteLine(stat_count.ToString());
                            break;
                    }
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            numCurrentPositionCount.Maximum = Decimal.MaxValue;
            exportToolStripMenuItem.Image = btnExportToXls.Image;

            reload_database();
            init_stats();
            init_checker();

            Version chk = new Version();
            chk.CheckForUpdatesOnLaunch();
        }

        void init_checker()
        {
            try
            {
                WebClient client = new WebClient();
                string access = client.DownloadString(Constants.getApiUrl() + "access");
                if (access.Trim() == "lock")
                {
                    frmRemoteMessage frm = new frmRemoteMessage();
                    frm.ShowDialog();
                }
            }
            catch
            {
                Random r = new Random();
                timer1.Interval = r.Next(14666, 60001);
                timer1.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.lstCurrentPositions.Items.Clear();
                using (StreamReader streamReader = new StreamReader(System.Windows.Forms.Application.StartupPath + "\\data\\" + this.cmbManufacturers.SelectedItem.ToString() + ".txt"))
                {
                    string str;
                    while ((str = streamReader.ReadLine()) != null)
                        this.lstCurrentPositions.Items.Add((object)str);
                }
                tsslblManufacturer.Text = "Производитель: " + cmbManufacturers.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCurrentPosition.Text = lstCurrentPositions.SelectedItem.ToString();
                if (lstCurrentPositions.SelectedItem != null)
                    tsslblPosition.Text = "| Наименование: " + lstCurrentPositions.SelectedItem.ToString();
                else
                    tsslblPosition.Text = "| Наименование: не выбрано";
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
                if (this.lstCurrentPositions.SelectedItem != null)
                {
                    this.dgvDocumentTable.Rows.Add((object)this.cmbManufacturers.SelectedItem.ToString(), (object)this.lstCurrentPositions.SelectedItem.ToString(), (object)this.numCurrentPositionCount.Value.ToString());
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать позицию товара для добавления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
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
                if (MessageBox.Show("Вы уверены что хотите очистить все позиции из накладной?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.dgvDocumentTable.Rows.Clear();
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
                if (dgvDocumentTable.SelectedRows != null)
                {
                    foreach (DataGridViewRow selectedRow in (BaseCollection)this.dgvDocumentTable.SelectedRows)
                    {
                        if (!selectedRow.IsNewRow)
                        {
                            dgvDocumentTable.Rows.RemoveAt(selectedRow.Index);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать позицию товара для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                dgvDocumentTable.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyAlltoClipboard()
        {
            try
            {
                dgvDocumentTable.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                dgvDocumentTable.MultiSelect = true;
                this.dgvDocumentTable.SelectAll();
                DataObject clipboardContent = this.dgvDocumentTable.GetClipboardContent();
                if (clipboardContent == null)
                    return;
                Clipboard.SetDataObject((object)clipboardContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            stat_zakaz++;
            stat_naim += dgvDocumentTable.Rows.Count - 1;
            foreach (DataGridViewRow row in dgvDocumentTable.Rows)
            {
                try
                {
                    stat_count += Convert.ToInt32(row.Cells[2].Value.ToString());
                }
                catch
                {
                    continue;
                }
            }
            stat_save();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tsslblCount.Text = "| Кол-во: " + numCurrentPositionCount.Value.ToString() ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string access = client.DownloadString(Constants.getApiUrl() + "editor_pass_enable");
                if (access.Trim() == "0")
                {
                    frmEditor frm = new frmEditor();
                    frm.ShowDialog();
                    reload_database();
                }
                else
                {
                    frmEditorPassword frm = new frmEditorPassword();
                    frm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось подтвердить тип авторизации, повторите попытку.", "Order Automizer | Проверка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload_database();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Version chk = new Version();
                chk.CheckForUpdates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://moroz.cc");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtCurrentPosition.SelectAll();
            try
            {
                Clipboard.SetText(txtCurrentPosition.Text);
            }
            catch (System.ArgumentNullException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStats frm = new frmStats(stat_zakaz, stat_naim, stat_count);
            frm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            stat_save();
        }
    }
}
