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
    public partial class FrmDefaultCom : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dia"].ConnectionString);


        public FrmDefaultCom(string lbusername)
        {
            InitializeComponent();

            Boolean a, u, v, d, p;


            label1.Text = lbusername.ToString();

            con.Open();
            SqlCommand cmdl = new SqlCommand("select addright,updateright,viewright,deleteright,printright from userrights where username = '" + lbusername.ToString() + "' and formname = 'FrmDefaultCom'", con);


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
           

            con.Close();
          
            if (u == true)
            {
                button1.Enabled = true;
            }
            if (v == true)
            {
                dtvV.Visible = true;
            }
           
        }

        private void FrmDefaultCom_Load(object sender, EventArgs e)
        {
            disp_DefCom();
            // TODO: This line of code loads data into the 'comNameDataSet.CompanyMaster' table. You can move, or remove it, as needed.
            this.companyMasterTableAdapter.Fill(this.comNameDataSet.CompanyMaster);




        }

        public void disp_DefCom()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from defcom";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtvV.DataSource = dt;
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update defcom set defcomname = '" + comboBox1.Text + "',user = '" + label1.Text + "' where id = '1'  ", con);

            cmd.ExecuteNonQuery();
            con.Close();
            disp_DefCom();
          
           
        }
    }
}
