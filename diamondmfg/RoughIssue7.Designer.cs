namespace diamondmfg
{
    partial class RoughIssue
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
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtReamark = new System.Windows.Forms.TextBox();
            this.txtDalaliAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnP = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.MainDt = new System.Windows.Forms.DateTimePicker();
            this.RoughDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.txtParty = new System.Windows.Forms.ComboBox();
            this.partymasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diamDataSet2 = new diamondmfg.diamDataSet2();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtExpensePer = new System.Windows.Forms.TextBox();
            this.txtDalaliPer = new System.Windows.Forms.TextBox();
            this.txtFinalCost = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCts = new System.Windows.Forms.TextBox();
            this.txtRoughName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtvV = new System.Windows.Forms.DataGridView();
            this.dtvfa = new System.Windows.Forms.DataGridView();
            this.party_masterTableAdapter = new diamondmfg.diamDataSet2TableAdapters.party_masterTableAdapter();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partymasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(452, 81);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(63, 20);
            this.txtRate.TabIndex = 8;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(624, 187);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "Delete";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(6, 81);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(70, 20);
            this.txtNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(565, 109);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseAmount.TabIndex = 11;
            this.txtExpenseAmount.TextChanged += new System.EventHandler(this.txtExpenseAmount_TextChanged);
            this.txtExpenseAmount.Leave += new System.EventHandler(this.txtExpenseAmount_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Expense";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(565, 83);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.Enter += new System.EventHandler(this.txtAmount_Enter);
            // 
            // txtReamark
            // 
            this.txtReamark.Location = new System.Drawing.Point(577, 19);
            this.txtReamark.Name = "txtReamark";
            this.txtReamark.Size = new System.Drawing.Size(100, 20);
            this.txtReamark.TabIndex = 2;
            // 
            // txtDalaliAmount
            // 
            this.txtDalaliAmount.Location = new System.Drawing.Point(565, 135);
            this.txtDalaliAmount.Name = "txtDalaliAmount";
            this.txtDalaliAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDalaliAmount.TabIndex = 13;
            this.txtDalaliAmount.TextChanged += new System.EventHandler(this.txtDalaliAmount_TextChanged);
            this.txtDalaliAmount.Leave += new System.EventHandler(this.txtDalaliAmount_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Party";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Dalali";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Remark";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(462, 187);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "Add";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(543, 187);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 2;
            this.btnU.Text = "Update";
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnP);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.MainDt);
            this.groupBox1.Controls.Add(this.RoughDate);
            this.groupBox1.Controls.Add(this.cmbCurrency);
            this.groupBox1.Controls.Add(this.txtParty);
            this.groupBox1.Controls.Add(this.txtDalaliAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.btnU);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.btnD);
            this.groupBox1.Controls.Add(this.btnA);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtReamark);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.txtExpensePer);
            this.groupBox1.Controls.Add(this.txtDalaliPer);
            this.groupBox1.Controls.Add(this.txtFinalCost);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtExpenseAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtCts);
            this.groupBox1.Controls.Add(this.txtRoughName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnP
            // 
            this.btnP.Enabled = false;
            this.btnP.Location = new System.Drawing.Point(708, 187);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 19;
            this.btnP.Text = "PRINT";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(732, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Company";
            this.label18.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(732, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "User";
            this.label17.Visible = false;
            // 
            // MainDt
            // 
            this.MainDt.Location = new System.Drawing.Point(734, 13);
            this.MainDt.Name = "MainDt";
            this.MainDt.Size = new System.Drawing.Size(65, 20);
            this.MainDt.TabIndex = 17;
            // 
            // RoughDate
            // 
            this.RoughDate.Location = new System.Drawing.Point(98, 13);
            this.RoughDate.Name = "RoughDate";
            this.RoughDate.Size = new System.Drawing.Size(100, 20);
            this.RoughDate.TabIndex = 0;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "$",
            "RS"});
            this.cmbCurrency.Location = new System.Drawing.Point(373, 80);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(68, 21);
            this.cmbCurrency.TabIndex = 7;
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtParty
            // 
            this.txtParty.DataSource = this.partymasterBindingSource;
            this.txtParty.DisplayMember = "Party_Name";
            this.txtParty.FormattingEnabled = true;
            this.txtParty.Location = new System.Drawing.Point(344, 16);
            this.txtParty.Name = "txtParty";
            this.txtParty.Size = new System.Drawing.Size(140, 21);
            this.txtParty.TabIndex = 1;
            this.txtParty.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // partymasterBindingSource
            // 
            this.partymasterBindingSource.DataMember = "party_master";
            this.partymasterBindingSource.DataSource = this.diamDataSet2;
            // 
            // diamDataSet2
            // 
            this.diamDataSet2.DataSetName = "diamDataSet2";
            this.diamDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cost";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(574, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(473, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Rate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "(RS/$)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "CTS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Rough Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(737, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "(%)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(737, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total ";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(671, 83);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(60, 20);
            this.txtCost.TabIndex = 10;
            // 
            // txtExpensePer
            // 
            this.txtExpensePer.Location = new System.Drawing.Point(671, 109);
            this.txtExpensePer.Name = "txtExpensePer";
            this.txtExpensePer.Size = new System.Drawing.Size(60, 20);
            this.txtExpensePer.TabIndex = 12;
            this.txtExpensePer.TextChanged += new System.EventHandler(this.txtExpensePer_TextChanged);
            this.txtExpensePer.Leave += new System.EventHandler(this.txtExpensePer_Leave);
            // 
            // txtDalaliPer
            // 
            this.txtDalaliPer.Location = new System.Drawing.Point(671, 135);
            this.txtDalaliPer.Name = "txtDalaliPer";
            this.txtDalaliPer.Size = new System.Drawing.Size(60, 20);
            this.txtDalaliPer.TabIndex = 14;
            this.txtDalaliPer.Leave += new System.EventHandler(this.txtDalaliPer_Leave);
            // 
            // txtFinalCost
            // 
            this.txtFinalCost.Location = new System.Drawing.Point(671, 161);
            this.txtFinalCost.Name = "txtFinalCost";
            this.txtFinalCost.ReadOnly = true;
            this.txtFinalCost.Size = new System.Drawing.Size(60, 20);
            this.txtFinalCost.TabIndex = 16;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(565, 161);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Enter += new System.EventHandler(this.txtTotal_Enter);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(282, 81);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(70, 20);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtCts
            // 
            this.txtCts.Location = new System.Drawing.Point(190, 81);
            this.txtCts.Name = "txtCts";
            this.txtCts.Size = new System.Drawing.Size(70, 20);
            this.txtCts.TabIndex = 5;
            this.txtCts.TextChanged += new System.EventHandler(this.txtCts_TextChanged);
            this.txtCts.Leave += new System.EventHandler(this.txtCts_Leave);
            // 
            // txtRoughName
            // 
            this.txtRoughName.Location = new System.Drawing.Point(82, 81);
            this.txtRoughName.Name = "txtRoughName";
            this.txtRoughName.Size = new System.Drawing.Size(102, 20);
            this.txtRoughName.TabIndex = 4;
            this.txtRoughName.Leave += new System.EventHandler(this.txtRoughName_Leave);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(5, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(28, 20);
            this.txtId.TabIndex = 3;
            // 
            // dtvV
            // 
            this.dtvV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvV.Location = new System.Drawing.Point(12, 249);
            this.dtvV.Name = "dtvV";
            this.dtvV.Size = new System.Drawing.Size(1013, 346);
            this.dtvV.TabIndex = 4;
            // 
            // dtvfa
            // 
            this.dtvfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvfa.Location = new System.Drawing.Point(823, 112);
            this.dtvfa.Name = "dtvfa";
            this.dtvfa.Size = new System.Drawing.Size(74, 29);
            this.dtvfa.TabIndex = 87;
            this.dtvfa.Visible = false;
            // 
            // party_masterTableAdapter
            // 
            this.party_masterTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(1040, 25);
            this.fillBy2ToolStrip.TabIndex = 88;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Visible = false;
            this.fillBy2ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillBy2ToolStrip_ItemClicked);
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // RoughIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 712);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.dtvfa);
            this.Controls.Add(this.dtvV);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoughIssue";
            this.Text = "RoughIssue";
            this.Load += new System.EventHandler(this.RoughIssue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partymasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtReamark;
        private System.Windows.Forms.TextBox txtDalaliAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtvV;
        private System.Windows.Forms.DateTimePicker RoughDate;
        private System.Windows.Forms.ComboBox txtParty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCts;
        private System.Windows.Forms.TextBox txtRoughName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtFinalCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExpensePer;
        private System.Windows.Forms.TextBox txtDalaliPer;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker MainDt;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dtvfa;
        private System.Windows.Forms.Button btnP;
        private diamDataSet2 diamDataSet2;
        private System.Windows.Forms.BindingSource partymasterBindingSource;
        private diamDataSet2TableAdapters.party_masterTableAdapter party_masterTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
    }
}