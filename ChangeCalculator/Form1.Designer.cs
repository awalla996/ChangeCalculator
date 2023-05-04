
namespace ChangeCalculator
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
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.txtQuarters = new System.Windows.Forms.TextBox();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.txtNickels = new System.Windows.Forms.TextBox();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblQuarters = new System.Windows.Forms.Label();
            this.lblDimes = new System.Windows.Forms.Label();
            this.lblNickels = new System.Windows.Forms.Label();
            this.lblPennies = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(418, 43);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(100, 26);
            this.txtAmountDue.TabIndex = 0;
            this.txtAmountDue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmountDue_KeyDown);
            // 
            // txtQuarters
            // 
            this.txtQuarters.Location = new System.Drawing.Point(418, 124);
            this.txtQuarters.Name = "txtQuarters";
            this.txtQuarters.ReadOnly = true;
            this.txtQuarters.Size = new System.Drawing.Size(100, 26);
            this.txtQuarters.TabIndex = 1;
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(418, 165);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.ReadOnly = true;
            this.txtDimes.Size = new System.Drawing.Size(100, 26);
            this.txtDimes.TabIndex = 2;
            // 
            // txtNickels
            // 
            this.txtNickels.Location = new System.Drawing.Point(418, 206);
            this.txtNickels.Name = "txtNickels";
            this.txtNickels.ReadOnly = true;
            this.txtNickels.Size = new System.Drawing.Size(100, 26);
            this.txtNickels.TabIndex = 3;
            // 
            // txtPennies
            // 
            this.txtPennies.Location = new System.Drawing.Point(418, 252);
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.ReadOnly = true;
            this.txtPennies.Size = new System.Drawing.Size(100, 26);
            this.txtPennies.TabIndex = 4;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(173, 49);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(221, 20);
            this.lblAmountDue.TabIndex = 5;
            this.lblAmountDue.Text = "Amount of change due (0-99):";
            // 
            // lblQuarters
            // 
            this.lblQuarters.AutoSize = true;
            this.lblQuarters.Location = new System.Drawing.Point(343, 130);
            this.lblQuarters.Name = "lblQuarters";
            this.lblQuarters.Size = new System.Drawing.Size(75, 20);
            this.lblQuarters.TabIndex = 6;
            this.lblQuarters.Text = "Quarters:";
            // 
            // lblDimes
            // 
            this.lblDimes.AutoSize = true;
            this.lblDimes.Location = new System.Drawing.Point(354, 171);
            this.lblDimes.Name = "lblDimes";
            this.lblDimes.Size = new System.Drawing.Size(58, 20);
            this.lblDimes.TabIndex = 7;
            this.lblDimes.Text = "Dimes:";
            // 
            // lblNickels
            // 
            this.lblNickels.AutoSize = true;
            this.lblNickels.Location = new System.Drawing.Point(349, 212);
            this.lblNickels.Name = "lblNickels";
            this.lblNickels.Size = new System.Drawing.Size(63, 20);
            this.lblNickels.TabIndex = 8;
            this.lblNickels.Text = "Nickels:";
            // 
            // lblPennies
            // 
            this.lblPennies.AutoSize = true;
            this.lblPennies.Location = new System.Drawing.Point(342, 258);
            this.lblPennies.Name = "lblPennies";
            this.lblPennies.Size = new System.Drawing.Size(70, 20);
            this.lblPennies.TabIndex = 9;
            this.lblPennies.Text = "Pennies:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(191, 325);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 41);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(370, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPennies);
            this.Controls.Add(this.lblNickels);
            this.Controls.Add(this.lblDimes);
            this.Controls.Add(this.lblQuarters);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.txtNickels);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.txtQuarters);
            this.Controls.Add(this.txtAmountDue);
            this.Name = "Form1";
            this.Text = "Change Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.TextBox txtQuarters;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.TextBox txtNickels;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblQuarters;
        private System.Windows.Forms.Label lblDimes;
        private System.Windows.Forms.Label lblNickels;
        private System.Windows.Forms.Label lblPennies;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

