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
using DevExpress.XtraEditors;
using libdebug;

namespace OrbisInjector
{
    public partial class Form1 : XtraForm
    {
        private readonly WebClient client = new WebClient();

        public Form1()
        {
            InitializeComponent();
            LoadPayloadsDropdown();

            Task.Run(UpdatePayloadDropdown);
        }

        private async Task UpdatePayloadDropdown()
        {
            while (true)
            {
                string payloadsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Payloads");

                if (Directory.Exists(payloadsDirectory))
                {
                    string[] payloads = Directory.GetFiles(payloadsDirectory, "*.bin");
                    foreach (string payload in payloads)
                    {
                        if (!PayloadComboBoxEdit.Properties.Items.Contains(Path.GetFileName(payload)))
                        {
                            PayloadComboBoxEdit.Properties.Items.Add(Path.GetFileName(payload));
                        }
                    }
                }

                await Task.Delay(5000); // Wait for 5 seconds before checking again
            }
        }


        private void LoadPayloadsDropdown()
        {
            string payloadsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Payloads");

            if (Directory.Exists(payloadsDirectory))
            {
                string[] payloads = Directory.GetFiles(payloadsDirectory, "*.bin");
                foreach (string payload in payloads)
                {
                    PayloadComboBoxEdit.Properties.Items.Add(Path.GetFileName(payload));
                }
                PayloadComboBoxEdit.SelectedIndex = 0;
            }
        }

        private async Task<bool> CheckBinServerStatus(string ipAddress)
        {
            try
            {
                string statusUrl = $"http://{ipAddress}:9090/status";
                string statusData = await client.DownloadStringTaskAsync(statusUrl);

                Console.WriteLine(ipAddress);

                if (statusData.Contains("{ \"status\": \"ready\" }"))
                {
                    LogMemoEdit.Text += "GoldHEN Bin Server Detected" + Environment.NewLine;
                    return true;
                }
            }
            catch (WebException)
            {
                LogMemoEdit.Text += "GoldHEN Bin Server Not Detected!!!" + Environment.NewLine;
            }
            return false;
        }

        private async Task LoadPayload(string ipAddress, string payloadFile)
        {
            try
            {
                string statusUrl = $"http://{ipAddress}:9090/status";
                string statusData = await client.DownloadStringTaskAsync(statusUrl);

                Console.WriteLine("Server status:", statusData);

                if (!statusData.Contains("{ \"status\": \"ready\" }"))
                {
                    LogMemoEdit.Text += "Cannot Load Payload Because The BinLoader Server Is Busy" + Environment.NewLine;
                    return;
                }

                byte[] payloadData = File.ReadAllBytes(payloadFile);

                byte[] sendResponse = await client.UploadDataTaskAsync($"http://{ipAddress}:9090", payloadData);



                LogMemoEdit.Text += "Payload sent successfully" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:", ex.Message);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            IpAddressTextEdit.Text = Properties.Settings.Default.console_ip;
            CustomPathEdit.Text = Properties.Settings.Default.custom_path;

            if (!(await CheckBinServerStatus(Properties.Settings.Default.console_ip)))
            {
                XtraMessageBox.Show("GoldHEN's BinLoader server has not been detected, make sure you toggle the binloader server before using the tool.", "Orbis Payloads", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            string ipAddress = IpAddressTextEdit.Text;
            string payloadFile;

            if (CustomPathEdit.Checked)
            {
                payloadFile = PayloadTextEdit.Text;
            }
            else
            {
                string payloadsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Payloads");
                if (!Directory.Exists(payloadsDirectory))
                {
                    DialogResult result = XtraMessageBox.Show("The 'Payloads' directory does not exist. Do you want to create it now?", "Directory Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Directory.CreateDirectory(payloadsDirectory);
                    }
                }

                payloadFile = Path.Combine(payloadsDirectory, PayloadComboBoxEdit.Text);
            }

            if (string.IsNullOrEmpty(ipAddress) || string.IsNullOrEmpty(payloadFile))
            {
                XtraMessageBox.Show("Please enter the IP address and select a payload.");
                return;
            }

            try
            {
                if (!(await CheckBinServerStatus(ipAddress)))
                {
                    return;
                }

                await LoadPayload(ipAddress, payloadFile);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PayloadTextEdit.Text = openFileDialog.FileName;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.console_ip = IpAddressTextEdit.Text;
            Properties.Settings.Default.custom_path = CustomPathEdit.Text;

            Properties.Settings.Default.Save();
        }
    }
}
