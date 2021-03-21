namespace Lab3TV
{
    partial class UocBoi
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
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBCNN = new System.Windows.Forms.RadioButton();
            this.rdUCLN = new System.Windows.Forms.RadioButton();
            this.btThoat = new System.Windows.Forms.Button();
            this.btBoqua = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grChontim = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grChontim.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(88, 61);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(257, 22);
            this.txtB.TabIndex = 2;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(88, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(257, 22);
            this.txtA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "A:";
            // 
            // rdBCNN
            // 
            this.rdBCNN.AutoSize = true;
            this.rdBCNN.Location = new System.Drawing.Point(65, 62);
            this.rdBCNN.Name = "rdBCNN";
            this.rdBCNN.Size = new System.Drawing.Size(67, 21);
            this.rdBCNN.TabIndex = 0;
            this.rdBCNN.Text = "BCNN";
            this.rdBCNN.UseVisualStyleBackColor = true;
            // 
            // rdUCLN
            // 
            this.rdUCLN.AutoSize = true;
            this.rdUCLN.Checked = true;
            this.rdUCLN.Location = new System.Drawing.Point(66, 25);
            this.rdUCLN.Name = "rdUCLN";
            this.rdUCLN.Size = new System.Drawing.Size(66, 21);
            this.rdUCLN.TabIndex = 0;
            this.rdUCLN.TabStop = true;
            this.rdUCLN.Text = "UCLN";
            this.rdUCLN.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(449, 100);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(264, 100);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(75, 23);
            this.btBoqua.TabIndex = 0;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(76, 100);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 0;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txtKetqua
            // 
            this.txtKetqua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtKetqua.Location = new System.Drawing.Point(109, 42);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.ReadOnly = true;
            this.txtKetqua.Size = new System.Drawing.Size(450, 22);
            this.txtKetqua.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // grChontim
            // 
            this.grChontim.Controls.Add(this.rdBCNN);
            this.grChontim.Controls.Add(this.rdUCLN);
            this.grChontim.Location = new System.Drawing.Point(463, 26);
            this.grChontim.Name = "grChontim";
            this.grChontim.Size = new System.Drawing.Size(200, 117);
            this.grChontim.TabIndex = 2;
            this.grChontim.TabStop = false;
            this.grChontim.Text = "Chọn tìm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btThoat);
            this.groupBox3.Controls.Add(this.txtKetqua);
            this.groupBox3.Controls.Add(this.btBoqua);
            this.groupBox3.Controls.Add(this.btTim);
            this.groupBox3.Location = new System.Drawing.Point(23, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 165);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả:";
            // 
            // UocBoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 362);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grChontim);
            this.Controls.Add(this.groupBox1);
            this.Name = "UocBoi";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grChontim.ResumeLayout(false);
            this.grChontim.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBCNN;
        private System.Windows.Forms.RadioButton rdUCLN;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btBoqua;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grChontim;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}