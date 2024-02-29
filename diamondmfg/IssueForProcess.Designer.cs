namespace diamondmfg
{
    partial class IssueForProcess
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
            this.components = new System.ComponentModel.Container();
            this.dtvfa = new System.Windows.Forms.DataGridView();
            this.dtvV = new System.Windows.Forms.DataGridView();
            this.btnP = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.ProcessDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPcs = new System.Windows.Forms.TextBox();
            this.txtCts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbParty = new System.Windows.Forms.ComboBox();
            this.cmbDep = new System.Windows.Forms.ComboBox();
            this.depMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diamDataSet4 = new diamondmfg.diamDataSet4();
            this.cmbKapan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.depMasterTableAdapter = new diamondmfg.diamDataSet4TableAdapters.DepMasterTableAdapter();
            this.diamDataSet5 = new diamondmfg.diamDataSet5();
            this.kapanCreateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kapanCreateTableAdapter = new diamondmfg.diamDataSet5TableAdapters.KapanCreateTableAdapter();
            this.diamDataSet6 = new diamondmfg.diamDataSet6();
            this.partymasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.party_masterTableAdapter = new diamondmfg.diamDataSet6TableAdapters.party_masterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapanCreateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partymasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvfa
            // 
            this.dtvfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvfa.Location = new System.Drawing.Point(786, 18);
            this.dtvfa.Name = "dtvfa";
            this.dtvfa.Size = new System.Drawing.Size(42, 23);
            this.dtvfa.TabIndex = 89;
            this.dtvfa.Visible = false;
            // 
            // dtvV
            // 
            this.dtvV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvV.Location = new System.Drawing.Point(46, 139);
            this.dtvV.Name = "dtvV";
            this.dtvV.Size = new System.Drawing.Size(770, 336);
            this.dtvV.TabIndex = 88;
            this.dtvV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvV_CellContentClick);
            // 
            // btnP
            // 
            this.btnP.Enabled = false;
            this.btnP.Location = new System.Drawing.Point(492, 96);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 93;
            this.btnP.Text = "PRINT";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(327, 96);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 90;
            this.btnU.Text = "Update";
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(408, 96);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 91;
            this.btnD.Text = "Delete";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(246, 96);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 92;
            this.btnA.Text = "Add";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // ProcessDate
            // 
            this.ProcessDate.Location = new System.Drawing.Point(101, 12);
            this.ProcessDate.Name = "ProcessDate";
            this.ProcessDate.Size = new System.Drawing.Size(100, 20);
            this.ProcessDate.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "PSC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Kapan No";
            // 
            // txtPcs
            // 
            this.txtPcs.Location = new System.Drawing.Point(529, 44);
            this.txtPcs.Name = "txtPcs";
            this.txtPcs.Size = new System.Drawing.Size(70, 20);
            this.txtPcs.TabIndex = 101;
            // 
            // txtCts
            // 
            this.txtCts.Location = new System.Drawing.Point(621, 44);
            this.txtCts.Name = "txtCts";
            this.txtCts.Size = new System.Drawing.Size(70, 20);
            this.txtCts.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Party Name";
            // 
            // cmbParty
            // 
            this.cmbParty.DataSource = this.partymasterBindingSource;
            this.cmbParty.DisplayMember = "Party_Name";
            this.cmbParty.FormattingEnabled = true;
            this.cmbParty.Location = new System.Drawing.Point(309, 44);
            this.cmbParty.Name = "cmbParty";
            this.cmbParty.Size = new System.Drawing.Size(121, 21);
            this.cmbParty.TabIndex = 102;
            // 
            // cmbDep
            // 
            this.cmbDep.DataSource = this.depMasterBindingSource;
            this.cmbDep.DisplayMember = "Dep_name";
            this.cmbDep.FormattingEnabled = true;
            this.cmbDep.Location = new System.Drawing.Point(111, 48);
            this.cmbDep.Name = "cmbDep";
            this.cmbDep.Size = new System.Drawing.Size(101, 21);
            this.cmbDep.TabIndex = 102;
            // 
            // depMasterBindingSource
            // 
            this.depMasterBindingSource.DataMember = "DepMaster";
            this.depMasterBindingSource.DataSource = this.diamDataSet4;
            // 
            // diamDataSet4
            // 
            this.diamDataSet4.DataSetName = "diamDataSet4";
            this.diamDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKapan
            // 
            this.cmbKapan.DataSource = this.kapanCreateBindingSource;
            this.cmbKapan.DisplayMember = "KapanNo";
            this.cmbKapan.FormattingEnabled = true;
            this.cmbKapan.Location = new System.Drawing.Point(436, 43);
            this.cmbKapan.Name = "cmbKapan";
            this.cmbKapan.Size = new System.Drawing.Size(73, 21);
            this.cmbKapan.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "CTS";
            // 
            // depMasterTableAdapter
            // 
            this.depMasterTableAdapter.ClearBeforeFill = true;
            // 
            // diamDataSet5
            // 
            this.diamDataSet5.DataSetName = "diamDataSet5";
            this.diamDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kapanCreateBindingSource
            // 
            this.kapanCreateBindingSource.DataMember = "KapanCreate";
            this.kapanCreateBindingSource.DataSource = this.diamDataSet5;
            // 
            // kapanCreateTableAdapter
            // 
            this.kapanCreateTableAdapter.ClearBeforeFill = true;
            // 
            // diamDataSet6
            // 
            this.diamDataSet6.DataSetName = "diamDataSet6";
            this.diamDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partymasterBindingSource
            // 
            this.partymasterBindingSource.DataMember = "party_master";
            this.partymasterBindingSource.DataSource = this.diamDataSet6;
            // 
            // party_masterTableAdapter
            // 
            this.party_masterTableAdapter.ClearBeforeFill = true;
            // 
            // IssueForProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 487);
            this.Controls.Add(this.cmbDep);
            this.Controls.Add(this.cmbKapan);
            this.Controls.Add(this.cmbParty);
            this.Controls.Add(this.ProcessDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPcs);
            this.Controls.Add(this.txtCts);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.dtvfa);
            this.Controls.Add(this.dtvV);
            this.Name = "IssueForProcess";
            this.Text = "Issue For Process";
            this.Load += new System.EventHandler(this.IssueForProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapanCreateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partymasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvfa;
        private System.Windows.Forms.DataGridView dtvV;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.DateTimePicker ProcessDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPcs;
        private System.Windows.Forms.TextBox txtCts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbParty;
        private System.Windows.Forms.ComboBox cmbDep;
        private System.Windows.Forms.ComboBox cmbKapan;
        private System.Windows.Forms.Label label4;
        private diamDataSet4 diamDataSet4;
        private System.Windows.Forms.BindingSource depMasterBindingSource;
        private diamDataSet4TableAdapters.DepMasterTableAdapter depMasterTableAdapter;
        private diamDataSet5 diamDataSet5;
        private System.Windows.Forms.BindingSource kapanCreateBindingSource;
        private diamDataSet5TableAdapters.KapanCreateTableAdapter kapanCreateTableAdapter;
        private diamDataSet6 diamDataSet6;
        private System.Windows.Forms.BindingSource partymasterBindingSource;
        private diamDataSet6TableAdapters.party_masterTableAdapter party_masterTableAdapter;
    }
}