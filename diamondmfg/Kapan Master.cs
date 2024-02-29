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
    public partial class Kapan_Master : Form
    {
        public Kapan_Master(string lbusername)
        {
            InitializeComponent();

            Boolean a, u, v, d, p;




            con.Open();
            SqlCommand cmdl = new SqlCommand("select addright,updateright,viewright,deleteright,printright from userrights where username = '" + lbusername.ToString() + "' and formname = 'kapan_master'", con);


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

        private void Kapan_Master_Load(object sender, EventArgs e)
        {
            disp_Rough();
            // TODO: This line of code loads data into the 'diamDataSet3.RoughManageStock' table. You can move, or remove it, as needed.
            this.roughManageStockTableAdapter.Fill(this.diamDataSet3.RoughManageStock);

        }

        public void disp_Rough()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from KapanCreate";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtvV.DataSource = dt;
            con.Close();
        }

        public void availablerough()
        {
            try
            {

                
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select CTS from RoughManageStock where RoughName = '" + cmbRough.Text + "'";
                var result = cmd.ExecuteScalar();
                label4.Text = result.ToString();
                con.Close();
                if(Convert.ToDouble(label4.Text) <= Convert.ToDouble(txtWeight.Text))
                {
                    clearall();
                    MessageBox.Show("Stock is Not Available");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void clearall()
        {
            txtKapanNo.Clear();
            txtRemark.Clear();
            txtWeight.Clear();
            cmbRough.ResetText();
            
        }

        public void RoughManageA()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update RoughManageStock set CTS = CTS -'"+txtWeight.Text+"' where RoughName = '"+cmbRough.Text+"' ", con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            availablerough();
            if (txtKapanNo.Text != "" && cmbRough.Text != "" && txtRemark.Text != "" && txtWeight.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into KapanCreate values(convert(date,'" + KapanDt.Text + "',5),  '" + txtKapanNo.Text + "' , '" + cmbRough .Text + "' , '" + txtWeight.Text + "' , '" + txtRemark .Text + "')", con);

                cmd.ExecuteNonQuery();

                con.Close();
                RoughManageA();
               

                disp_Rough();
            }
            else
            {
                MessageBox.Show("Fill All Details");
            }
            
        }

        private void cmbRough_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
