namespace PRIME_WHEN_INPUT
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbFactors = new System.Windows.Forms.Label();
            this.txtFactors = new System.Windows.Forms.TextBox();
            this.rtxtFactors = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(38, 81);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(714, 52);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum.Location = new System.Drawing.Point(31, 27);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(268, 37);
            this.lbNum.TabIndex = 1;
            this.lbNum.Tag = "";
            this.lbNum.Text = "TYPE NUMBER:";
            // 
            // lbFactors
            // 
            this.lbFactors.AutoSize = true;
            this.lbFactors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFactors.Location = new System.Drawing.Point(31, 192);
            this.lbFactors.Name = "lbFactors";
            this.lbFactors.Size = new System.Drawing.Size(412, 37);
            this.lbFactors.TabIndex = 3;
            this.lbFactors.Tag = "";
            this.lbFactors.Text = "PRIME FACTORIZATION:";
            // 
            // txtFactors
            // 
            this.txtFactors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactors.Location = new System.Drawing.Point(38, 245);
            this.txtFactors.Multiline = true;
            this.txtFactors.Name = "txtFactors";
            this.txtFactors.Size = new System.Drawing.Size(714, 52);
            this.txtFactors.TabIndex = 2;
            this.txtFactors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtxtFactors
            // 
            this.rtxtFactors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtFactors.Location = new System.Drawing.Point(38, 317);
            this.rtxtFactors.Name = "rtxtFactors";
            this.rtxtFactors.Size = new System.Drawing.Size(714, 56);
            this.rtxtFactors.TabIndex = 4;
            this.rtxtFactors.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtFactors);
            this.Controls.Add(this.lbFactors);
            this.Controls.Add(this.txtFactors);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbFactors;
        private System.Windows.Forms.TextBox txtFactors;
        private System.Windows.Forms.RichTextBox rtxtFactors;
    }
}

