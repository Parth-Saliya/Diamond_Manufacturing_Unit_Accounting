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
using System.IO;

namespace diamondmfg
{
    public partial class FrmCompanyMaster : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dia"].ConnectionString);
        string imglocation = "";
       
        public FrmCompanyMaster(string lbusername)
        {
            InitializeComponent();

            //GET USER RIGHTS FOR THIS FORM
            usern.Text = lbusername.ToString();
            Boolean a, u, v, d, p;

           


            con.Open();
            SqlCommand cmdl = new SqlCommand("select addright,updateright,viewright,deleteright,printright from userrights where username = '" + lbusername.ToString() + "' and formname = 'FrmCompanyMaster'", con);


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
                btnD.Visible = true;
            }
            if (p == true)
            {
                btnP.Visible = true;
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void GetId()
        {
            con.Open();
            SqlCommand cmdl = new SqlCommand("select max(id) from companymaster", con);


            cmdl.ExecuteNonQuery();
            var resl = cmdl.ExecuteScalar();
           
            if (resl.ToString() == "")
            {
                txtId.Text = "1";
            }
            else
            {

                int gg = Convert.ToInt32(resl.ToString());
                gg = gg + 1;
                txtId.Text = gg.ToString();
            }

            con.Close();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            GetId();


            byte[] image = null;
            FileStream streem = new FileStream(imglocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            image = brs.ReadBytes((int)streem.Length);

            con.Open();
            SqlCommand cmdl = new SqlCommand("select count(*) from companymaster where id = '" + txtId .Text + "'", con);


            cmdl.ExecuteNonQuery();
            var resl = cmdl.ExecuteScalar();

            int gg = Convert.ToInt32(resl.ToString());

            con.Close();



            if (gg != 1)


            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into companymaster values('" + ComName.Text + "' , '" + ComAddress.Text + "' , '" + ComMobileNo1.Text + "' , '" + ComMobileNo2.Text + "' , '" + ComGSTNo.Text + "'  , '" + ComCINNo.Text + "' , '" + ComPANNo.Text + "' , '" + ComBankName.Text + "', '" + ComIFSCCode.Text + "' , '" + ComAccountNo.Text + "', '" + ComOwnerName.Text + "', '" + usern.Text + "'  , convert(date,'" + ComRegDate.Text + "',5), @images, '" + ComTagline.Text + "')", con);

                cmd.Parameters.Add(new SqlParameter("@images", image));


                cmd.ExecuteNonQuery();

                con.Close();
                disp_com();


            }

           

          
        }

        public void enter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public void disp_com()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from companymaster";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtvV.DataSource = dt;
            con.Close();
        }

        private void ComTagline_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComName_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComAddress_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComMobileNo1_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComMobileNo2_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComGSTNo_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComCINNo_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComPANNo_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComBankName_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComIFSCCode_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComAccountNo_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComOwnerName_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComTagline_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComLogo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ComLogo_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void ComRegDate_KeyDown(object sender, KeyEventArgs e)
        {
            enter(e);
        }

        private void FrmCompanyMaster_Load(object sender, EventArgs e)
        {
            disp_com();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(opf.ShowDialog() == DialogResult.OK )
            {
                
                pictureBox1.Image = Image.FromFile(opf.FileName);
                imglocation = opf.FileName.ToString();
            }
        }

        private void dtvV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0)
            {

                try
                {

                    DataGridViewRow row = this.dtvV.Rows[e.RowIndex];

                    var data = (Byte[])(row.Cells["comlogo"].Value);

                    var stream = new MemoryStream(data);

                    pictureBox1.Image = Image.FromStream(stream);

                    txtId.Text = row.Cells[0].Value.ToString();
                    ComName.Text = row.Cells[1].Value.ToString();
                    ComAddress.Text = row.Cells[2].Value.ToString();
                    ComMobileNo1.Text = row.Cells[3].Value.ToString();
                    ComMobileNo2.Text = row.Cells[4].Value.ToString();
                    ComGSTNo.Text = row.Cells[5].Value.ToString();
                    ComCINNo.Text = row.Cells[6].Value.ToString();
                    ComPANNo.Text = row.Cells[7].Value.ToString();
                    ComBankName.Text = row.Cells[8].Value.ToString();
                    ComIFSCCode.Text = row.Cells[9].Value.ToString();
                    ComAccountNo.Text = row.Cells[10].Value.ToString();
                    ComOwnerName.Text = row.Cells[11].Value.ToString();
                    usern.Text = row.Cells[12].Value.ToString();
                    ComRegDate.Text = row.Cells[13].Value.ToString();
                    //     pictureBox1 .Image = row.Cells[14].Value.ToString();
                    ComTagline.Text = row.Cells[15].Value.ToString();
                }
                catch(Exception ex)
                {

                }

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (txtId .Text != "" )
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from company aster where id = '" + txtId .Text + "'  ", con);

                cmd.ExecuteNonQuery();
                con.Close();
                disp_com ();


            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {

           byte[] image = null;
      /*      FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            image = brs.ReadBytes((int)streem.Length);

    */

            if (txtId .Text != "" && ComName .Text != "" && ComAddress .Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update companymaster set comname = '" + ComName.Text + "', comaddress = '" + ComAddress .Text + "',ComMobileNo1 = '" + ComMobileNo1.Text + "', ComMobileNo2 = '" + ComMobileNo2.Text + "', ComGSTNo = '" + ComGSTNo.Text + "', ComCINNo = '" + ComCINNo .Text + "',ComPANNo = '" + ComPANNo .Text + "', ComBankName = '" + ComBankName .Text + "',ComIFSCCode = '" + ComIFSCCode.Text + "', ComAccountNo = '" + ComAccountNo.Text + "',ComOwnerName = '" + ComOwnerName  .Text + "',comusername = '" + usern.Text + "', comregdate = convert(date,'" + ComRegDate.Text + "',5), comtagline = '" + ComTagline.Text + "' where id = '" + txtId .Text + "'  ", con);
            //    cmd.Parameters.Add(new SqlParameter("@images", image));
                
               


                cmd.ExecuteNonQuery();
                con.Close();
                disp_com();

               
            }
        }
    }
}
