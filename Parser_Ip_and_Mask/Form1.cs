using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser_Ip_and_Mask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        { 
            Clear();
            Extractor.ExtractIpAndMask(txtPath.Text,dgvResult,txtLog,txtVrfForwarding.Text);
        }

        private void Clear()
        {
            dgvResult.Rows.Clear();
            txtLog.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            var indexesColumns = new int[] { 1, 2 };
            dgvResult.CopyDataColumns(indexesColumns);
        }
    }
}