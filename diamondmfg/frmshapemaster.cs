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
    public partial class frmshapemaster : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dia"].ConnectionString);

        public frmshapemaster(string lbusername)
        {
            InitializeComponent();

 
            Boolean a, u, v, d, p;




            con.Open();
            SqlCommand cmdl = new SqlCommand("select addright,updateright,viewright,deleteright,printright from userrights where username = '" + lbusername.ToString() + "' and formname = 'frmshapemaster'", con);


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


        public void disp_Shade()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from shapemaster";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtvV.DataSource = dt;
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into shapemaster values('" + textBox2.Text + "')", con);

            cmd.ExecuteNonQuery();

            con.Close();
            disp_Shade();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update shapemaster set shape_name = '" + textBox2.Text + "' where id = '" + textBox1.Text + "'  ", con);

                cmd.ExecuteNonQuery();
                con.Close();
                disp_Shade();

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from shapemaster where id = '" + textBox1.Text + "'  ", con);

                cmd.ExecuteNonQuery();
                con.Close();
                disp_Shade();


            }
        }

        private void frmshapemaster_Load(object sender, EventArgs e)
        {
            disp_Shade();
        }

        private void dtvV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dtvV.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();

                textBox2.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
