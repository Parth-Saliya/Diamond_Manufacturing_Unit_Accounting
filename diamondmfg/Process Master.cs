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
    public partial class Process_Master : Form
    {
        public Process_Master(string lbusername)
        {
            InitializeComponent();

            Boolean a, u, v, d, p;




            con.Open();
            SqlCommand cmdl = new SqlCommand("select addright,updateright,viewright,deleteright,printright from userrights where username = '" + lbusername.ToString() + "' and formname = 'process_master'", con);


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
            MessageBox.Show(a.ToString() + u + v + d + p);

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

        public void disp_dep()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from processmaster";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtvV.DataSource = dt;
            con.Close();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into processmaster values('" + textBox2.Text + "')", con);

            cmd.ExecuteNonQuery();

            con.Close();
            disp_dep();
        }
    }
}
