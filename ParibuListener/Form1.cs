using ParibuListener.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Linq;
using System.IO;

namespace ParibuListener
{
    public partial class Form1 : Form
    {
        List<CoinModel> coins;
        List<AlertModel> alerts;
        public Form1()
        {
            InitializeComponent();
            coins = new List<CoinModel>();
            alerts = new List<AlertModel>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDataFromParibu();
            ReadDataFromJsonFile();
        }

        void ReadDataFromJsonFile()
        {
            try
            {
                if (!File.Exists("Alerts.txt"))
                    File.Create("Alerts.txt");
                StreamReader sr = new StreamReader("Alerts.txt");
                var alertString = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                if (!String.IsNullOrEmpty(alertString))
                    alerts = JsonConvert.DeserializeObject<List<AlertModel>>(alertString);

                FillAlerts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void GetDataFromParibu()
        {
            try
            {
                WebClient wc = new WebClient();
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var flatData = wc.DownloadString("https://www.paribu.com/ticker");
                var coinList = JsonConvert.DeserializeObject<JObject>(flatData);

                coins.Clear();
                foreach (var coin in coinList)
                {
                    txtCoin.Items.Add(coin.Key);
                    var newCoin = JsonConvert.DeserializeObject<CoinModel>(coin.Value.ToString());
                    newCoin.Name = coin.Key;
                    coins.Add(newCoin);
                }

                FillCoins();
                CheckAlert();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillCoins()
        {
            lstCoins.Items.Clear();
            foreach (var coin in coins)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = coin.Name;
                lvi.SubItems.Add(coin.lowestAsk.ToString());
                lvi.SubItems.Add(coin.high24hr.ToString());
                lvi.SubItems.Add(coin.percentChange.ToString());
                if (coin.percentChange < 0)
                {
                    lvi.BackColor = Color.DarkRed;
                    lvi.ForeColor = Color.White;
                }
                else
                    lvi.BackColor = Color.ForestGreen;

                lstCoins.Items.Add(lvi);
            }
        }

        private void btnAddAlert_Click(object sender, EventArgs e)
        {
            if (txtCoin.Text.Length > 0 && txtPrice.Text.Length > 0 && txtType.Text.Length > 0)
            {
                AddAlert();
            }
            else
                MessageBox.Show("Hepsini doldur");

        }

        void AddAlert()
        {
            try
            {
                bool isUp = txtType.Text == "Üstünde"; ;
                if (alerts.Any(p => p.Name == txtCoin.Text && p.IsUp == isUp))
                {
                    MessageBox.Show("Önce mevcut alarmı sil");
                    return;
                }

                AlertModel alert = new AlertModel();
                alert.Name = txtCoin.Text;
                alert.Price = Convert.ToDouble(txtPrice.Text);
                alert.IsUp = isUp;
                alerts.Add(alert);
                FillAlerts();

                txtCoin.Text = "";
                txtPrice.Text = "";
                txtType.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillAlerts()
        {
            try
            {
                StreamWriter sw = new StreamWriter("Alerts.txt");
                sw.Write(JsonConvert.SerializeObject(alerts));
                sw.Close();
                sw.Dispose();

                lstAlerts.Items.Clear();
                foreach (var alert in alerts)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = alert.Name;
                    lvi.SubItems.Add(alert.Price.ToString());
                    lvi.SubItems.Add(alert.IsUp ? "Üstünde" : "Altında");
                    if (!alert.IsUp)
                    {
                        lvi.BackColor = Color.DarkRed;
                        lvi.ForeColor = Color.White;
                    }
                    else
                        lvi.BackColor = Color.ForestGreen;

                    lstAlerts.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstAlerts_DoubleClick(object sender, EventArgs e)
        {
            if (lstAlerts.SelectedItems.Count > 0)
            {
                var coinName = lstAlerts.SelectedItems[0].Text;
                var isUp = lstAlerts.SelectedItems[0].SubItems[2].Text == "Üstünde";
                lstAlerts.Items.Remove(lstAlerts.SelectedItems[0]);
                alerts.Remove(alerts.FirstOrDefault(p => p.Name == coinName && p.IsUp == isUp));
                FillAlerts();
            }
        }

        void CheckAlert()
        {
            foreach (var alert in alerts)
            {
                var coin = coins.FirstOrDefault(p => p.Name == alert.Name);
                if ((alert.IsUp == true && coin.lowestAsk >= alert.Price) || (alert.IsUp == false && coin.lowestAsk <= alert.Price))
                    MessageBox.Show("Kardeşşşşş koş " + alert.Name + " coin'e bişeyler oluyor");

            }
        }

        private void tmrListener_Tick(object sender, EventArgs e)
        {
            GetDataFromParibu();
        }
    }
}
