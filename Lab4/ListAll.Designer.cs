namespace Lab4
{
    partial class ListAll
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
            this.cbx = new System.Windows.Forms.ComboBox();
            this.lsv = new System.Windows.Forms.ListView();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cbxInput = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx
            // 
            this.cbx.FormattingEnabled = true;
            this.cbx.Items.AddRange(new object[] {
            "Products",
            "Suppliers",
            "Categories"});
            this.cbx.Location = new System.Drawing.Point(12, 12);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(232, 24);
            this.cbx.TabIndex = 7;
            this.cbx.SelectedIndexChanged += new System.EventHandler(this.cbx_SelectedIndexChanged);
            // 
            // lsv
            // 
            this.lsv.FullRowSelect = true;
            this.lsv.GridLines = true;
            this.lsv.HideSelection = false;
            this.lsv.Location = new System.Drawing.Point(12, 64);
            this.lsv.Name = "lsv";
            this.lsv.Size = new System.Drawing.Size(803, 400);
            this.lsv.TabIndex = 8;
            this.lsv.UseCompatibleStateImageBehavior = false;
            this.lsv.View = System.Windows.Forms.View.Details;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(92, 520);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(248, 22);
            this.txtInput.TabIndex = 9;
            // 
            // cbxInput
            // 
            this.cbxInput.FormattingEnabled = true;
            this.cbxInput.Items.AddRange(new object[] {
            "ProductName",
            "CompanyName"});
            this.cbxInput.Location = new System.Drawing.Point(425, 520);
            this.cbxInput.Name = "cbxInput";
            this.cbxInput.Size = new System.Drawing.Size(142, 24);
            this.cbxInput.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(625, 520);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(190, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // ListAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lsv);
            this.Controls.Add(this.cbx);
            this.Name = "ListAll";
            this.Text = "ListAll";
            this.Load += new System.EventHandler(this.ListAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.ListView lsv;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cbxInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}