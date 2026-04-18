namespace WindowsFormsApplication22
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
            this.media = new System.Windows.Forms.Button();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_e1 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_e1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // media
            // 
            this.media.Location = new System.Drawing.Point(107, 206);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(75, 23);
            this.media.TabIndex = 0;
            this.media.Text = "media";
            this.media.UseVisualStyleBackColor = true;
            this.media.Click += new System.EventHandler(this.soma_Click);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(141, 56);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 1;
            this.txt_b.Text = "20";
            this.txt_b.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(141, 23);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 20);
            this.txt_a.TabIndex = 2;
            this.txt_a.Text = "10";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(55, 30);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(55, 13);
            this.lbl_a.TabIndex = 3;
            this.lbl_a.Text = "Valor de a";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(55, 59);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(55, 13);
            this.lbl_b.TabIndex = 4;
            this.lbl_b.Text = "Valor de b";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(55, 93);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(55, 13);
            this.lbl_c.TabIndex = 5;
            this.lbl_c.Text = "Valor de c";
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Location = new System.Drawing.Point(55, 124);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(55, 13);
            this.lbl_d.TabIndex = 6;
            this.lbl_d.Text = "Valor de d";
            // 
            // lbl_e1
            // 
            this.lbl_e1.AutoSize = true;
            this.lbl_e1.Location = new System.Drawing.Point(55, 155);
            this.lbl_e1.Name = "lbl_e1";
            this.lbl_e1.Size = new System.Drawing.Size(61, 13);
            this.lbl_e1.TabIndex = 7;
            this.lbl_e1.Text = "Valor de e1";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(141, 93);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 20);
            this.txt_c.TabIndex = 8;
            this.txt_c.Text = "30";
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(141, 124);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(100, 20);
            this.txt_d.TabIndex = 9;
            this.txt_d.Text = "40";
            // 
            // txt_e1
            // 
            this.txt_e1.Location = new System.Drawing.Point(141, 155);
            this.txt_e1.Name = "txt_e1";
            this.txt_e1.Size = new System.Drawing.Size(100, 20);
            this.txt_e1.TabIndex = 10;
            this.txt_e1.Text = "50";
            this.txt_e1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_e1);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.lbl_e1);
            this.Controls.Add(this.lbl_d);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.media);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button media;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.Label lbl_e1;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_e1;
    }
}

