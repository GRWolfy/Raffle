namespace Raffle.Test
{
    partial class Test2
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
            this.txtWinner = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtCongratulations = new System.Windows.Forms.TextBox();
            this.btnSelectWinner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWinner
            // 
            this.txtWinner.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWinner.Location = new System.Drawing.Point(121, 249);
            this.txtWinner.Name = "txtWinner";
            this.txtWinner.Size = new System.Drawing.Size(554, 61);
            this.txtWinner.TabIndex = 0;
            this.txtWinner.Text = " ";
            this.txtWinner.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(30, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCongratulations
            // 
            this.txtCongratulations.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCongratulations.Location = new System.Drawing.Point(92, 105);
            this.txtCongratulations.Name = "txtCongratulations";
            this.txtCongratulations.Size = new System.Drawing.Size(681, 96);
            this.txtCongratulations.TabIndex = 2;
            this.txtCongratulations.Text = "CONGRATULATIONS!";
            this.txtCongratulations.Visible = false;
            // 
            // btnSelectWinner
            // 
            this.btnSelectWinner.Location = new System.Drawing.Point(342, 348);
            this.btnSelectWinner.Name = "btnSelectWinner";
            this.btnSelectWinner.Size = new System.Drawing.Size(108, 28);
            this.btnSelectWinner.TabIndex = 3;
            this.btnSelectWinner.Text = "Select Winner";
            this.btnSelectWinner.UseVisualStyleBackColor = true;
            this.btnSelectWinner.Click += new System.EventHandler(this.btnSelectWinner_Click);
            // 
            // Test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectWinner);
            this.Controls.Add(this.txtCongratulations);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtWinner);
            this.Name = "Test2";
            this.Text = "Test2";
            this.Load += new System.EventHandler(this.Test2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtWinner;
        private Button btnBack;
        private TextBox txtCongratulations;
        private Button btnSelectWinner;
    }
}