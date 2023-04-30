using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            Extractor.ExtractIpAndMask(txtPath.Text,dgvResult,txtLog);
            
        }

        private void Clear()
        {
            dgvResult.Rows.Clear();
            txtLog.Clear();
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}