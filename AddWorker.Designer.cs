namespace Telecommunication_Franchise_Management_System
{
    partial class AddWorkerForm
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
            this.BackCmd = new System.Windows.Forms.Button();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.AddWorkerCmd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Cnictxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackCmd
            // 
            this.BackCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackCmd.Location = new System.Drawing.Point(748, 369);
            this.BackCmd.Name = "BackCmd";
            this.BackCmd.Size = new System.Drawing.Size(97, 32);
            this.BackCmd.TabIndex = 15;
            this.BackCmd.Text = "Back";
            this.BackCmd.UseVisualStyleBackColor = true;
            this.BackCmd.Visible = false;
            this.BackCmd.Click += new System.EventHandler(this.BackCmd_Click);
            // 
            // Phonetxt
            // 
            this.Phonetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phonetxt.Location = new System.Drawing.Point(419, 244);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(204, 20);
            this.Phonetxt.TabIndex = 12;
            this.Phonetxt.TextChanged += new System.EventHandler(this.Phonetxt_TextChanged);
            // 
            // AddWorkerCmd
            // 
            this.AddWorkerCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddWorkerCmd.Location = new System.Drawing.Point(645, 369);
            this.AddWorkerCmd.Name = "AddWorkerCmd";
            this.AddWorkerCmd.Size = new System.Drawing.Size(97, 32);
            this.AddWorkerCmd.TabIndex = 14;
            this.AddWorkerCmd.Text = "Add";
            this.AddWorkerCmd.UseVisualStyleBackColor = true;
            this.AddWorkerCmd.Click += new System.EventHandler(this.AddWorkerCmd_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "CNIC :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone No. :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BackCmd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Nametxt);
            this.panel1.Controls.Add(this.AddWorkerCmd);
            this.panel1.Controls.Add(this.Cnictxt);
            this.panel1.Controls.Add(this.Passwordtxt);
            this.panel1.Controls.Add(this.Phonetxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 472);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Add New Worker";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nametxt
            // 
            this.Nametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nametxt.Location = new System.Drawing.Point(419, 144);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(204, 20);
            this.Nametxt.TabIndex = 15;
            this.Nametxt.TextChanged += new System.EventHandler(this.Nametxt_TextChanged);
            // 
            // Cnictxt
            // 
            this.Cnictxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cnictxt.Location = new System.Drawing.Point(419, 296);
            this.Cnictxt.Name = "Cnictxt";
            this.Cnictxt.Size = new System.Drawing.Size(204, 20);
            this.Cnictxt.TabIndex = 14;
            this.Cnictxt.TextChanged += new System.EventHandler(this.Cnictxt_TextChanged);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwordtxt.Location = new System.Drawing.Point(419, 194);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(204, 20);
            this.Passwordtxt.TabIndex = 13;
            this.Passwordtxt.TextChanged += new System.EventHandler(this.Passwordtxt_TextChanged);
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 472);
            this.Controls.Add(this.panel1);
            this.Name = "AddWorkerForm";
            this.Text = "AddWorker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddWorkerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackCmd;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Button AddWorkerCmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Cnictxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}