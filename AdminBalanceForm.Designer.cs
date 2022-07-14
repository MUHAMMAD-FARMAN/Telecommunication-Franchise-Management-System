namespace Telecommunication_Franchise_Management_System
{
    partial class AdminBalanceForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WorkerBalanceViewGV = new System.Windows.Forms.DataGridView();
            this.Approve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerBalanceViewGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.WorkerBalanceViewGV, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.8486F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.15139F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 502);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // WorkerBalanceViewGV
            // 
            this.WorkerBalanceViewGV.AllowUserToOrderColumns = true;
            this.WorkerBalanceViewGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkerBalanceViewGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkerBalanceViewGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Approve,
            this.Change});
            this.WorkerBalanceViewGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkerBalanceViewGV.Location = new System.Drawing.Point(3, 3);
            this.WorkerBalanceViewGV.Name = "WorkerBalanceViewGV";
            this.WorkerBalanceViewGV.Size = new System.Drawing.Size(960, 435);
            this.WorkerBalanceViewGV.TabIndex = 0;
            this.WorkerBalanceViewGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkerBalanceViewGV_CellContentClick);
            // 
            // Approve
            // 
            this.Approve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Approve.HeaderText = "Approve";
            this.Approve.Name = "Approve";
            this.Approve.Text = "Approve";
            this.Approve.UseColumnTextForButtonValue = true;
            // 
            // Change
            // 
            this.Change.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Change.HeaderText = "Change";
            this.Change.Name = "Change";
            this.Change.Text = "Change";
            this.Change.UseColumnTextForButtonValue = true;
            // 
            // AdminBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminBalanceForm";
            this.Text = "AdminBalanceForm";
            this.Load += new System.EventHandler(this.AdminBalanceForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkerBalanceViewGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView WorkerBalanceViewGV;
        private System.Windows.Forms.DataGridViewButtonColumn Approve;
        private System.Windows.Forms.DataGridViewButtonColumn Change;
    }
}