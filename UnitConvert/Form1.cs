using System;
using System.Windows.Forms;
namespace UnitConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Convert Calculating";
        }

        private void txtByte_TextChanged(object sender, EventArgs e)
        {
            const int oneByte = 1024;

            if(txtByte.Text=="")
            {
                txtBit.Text = "";
                txtKb.Text = "";
                txtMb.Text = "";
                txtGb.Text = "";
                txtTb.Text = "";
                txtPb.Text = "";
            }
            try
            {
                txtBit.Text = Convert.ToString(double.Parse(txtByte.Text) * 8);
                txtKb.Text = Convert.ToString(double.Parse(txtByte.Text) / oneByte);
                txtMb.Text = Convert.ToString(double.Parse(txtByte.Text) / Math.Pow(oneByte, 3));
                txtGb.Text = Convert.ToString(double.Parse(txtByte.Text) / Math.Pow(oneByte, 6));
                txtTb.Text = Convert.ToString(double.Parse(txtByte.Text) / Math.Pow(oneByte, 9));
                txtPb.Text = Convert.ToString(double.Parse(txtByte.Text) / Math.Pow(oneByte, 12));
                txtBinaryNumber.Text = Convert.ToString(long.Parse(txtByte.Text), 2);
            }
            catch (Exception ex)
            {
            }
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            const int oneThousand = 1000;
            if(txtSecond.Text=="")
            {
                txtMs.Text = "";
                txtUs.Text = "";
                txtNs.Text = "";
                txtPs.Text = "";
                txtFs.Text = "";
                txtAs.Text = "";
                txtBinaryNumber.Text = "";
            }
            try
            {
                txtMs.Text = Convert.ToString(double.Parse(txtSecond.Text) / Math.Pow(oneThousand, 3));
                txtUs.Text = Convert.ToString(double.Parse(txtSecond.Text) / Math.Pow(oneThousand, 6));
                txtNs.Text = Convert.ToString(double.Parse(txtSecond.Text) / Math.Pow(oneThousand, 9));
                txtPs.Text = Convert.ToString(double.Parse(txtSecond.Text) / Math.Pow(oneThousand, 12));
                txtFs.Text = Convert.ToString(double.Parse(txtSecond.Text) / Math.Pow(oneThousand, 15));
                txtAs.Text = Convert.ToString(double.Parse(txtSecond.Text) / Math.Pow(oneThousand, 18)); 
            }
            catch(Exception ex)
            {

            }
        }
    }
}
