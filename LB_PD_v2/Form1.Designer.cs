namespace LB_PD_v2
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
            this.precu_cena1 = new System.Windows.Forms.TextBox();
            this.precu_daudzums1 = new System.Windows.Forms.NumericUpDown();
            this.aprekinat_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nauda_amnt = new System.Windows.Forms.TextBox();
            this.precu_cena2 = new System.Windows.Forms.TextBox();
            this.precu_cena3 = new System.Windows.Forms.TextBox();
            this.precu_daudzums2 = new System.Windows.Forms.NumericUpDown();
            this.precu_daudzums3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.precu_nos1 = new System.Windows.Forms.TextBox();
            this.precu_nos2 = new System.Windows.Forms.TextBox();
            this.precu_nos3 = new System.Windows.Forms.TextBox();
            this.aprekini = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.precu_daudzums1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precu_daudzums2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precu_daudzums3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preču cenas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preču daudzums";
            // 
            // precu_cena1
            // 
            this.precu_cena1.Location = new System.Drawing.Point(243, 77);
            this.precu_cena1.Name = "precu_cena1";
            this.precu_cena1.Size = new System.Drawing.Size(100, 20);
            this.precu_cena1.TabIndex = 2;
            // 
            // precu_daudzums1
            // 
            this.precu_daudzums1.Location = new System.Drawing.Point(391, 77);
            this.precu_daudzums1.Name = "precu_daudzums1";
            this.precu_daudzums1.Size = new System.Drawing.Size(100, 20);
            this.precu_daudzums1.TabIndex = 3;
            // 
            // aprekinat_btn
            // 
            this.aprekinat_btn.Location = new System.Drawing.Point(532, 125);
            this.aprekinat_btn.Name = "aprekinat_btn";
            this.aprekinat_btn.Size = new System.Drawing.Size(75, 25);
            this.aprekinat_btn.TabIndex = 4;
            this.aprekinat_btn.Text = "Apreķināt";
            this.aprekinat_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cik Jums nauda ir makā?";
            // 
            // nauda_amnt
            // 
            this.nauda_amnt.Location = new System.Drawing.Point(532, 77);
            this.nauda_amnt.Name = "nauda_amnt";
            this.nauda_amnt.Size = new System.Drawing.Size(100, 20);
            this.nauda_amnt.TabIndex = 6;
            // 
            // precu_cena2
            // 
            this.precu_cena2.Location = new System.Drawing.Point(243, 103);
            this.precu_cena2.Name = "precu_cena2";
            this.precu_cena2.Size = new System.Drawing.Size(100, 20);
            this.precu_cena2.TabIndex = 7;
            this.precu_cena2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // precu_cena3
            // 
            this.precu_cena3.Location = new System.Drawing.Point(243, 129);
            this.precu_cena3.Name = "precu_cena3";
            this.precu_cena3.Size = new System.Drawing.Size(100, 20);
            this.precu_cena3.TabIndex = 8;
            // 
            // precu_daudzums2
            // 
            this.precu_daudzums2.Location = new System.Drawing.Point(391, 104);
            this.precu_daudzums2.Name = "precu_daudzums2";
            this.precu_daudzums2.Size = new System.Drawing.Size(100, 20);
            this.precu_daudzums2.TabIndex = 9;
            this.precu_daudzums2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // precu_daudzums3
            // 
            this.precu_daudzums3.Location = new System.Drawing.Point(391, 130);
            this.precu_daudzums3.Name = "precu_daudzums3";
            this.precu_daudzums3.Size = new System.Drawing.Size(100, 20);
            this.precu_daudzums3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preču nosaukums";
            // 
            // precu_nos1
            // 
            this.precu_nos1.Location = new System.Drawing.Point(115, 77);
            this.precu_nos1.Name = "precu_nos1";
            this.precu_nos1.Size = new System.Drawing.Size(100, 20);
            this.precu_nos1.TabIndex = 12;
            // 
            // precu_nos2
            // 
            this.precu_nos2.Location = new System.Drawing.Point(115, 104);
            this.precu_nos2.Name = "precu_nos2";
            this.precu_nos2.Size = new System.Drawing.Size(100, 20);
            this.precu_nos2.TabIndex = 13;
            // 
            // precu_nos3
            // 
            this.precu_nos3.Location = new System.Drawing.Point(115, 130);
            this.precu_nos3.Name = "precu_nos3";
            this.precu_nos3.Size = new System.Drawing.Size(100, 20);
            this.precu_nos3.TabIndex = 14;
            // 
            // aprekini
            // 
            this.aprekini.Location = new System.Drawing.Point(613, 129);
            this.aprekini.Name = "aprekini";
            this.aprekini.Size = new System.Drawing.Size(100, 20);
            this.aprekini.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aprekini);
            this.Controls.Add(this.precu_nos3);
            this.Controls.Add(this.precu_nos2);
            this.Controls.Add(this.precu_nos1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precu_daudzums3);
            this.Controls.Add(this.precu_daudzums2);
            this.Controls.Add(this.precu_cena3);
            this.Controls.Add(this.precu_cena2);
            this.Controls.Add(this.nauda_amnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aprekinat_btn);
            this.Controls.Add(this.precu_daudzums1);
            this.Controls.Add(this.precu_cena1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.precu_daudzums1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precu_daudzums2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precu_daudzums3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precu_cena1;
        private System.Windows.Forms.NumericUpDown precu_daudzums1;
        private System.Windows.Forms.Button aprekinat_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nauda_amnt;
        private System.Windows.Forms.TextBox precu_cena2;
        private System.Windows.Forms.TextBox precu_cena3;
        private System.Windows.Forms.NumericUpDown precu_daudzums2;
        private System.Windows.Forms.NumericUpDown precu_daudzums3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precu_nos1;
        private System.Windows.Forms.TextBox precu_nos2;
        private System.Windows.Forms.TextBox precu_nos3;
        private System.Windows.Forms.TextBox aprekini;
    }
}

