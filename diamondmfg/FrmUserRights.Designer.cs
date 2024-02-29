namespace diamondmfg
{
    partial class FrmUserRights
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
            this.userMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diamDataSet = new diamondmfg.diamDataSet();
            this.userMasterTableAdapter = new diamondmfg.diamDataSetTableAdapters.UserMasterTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UPDATER = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VIEWR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRINTR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnU = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnV = new System.Windows.Forms.Button();
            this.AddDefaultForm = new System.Windows.Forms.Button();
            this.dtvV = new System.Windows.Forms.DataGridView();
            this.dtvfa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Visible = false;
            // 
            // userMasterBindingSource
            // 
            this.userMasterBindingSource.DataMember = "UserMaster";
            this.userMasterBindingSource.DataSource = this.diamDataSet;
            // 
            // diamDataSet
            // 
            this.diamDataSet.DataSetName = "diamDataSet";
            this.diamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userMasterTableAdapter
            // 
            this.userMasterTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FName,
            this.ADDR,
            this.UPDATER,
            this.VIEWR,
            this.DELETE,
            this.PRINTR});
            this.dataGridView1.Location = new System.Drawing.Point(193, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(100, 29);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // FName
            // 
            this.FName.HeaderText = "Name";
            this.FName.Name = "FName";
            this.FName.Width = 300;
            // 
            // ADDR
            // 
            this.ADDR.HeaderText = "ADD";
            this.ADDR.Name = "ADDR";
            this.ADDR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ADDR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UPDATER
            // 
            this.UPDATER.HeaderText = "UPDATE";
            this.UPDATER.Name = "UPDATER";
            this.UPDATER.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UPDATER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // VIEWR
            // 
            this.VIEWR.HeaderText = "VIEW";
            this.VIEWR.Name = "VIEWR";
            this.VIEWR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VIEWR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.Name = "DELETE";
            // 
            // PRINTR
            // 
            this.PRINTR.HeaderText = "PRINT";
            this.PRINTR.Name = "PRINTR";
            // 
            // btnU
            // 
            this.btnU.Enabled = false;
            this.btnU.Location = new System.Drawing.Point(336, 386);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 6;
            this.btnU.Text = "SAVE";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.userMasterBindingSource;
            this.comboBox2.DisplayMember = "UserName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(349, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox2_KeyDown);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(490, 31);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(127, 23);
            this.btnV.TabIndex = 3;
            this.btnV.Text = "GET DETAIL";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddDefaultForm
            // 
            this.AddDefaultForm.Location = new System.Drawing.Point(623, 31);
            this.AddDefaultForm.Name = "AddDefaultForm";
            this.AddDefaultForm.Size = new System.Drawing.Size(127, 23);
            this.AddDefaultForm.TabIndex = 4;
            this.AddDefaultForm.Text = "ADD";
            this.AddDefaultForm.UseVisualStyleBackColor = true;
            this.AddDefaultForm.Click += new System.EventHandler(this.AddDefaultForm_Click);
            // 
            // dtvV
            // 
            this.dtvV.BackgroundColor = System.Drawing.Color.White;
            this.dtvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvV.Location = new System.Drawing.Point(2, 60);
            this.dtvV.Name = "dtvV";
            this.dtvV.Size = new System.Drawing.Size(852, 320);
            this.dtvV.TabIndex = 5;
            this.dtvV.Visible = false;
            // 
            // dtvfa
            // 
            this.dtvfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvfa.Location = new System.Drawing.Point(768, 12);
            this.dtvfa.Name = "dtvfa";
            this.dtvfa.Size = new System.Drawing.Size(74, 29);
            this.dtvfa.TabIndex = 6;
            // 
            // FrmUserRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 427);
            this.Controls.Add(this.dtvfa);
            this.Controls.Add(this.dtvV);
            this.Controls.Add(this.AddDefaultForm);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmUserRights";
            this.Text = "FrmUserRights";
            this.Load += new System.EventHandler(this.FrmUserRights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private diamDataSet diamDataSet;
        private System.Windows.Forms.BindingSource userMasterBindingSource;
        private diamDataSetTableAdapters.UserMasterTableAdapter userMasterTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ADDR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UPDATER;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VIEWR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DELETE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PRINTR;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button AddDefaultForm;
        private System.Windows.Forms.DataGridView dtvV;
        private System.Windows.Forms.DataGridView dtvfa;
    }
}