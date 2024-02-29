using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diamondmfg
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dia"].ConnectionString);

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmdl = new SqlCommand("select count(*) from usermaster where username = '" + textBox1.Text + "' and password = '"+textBox2.Text+"'", con);


            cmdl.ExecuteNonQuery();
            var resl = cmdl.ExecuteScalar();
            var USERNAME = textBox1.Text;
            int gg = Convert.ToInt32(resl.ToString());

            con.Close();

            if(gg == 1)
            {
                this.Hide();
                FrmDashboard f7 = new FrmDashboard(USERNAME.ToString());
                f7.Show();
            }
            else
            {
                MessageBox.Show("USERNAME AND PASSWORD NOT MATCHED");
            }
        }

        public void enter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }
    }
}
