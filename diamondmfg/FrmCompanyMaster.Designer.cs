namespace diamondmfg
{
    partial class FrmCompanyMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtvfa = new System.Windows.Forms.DataGridView();
            this.dtvV = new System.Windows.Forms.DataGridView();
            this.ComRegDate = new System.Windows.Forms.DateTimePicker();
            this.ComTagline = new System.Windows.Forms.TextBox();
            this.ComOwnerName = new System.Windows.Forms.TextBox();
            this.ComAccountNo = new System.Windows.Forms.TextBox();
            this.ComIFSCCode = new System.Windows.Forms.TextBox();
            this.ComBankName = new System.Windows.Forms.TextBox();
            this.ComPANNo = new System.Windows.Forms.TextBox();
            this.ComCINNo = new System.Windows.Forms.TextBox();
            this.ComGSTNo = new System.Windows.Forms.TextBox();
            this.ComMobileNo2 = new System.Windows.Forms.TextBox();
            this.ComMobileNo1 = new System.Windows.Forms.TextBox();
            this.ComAddress = new System.Windows.Forms.TextBox();
            this.ComName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnP = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.usern = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvfa
            // 
            this.dtvfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvfa.Location = new System.Drawing.Point(767, 12);
            this.dtvfa.Name = "dtvfa";
            this.dtvfa.Size = new System.Drawing.Size(74, 29);
            this.dtvfa.TabIndex = 7;
            this.dtvfa.Visible = false;
            // 
            // dtvV
            // 
            this.dtvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvV.Location = new System.Drawing.Point(12, 317);
            this.dtvV.Name = "dtvV";
            this.dtvV.Size = new System.Drawing.Size(858, 150);
            this.dtvV.TabIndex = 15;
            this.dtvV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvV_CellDoubleClick);
            // 
            // ComRegDate
            // 
            this.ComRegDate.Location = new System.Drawing.Point(470, 139);
            this.ComRegDate.Name = "ComRegDate";
            this.ComRegDate.Size = new System.Drawing.Size(181, 20);
            this.ComRegDate.TabIndex = 12;
            this.ComRegDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComRegDate_KeyDown);
            // 
            // ComTagline
            // 
            this.ComTagline.Location = new System.Drawing.Point(460, 234);
            this.ComTagline.Name = "ComTagline";
            this.ComTagline.Size = new System.Drawing.Size(181, 20);
            this.ComTagline.TabIndex = 13;
            this.ComTagline.TextChanged += new System.EventHandler(this.ComTagline_TextChanged);
            this.ComTagline.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComTagline_KeyDown);
            // 
            // ComOwnerName
            // 
            this.ComOwnerName.Location = new System.Drawing.Point(470, 113);
            this.ComOwnerName.Name = "ComOwnerName";
            this.ComOwnerName.Size = new System.Drawing.Size(181, 20);
            this.ComOwnerName.TabIndex = 11;
            this.ComOwnerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComOwnerName_KeyDown);
            // 
            // ComAccountNo
            // 
            this.ComAccountNo.Location = new System.Drawing.Point(470, 87);
            this.ComAccountNo.Name = "ComAccountNo";
            this.ComAccountNo.Size = new System.Drawing.Size(181, 20);
            this.ComAccountNo.TabIndex = 10;
            this.ComAccountNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComAccountNo_KeyDown);
            // 
            // ComIFSCCode
            // 
            this.ComIFSCCode.Location = new System.Drawing.Point(470, 61);
            this.ComIFSCCode.Name = "ComIFSCCode";
            this.ComIFSCCode.Size = new System.Drawing.Size(181, 20);
            this.ComIFSCCode.TabIndex = 9;
            this.ComIFSCCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComIFSCCode_KeyDown);
            // 
            // ComBankName
            // 
            this.ComBankName.Location = new System.Drawing.Point(470, 35);
            this.ComBankName.Name = "ComBankName";
            this.ComBankName.Size = new System.Drawing.Size(181, 20);
            this.ComBankName.TabIndex = 8;
            this.ComBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComBankName_KeyDown);
            // 
            // ComPANNo
            // 
            this.ComPANNo.Location = new System.Drawing.Point(178, 187);
            this.ComPANNo.Name = "ComPANNo";
            this.ComPANNo.Size = new System.Drawing.Size(181, 20);
            this.ComPANNo.TabIndex = 7;
            this.ComPANNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComPANNo_KeyDown);
            // 
            // ComCINNo
            // 
            this.ComCINNo.Location = new System.Drawing.Point(178, 162);
            this.ComCINNo.Name = "ComCINNo";
            this.ComCINNo.Size = new System.Drawing.Size(181, 20);
            this.ComCINNo.TabIndex = 6;
            this.ComCINNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComCINNo_KeyDown);
            // 
            // ComGSTNo
            // 
            this.ComGSTNo.Location = new System.Drawing.Point(178, 137);
            this.ComGSTNo.Name = "ComGSTNo";
            this.ComGSTNo.Size = new System.Drawing.Size(181, 20);
            this.ComGSTNo.TabIndex = 5;
            this.ComGSTNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComGSTNo_KeyDown);
            // 
            // ComMobileNo2
            // 
            this.ComMobileNo2.Location = new System.Drawing.Point(178, 112);
            this.ComMobileNo2.Name = "ComMobileNo2";
            this.ComMobileNo2.Size = new System.Drawing.Size(181, 20);
            this.ComMobileNo2.TabIndex = 4;
            this.ComMobileNo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComMobileNo2_KeyDown);
            // 
            // ComMobileNo1
            // 
            this.ComMobileNo1.Location = new System.Drawing.Point(178, 87);
            this.ComMobileNo1.Name = "ComMobileNo1";
            this.ComMobileNo1.Size = new System.Drawing.Size(181, 20);
            this.ComMobileNo1.TabIndex = 3;
            this.ComMobileNo1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComMobileNo1_KeyDown);
            // 
            // ComAddress
            // 
            this.ComAddress.Location = new System.Drawing.Point(178, 62);
            this.ComAddress.Name = "ComAddress";
            this.ComAddress.Size = new System.Drawing.Size(181, 20);
            this.ComAddress.TabIndex = 2;
            this.ComAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComAddress_KeyDown);
            // 
            // ComName
            // 
            this.ComName.Location = new System.Drawing.Point(178, 37);
            this.ComName.Name = "ComName";
            this.ComName.Size = new System.Drawing.Size(181, 20);
            this.ComName.TabIndex = 1;
            this.ComName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComName_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(406, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Tagline :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(427, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Logo :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Reg. Date :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Owner Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Account No. :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "IFSC Code :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Bank Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "PAN No. :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "CIN No. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "GST No. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Mobile No. 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mobile No. 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "CompanyName :";
            // 
            // btnP
            // 
            this.btnP.Enabled = false;
            this.btnP.Location = new System.Drawing.Point(265, 19);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 3;
            this.btnP.Text = "PRINT";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Enabled = false;
            this.btnD.Location = new System.Drawing.Point(181, 19);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "DELETE";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnU
            // 
            this.btnU.Enabled = false;
            this.btnU.Location = new System.Drawing.Point(97, 19);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 1;
            this.btnU.Text = "UPDATE";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.Location = new System.Drawing.Point(13, 19);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "ADD";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnP);
            this.groupBox1.Controls.Add(this.btnA);
            this.groupBox1.Controls.Add(this.btnD);
            this.groupBox1.Controls.Add(this.btnU);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(239, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 52);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(150, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Id :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(178, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(103, 20);
            this.txtId.TabIndex = 0;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(287, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 13);
            this.linkLabel1.TabIndex = 76;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GET ID";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // usern
            // 
            this.usern.AutoSize = true;
            this.usern.Location = new System.Drawing.Point(686, 9);
            this.usern.Name = "usern";
            this.usern.Size = new System.Drawing.Size(75, 13);
            this.usern.TabIndex = 51;
            this.usern.Text = "Owner Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(555, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "BROWSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(882, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtvV);
            this.Controls.Add(this.ComRegDate);
            this.Controls.Add(this.ComTagline);
            this.Controls.Add(this.ComOwnerName);
            this.Controls.Add(this.ComAccountNo);
            this.Controls.Add(this.ComIFSCCode);
            this.Controls.Add(this.ComBankName);
            this.Controls.Add(this.ComPANNo);
            this.Controls.Add(this.ComCINNo);
            this.Controls.Add(this.ComGSTNo);
            this.Controls.Add(this.ComMobileNo2);
            this.Controls.Add(this.ComMobileNo1);
            this.Controls.Add(this.ComAddress);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.ComName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.usern);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvfa);
            this.Name = "FrmCompanyMaster";
            this.Text = "FrmCompanyMaster";
            this.Load += new System.EventHandler(this.FrmCompanyMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvfa;
        private System.Windows.Forms.DataGridView dtvV;
        private System.Windows.Forms.DateTimePicker ComRegDate;
        private System.Windows.Forms.TextBox ComTagline;
        private System.Windows.Forms.TextBox ComOwnerName;
        private System.Windows.Forms.TextBox ComAccountNo;
        private System.Windows.Forms.TextBox ComIFSCCode;
        private System.Windows.Forms.TextBox ComBankName;
        private System.Windows.Forms.TextBox ComPANNo;
        private System.Windows.Forms.TextBox ComCINNo;
        private System.Windows.Forms.TextBox ComGSTNo;
        private System.Windows.Forms.TextBox ComMobileNo2;
        private System.Windows.Forms.TextBox ComMobileNo1;
        private System.Windows.Forms.TextBox ComAddress;
        private System.Windows.Forms.TextBox ComName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label usern;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}