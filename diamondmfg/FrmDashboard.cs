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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard(String USER)
        {
            InitializeComponent();

            lbUserName.Text = USER;

           
            string a, u, v, d, p;

            con.Open();
            SqlCommand cmdl = new SqlCommand("select addright,updateright,viewright,deleteright,printright from userrights where username = '" + lbUserName.Text + "' and formname = 'frmdashboard'", con);


            cmdl.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdl);
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            a = dataGridView2.Rows[0].Cells[0].Value.ToString();
            u = dataGridView2.Rows[0].Cells[1].Value.ToString();
            v = dataGridView2.Rows[0].Cells[2].Value.ToString();
            d = dataGridView2.Rows[0].Cells[3].Value.ToString();
            p = dataGridView2.Rows[0].Cells[4].Value.ToString();

           
            con.Close();
        }


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dia"].ConnectionString);

        private void btnComMast_Click(object sender, EventArgs e)
        {
            FrmCompanyMaster FCM = new FrmCompanyMaster(lbUserName.Text);
            FCM.Show();
        }

        private void btnUserMaster_Click(object sender, EventArgs e)
        {
            Boolean   a, u, v, d, p;

            con.Open();
            SqlCommand cmdl = new SqlCommand("select addright,updateright,viewright,deleteright,printright from userrights where username = '" + lbUserName.Text + "' and formname = 'User_master'", con);


            cmdl.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdl);
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            

            a = Convert .ToBoolean( dataGridView2.Rows[0].Cells[0].Value);
            u = Convert.ToBoolean ( dataGridView2.Rows[0].Cells[1].Value);
            v = Convert.ToBoolean( dataGridView2.Rows[0].Cells[2].Value);
            d = Convert.ToBoolean( dataGridView2.Rows[0].Cells[3].Value);
            p = Convert.ToBoolean( dataGridView2.Rows[0].Cells[4].Value);

            
            con.Close();

          //  MessageBox.Show(v);
            if (v == true)
            {
                
                User_master FUM = new User_master(a,u,v,d,p);
                FUM.Show();
            }
        }

        public void enter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnUserRights_Click(object sender, EventArgs e)
        {
            FrmUserRights FUR = new FrmUserRights(lbUserName.Text);
            FUR.Show();
        }

        private void btnComMast_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmshademaster FSM = new frmshademaster(lbUserName.Text);
            FSM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Process_Master  FUP = new Process_Master(lbUserName.Text);
            FUP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmshapemaster FSPM = new frmshapemaster(lbUserName.Text);
            FSPM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmdepartmentmaster FDM = new frmdepartmentmaster(lbUserName.Text);
            FDM.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGroupMaster FGM = new FrmGroupMaster(lbUserName.Text);
            FGM.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDefaultCom FDCM = new FrmDefaultCom(lbUserName.Text);
            FDCM.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmPurityMaster  FPM = new FrmPurityMaster(lbUserName.Text);
            FPM.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAssortmentMaster  FAM = new diamondmfg.FrmAssortmentMaster(lbUserName.Text);
            FAM.Show();
        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Party_Master FAM = new Party_Master(lbUserName.Text);
            FAM.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RoughIssue FCR = new RoughIssue(lbUserName.Text);
            FCR.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Kapan_Master FCk = new Kapan_Master(lbUserName.Text);
            FCk.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RoughAvailable  FCR = new RoughAvailable (lbUserName.Text);
            FCR.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            IssueForProcess FCI = new IssueForProcess(lbUserName.Text);
            FCI.Show();
        }
    }
}
