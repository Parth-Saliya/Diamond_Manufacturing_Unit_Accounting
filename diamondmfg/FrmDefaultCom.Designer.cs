namespace diamondmfg
{
    partial class FrmDefaultCom
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comNameDataSet = new diamondmfg.ComNameDataSet();
            this.companyMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyMasterTableAdapter = new diamondmfg.ComNameDataSetTableAdapters.CompanyMasterTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvV = new System.Windows.Forms.DataGridView();
            this.dtvfa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.comNameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.companyMasterBindingSource;
            this.comboBox1.DisplayMember = "ComName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comNameDataSet
            // 
            this.comNameDataSet.DataSetName = "ComNameDataSet";
            this.comNameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyMasterBindingSource
            // 
            this.companyMasterBindingSource.DataMember = "CompanyMaster";
            this.companyMasterBindingSource.DataSource = this.comNameDataSet;
            // 
            // companyMasterTableAdapter
            // 
            this.companyMasterTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(181, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Make Default";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // dtvV
            // 
            this.dtvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvV.Location = new System.Drawing.Point(12, 110);
            this.dtvV.Name = "dtvV";
            this.dtvV.Size = new System.Drawing.Size(304, 192);
            this.dtvV.TabIndex = 86;
            // 
            // dtvfa
            // 
            this.dtvfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvfa.Location = new System.Drawing.Point(1, 70);
            this.dtvfa.Name = "dtvfa";
            this.dtvfa.Size = new System.Drawing.Size(55, 29);
            this.dtvfa.TabIndex = 87;
            this.dtvfa.Visible = false;
            // 
            // FrmDefaultCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 324);
            this.Controls.Add(this.dtvfa);
            this.Controls.Add(this.dtvV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmDefaultCom";
            this.Text = "FrmDefaultCom";
            this.Load += new System.EventHandler(this.FrmDefaultCom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comNameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private ComNameDataSet comNameDataSet;
        private System.Windows.Forms.BindingSource companyMasterBindingSource;
        private ComNameDataSetTableAdapters.CompanyMasterTableAdapter companyMasterTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvV;
        private System.Windows.Forms.DataGridView dtvfa;
    }
}