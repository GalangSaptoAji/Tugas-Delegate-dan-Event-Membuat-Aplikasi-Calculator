
namespace Aplikasi_Calculator
{
    partial class Calculator
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
            this.txtNilaiA = new System.Windows.Forms.Label();
            this.txtNilaiB = new System.Windows.Forms.Label();
            this.Opsi = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.prosesData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.AutoSize = true;
            this.txtNilaiA.Location = new System.Drawing.Point(24, 60);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(37, 13);
            this.txtNilaiA.TabIndex = 1;
            this.txtNilaiA.Text = "Nilai A";
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.AutoSize = true;
            this.txtNilaiB.Location = new System.Drawing.Point(24, 101);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(37, 13);
            this.txtNilaiB.TabIndex = 2;
            this.txtNilaiB.Text = "Nilai B";
            // 
            // Opsi
            // 
            this.Opsi.FormattingEnabled = true;
            this.Opsi.Location = new System.Drawing.Point(86, 18);
            this.Opsi.Name = "Opsi";
            this.Opsi.Size = new System.Drawing.Size(180, 21);
            this.Opsi.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 5;
            // 
            // prosesData
            // 
            this.prosesData.Location = new System.Drawing.Point(154, 137);
            this.prosesData.Name = "prosesData";
            this.prosesData.Size = new System.Drawing.Size(112, 27);
            this.prosesData.TabIndex = 6;
            this.prosesData.Text = "Proses";
            this.prosesData.UseVisualStyleBackColor = true;
            this.prosesData.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 192);
            this.Controls.Add(this.prosesData);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Opsi);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNilaiA;
        private System.Windows.Forms.Label txtNilaiB;
        private System.Windows.Forms.ComboBox Opsi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button prosesData;
    }
}