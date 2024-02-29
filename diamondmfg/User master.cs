using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace diamondmfg
{
    public partial class User_master : Form
    {
        public User_master(Boolean a,Boolean u,Boolean v,Boolean d,Boolean p)
        {
            InitializeComponent();

            if(a == true)
            {
                btnA.Enabled = true;
            }
            if (u == true)
            {
                btnU.Enabled = true;
            }
            if (v == true)
            {
                dtvV .Visible    = true;
            }
            if (d == true)
            {
                btnD .Enabled = true;
            }
            if (p == true)
            {
                btnA.Enabled = true;
            }



        }




        DateTime dt2 = DateTime.Now;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dia"].ConnectionString);

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmdl = new SqlCommand("select max(usercode) from usermaster", con);


            cmdl.ExecuteNonQuery();
            var resl = cmdl.ExecuteScalar();
            MessageBox.Show(resl.ToString());
            int gg = Convert.ToInt32(resl.ToString());
            gg = gg + 1;
            textBox3.Text = gg.ToString();
            

            con.Close();
        }


     

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
            

                    con.Open();
                    SqlCommand cmdl = new SqlCommand("select count(*) from usermaster where usercode = '"+textBox3.Text+"'", con);


                    cmdl.ExecuteNonQuery();
                    var resl = cmdl.ExecuteScalar();

                    int gg = Convert.ToInt32(resl.ToString());

                    con.Close();



                if (gg != 1)


                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into usermaster values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + datet.Text + "', '" + textBox3.Text + "')", con);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    disp_User();

                    
                    getform();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }

               




            }
        }

        public void disp_User()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select username,usercode,password from usermaster";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtvV.DataSource = dt;
            con.Close();


        }

        private void User_master_Load(object sender, EventArgs e)
        {
            disp_User();

            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update usermaster set username = '" + textBox1.Text + "', password = '" + textBox2.Text + "' where usercode = '" + textBox3.Text + "'  ", con);

                cmd.ExecuteNonQuery();
                con.Close();
                disp_User();

                con.Open();
                SqlCommand cmdr = new SqlCommand("update userrights set username = '" + textBox1.Text + "' where username = '"+textBox4.Text+"' ", con);

                cmdr.ExecuteNonQuery();
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from usermaster where usercode = '" + textBox3.Text + "'  ", con);

                cmd.ExecuteNonQuery();
                con.Close();
                disp_User();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dtvV.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox4.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        public void enter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public void getform()
        {
            List<ClassUserRights> list = new List<diamondmfg.ClassUserRights>();
            Type formtype = typeof(Form);
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
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
                dataGridView2.Rows.Add(row);
            }

            int a = dataGridView2.RowCount;

            for (int i = 0; i < a-1; i++)
            {
                string s = dataGridView2.Rows[i].Cells[0].Value.ToString();
                MessageBox.Show(s.ToString());


                con.Open();
                SqlCommand cmd = new SqlCommand("insert into userrights values('" + textBox1.Text + "','"+s.ToString()+"', '0', '0','0', '0','0')", con);

                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
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
