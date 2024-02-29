using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;
using System.Configuration;

namespace diamondmfg
{
    public partial class FrmUserRights : Form
    {
        public FrmUserRights(string lbusername)
        {
            InitializeComponent();

            //GET USER RIGHTS FOR THIS FORM

            Boolean a, u, v, d, p;

            


            con.Open();
            SqlCommand cmdl = new SqlCommand("select addright,updateright,viewright,deleteright,printright from userrights where username = '" + lbusername.ToString() + "' and formname = 'frmuserrights'", con);


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

            if(u == true)
            {
                btnU.Enabled = true;
            }
            if (v == true)
            {
                dtvV .Visible = true;
            }



        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dia"].ConnectionString);

        private void FrmUserRights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diamDataSet.UserMaster' table. You can move, or remove it, as needed.
            this.userMasterTableAdapter.Fill(this.diamDataSet.UserMaster);


            List<ClassUserRights> list = new List<diamondmfg.ClassUserRights>();
            Type formtype = typeof(Form);
            foreach(Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (formtype.IsAssignableFrom(t))
                    list.Add(new ClassUserRights() { id = t.FullName, FormName = t.Name });

            }

            comboBox1.DataSource = list;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "FormName";

           

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                string value = comboBox1.GetItemText(comboBox1.Items[i]);
                

                string[] row = new string[] { value };
                dataGridView1.Rows.Add(row);
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
          int a =  dtvV.RowCount - 1;
           // MessageBox.Show(a.ToString());
            for(int i=0;i<a;i++)
            {
                string ad = dtvV.Rows[i].Cells[3].Value.ToString();
                string u = dtvV.Rows[i].Cells[4].Value.ToString();
                string v = dtvV.Rows[i].Cells[5].Value.ToString();
                string d = dtvV.Rows[i].Cells[6].Value.ToString();
                string p = dtvV.Rows[i].Cells[7].Value.ToString();
                string s = dtvV.Rows[i].Cells[0].Value.ToString();
                MessageBox.Show(ad.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("update userrights set addright = '" + ad.ToString() + "', updateright = '" + u.ToString() + "',viewright = '"+v.ToString() + "', deleteright = '" + d.ToString() + "', printright = '" + p.ToString() + "' where id = '" + s.ToString() + "'  ", con);

                cmd.ExecuteNonQuery();
                con.Close();
               
            }
            disp_rights();
        }

        private void AddDefaultForm_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            disp_rights();
        }

        public void enter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public void disp_rights()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from userrights where username = '" + comboBox2.Text + "'";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtvV.DataSource = dt;
            con.Close();
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }
    }
}
