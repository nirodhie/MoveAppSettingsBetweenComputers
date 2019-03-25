namespace MoveAppSettingsBetweenComputers
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newComputer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oldComputer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.proceedButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "You";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(64, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "NEED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "to have local administrator access on both machines for this to work!!!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.userAccount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.newComputer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.oldComputer);
            this.groupBox1.Location = new System.Drawing.Point(16, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine names";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(359, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "<- name of the account of the user whose data we need";
            // 
            // userAccount
            // 
            this.userAccount.Location = new System.Drawing.Point(6, 77);
            this.userAccount.Name = "userAccount";
            this.userAccount.Size = new System.Drawing.Size(214, 22);
            this.userAccount.TabIndex = 4;
            this.userAccount.TextChanged += new System.EventHandler(this.userAccount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "<- name of a computer you want to copy data TO";
            // 
            // newComputer
            // 
            this.newComputer.Location = new System.Drawing.Point(6, 49);
            this.newComputer.Name = "newComputer";
            this.newComputer.Size = new System.Drawing.Size(214, 22);
            this.newComputer.TabIndex = 2;
            this.newComputer.TextChanged += new System.EventHandler(this.newComputer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "<- name of a computer you want to copy data FROM";
            // 
            // oldComputer
            // 
            this.oldComputer.Location = new System.Drawing.Point(6, 21);
            this.oldComputer.Name = "oldComputer";
            this.oldComputer.Size = new System.Drawing.Size(214, 22);
            this.oldComputer.TabIndex = 0;
            this.oldComputer.TextChanged += new System.EventHandler(this.oldComputer_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.proceedButton);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(16, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 289);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Software settings to copy";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 105);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(98, 21);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 77);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(126, 21);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "OneNote notes";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(265, 260);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(86, 23);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(203, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Avaya OneX Communicator";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Google Chrome";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(630, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Move Application Settings Between Computers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newComputer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oldComputer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

