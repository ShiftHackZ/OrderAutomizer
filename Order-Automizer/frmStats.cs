using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Order_Automizer
{
    public partial class frmStats : Form
    {
        private int manuf_general_m = 0;
        private int manuf_general_p = 0;
        float manuf_general_s = 0;

        private int stat_order = 0;
        private int stat_positions = 0;
        private int stat_count = 0;

        public frmStats(int s_z, int s_n, int s_c)
        {
            stat_order = s_z;
            stat_positions = s_n;
            stat_count = s_c;
            InitializeComponent();
        }

        private void frmStats_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (FileSystemInfo file in new DirectoryInfo(System.Windows.Forms.Application.StartupPath + "\\data").GetFiles())
                {
                    manuf_general_m++;
                    using (StreamReader streamReader = new StreamReader(file.FullName))
                    {
                        while (streamReader.ReadLine() != null)
                            manuf_general_p++;
                    }
                }

                if (manuf_general_m != 0)
                    manuf_general_s = manuf_general_p / manuf_general_m;

                lblManufGeneral.Text = manuf_general_m.ToString();
                lblManufGeneralPositions.Text = manuf_general_p.ToString();
                lblGeneralPositionsPerManufacturer.Text = manuf_general_s.ToString();
            }
            catch
            {
                MessageBox.Show("Не удалось считать базу данных, проверьте наличие папки data в папке с программой!", "Order Automizer | Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblOrder.Text = stat_order.ToString();
            lblPositions.Text = stat_positions.ToString();
            lblCount.Text = stat_count.ToString();
            if (stat_order != 0)
            {
                lblPositionsPerOrders.Text = Convert.ToString(stat_positions / stat_order);
                lblCountPerOrder.Text = Convert.ToString(stat_count / stat_order);
            }
        }

    }
}
