namespace Telecommunication_Franchise_Management_System
{
    partial class CustomerEmoneyForm
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
            this.Rechargelbl = new System.Windows.Forms.Button();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rechargelbl
            // 
            this.Rechargelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rechargelbl.Location = new System.Drawing.Point(374, 230);
            this.Rechargelbl.Name = "Rechargelbl";
            this.Rechargelbl.Size = new System.Drawing.Size(97, 36);
            this.Rechargelbl.TabIndex = 5;
            this.Rechargelbl.Text = "Recharge";
            this.Rechargelbl.UseVisualStyleBackColor = true;
            this.Rechargelbl.Click += new System.EventHandler(this.Rechargelbl_Click);
            // 
            // Balancelbl
            // 
            this.Balancelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Balancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.Location = new System.Drawing.Point(414, 120);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(161, 33);
            this.Balancelbl.TabIndex = 4;
            this.Balancelbl.Text = "Balance";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Emoney Balance :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Balancelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 6;
            // 
            // CustomerEmoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rechargelbl);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerEmoneyForm";
            this.Text = "CustomerEmoneyForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerEmoneyForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rechargelbl;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}