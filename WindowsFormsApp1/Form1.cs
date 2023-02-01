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
 
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtstuid.Text));
                bw.Write(txtname.Text);
                bw.Write(txtAddress.Text);
                bw.Write(txtmarks.Text);
                bw.Write(Convert.ToDouble(txtpercentage.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Data saved to file..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SkillMineDoc\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtstuid.Text = br.ReadInt32().ToString();
                txtname.Text = br.ReadString();
                txtAddress.Text = br.ReadString();
                txtmarks.Text = br.ReadString();
                txtpercentage.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {

        }
    }
}
