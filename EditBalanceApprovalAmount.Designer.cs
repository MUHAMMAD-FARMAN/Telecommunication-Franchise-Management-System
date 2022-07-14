namespace Telecommunication_Franchise_Management_System
{
    partial class EditBalanceApprovalAmount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeAmounttxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ChangeApprovalAmountCmd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 45);
            this.label2.TabIndex = 21;
            this.label2.Text = "Change Balance Approval Amount";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Amount :";
            // 
            // ChangeAmounttxt
            // 
            this.ChangeAmounttxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeAmounttxt.Location = new System.Drawing.Point(413, 162);
            this.ChangeAmounttxt.Name = "ChangeAmounttxt";
            this.ChangeAmounttxt.Size = new System.Drawing.Size(196, 20);
            this.ChangeAmounttxt.TabIndex = 19;
            this.ChangeAmounttxt.TextChanged += new System.EventHandler(this.ChangeAmounttxt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ChangeApprovalAmountCmd);
            this.panel1.Controls.Add(this.ChangeAmounttxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 486);
            this.panel1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(530, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeApprovalAmountCmd
            // 
            this.ChangeApprovalAmountCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeApprovalAmountCmd.Location = new System.Drawing.Point(644, 258);
            this.ChangeApprovalAmountCmd.Name = "ChangeApprovalAmountCmd";
            this.ChangeApprovalAmountCmd.Size = new System.Drawing.Size(91, 30);
            this.ChangeApprovalAmountCmd.TabIndex = 22;
            this.ChangeApprovalAmountCmd.Text = "Change";
            this.ChangeApprovalAmountCmd.UseVisualStyleBackColor = true;
            this.ChangeApprovalAmountCmd.Click += new System.EventHandler(this.ChangeApprovalAmountCmd_Click);
            // 
            // EditBalanceApprovalAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 486);
            this.Controls.Add(this.panel1);
            this.Name = "EditBalanceApprovalAmount";
            this.Text = "EditBalanceApprovalAmount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Amounttxt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChangeAmounttxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangeApprovalAmountCmd;
        private System.Windows.Forms.Button button1;
    }
}