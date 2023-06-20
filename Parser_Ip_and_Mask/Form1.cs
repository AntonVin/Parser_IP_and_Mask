using Microsoft.Win32;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parser_Ip_and_Mask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPath.Text = RegistrHelper.GetPath();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtPath.Text))
            {
                MessageBox.Show("Такой папки не существует","ОШИБКА",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Clear();
            RegistrHelper.SetPath(txtPath.Text);

            Extractor.ExtractDataToTable(txtPath.Text,dgvResult,txtLog);
        }

        private void Clear()
        {
            dgvResult.Rows.Clear();
            txtLog.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            var indexesColumns = new List<int>();
            if (chBox_Station.Checked) indexesColumns.Add(0);
            if (chBox_Interface.Checked) indexesColumns.Add(1);
            if (chBox_IP.Checked) indexesColumns.Add(2);
            if (chBox_Mask.Checked) indexesColumns.Add(3);
            if (chBox_VRF.Checked) indexesColumns.Add(4);
            if (chBox_Shutdown.Checked) indexesColumns.Add(5);
            dgvResult.CopyDataColumns(indexesColumns.ToArray());
        }

        private void btnOpenFD_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                txtPath.Text = folderBrowserDialog.SelectedPath;
        }
    }
}