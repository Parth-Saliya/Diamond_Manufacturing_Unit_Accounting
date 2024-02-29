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
    public partial class IssueForProcess : Form
    {
        public IssueForProcess(string lbusername)
        {
            InitializeComponent();

            Boolean a, u, v, d, p;




            con.Open();
            SqlCommand cmdl = new SqlCommand("select addright,updateright,viewright,deleteright,printright from userrights where username = '" + lbusername.ToString() + "' and formname = 'frmdepartmentmaster'", con);


            cmdl.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdl);
            da.Fill(dt);
            dtvfa.DataSource = dt;



            a = Convert.ToBoolean(dtvfa.Rows[0].Cells[0].Value);
            u = Convert.ToBoolean(dtvfa.Rows[0].Cells[1].Value);
            v = Convert.ToBoolean(dtvfa.Rows[0].Cells[2].Value);
            d = Convert.ToBoolean(dtvfa.Rows[0].Cells[3].Value);
            p = Convert.ToBoolean(dtvfa.Rows[0].Cells[4].Value);
            //   MessageBox.Show(a.ToString() + u + v + d + p);

            con.Close();
            if (a == true)
            {
                btnA.Enabled = true;
            }
            if (u == true)
            {
                btnU.Enabled = true;
            }
            if (v == true)
            {
                dtvV.Visible = true;
            }
            if (d == true)
            {
                btnD.Enabled = true;
            }
            if (p == true)
            {
                btnP.Enabled = true;
            }
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dia"].ConnectionString);

        private void dtvV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IssueForProcess_Load(object sender, EventArgs e)
        {

            disp_Process();
            // TODO: This line of code loads data into the 'diamDataSet6.party_master' table. You can move, or remove it, as needed.
            this.party_masterTableAdapter.Fill(this.diamDataSet6.party_master);
            // TODO: This line of code loads data into the 'diamDataSet5.KapanCreate' table. You can move, or remove it, as needed.
            this.kapanCreateTableAdapter.Fill(this.diamDataSet5.KapanCreate);
            // TODO: This line of code loads data into the 'diamDataSet4.DepMaster' table. You can move, or remove it, as needed.
            this.depMasterTableAdapter.Fill(this.diamDataSet4.DepMaster);

        }

        public void disp_Process()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ProcessMaster";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtvV.DataSource = dt;
            con.Close();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (cmbDep.Text != "" && cmbKapan.Text != "" && cmbParty.Text != "" && txtCts.Text != "" && txtPcs.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProcessMaster values(convert(date,'" + ProcessDate.Text + "',5),  '" + cmbParty.Text + "' , '" + cmbDep.Text + "' , '" + cmbKapan.Text + "' , '" + txtPcs.Text + "'  , '" + txtCts.Text + "' )", con);

                cmd.ExecuteNonQuery();

                con.Close();

                disp_Process();
                
                
               
            }
            else
            {
                MessageBox.Show("Fill All Details");
            }
        }
    }
}
