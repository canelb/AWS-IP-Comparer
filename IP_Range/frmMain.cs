using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using IP_Range.Model;
using System.Globalization;

namespace IP_Range
{
    public partial class frmMain : Form
    {
        string fileContent1 = "";
        string fileContent2 = "";
        DateTime createdDateTimeAwsIpRange1, createdDateTimeAwsIpRange2;
        AWSIPRange awsIPRange1, awsIPRange2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFileAdd1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtFileInput1.Text = openFileDialog1.FileName;
        }

        private void btnFileAdd2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtFileInput2.Text = openFileDialog1.FileName;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cbxRegion.SelectedIndex = 0;
            cbxService.SelectedIndex = 0;
            chkSecondFile.Checked = true;
            txtFileInput2.Enabled = false;
            btnFileAdd2.Enabled = false;
        }

        private void chkSecondFile_Click(object sender, EventArgs e)
        {
            if (chkSecondFile.Checked)
            {
                txtFileInput2.Enabled = false;
                btnFileAdd2.Enabled = false;
            }
            else
            {
                txtFileInput2.Enabled = true;
                btnFileAdd2.Enabled = true;
            }
        }

        private void btnReadChck_Click(object sender, EventArgs e)
        {
            if(File.Exists(txtFileInput1.Text))
            {
                fileContent1 = File.ReadAllText(txtFileInput1.Text);
                if (chkSecondFile.Checked == false)
                {
                    if(File.Exists(txtFileInput2.Text))
                    {
                        fileContent2 = File.ReadAllText(txtFileInput2.Text);
                        awsIPRange1 = JsonConvert.DeserializeObject<AWSIPRange>(fileContent1);
                        awsIPRange2 = JsonConvert.DeserializeObject<AWSIPRange>(fileContent2);
                        createdDateTimeAwsIpRange1 = DateTime.ParseExact(awsIPRange1.CreateDate, "yyyy-MM-dd-HH-mm-ss", CultureInfo.InvariantCulture);
                        createdDateTimeAwsIpRange2 = DateTime.ParseExact(awsIPRange2.CreateDate, "yyyy-MM-dd-HH-mm-ss", CultureInfo.InvariantCulture);
                        int compareDate = DateTime.Compare(createdDateTimeAwsIpRange1, createdDateTimeAwsIpRange2);
                        if (compareDate < 0)
                        {
                            MessageBox.Show("Second file created date is newst.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            IEnumerable<Prefix> deletedIp = awsIPRange2.Prefixes.
                               Where(p => p.Region == cbxRegion.Text && p.Service == cbxService.Text).
                                   Except(awsIPRange1.Prefixes.Where(p => p.Region == cbxRegion.Text && p.Service == cbxService.Text), new PrefixComparer());
                            txtIP.Text = "--- Deleted --- \r\n";
                            txtIP.Text += String.Join(Environment.NewLine, deletedIp.Select(d => d.Ip_Prefix));
                            txtIP.Text += "\r\n\r\n";
                            IEnumerable<Prefix> newIp = awsIPRange1.Prefixes.
                                Where(p => p.Region == cbxRegion.Text && p.Service == cbxService.Text).
                                    Except(awsIPRange2.Prefixes.Where(p => p.Region == cbxRegion.Text && p.Service == cbxService.Text), new PrefixComparer());
                            txtIP.Text = "--- New --- \r\n";
                            txtIP.Text += String.Join(Environment.NewLine, newIp.Select(d => d.Ip_Prefix));
                        }
                        else if (compareDate == 0)
                        {
                            MessageBox.Show("Files created dates are same.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (compareDate > 0)
                        {
                            IEnumerable<Prefix> newIp = awsIPRange1.Prefixes.
                                Where(p => p.Region == cbxRegion.Text && p.Service == cbxService.Text).
                                    Except(awsIPRange2.Prefixes.Where(p => p.Region == cbxRegion.Text && p.Service == cbxService.Text), new PrefixComparer());
                            txtIP.Text = "--- New --- \r\n";
                            txtIP.Text += String.Join(Environment.NewLine, newIp.Select(d => d.Ip_Prefix));
                            txtIP.Text += "\r\n\r\n";
                            IEnumerable<Prefix> deletedIp = awsIPRange2.Prefixes.
                               Where(p => p.Region == cbxRegion.Text && p.Service == cbxService.Text).
                                   Except(awsIPRange1.Prefixes.Where(p => p.Region == cbxRegion.Text && p.Service == cbxService.Text), new PrefixComparer());
                            txtIP.Text += "--- Deleted --- \r\n";
                            txtIP.Text += String.Join(Environment.NewLine, deletedIp.Select(d => d.Ip_Prefix));
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is not a second file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    awsIPRange1 = JsonConvert.DeserializeObject<AWSIPRange>(fileContent1);
                    IEnumerable<Prefix> newIp = awsIPRange1.Prefixes.Where(p => p.Region == cbxRegion.Text && p.Service == cbxService.Text);
                    txtIP.Text = "--- New --- \r\n";
                    txtIP.Text += String.Join(Environment.NewLine, newIp.Select(d => d.Ip_Prefix));
                }
                MessageBox.Show("Completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is no file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    internal class PrefixComparer : IEqualityComparer<Prefix>
    {
        public bool Equals(Prefix x, Prefix y)
        {
            return (x.Ip_Prefix == y.Ip_Prefix);
        }

        public int GetHashCode(Prefix obj)
        {
            return 0;
        }
    }
}
