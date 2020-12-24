namespace quizpandawinform
{
    partial class quizpanda
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
            this.textBoxkalimat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfirst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxsecond = new System.Windows.Forms.TextBox();
            this.buttonkonversi = new System.Windows.Forms.Button();
            this.labelhasil = new System.Windows.Forms.Label();
            this.labeloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan kalimat";
            // 
            // textBoxkalimat
            // 
            this.textBoxkalimat.Location = new System.Drawing.Point(111, 19);
            this.textBoxkalimat.Name = "textBoxkalimat";
            this.textBoxkalimat.Size = new System.Drawing.Size(344, 20);
            this.textBoxkalimat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masukkan huruf";
            // 
            // textBoxfirst
            // 
            this.textBoxfirst.Location = new System.Drawing.Point(111, 71);
            this.textBoxfirst.Name = "textBoxfirst";
            this.textBoxfirst.Size = new System.Drawing.Size(100, 20);
            this.textBoxfirst.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "menjadi";
            // 
            // textBoxsecond
            // 
            this.textBoxsecond.Location = new System.Drawing.Point(295, 71);
            this.textBoxsecond.Name = "textBoxsecond";
            this.textBoxsecond.Size = new System.Drawing.Size(100, 20);
            this.textBoxsecond.TabIndex = 5;
            // 
            // buttonkonversi
            // 
            this.buttonkonversi.Location = new System.Drawing.Point(111, 147);
            this.buttonkonversi.Name = "buttonkonversi";
            this.buttonkonversi.Size = new System.Drawing.Size(276, 23);
            this.buttonkonversi.TabIndex = 6;
            this.buttonkonversi.Text = "Konversi";
            this.buttonkonversi.UseVisualStyleBackColor = true;
            this.buttonkonversi.Click += new System.EventHandler(this.buttonkonversi_Click);
            // 
            // labelhasil
            // 
            this.labelhasil.AutoSize = true;
            this.labelhasil.Location = new System.Drawing.Point(12, 222);
            this.labelhasil.Name = "labelhasil";
            this.labelhasil.Size = new System.Drawing.Size(36, 13);
            this.labelhasil.TabIndex = 7;
            this.labelhasil.Text = "Hasil :";
            // 
            // labeloutput
            // 
            this.labeloutput.AutoSize = true;
            this.labeloutput.Location = new System.Drawing.Point(108, 222);
            this.labeloutput.Name = "labeloutput";
            this.labeloutput.Size = new System.Drawing.Size(39, 13);
            this.labeloutput.TabIndex = 8;
            this.labeloutput.Text = "Output";
            // 
            // quizpanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeloutput);
            this.Controls.Add(this.labelhasil);
            this.Controls.Add(this.buttonkonversi);
            this.Controls.Add(this.textBoxsecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxfirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxkalimat);
            this.Controls.Add(this.label1);
            this.Name = "quizpanda";
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxkalimat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxsecond;
        private System.Windows.Forms.Button buttonkonversi;
        private System.Windows.Forms.Label labelhasil;
        private System.Windows.Forms.Label labeloutput;
    }
}

