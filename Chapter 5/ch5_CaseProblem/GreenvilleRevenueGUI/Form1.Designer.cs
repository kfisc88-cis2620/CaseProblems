namespace GreenvilleRevenueGUI
{
    partial class GreenvilleRevenueGUI
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
            this.components = new System.ComponentModel.Container();
            this.txtLastYear = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtThisYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.previousRevenueLabel = new System.Windows.Forms.Label();
            this.currentRevenueLabel = new System.Windows.Forms.Label();
            this.comparisonLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.competitionLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLastYear
            // 
            this.txtLastYear.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastYear.Location = new System.Drawing.Point(240, 67);
            this.txtLastYear.Name = "txtLastYear";
            this.txtLastYear.Size = new System.Drawing.Size(30, 23);
            this.txtLastYear.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtThisYear
            // 
            this.txtThisYear.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThisYear.Location = new System.Drawing.Point(240, 102);
            this.txtThisYear.Name = "txtThisYear";
            this.txtThisYear.Size = new System.Drawing.Size(30, 23);
            this.txtThisYear.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of contestants last year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of contestants this year:";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calculateButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(43, 153);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(72, 33);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // previousRevenueLabel
            // 
            this.previousRevenueLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousRevenueLabel.Location = new System.Drawing.Point(29, 252);
            this.previousRevenueLabel.Name = "previousRevenueLabel";
            this.previousRevenueLabel.Size = new System.Drawing.Size(539, 16);
            this.previousRevenueLabel.TabIndex = 6;
            // 
            // currentRevenueLabel
            // 
            this.currentRevenueLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRevenueLabel.Location = new System.Drawing.Point(29, 279);
            this.currentRevenueLabel.Name = "currentRevenueLabel";
            this.currentRevenueLabel.Size = new System.Drawing.Size(539, 16);
            this.currentRevenueLabel.TabIndex = 7;
            // 
            // comparisonLabel
            // 
            this.comparisonLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comparisonLabel.Location = new System.Drawing.Point(26, 318);
            this.comparisonLabel.Name = "comparisonLabel";
            this.comparisonLabel.Size = new System.Drawing.Size(542, 53);
            this.comparisonLabel.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ContextMenuStrip = this.contextMenuStrip1;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Greenville Revenue Calculator";
            // 
            // competitionLabel
            // 
            this.competitionLabel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.competitionLabel.Location = new System.Drawing.Point(29, 224);
            this.competitionLabel.Name = "competitionLabel";
            this.competitionLabel.Size = new System.Drawing.Size(539, 16);
            this.competitionLabel.TabIndex = 10;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(437, 77);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(35, 13);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "label3";
            // 
            // GreenvilleRevenueGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(606, 419);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.competitionLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comparisonLabel);
            this.Controls.Add(this.currentRevenueLabel);
            this.Controls.Add(this.previousRevenueLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThisYear);
            this.Controls.Add(this.txtLastYear);
            this.Name = "GreenvilleRevenueGUI";
            this.Text = "Greenville Revenue Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastYear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtThisYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label previousRevenueLabel;
        private System.Windows.Forms.Label currentRevenueLabel;
        private System.Windows.Forms.Label comparisonLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label competitionLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}

