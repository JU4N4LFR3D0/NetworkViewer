using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NetworkViewer
{
    public partial class Main : Form
    {
        #region Init
        List<NetworkInfo> networks = new List<NetworkInfo>();
        Dictionary<string, double> last_received = new Dictionary<string, double>();
        Dictionary<string, double> last_sent = new Dictionary<string, double>();
        NetworkInfo network = new NetworkInfo();
        double delta_received = 0;
        double delta_sent = 0;
        double prefix_value = 0;
        string prefix = "";
        public Main()
        {
            InitializeComponent();
            speed_toolStripComboBox.SelectedIndex = 0;
            LoadNetworkInterfacesComboBox();

            var chart = net_chart.ChartAreas[0];
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 60;

            net_chart.Series.Add("r");
            net_chart.Series.Add("s");
            net_chart.Series["r"].ChartType = SeriesChartType.Line;
            net_chart.Series["r"].Color = Color.Black;
            net_chart.Series["s"].ChartType = SeriesChartType.Line;
            net_chart.Series["s"].Color = Color.Black;
            net_chart.Series["s"].BorderDashStyle = ChartDashStyle.Dash;

            net_timer.Start();
        }
        #endregion
        #region Process
        void Reset()
        {
            if (net_chart.Series.Count > 0)
            {
                net_chart.Series["s"].Points.Clear();
                net_chart.Series["r"].Points.Clear();
            }
        }
        bool CalculateNetworks()
        {
            if (!NetworkInterface.GetIsNetworkAvailable()) return false;
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            {
                double received = ni.GetIPv4Statistics().BytesReceived;
                double sent = ni.GetIPv4Statistics().BytesSent;

                if (!last_received.ContainsKey(ni.Id))
                {
                    last_received[ni.Id] = received;
                }
                if (!last_sent.ContainsKey(ni.Id))
                {
                    last_sent[ni.Id] = sent;
                }

                delta_received = received - last_received[ni.Id];
                delta_sent = sent - last_sent[ni.Id];
                last_received[ni.Id] = received;
                last_sent[ni.Id] = sent;

                delta_received /= prefix_value;
                delta_sent /= prefix_value;

                networks.Add(new NetworkInfo()
                {
                    ID = ni.Id,
                    Type = ni.NetworkInterfaceType.ToString(),
                    Name = ni.Name ?? "Network",
                    Received = delta_received,
                    Send = delta_sent,
                }
                );
            }
            return true;
        }
        void CalculatePrefix()
        {
            prefix = speed_toolStripComboBox.SelectedItem.ToString();
            switch (speed_toolStripComboBox.SelectedIndex)
            {
                /*
                [0] B/s
                [1] b/s
                [2] KB/s
                [3] Kb/s
                [4] MB/s
                [5] Mb/s
                */
                case 0:
                    prefix_value = 1;
                    break;
                case 1:
                    prefix_value = 0.125;
                    break;
                case 2:
                    prefix_value = 1024;
                    break;
                case 3:
                    prefix_value = 1024 * 0.125;
                    break;
                case 4:
                    prefix_value = 1024 * 1024;
                    break;
                case 5:
                    prefix_value = 1024 * 1024 * 0.125;
                    break;
                default:
                    prefix_value = 1;
                    break;
            }
        }
        void DisplayTable()
        {
            netdataGridView.Rows.Clear();
            foreach (NetworkInfo net in networks)
            {
                netdataGridView.Rows.Add(
                    net.ID,
                    net.Name,
                    net.Type,
                    net.Received.ToString("N2") + " " + prefix,
                    net.Send.ToString("N2") + " " + prefix
                    );
            }
        }
        void DisplayChart()
        {
            while (net_chart.Series["r"].Points.Count >= 60)
            {
                net_chart.Series["r"].Points.Remove(net_chart.Series["r"].Points[0]);
            }
            while (net_chart.Series["s"].Points.Count >= 60)
            {
                net_chart.Series["s"].Points.Remove(net_chart.Series["s"].Points[0]);
            }

            foreach (DataPoint point in net_chart.Series["r"].Points)
            {
                point.XValue -= 1;
            }
            foreach (DataPoint point in net_chart.Series["s"].Points)
            {
                point.XValue -= 1;
            }

            if (network != null)
            {
                net_chart.Series["r"].Points.Add(new DataPoint(60, network.Received));
                net_chart.Series["s"].Points.Add(new DataPoint(60, network.Send));
            }
        }
        void LoadNetworkInterfacesComboBox()
        {
            if (!NetworkInterface.GetIsNetworkAvailable()) return;
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            interface_toolStripComboBox.Items.Clear();
            foreach (NetworkInterface ni in interfaces)
            {
                interface_toolStripComboBox.Items.Add(ni.Name);
            }
            interface_toolStripComboBox.SelectedIndex = 0;
        }
        #endregion
        #region Events
        private void net_timer_Tick(object sender, EventArgs e)
        {
            networks.Clear();
            CalculatePrefix();
            if (!CalculateNetworks()) return;
            network = networks.Find(elem => elem.Name == interface_toolStripComboBox.SelectedItem.ToString());
            if (net_tabControl.SelectedIndex == 0)
            {
                DisplayTable();
            }
            else
            {
                DisplayChart();
            }
            status_toolStripLabel.Text = $"Received: {network.Received.ToString("N2")} {prefix} Send: {network.Send.ToString("N2")} {prefix}";
        }
        private void speed_toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
        }
        private void interface_toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
        }
        #endregion
    }
    public class NetworkInfo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Received { get; set; }
        public double Send { get; set; }
    }
}