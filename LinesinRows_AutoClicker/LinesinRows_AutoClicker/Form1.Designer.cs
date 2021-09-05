
namespace LinesinRows_AutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxTiklaSayi = new System.Windows.Forms.TextBox();
            this.MaxTiklaCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxDefault = new System.Windows.Forms.CheckBox();
            this.checkBoxX2 = new System.Windows.Forms.CheckBox();
            this.checkBoxX3 = new System.Windows.Forms.CheckBox();
            this.textBox_TusAta = new System.Windows.Forms.TextBox();
            this.secTusaBas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Durum: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(63, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hazır";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "V5";
            // 
            // MaxTiklaSayi
            // 
            this.MaxTiklaSayi.BackColor = System.Drawing.SystemColors.Window;
            this.MaxTiklaSayi.Enabled = false;
            this.MaxTiklaSayi.Location = new System.Drawing.Point(196, 52);
            this.MaxTiklaSayi.Name = "MaxTiklaSayi";
            this.MaxTiklaSayi.Size = new System.Drawing.Size(100, 20);
            this.MaxTiklaSayi.TabIndex = 5;
            this.MaxTiklaSayi.TextChanged += new System.EventHandler(this.MaxTiklaSayi_TextChanged);
            // 
            // MaxTiklaCheck
            // 
            this.MaxTiklaCheck.AutoSize = true;
            this.MaxTiklaCheck.Location = new System.Drawing.Point(205, 29);
            this.MaxTiklaCheck.Name = "MaxTiklaCheck";
            this.MaxTiklaCheck.Size = new System.Drawing.Size(86, 17);
            this.MaxTiklaCheck.TabIndex = 6;
            this.MaxTiklaCheck.Text = "Max Tıklama";
            this.MaxTiklaCheck.UseVisualStyleBackColor = true;
            this.MaxTiklaCheck.CheckedChanged += new System.EventHandler(this.MaxTiklaCheck_CheckedChanged);
            // 
            // checkBoxDefault
            // 
            this.checkBoxDefault.AutoSize = true;
            this.checkBoxDefault.Checked = true;
            this.checkBoxDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDefault.Location = new System.Drawing.Point(43, 18);
            this.checkBoxDefault.Name = "checkBoxDefault";
            this.checkBoxDefault.Size = new System.Drawing.Size(76, 17);
            this.checkBoxDefault.TabIndex = 7;
            this.checkBoxDefault.Text = "X1 Default";
            this.checkBoxDefault.UseVisualStyleBackColor = true;
            this.checkBoxDefault.CheckedChanged += new System.EventHandler(this.checkBoxDefault_CheckedChanged);
            // 
            // checkBoxX2
            // 
            this.checkBoxX2.AutoSize = true;
            this.checkBoxX2.Location = new System.Drawing.Point(43, 42);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(69, 17);
            this.checkBoxX2.TabIndex = 8;
            this.checkBoxX2.Text = "X2 Boost";
            this.checkBoxX2.UseVisualStyleBackColor = true;
            this.checkBoxX2.CheckedChanged += new System.EventHandler(this.checkBoxX2_CheckedChanged);
            // 
            // checkBoxX3
            // 
            this.checkBoxX3.AutoSize = true;
            this.checkBoxX3.Location = new System.Drawing.Point(43, 66);
            this.checkBoxX3.Name = "checkBoxX3";
            this.checkBoxX3.Size = new System.Drawing.Size(91, 17);
            this.checkBoxX3.TabIndex = 9;
            this.checkBoxX3.Text = "X3 Overclock";
            this.checkBoxX3.UseVisualStyleBackColor = true;
            this.checkBoxX3.CheckedChanged += new System.EventHandler(this.checkBoxX3_CheckedChanged);
            // 
            // textBox_TusAta
            // 
            this.textBox_TusAta.Location = new System.Drawing.Point(127, 111);
            this.textBox_TusAta.Name = "textBox_TusAta";
            this.textBox_TusAta.Size = new System.Drawing.Size(100, 20);
            this.textBox_TusAta.TabIndex = 10;
            this.textBox_TusAta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_TusAta_KeyDown);
            // 
            // secTusaBas
            // 
            this.secTusaBas.AutoSize = true;
            this.secTusaBas.Location = new System.Drawing.Point(93, 114);
            this.secTusaBas.Name = "secTusaBas";
            this.secTusaBas.Size = new System.Drawing.Size(25, 13);
            this.secTusaBas.TabIndex = 11;
            this.secTusaBas.Text = "Key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(322, 172);
            this.Controls.Add(this.secTusaBas);
            this.Controls.Add(this.textBox_TusAta);
            this.Controls.Add(this.checkBoxX3);
            this.Controls.Add(this.checkBoxX2);
            this.Controls.Add(this.checkBoxDefault);
            this.Controls.Add(this.MaxTiklaCheck);
            this.Controls.Add(this.MaxTiklaSayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LinesinRows Auto Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxTiklaSayi;
        private System.Windows.Forms.CheckBox MaxTiklaCheck;
        private System.Windows.Forms.CheckBox checkBoxDefault;
        private System.Windows.Forms.CheckBox checkBoxX2;
        private System.Windows.Forms.CheckBox checkBoxX3;
        private System.Windows.Forms.TextBox textBox_TusAta;
        private System.Windows.Forms.Label secTusaBas;
    }
}

