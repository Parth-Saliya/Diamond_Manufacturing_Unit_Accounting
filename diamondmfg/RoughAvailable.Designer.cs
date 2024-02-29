namespace diamondmfg
{
    partial class RoughAvailable
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
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvfa
            // 
            this.dtvfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvfa.Location = new System.Drawing.Point(696, 12);
            this.dtvfa.Name = "dtvfa";
            this.dtvfa.Size = new System.Drawing.Size(74, 29);
            this.dtvfa.TabIndex = 89;
            this.dtvfa.Visible = false;
            // 
            // dtvV
            // 
            this.dtvV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvV.Location = new System.Drawing.Point(12, 47);
            this.dtvV.Name = "dtvV";
            this.dtvV.Size = new System.Drawing.Size(865, 346);
            this.dtvV.TabIndex = 88;
            this.dtvV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvV_CellContentClick);
            // 
            // RoughAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 517);
            this.Controls.Add(this.dtvfa);
            this.Controls.Add(this.dtvV);
            this.Name = "RoughAvailable";
            this.Text = "RoughAvailable";
            this.Load += new System.EventHandler(this.RoughAvailable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvfa;
        private System.Windows.Forms.DataGridView dtvV;
    }
}