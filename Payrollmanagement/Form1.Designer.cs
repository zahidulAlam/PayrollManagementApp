namespace Payrollmanagement
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
            this.employeeIDtextBox = new System.Windows.Forms.TextBox();
            this.employeeNametextBox = new System.Windows.Forms.TextBox();
            this.BasicSalarytextBox = new System.Windows.Forms.TextBox();
            this.insertbutton = new System.Windows.Forms.Button();
            this.payrolldataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaybutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.payrolldataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Basic Salary";
            // 
            // employeeIDtextBox
            // 
            this.employeeIDtextBox.Location = new System.Drawing.Point(120, 33);
            this.employeeIDtextBox.Name = "employeeIDtextBox";
            this.employeeIDtextBox.Size = new System.Drawing.Size(95, 20);
            this.employeeIDtextBox.TabIndex = 1;
            // 
            // employeeNametextBox
            // 
            this.employeeNametextBox.Location = new System.Drawing.Point(121, 63);
            this.employeeNametextBox.Name = "employeeNametextBox";
            this.employeeNametextBox.Size = new System.Drawing.Size(94, 20);
            this.employeeNametextBox.TabIndex = 2;
            // 
            // BasicSalarytextBox
            // 
            this.BasicSalarytextBox.Location = new System.Drawing.Point(120, 94);
            this.BasicSalarytextBox.Name = "BasicSalarytextBox";
            this.BasicSalarytextBox.Size = new System.Drawing.Size(94, 20);
            this.BasicSalarytextBox.TabIndex = 3;
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(69, 148);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(114, 29);
            this.insertbutton.TabIndex = 4;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // payrolldataGridView
            // 
            this.payrolldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payrolldataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.payrolldataGridView.Location = new System.Drawing.Point(280, 33);
            this.payrolldataGridView.Name = "payrolldataGridView";
            this.payrolldataGridView.Size = new System.Drawing.Size(743, 144);
            this.payrolldataGridView.TabIndex = 5;
            this.payrolldataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Employee Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Basic Salary";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "House Rant";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Medical";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tax";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Salary";
            this.Column7.Name = "Column7";
            // 
            // displaybutton
            // 
            this.displaybutton.Location = new System.Drawing.Point(69, 205);
            this.displaybutton.Name = "displaybutton";
            this.displaybutton.Size = new System.Drawing.Size(114, 30);
            this.displaybutton.TabIndex = 6;
            this.displaybutton.Text = "Display";
            this.displaybutton.UseVisualStyleBackColor = true;
            this.displaybutton.Click += new System.EventHandler(this.displaybutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 288);
            this.Controls.Add(this.displaybutton);
            this.Controls.Add(this.payrolldataGridView);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.BasicSalarytextBox);
            this.Controls.Add(this.employeeNametextBox);
            this.Controls.Add(this.employeeIDtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Payroll Management";
            ((System.ComponentModel.ISupportInitialize)(this.payrolldataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeIDtextBox;
        private System.Windows.Forms.TextBox employeeNametextBox;
        private System.Windows.Forms.TextBox BasicSalarytextBox;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.DataGridView payrolldataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button displaybutton;

    }
}

