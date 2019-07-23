using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Order_Automizer
{
    class Version
    {
        private static String VERSION = "1.15";
        //private static String URL = "https://api.moroz.cc/orderautomator/";

        public string GetVersion() { return VERSION; }

        public void CheckForUpdates()
        {
            try
            {
                WebClient client = new WebClient();
                string actual = client.DownloadString(Constants.getApiUrl() + "version");
                actual = actual.Replace(".", String.Empty);

                if (Convert.ToInt32(actual) > Convert.ToInt32(VERSION.Replace(".", String.Empty)))
                {
                    DialogResult dialogResult = MessageBox.Show("Доступна новая версия программы, вы хотите скачать новую версию?", "SMS-UK | Доступно обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(client.DownloadString(Constants.getApiUrl() + "latest").Trim());
                    }
                }
                else
                {
                    MessageBox.Show("У вас установлна последняя версия программы", "Проверка обновлений", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось соединиться с сервером. Повторите попытку позже.", "Проверка обновлений", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void CheckForUpdatesOnLaunch()
        {
            try
            {
                WebClient client = new WebClient();
                string actual = client.DownloadString(Constants.getApiUrl() + "version");
                actual = actual.Replace(".", String.Empty);
                if (Convert.ToInt32(actual) > Convert.ToInt32(VERSION.Replace(".", String.Empty)))
                {
                    DialogResult dialogResult = MessageBox.Show("Доступна новая версия программы, вы хотите скачать новую версию?", "Order Automizer | Доступно обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(client.DownloadString(Constants.getApiUrl() + "latest").Trim());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось соединиться с сервером. Повторите попытку позже.", "Проверка обновлений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
