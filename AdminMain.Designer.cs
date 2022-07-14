namespace Telecommunication_Franchise_Management_System
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.SideBarPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuButtonPnl = new System.Windows.Forms.Panel();
            this.Menulbl = new System.Windows.Forms.Label();
            this.MenuIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WorkersCmd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BalanceCmd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EmoneyCmd = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SimsCmd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ComlplainReportCmd = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SideBarPnl.SuspendLayout();
            this.MenuButtonPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarPnl
            // 
            this.SideBarPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SideBarPnl.BackColor = System.Drawing.Color.Red;
            this.SideBarPnl.Controls.Add(this.MenuButtonPnl);
            this.SideBarPnl.Controls.Add(this.panel2);
            this.SideBarPnl.Controls.Add(this.panel3);
            this.SideBarPnl.Controls.Add(this.panel4);
            this.SideBarPnl.Controls.Add(this.panel5);
            this.SideBarPnl.Controls.Add(this.panel6);
            this.SideBarPnl.Controls.Add(this.panel7);
            this.SideBarPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPnl.Location = new System.Drawing.Point(3, 3);
            this.SideBarPnl.MaximumSize = new System.Drawing.Size(208, 0);
            this.SideBarPnl.MinimumSize = new System.Drawing.Size(52, 507);
            this.SideBarPnl.Name = "SideBarPnl";
            this.SideBarPnl.Size = new System.Drawing.Size(208, 507);
            this.SideBarPnl.TabIndex = 0;
            this.SideBarPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // MenuButtonPnl
            // 
            this.MenuButtonPnl.BackColor = System.Drawing.Color.Red;
            this.MenuButtonPnl.Controls.Add(this.Menulbl);
            this.MenuButtonPnl.Controls.Add(this.MenuIcon);
            this.MenuButtonPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuButtonPnl.Location = new System.Drawing.Point(3, 3);
            this.MenuButtonPnl.Name = "MenuButtonPnl";
            this.MenuButtonPnl.Size = new System.Drawing.Size(200, 73);
            this.MenuButtonPnl.TabIndex = 0;
            // 
            // Menulbl
            // 
            this.Menulbl.AutoSize = true;
            this.Menulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menulbl.ForeColor = System.Drawing.Color.Black;
            this.Menulbl.Location = new System.Drawing.Point(58, 16);
            this.Menulbl.Name = "Menulbl";
            this.Menulbl.Size = new System.Drawing.Size(59, 24);
            this.Menulbl.TabIndex = 1;
            this.Menulbl.Text = "Menu";
            // 
            // MenuIcon
            // 
            this.MenuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuIcon.Image = ((System.Drawing.Image)(resources.GetObject("MenuIcon.Image")));
            this.MenuIcon.Location = new System.Drawing.Point(3, 9);
            this.MenuIcon.Name = "MenuIcon";
            this.MenuIcon.Size = new System.Drawing.Size(37, 34);
            this.MenuIcon.TabIndex = 0;
            this.MenuIcon.TabStop = false;
            this.MenuIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WorkersCmd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 46);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // WorkersCmd
            // 
            this.WorkersCmd.BackColor = System.Drawing.Color.White;
            this.WorkersCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkersCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkersCmd.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkersCmd.Image = global::Telecommunication_Franchise_Management_System.Properties.Resources.employee;
            this.WorkersCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkersCmd.Location = new System.Drawing.Point(0, 0);
            this.WorkersCmd.Name = "WorkersCmd";
            this.WorkersCmd.Size = new System.Drawing.Size(200, 46);
            this.WorkersCmd.TabIndex = 1;
            this.WorkersCmd.Text = "Workers";
            this.WorkersCmd.UseVisualStyleBackColor = false;
            this.WorkersCmd.Click += new System.EventHandler(this.Workers_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BalanceCmd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 46);
            this.panel3.TabIndex = 3;
            // 
            // BalanceCmd
            // 
            this.BalanceCmd.BackColor = System.Drawing.Color.White;
            this.BalanceCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BalanceCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalanceCmd.Image = global::Telecommunication_Franchise_Management_System.Properties.Resources.money;
            this.BalanceCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BalanceCmd.Location = new System.Drawing.Point(0, 0);
            this.BalanceCmd.Name = "BalanceCmd";
            this.BalanceCmd.Size = new System.Drawing.Size(200, 46);
            this.BalanceCmd.TabIndex = 2;
            this.BalanceCmd.Text = "Balance";
            this.BalanceCmd.UseVisualStyleBackColor = false;
            this.BalanceCmd.Click += new System.EventHandler(this.BalanceCmd_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.EmoneyCmd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(3, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 46);
            this.panel4.TabIndex = 4;
            // 
            // EmoneyCmd
            // 
            this.EmoneyCmd.BackColor = System.Drawing.Color.White;
            this.EmoneyCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmoneyCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmoneyCmd.Image = global::Telecommunication_Franchise_Management_System.Properties.Resources.cashless_payment1;
            this.EmoneyCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmoneyCmd.Location = new System.Drawing.Point(0, 0);
            this.EmoneyCmd.Name = "EmoneyCmd";
            this.EmoneyCmd.Size = new System.Drawing.Size(200, 46);
            this.EmoneyCmd.TabIndex = 3;
            this.EmoneyCmd.Text = "Emoney";
            this.EmoneyCmd.UseVisualStyleBackColor = false;
            this.EmoneyCmd.Click += new System.EventHandler(this.EmoneyCmd_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SimsCmd);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(3, 238);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 46);
            this.panel5.TabIndex = 5;
            // 
            // SimsCmd
            // 
            this.SimsCmd.BackColor = System.Drawing.Color.White;
            this.SimsCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimsCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimsCmd.Image = global::Telecommunication_Franchise_Management_System.Properties.Resources.sim_card;
            this.SimsCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SimsCmd.Location = new System.Drawing.Point(0, 0);
            this.SimsCmd.Name = "SimsCmd";
            this.SimsCmd.Size = new System.Drawing.Size(200, 46);
            this.SimsCmd.TabIndex = 4;
            this.SimsCmd.Text = "Sims";
            this.SimsCmd.UseVisualStyleBackColor = false;
            this.SimsCmd.Click += new System.EventHandler(this.SimsCmd_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ComlplainReportCmd);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(3, 290);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 50);
            this.panel6.TabIndex = 6;
            // 
            // ComlplainReportCmd
            // 
            this.ComlplainReportCmd.BackColor = System.Drawing.Color.White;
            this.ComlplainReportCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComlplainReportCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComlplainReportCmd.Image = global::Telecommunication_Franchise_Management_System.Properties.Resources.report;
            this.ComlplainReportCmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComlplainReportCmd.Location = new System.Drawing.Point(0, 0);
            this.ComlplainReportCmd.Name = "ComlplainReportCmd";
            this.ComlplainReportCmd.Size = new System.Drawing.Size(200, 50);
            this.ComlplainReportCmd.TabIndex = 5;
            this.ComlplainReportCmd.Text = "    Complains";
            this.ComlplainReportCmd.UseVisualStyleBackColor = false;
            this.ComlplainReportCmd.Click += new System.EventHandler(this.ComlplainReportCmd_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.button1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 346);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 45);
            this.panel7.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 15F);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 505);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Telecommunication_Franchise_Management_System.Properties.Resources.project_manager;
            this.pictureBox1.Location = new System.Drawing.Point(502, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(666, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(504, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SideBarPnl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 505);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 505);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainForm";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AminMainForm_Load);
            this.SideBarPnl.ResumeLayout(false);
            this.MenuButtonPnl.ResumeLayout(false);
            this.MenuButtonPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SideBarPnl;
        private System.Windows.Forms.Panel MenuButtonPnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox MenuIcon;
        private System.Windows.Forms.Label Menulbl;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Button WorkersCmd;
        private System.Windows.Forms.Button BalanceCmd;
        private System.Windows.Forms.Button EmoneyCmd;
        private System.Windows.Forms.Button SimsCmd;
        private System.Windows.Forms.Button ComlplainReportCmd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
    }
}