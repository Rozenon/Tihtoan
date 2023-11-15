namespace Tihtoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btcong = new System.Windows.Forms.Button();
            this.bttru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btchia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btchia);
            this.groupBox1.Controls.Add(this.btnnhan);
            this.groupBox1.Controls.Add(this.bttru);
            this.groupBox1.Controls.Add(this.btcong);
            this.groupBox1.Controls.Add(this.txtkq);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(175, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "So a:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(139, 59);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(206, 22);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(139, 116);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(206, 22);
            this.txtb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "So b :";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(139, 172);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(206, 22);
            this.txtkq.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ketqua:";
            // 
            // btcong
            // 
            this.btcong.Location = new System.Drawing.Point(104, 214);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(75, 23);
            this.btcong.TabIndex = 6;
            this.btcong.Text = "+";
            this.btcong.UseVisualStyleBackColor = true;
            this.btcong.Click += new System.EventHandler(this.btcong_Click);
            // 
            // bttru
            // 
            this.bttru.Location = new System.Drawing.Point(189, 215);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(75, 23);
            this.bttru.TabIndex = 7;
            this.bttru.Text = "-";
            this.bttru.UseVisualStyleBackColor = true;
            this.bttru.Click += new System.EventHandler(this.bttru_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(270, 214);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(75, 23);
            this.btnnhan.TabIndex = 8;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btchia
            // 
            this.btchia.Location = new System.Drawing.Point(351, 214);
            this.btchia.Name = "btchia";
            this.btchia.Size = new System.Drawing.Size(75, 23);
            this.btchia.TabIndex = 9;
            this.btchia.Text = "/";
            this.btchia.UseVisualStyleBackColor = true;
            this.btchia.Click += new System.EventHandler(this.btchia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btchia;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button bttru;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label1;
    }
}

