namespace WebExtractEntity
{
    partial class ExtractForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_rjChromeAno = new System.Windows.Forms.TextBox();
            this.tb_spChromeAno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_rjChrome = new System.Windows.Forms.Button();
            this.bt_spChrome = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_rjPhantomAno = new System.Windows.Forms.TextBox();
            this.tb_spPhantomAno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_rjPhantom = new System.Windows.Forms.Button();
            this.bt_spPhantom = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extração de Dados com Selenium Framework";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_rjChromeAno);
            this.groupBox1.Controls.Add(this.tb_spChromeAno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bt_rjChrome);
            this.groupBox1.Controls.Add(this.bt_spChrome);
            this.groupBox1.Location = new System.Drawing.Point(25, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chrome";
            // 
            // tb_rjChromeAno
            // 
            this.tb_rjChromeAno.Location = new System.Drawing.Point(123, 103);
            this.tb_rjChromeAno.MaxLength = 4;
            this.tb_rjChromeAno.Name = "tb_rjChromeAno";
            this.tb_rjChromeAno.Size = new System.Drawing.Size(52, 21);
            this.tb_rjChromeAno.TabIndex = 6;
            this.tb_rjChromeAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_spChromeAno
            // 
            this.tb_spChromeAno.Location = new System.Drawing.Point(123, 62);
            this.tb_spChromeAno.MaxLength = 4;
            this.tb_spChromeAno.Name = "tb_spChromeAno";
            this.tb_spChromeAno.Size = new System.Drawing.Size(52, 21);
            this.tb_spChromeAno.TabIndex = 5;
            this.tb_spChromeAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado";
            // 
            // bt_rjChrome
            // 
            this.bt_rjChrome.Location = new System.Drawing.Point(5, 102);
            this.bt_rjChrome.Name = "bt_rjChrome";
            this.bt_rjChrome.Size = new System.Drawing.Size(75, 23);
            this.bt_rjChrome.TabIndex = 1;
            this.bt_rjChrome.Text = "RJ";
            this.bt_rjChrome.UseVisualStyleBackColor = true;
            this.bt_rjChrome.Click += new System.EventHandler(this.bt_rjChrome_Click);
            // 
            // bt_spChrome
            // 
            this.bt_spChrome.Location = new System.Drawing.Point(5, 60);
            this.bt_spChrome.Name = "bt_spChrome";
            this.bt_spChrome.Size = new System.Drawing.Size(75, 23);
            this.bt_spChrome.TabIndex = 0;
            this.bt_spChrome.Text = "SP";
            this.bt_spChrome.UseVisualStyleBackColor = true;
            this.bt_spChrome.Click += new System.EventHandler(this.bt_spChrome_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_rjPhantomAno);
            this.groupBox2.Controls.Add(this.tb_spPhantomAno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bt_rjPhantom);
            this.groupBox2.Controls.Add(this.bt_spPhantom);
            this.groupBox2.Location = new System.Drawing.Point(244, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(200, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phantom";
            // 
            // tb_rjPhantomAno
            // 
            this.tb_rjPhantomAno.Location = new System.Drawing.Point(124, 103);
            this.tb_rjPhantomAno.MaxLength = 4;
            this.tb_rjPhantomAno.Name = "tb_rjPhantomAno";
            this.tb_rjPhantomAno.Size = new System.Drawing.Size(52, 21);
            this.tb_rjPhantomAno.TabIndex = 10;
            this.tb_rjPhantomAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_spPhantomAno
            // 
            this.tb_spPhantomAno.Location = new System.Drawing.Point(124, 62);
            this.tb_spPhantomAno.MaxLength = 4;
            this.tb_spPhantomAno.Name = "tb_spPhantomAno";
            this.tb_spPhantomAno.Size = new System.Drawing.Size(52, 21);
            this.tb_spPhantomAno.TabIndex = 9;
            this.tb_spPhantomAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estado";
            // 
            // bt_rjPhantom
            // 
            this.bt_rjPhantom.Location = new System.Drawing.Point(5, 102);
            this.bt_rjPhantom.Name = "bt_rjPhantom";
            this.bt_rjPhantom.Size = new System.Drawing.Size(75, 23);
            this.bt_rjPhantom.TabIndex = 2;
            this.bt_rjPhantom.Text = "RJ";
            this.bt_rjPhantom.UseVisualStyleBackColor = true;
            this.bt_rjPhantom.Click += new System.EventHandler(this.bt_rjPhantom_Click);
            // 
            // bt_spPhantom
            // 
            this.bt_spPhantom.Location = new System.Drawing.Point(5, 60);
            this.bt_spPhantom.Name = "bt_spPhantom";
            this.bt_spPhantom.Size = new System.Drawing.Size(75, 23);
            this.bt_spPhantom.TabIndex = 1;
            this.bt_spPhantom.Text = "SP";
            this.bt_spPhantom.UseVisualStyleBackColor = true;
            this.bt_spPhantom.Click += new System.EventHandler(this.bt_spPhantom_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(25, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 164);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(413, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // ExtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 402);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 255);
            this.Name = "ExtractForm";
            this.Text = "Extração de Dados com Selenium Framework";
            this.Load += new System.EventHandler(this.ExtractForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_rjChromeAno;
        private System.Windows.Forms.TextBox tb_spChromeAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_rjChrome;
        private System.Windows.Forms.Button bt_spChrome;
        private System.Windows.Forms.TextBox tb_rjPhantomAno;
        private System.Windows.Forms.TextBox tb_spPhantomAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_rjPhantom;
        private System.Windows.Forms.Button bt_spPhantom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}