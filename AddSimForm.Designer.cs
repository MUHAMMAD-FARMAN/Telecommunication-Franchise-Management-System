namespace Telecommunication_Franchise_Management_System
{
    partial class AddSimForm
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
            this.BackCmd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Numbertxt = new System.Windows.Forms.TextBox();
            this.AddWorkerCmd = new System.Windows.Forms.Button();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 34);
            this.label2.TabIndex = 28;
            this.label2.Text = "Add New Sim";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Number :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BackCmd
            // 
            this.BackCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackCmd.Location = new System.Drawing.Point(585, 379);
            this.BackCmd.Name = "BackCmd";
            this.BackCmd.Size = new System.Drawing.Size(97, 32);
            this.BackCmd.TabIndex = 25;
            this.BackCmd.Text = "Back";
            this.BackCmd.UseVisualStyleBackColor = true;
            this.BackCmd.Visible = false;
            this.BackCmd.Click += new System.EventHandler(this.BackCmd_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Price :";
            // 
            // Numbertxt
            // 
            this.Numbertxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Numbertxt.Location = new System.Drawing.Point(256, 154);
            this.Numbertxt.Name = "Numbertxt";
            this.Numbertxt.Size = new System.Drawing.Size(204, 20);
            this.Numbertxt.TabIndex = 26;
            // 
            // AddWorkerCmd
            // 
            this.AddWorkerCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddWorkerCmd.Location = new System.Drawing.Point(482, 379);
            this.AddWorkerCmd.Name = "AddWorkerCmd";
            this.AddWorkerCmd.Size = new System.Drawing.Size(97, 32);
            this.AddWorkerCmd.TabIndex = 23;
            this.AddWorkerCmd.Text = "Add";
            this.AddWorkerCmd.UseVisualStyleBackColor = true;
            this.AddWorkerCmd.Click += new System.EventHandler(this.AddWorkerCmd_Click);
            // 
            // Pricetxt
            // 
            this.Pricetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pricetxt.Location = new System.Drawing.Point(256, 254);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(204, 20);
            this.Pricetxt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Type :";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Golden",
            "Prepaid",
            "Postpaid"});
            this.TypeComboBox.Location = new System.Drawing.Point(256, 205);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(204, 21);
            this.TypeComboBox.TabIndex = 29;
            this.TypeComboBox.Text = "Type";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 30;
            // 
            // AddSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackCmd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Numbertxt);
            this.Controls.Add(this.AddWorkerCmd);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.panel1);
            this.Name = "AddSimForm";
            this.Text = "AddSimForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddSimForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackCmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Numbertxt;
        private System.Windows.Forms.Button AddWorkerCmd;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Panel panel1;
    }
}