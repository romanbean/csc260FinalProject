using System;
using System.Windows.Forms;

namespace BakingUnitConverter
{
    public partial class Converter : Form
    {
        Share s = new Share();
        Recipe r = new Recipe();
        public Converter()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            s.AbleToUpload(rtb_Main);
        }
        private void btn_download_Click(object sender, EventArgs e)
        {
            s.AbleToDownload(rtb_Main);
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            r.QuickReplace(rtb_Main, tb_PrevNum, tb_NewNum, cb_PrevUnit, cb_NewUnit);
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            r.UnitConversion(tb_PrevNum, cb_PrevUnit, cb_NewUnit, tb_NewNum, rb_Metric, rb_US);
        }
    }
}
