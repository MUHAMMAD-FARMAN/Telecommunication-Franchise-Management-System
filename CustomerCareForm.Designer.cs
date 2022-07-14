namespace Telecommunication_Franchise_Management_System
{
    partial class CustomerCareForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitCmd = new System.Windows.Forms.Button();
            this.ComplainTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Care Centre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubmitCmd);
            this.panel1.Controls.Add(this.ComplainTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 3;
            // 
            // SubmitCmd
            // 
            this.SubmitCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitCmd.Location = new System.Drawing.Point(435, 265);
            this.SubmitCmd.Name = "SubmitCmd";
            this.SubmitCmd.Size = new System.Drawing.Size(118, 40);
            this.SubmitCmd.TabIndex = 5;
            this.SubmitCmd.Text = "Submit";
            this.SubmitCmd.UseVisualStyleBackColor = true;
            this.SubmitCmd.Click += new System.EventHandler(this.SubmitCmd_Click);
            // 
            // ComplainTxt
            // 
            this.ComplainTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComplainTxt.Location = new System.Drawing.Point(299, 155);
            this.ComplainTxt.Name = "ComplainTxt";
            this.ComplainTxt.Size = new System.Drawing.Size(423, 20);
            this.ComplainTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Your Complain :";
            // 
            // CustomerCareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerCareForm";
            this.Text = "CustomerCareForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ComplainTxt;
        private System.Windows.Forms.Button SubmitCmd;
    }
}