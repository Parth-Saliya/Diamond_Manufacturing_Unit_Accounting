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
    public partial class RoughIssue : Form
    {
        public RoughIssue(string lbusername)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoughIntoPrice();
        }

        private void RoughIssue_Load(object sender, EventArgs e)
        {
            disp_Rough();
            // TODO: This line of code loads data into the 'diamDataSet2.party_master' table. You can move, or remove it, as needed.
            this.party_masterTableAdapter.Fill(this.diamDataSet2.party_master);
            fillBy2ToolStripButton.PerformClick();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            disp_Rough();
        }

        public void RoughIntoPrice()
        {
            if(txtCts.Text != "" && txtPrice.Text != "")
            {
                if (cmbCurrency.Text == "$")
                {
                    if (!string.IsNullOrEmpty(txtCts.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(cmbCurrency.Text) && !string.IsNullOrEmpty(txtRate.Text))
                    { 
                        txtAmount.Text = (Convert.ToDouble(txtCts.Text) * Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtRate.Text)).ToString();

                    decimal asd = Convert.ToDecimal(txtAmount.Text.ToString());
                    decimal aa = Math.Round(asd, 0);
                    txtAmount.Text = aa.ToString();
                    }
                }

                if (cmbCurrency.Text == "RS")
                {

                    if (!string.IsNullOrEmpty(txtCts.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(cmbCurrency.Text) && !string.IsNullOrEmpty(txtRate.Text))
                    {
                        txtAmount.Text = (Convert.ToDouble(txtCts.Text) * Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtRate.Text)).ToString();

                        decimal asd = Convert.ToDecimal(txtAmount.Text.ToString());
                        decimal aa = Math.Round(asd, 0);
                        txtAmount.Text = aa.ToString();
                    }
                }



                if (!string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtCts.Text))
                {
                    txtCost.Text = (Convert.ToDouble(txtAmount.Text) / Convert.ToDouble(txtCts.Text)).ToString();

                    decimal asdd = Convert.ToDecimal(txtCost.Text.ToString());
                    decimal aad = Math.Round(asdd, 2);
                    txtCost.Text = aad.ToString();
                }



            }
        }

        public void ExpenseCalculatorByPer()
        {
            if (txtExpensePer.Text != "")
            {
                if (!string.IsNullOrEmpty(txtCts.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(cmbCurrency.Text))
                {
                    txtExpenseAmount.Text = (Convert.ToDouble(txtExpensePer.Text) * Convert.ToDouble(txtAmount.Text) / 100).ToString();

                    decimal asd = Convert.ToDecimal(txtExpenseAmount.Text.ToString());
                    decimal aa = Math.Round(asd, 0);
                    txtExpenseAmount.Text = aa.ToString();
                }
            }


        }

        public void ExpenseCalculatorByAmount()
        {
            if (txtExpenseAmount.Text != "")
            {
                if (!string.IsNullOrEmpty(txtCts.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(cmbCurrency.Text))
                {
                    txtExpensePer.Text = (Convert.ToDouble(txtExpenseAmount.Text) / Convert.ToDouble(txtAmount.Text) * 100).ToString();
                    decimal asd = Convert.ToDecimal(txtExpensePer.Text.ToString());
                    decimal aa = Math.Round(asd, 2);
                    txtExpensePer.Text = aa.ToString();
                }
            }
            

        }

        public void DalaliCalculatorByPer()
        {
            if (txtDalaliPer.Text != "")
            {
                if (!string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtExpenseAmount.Text) && !string.IsNullOrEmpty(txtDalaliPer.Text))
                    txtDalaliAmount.Text = (Convert.ToDouble(txtDalaliPer.Text) * (Convert.ToDouble(txtAmount.Text)+ Convert.ToDouble(txtExpenseAmount.Text)) / 100).ToString();

                decimal asd = Convert.ToDecimal(txtDalaliAmount.Text.ToString());
                decimal aa = Math.Round(asd, 0);
                txtDalaliAmount.Text = aa.ToString();
            }


        }

        public void DalaliCalculatorByAmount()
        {
            if (txtDalaliAmount.Text != "")
            {
                if (!string.IsNullOrEmpty(txtDalaliAmount.Text) && !string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtExpenseAmount.Text))
                    txtDalaliPer.Text = (Convert.ToDouble(txtDalaliAmount.Text)*100 / (Convert.ToDouble(txtAmount.Text)+ Convert.ToDouble(txtExpenseAmount.Text)) ).ToString();
                
                decimal asd = Convert.ToDecimal ( txtDalaliPer.Text.ToString());
                decimal aa = Math.Round(asd, 2);
                //  double after = Math.Round(asd, 0, MidpointRounding.AwayFromZero);
              //  MessageBox.Show(aa.ToString());
                txtDalaliPer.Text = aa.ToString();
            }


        }

        public void TotalRoughAmount()
        {
    
            if (txtDalaliAmount.Text != "" && txtAmount.Text != "" && txtExpenseAmount.Text != "")
            {
                if (!string.IsNullOrEmpty(txtDalaliAmount.Text) && !string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtExpenseAmount.Text))
                {
                    txtTotal.Text = (Convert.ToDouble(txtDalaliAmount.Text) + Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(txtExpenseAmount.Text)).ToString();
                    txtFinalCost.Text = (Convert.ToDouble(txtTotal.Text) / Convert.ToDouble(txtCts.Text)).ToString();

                    decimal asd = Convert.ToDecimal(txtFinalCost.Text.ToString());
                    decimal aa = Math.Round(asd, 0);
                    txtFinalCost.Text = aa.ToString();
                }
            }


        
        }

        public void runall()
        {
            RoughIntoPrice();
            ExpenseCalculatorByPer();
            ExpenseCalculatorByAmount();
            DalaliCalculatorByAmount();
            DalaliCalculatorByPer();
            TotalRoughAmount();

        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            RoughIntoPrice();
        }

        private void txtExpensePer_Leave(object sender, EventArgs e)
        {
            ExpenseCalculatorByPer();
        }

        private void txtExpenseAmount_Leave(object sender, EventArgs e)
        {
            ExpenseCalculatorByAmount();

        }

        private void txtDalaliPer_Leave(object sender, EventArgs e)
        {
            DalaliCalculatorByPer();
            TotalRoughAmount();
        }

        private void txtDalaliAmount_Leave(object sender, EventArgs e)
        {
            DalaliCalculatorByAmount();
            TotalRoughAmount();
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            TotalRoughAmount();
        }

        private void txtDalaliAmount_TextChanged(object sender, EventArgs e)
        {
            DalaliCalculatorByAmount();
            TotalRoughAmount();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCts_TextChanged(object sender, EventArgs e)
        {
            RoughIntoPrice();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            RoughIntoPrice();
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            RoughIntoPrice();
        }

        private void txtExpenseAmount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtExpensePer_TextChanged(object sender, EventArgs e)
        {
            ExpenseCalculatorByPer();
        }

        private void txtRoughName_Leave(object sender, EventArgs e)
        {

        }

        private void txtCts_Leave(object sender, EventArgs e)
        {
            runall();
        }

        public void disp_Rough()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from RoughIssue";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtvV.DataSource = dt;
            con.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if(txtParty.Text != "" && txtNo.Text != "" && txtRoughName.Text != "" && txtCts.Text != "" && txtPrice.Text != "" && cmbCurrency.Text != "" && txtRate.Text != "" && txtAmount.Text != "" && txtCost.Text != "" && txtExpenseAmount.Text != "" && txtExpensePer.Text != "" && txtDalaliAmount.Text != "" && txtDalaliPer.Text != "" && txtTotal.Text != "" && txtFinalCost.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into RoughIssue values(convert(date,'" + RoughDate.Text + "',5),  '" + txtParty.Text + "' , '" + txtReamark.Text + "' , '" + txtNo.Text + "' , '" + txtRoughName.Text + "'  , '" + txtCts.Text + "' , '" + txtPrice.Text + "' , '" + cmbCurrency.Text + "', '" + txtRate.Text + "' , '" + txtAmount.Text + "', '" + txtCost.Text + "', '" + txtExpenseAmount.Text + "', '" + txtExpensePer.Text + "', '" + txtDalaliAmount.Text + "' , '" + txtDalaliPer.Text + "', '" + txtTotal.Text + "', '" + txtFinalCost.Text + "' , '" + label17 .Text + "', '" + label18 .Text + "'   , convert(date,'" + MainDt.Text + "',5))", con);

                cmd.ExecuteNonQuery();

                con.Close();

                con.Open();
                SqlCommand cmdm = new SqlCommand("insert into RoughManageStock values(convert(date,'" + RoughDate.Text + "',5),  '" + txtParty.Text + "' , '" + txtReamark.Text + "' , '" + txtNo.Text + "' , '" + txtRoughName.Text + "'  , '" + txtCts.Text + "' , '" + txtPrice.Text + "' , '" + cmbCurrency.Text + "', '" + txtRate.Text + "' , '" + txtAmount.Text + "', '" + txtCost.Text + "', '" + txtExpenseAmount.Text + "', '" + txtExpensePer.Text + "', '" + txtDalaliAmount.Text + "' , '" + txtDalaliPer.Text + "', '" + txtTotal.Text + "', '" + txtFinalCost.Text + "' , '" + label17.Text + "', '" + label18.Text + "'   , convert(date,'" + MainDt.Text + "',5))", con);

                cmdm.ExecuteNonQuery();

                con.Close();

                disp_Rough();
            }
            else
            {
                MessageBox.Show("Fill All Details");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtParty.Text != "" && txtNo.Text != "" && txtRoughName.Text != "" && txtCts.Text != "" && txtPrice.Text != "" && cmbCurrency.Text != "" && txtRate.Text != "" && txtAmount.Text != "" && txtCost.Text != "" && txtExpenseAmount.Text != "" && txtExpensePer.Text != "" && txtDalaliAmount.Text != "" && txtDalaliPer.Text != "" && txtTotal.Text != "" && txtFinalCost.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from RoughIssue where id = '" + txtId.Text + "'  ", con);

                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmdk = new SqlCommand("delete from RoughManageStock where id = '" + txtId.Text + "'  ", con);

                cmdk.ExecuteNonQuery();

                con.Close();
                disp_Rough();
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.party_masterTableAdapter.FillBy2(this.diamDataSet2.party_master);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
