namespace Telecommunication_Franchise_Management_System
{
    partial class EmoneyAprovalAmountChangeForm
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
            this.ChangeApprovalAmountCmd = new System.Windows.Forms.Button();
            this.ChangeAmounttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ChangeApprovalAmountCmd
            // 
            this.ChangeApprovalAmountCmd.Location = new System.Drawing.Point(534, 285);
            this.ChangeApprovalAmountCmd.Name = "ChangeApprovalAmountCmd";
            this.ChangeApprovalAmountCmd.Size = new System.Drawing.Size(99, 32);
            this.ChangeApprovalAmountCmd.TabIndex = 26;
            this.ChangeApprovalAmountCmd.Text = "Change";
            this.ChangeApprovalAmountCmd.UseVisualStyleBackColor = true;
            this.ChangeApprovalAmountCmd.Click += new System.EventHandler(this.ChangeApprovalAmountCmd_Click);
            // 
            // ChangeAmounttxt
            // 
            this.ChangeAmounttxt.Location = new System.Drawing.Point(303, 191);
            this.ChangeAmounttxt.Name = "ChangeAmounttxt";
            this.ChangeAmounttxt.Size = new System.Drawing.Size(204, 20);
            this.ChangeAmounttxt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enter Amount :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 47);
            this.label2.TabIndex = 25;
            this.label2.Text = "Change Balance Approval Amount";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 27;
            // 
            // EmoneyAprovalAmountChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeApprovalAmountCmd);
            this.Controls.Add(this.ChangeAmounttxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "EmoneyAprovalAmountChangeForm";
            this.Text = "EmoneyAprovalAmountChange";
            this.Load += new System.EventHandler(this.EmoneyAprovalAmountChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeApprovalAmountCmd;
        private System.Windows.Forms.TextBox ChangeAmounttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}