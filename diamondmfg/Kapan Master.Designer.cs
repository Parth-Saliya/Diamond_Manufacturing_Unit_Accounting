namespace diamondmfg
{
    partial class Kapan_Master
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
            this.KapanDt = new System.Windows.Forms.DateTimePicker();
            this.cmbRough = new System.Windows.Forms.ComboBox();
            this.roughManageStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diamDataSet3 = new diamondmfg.diamDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtKapanNo = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtvV = new System.Windows.Forms.DataGridView();
            this.roughManageStockTableAdapter = new diamondmfg.diamDataSet3TableAdapters.RoughManageStockTableAdapter();
            this.dtvfa = new System.Windows.Forms.DataGridView();
            this.btnP = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roughManageStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).BeginInit();
            this.SuspendLayout();
            // 
            // KapanDt
            // 
            this.KapanDt.Location = new System.Drawing.Point(92, 12);
            this.KapanDt.Name = "KapanDt";
            this.KapanDt.Size = new System.Drawing.Size(100, 20);
            this.KapanDt.TabIndex = 9;
            // 
            // cmbRough
            // 
            this.cmbRough.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRough.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRough.DataSource = this.roughManageStockBindingSource;
            this.cmbRough.DisplayMember = "RoughName";
            this.cmbRough.FormattingEnabled = true;
            this.cmbRough.Location = new System.Drawing.Point(283, 53);
            this.cmbRough.Name = "cmbRough";
            this.cmbRough.Size = new System.Drawing.Size(102, 21);
            this.cmbRough.TabIndex = 26;
            this.cmbRough.Leave += new System.EventHandler(this.cmbRough_Leave);
            // 
            // roughManageStockBindingSource
            // 
            this.roughManageStockBindingSource.DataMember = "RoughManageStock";
            this.roughManageStockBindingSource.DataSource = this.diamDataSet3;
            // 
            // diamDataSet3
            // 
            this.diamDataSet3.DataSetName = "diamDataSet3";
            this.diamDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Weight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Rough Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kapan No";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(438, 54);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(70, 20);
            this.txtWeight.TabIndex = 24;
            // 
            // txtKapanNo
            // 
            this.txtKapanNo.Location = new System.Drawing.Point(92, 53);
            this.txtKapanNo.Name = "txtKapanNo";
            this.txtKapanNo.Size = new System.Drawing.Size(100, 20);
            this.txtKapanNo.TabIndex = 22;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(560, 54);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(99, 20);
            this.txtRemark.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Remark";
            // 
            // dtvV
            // 
            this.dtvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvV.Location = new System.Drawing.Point(13, 139);
            this.dtvV.Name = "dtvV";
            this.dtvV.Size = new System.Drawing.Size(686, 359);
            this.dtvV.TabIndex = 27;
            // 
            // roughManageStockTableAdapter
            // 
            this.roughManageStockTableAdapter.ClearBeforeFill = true;
            // 
            // dtvfa
            // 
            this.dtvfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvfa.Location = new System.Drawing.Point(560, 3);
            this.dtvfa.Name = "dtvfa";
            this.dtvfa.Size = new System.Drawing.Size(74, 29);
            this.dtvfa.TabIndex = 88;
            this.dtvfa.Visible = false;
            // 
            // btnP
            // 
            this.btnP.Enabled = false;
            this.btnP.Location = new System.Drawing.Point(416, 97);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 92;
            this.btnP.Text = "PRINT";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(251, 97);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 89;
            this.btnU.Text = "Update";
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(332, 97);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 90;
            this.btnD.Text = "Delete";
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(170, 97);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 91;
            this.btnA.Text = "Add";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ar";
            // 
            // Kapan_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 510);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.dtvfa);
            this.Controls.Add(this.dtvV);
            this.Controls.Add(this.KapanDt);
            this.Controls.Add(this.cmbRough);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtKapanNo);
            this.Name = "Kapan_Master";
            this.Text = "Kapan_Master";
            this.Load += new System.EventHandler(this.Kapan_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roughManageStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker KapanDt;
        private System.Windows.Forms.ComboBox cmbRough;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtKapanNo;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtvV;
        private diamDataSet3 diamDataSet3;
        private System.Windows.Forms.BindingSource roughManageStockBindingSource;
        private diamDataSet3TableAdapters.RoughManageStockTableAdapter roughManageStockTableAdapter;
        private System.Windows.Forms.DataGridView dtvfa;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label label4;
    }
}