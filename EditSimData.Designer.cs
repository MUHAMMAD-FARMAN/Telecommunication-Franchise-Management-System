namespace Telecommunication_Franchise_Management_System
{
    partial class EditSimData
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
            this.BackCmd = new System.Windows.Forms.Button();
            this.UpdateSimCmd = new System.Windows.Forms.Button();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Numbertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Sim Data";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.BackCmd);
            this.panel1.Controls.Add(this.UpdateSimCmd);
            this.panel1.Controls.Add(this.Pricetxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TypeComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Numbertxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // BackCmd
            // 
            this.BackCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackCmd.Location = new System.Drawing.Point(633, 356);
            this.BackCmd.Name = "BackCmd";
            this.BackCmd.Size = new System.Drawing.Size(97, 32);
            this.BackCmd.TabIndex = 35;
            this.BackCmd.Text = "Back";
            this.BackCmd.UseVisualStyleBackColor = true;
            this.BackCmd.Click += new System.EventHandler(this.BackCmd_Click);
            // 
            // UpdateSimCmd
            // 
            this.UpdateSimCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateSimCmd.Location = new System.Drawing.Point(521, 356);
            this.UpdateSimCmd.Name = "UpdateSimCmd";
            this.UpdateSimCmd.Size = new System.Drawing.Size(97, 32);
            this.UpdateSimCmd.TabIndex = 34;
            this.UpdateSimCmd.Text = "Update";
            this.UpdateSimCmd.UseVisualStyleBackColor = true;
            this.UpdateSimCmd.Click += new System.EventHandler(this.UpdateSimCmd_Click);
            // 
            // Pricetxt
            // 
            this.Pricetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pricetxt.Location = new System.Drawing.Point(306, 264);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(204, 20);
            this.Pricetxt.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "Price :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Golden",
            "Prepaid",
            "Postpaid"});
            this.TypeComboBox.Location = new System.Drawing.Point(306, 210);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(204, 21);
            this.TypeComboBox.TabIndex = 31;
            this.TypeComboBox.Text = "Type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Type :";
            // 
            // Numbertxt
            // 
            this.Numbertxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Numbertxt.Location = new System.Drawing.Point(306, 160);
            this.Numbertxt.Name = "Numbertxt";
            this.Numbertxt.Size = new System.Drawing.Size(204, 20);
            this.Numbertxt.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Number :";
            // 
            // EditSimData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EditSimData";
            this.Text = "EditSimData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditSimData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numbertxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackCmd;
        private System.Windows.Forms.Button UpdateSimCmd;
    }
}