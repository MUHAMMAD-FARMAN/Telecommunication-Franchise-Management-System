namespace Telecommunication_Franchise_Management_System
{
    partial class EditUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cnictxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackCmd = new System.Windows.Forms.Button();
            this.Updatecmd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Worker ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // Nametxt
            // 
            this.Nametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nametxt.Location = new System.Drawing.Point(322, 113);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(204, 20);
            this.Nametxt.TabIndex = 2;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwordtxt.Location = new System.Drawing.Point(323, 166);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(204, 20);
            this.Passwordtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password  :";
            // 
            // Phonetxt
            // 
            this.Phonetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phonetxt.Location = new System.Drawing.Point(323, 216);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(204, 20);
            this.Phonetxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone No. :";
            // 
            // cnictxt
            // 
            this.cnictxt.Location = new System.Drawing.Point(323, 266);
            this.cnictxt.Name = "cnictxt";
            this.cnictxt.Size = new System.Drawing.Size(204, 20);
            this.cnictxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "CNIC :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.BackCmd);
            this.panel1.Controls.Add(this.Phonetxt);
            this.panel1.Controls.Add(this.Updatecmd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BackCmd
            // 
            this.BackCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackCmd.Location = new System.Drawing.Point(661, 334);
            this.BackCmd.Name = "BackCmd";
            this.BackCmd.Size = new System.Drawing.Size(97, 32);
            this.BackCmd.TabIndex = 9;
            this.BackCmd.Text = "Back";
            this.BackCmd.UseVisualStyleBackColor = true;
            this.BackCmd.Visible = false;
            // 
            // Updatecmd
            // 
            this.Updatecmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Updatecmd.Location = new System.Drawing.Point(558, 334);
            this.Updatecmd.Name = "Updatecmd";
            this.Updatecmd.Size = new System.Drawing.Size(97, 32);
            this.Updatecmd.TabIndex = 8;
            this.Updatecmd.Text = "Update";
            this.Updatecmd.UseVisualStyleBackColor = true;
            this.Updatecmd.Click += new System.EventHandler(this.Updatecmd_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cnictxt);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cnictxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Updatecmd;
        private System.Windows.Forms.Button BackCmd;
    }
}