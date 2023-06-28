namespace L04_01
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
            this.btnGetSum = new System.Windows.Forms.Button();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetSum
            // 
            this.btnGetSum.Location = new System.Drawing.Point(265, 274);
            this.btnGetSum.Name = "btnGetSum";
            this.btnGetSum.Size = new System.Drawing.Size(146, 51);
            this.btnGetSum.TabIndex = 2;
            this.btnGetSum.Text = "Get Sum";
            this.btnGetSum.UseVisualStyleBackColor = true;
            this.btnGetSum.Click += new System.EventHandler(this.btnGetSum_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(126, 111);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(147, 25);
            this.lblFirst.TabIndex = 1;
            this.lblFirst.Text = "First Number :";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(126, 179);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(178, 25);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "Second Number :";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(347, 111);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(174, 31);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.Click += new System.EventHandler(this.txtFirst_Enter);
            this.txtFirst.Enter += new System.EventHandler(this.txtFirst_Enter);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(347, 179);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(174, 31);
            this.txtSecond.TabIndex = 1;
            this.txtSecond.Click += new System.EventHandler(this.txtSecond_Enter);
            this.txtSecond.Enter += new System.EventHandler(this.txtSecond_Enter);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSum.Location = new System.Drawing.Point(304, 354);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 25);
            this.lblSum.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 452);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.btnGetSum);
            this.Name = "Form1";
            this.Text = "Calculate Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSum;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label lblSum;
    }
}

