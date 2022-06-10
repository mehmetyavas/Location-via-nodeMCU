namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBoxLineX = new System.Windows.Forms.TextBox();
            this.txtBoxLineY = new System.Windows.Forms.TextBox();
            this.lblPointX = new System.Windows.Forms.Label();
            this.lblPointY = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxPointX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPointY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxIP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.richTxtBoxRSSI2 = new System.Windows.Forms.RichTextBox();
            this.richTxtBoxRSSI1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAB = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxLineX
            // 
            this.txtBoxLineX.Location = new System.Drawing.Point(100, 54);
            this.txtBoxLineX.Name = "txtBoxLineX";
            this.txtBoxLineX.Size = new System.Drawing.Size(100, 22);
            this.txtBoxLineX.TabIndex = 17;
            this.txtBoxLineX.Text = "0";
            // 
            // txtBoxLineY
            // 
            this.txtBoxLineY.Location = new System.Drawing.Point(100, 91);
            this.txtBoxLineY.Name = "txtBoxLineY";
            this.txtBoxLineY.Size = new System.Drawing.Size(100, 22);
            this.txtBoxLineY.TabIndex = 18;
            this.txtBoxLineY.Text = "0";
            // 
            // lblPointX
            // 
            this.lblPointX.AutoSize = true;
            this.lblPointX.Location = new System.Drawing.Point(29, 57);
            this.lblPointX.Name = "lblPointX";
            this.lblPointX.Size = new System.Drawing.Size(64, 16);
            this.lblPointX.TabIndex = 19;
            this.lblPointX.Text = "X değeri=";
            // 
            // lblPointY
            // 
            this.lblPointY.AutoSize = true;
            this.lblPointY.Location = new System.Drawing.Point(29, 94);
            this.lblPointY.Name = "lblPointY";
            this.lblPointY.Size = new System.Drawing.Size(65, 16);
            this.lblPointY.TabIndex = 20;
            this.lblPointY.Text = "Y değeri=";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.Location = new System.Drawing.Point(846, 391);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(245, 59);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxLineX);
            this.groupBox1.Controls.Add(this.lblPointY);
            this.groupBox1.Controls.Add(this.txtBoxLineY);
            this.groupBox1.Controls.Add(this.lblPointX);
            this.groupBox1.Location = new System.Drawing.Point(846, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 137);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "En Boy Değeri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxPointX);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBoxPointY);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(846, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 141);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Noktanın Konumu";
            // 
            // txtBoxPointX
            // 
            this.txtBoxPointX.Location = new System.Drawing.Point(100, 54);
            this.txtBoxPointX.Name = "txtBoxPointX";
            this.txtBoxPointX.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPointX.TabIndex = 17;
            this.txtBoxPointX.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Y değeri=";
            // 
            // txtBoxPointY
            // 
            this.txtBoxPointY.Location = new System.Drawing.Point(100, 91);
            this.txtBoxPointY.Name = "txtBoxPointY";
            this.txtBoxPointY.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPointY.TabIndex = 18;
            this.txtBoxPointY.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "X değeri=";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(229, 821);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(20, 16);
            this.lblZ.TabIndex = 26;
            this.lblZ.Text = "z=";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(229, 761);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(21, 16);
            this.lblH.TabIndex = 25;
            this.lblH.Text = "h=";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(229, 789);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(22, 16);
            this.lblA.TabIndex = 24;
            this.lblA.Text = "a=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "IP adresi:";
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.Location = new System.Drawing.Point(75, 54);
            this.txtBoxIP.Name = "txtBoxIP";
            this.txtBoxIP.Size = new System.Drawing.Size(147, 22);
            this.txtBoxIP.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.richTxtBoxRSSI2);
            this.groupBox3.Controls.Add(this.richTxtBoxRSSI1);
            this.groupBox3.Controls.Add(this.txtBoxIP);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(846, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 283);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RSSI Verisi";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(75, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 23);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // richTxtBoxRSSI2
            // 
            this.richTxtBoxRSSI2.Location = new System.Drawing.Point(75, 206);
            this.richTxtBoxRSSI2.Name = "richTxtBoxRSSI2";
            this.richTxtBoxRSSI2.Size = new System.Drawing.Size(147, 61);
            this.richTxtBoxRSSI2.TabIndex = 21;
            this.richTxtBoxRSSI2.Text = "";
            // 
            // richTxtBoxRSSI1
            // 
            this.richTxtBoxRSSI1.Location = new System.Drawing.Point(75, 128);
            this.richTxtBoxRSSI1.Name = "richTxtBoxRSSI1";
            this.richTxtBoxRSSI1.Size = new System.Drawing.Size(147, 61);
            this.richTxtBoxRSSI1.TabIndex = 20;
            this.richTxtBoxRSSI1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAB
            // 
            this.lblAB.AutoSize = true;
            this.lblAB.Location = new System.Drawing.Point(614, 596);
            this.lblAB.Name = "lblAB";
            this.lblAB.Size = new System.Drawing.Size(30, 16);
            this.lblAB.TabIndex = 29;
            this.lblAB.Text = "ab=";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(403, 761);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 16);
            this.lblX.TabIndex = 30;
            this.lblX.Text = "x=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 859);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblAB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxLineX;
        private System.Windows.Forms.TextBox txtBoxLineY;
        private System.Windows.Forms.Label lblPointX;
        private System.Windows.Forms.Label lblPointY;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxPointX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPointY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTxtBoxRSSI2;
        private System.Windows.Forms.RichTextBox richTxtBoxRSSI1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAB;
        private System.Windows.Forms.Label lblX;
    }
}

