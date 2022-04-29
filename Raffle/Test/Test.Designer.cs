namespace Raffle.Test
{
    partial class Test
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
            this.datagridviewRaffle = new System.Windows.Forms.DataGridView();
            this.btnSelectExcel = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridStudents = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.btnGoToRaffle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewRaffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewRaffle
            // 
            this.datagridviewRaffle.AllowUserToAddRows = false;
            this.datagridviewRaffle.AllowUserToDeleteRows = false;
            this.datagridviewRaffle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewRaffle.Location = new System.Drawing.Point(65, 41);
            this.datagridviewRaffle.Name = "datagridviewRaffle";
            this.datagridviewRaffle.RowTemplate.Height = 25;
            this.datagridviewRaffle.Size = new System.Drawing.Size(692, 307);
            this.datagridviewRaffle.TabIndex = 4;
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Location = new System.Drawing.Point(447, 370);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(114, 44);
            this.btnSelectExcel.TabIndex = 1;
            this.btnSelectExcel.Text = "Select excel file";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFileName.Location = new System.Drawing.Point(170, 370);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(261, 39);
            this.txtFileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "File name:";
            // 
            // datagridStudents
            // 
            this.datagridStudents.AllowUserToAddRows = false;
            this.datagridStudents.AllowUserToDeleteRows = false;
            this.datagridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.datagridStudents.Location = new System.Drawing.Point(65, 41);
            this.datagridStudents.Name = "datagridStudents";
            this.datagridStudents.RowTemplate.Height = 25;
            this.datagridStudents.Size = new System.Drawing.Size(692, 307);
            this.datagridStudents.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID NUMBER";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FIRS NAME";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "LAST NAME";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "COURSE";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "YEAR LEVEL";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CAMPUS";
            this.Column6.Name = "Column6";
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(621, 370);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(105, 44);
            this.btnSaveToDatabase.TabIndex = 6;
            this.btnSaveToDatabase.Text = "Save to Database";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // btnGoToRaffle
            // 
            this.btnGoToRaffle.Location = new System.Drawing.Point(713, 12);
            this.btnGoToRaffle.Name = "btnGoToRaffle";
            this.btnGoToRaffle.Size = new System.Drawing.Size(75, 23);
            this.btnGoToRaffle.TabIndex = 7;
            this.btnGoToRaffle.Text = "Go To Raffle";
            this.btnGoToRaffle.UseVisualStyleBackColor = true;
            this.btnGoToRaffle.Click += new System.EventHandler(this.btnGoToRaffle_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToRaffle);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.datagridStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSelectExcel);
            this.Controls.Add(this.datagridviewRaffle);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewRaffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagridviewRaffle;
        private Button btnSelectExcel;
        private TextBox txtFileName;
        private Label label1;
        private DataGridView datagridStudents;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnSaveToDatabase;
        private Button btnGoToRaffle;
    }
}