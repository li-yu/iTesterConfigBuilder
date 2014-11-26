namespace Test
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_imageversion = new System.Windows.Forms.TextBox();
            this.textBox_imei = new System.Windows.Forms.TextBox();
            this.textBox_btmac = new System.Windows.Forms.TextBox();
            this.textBox_wifimac = new System.Windows.Forms.TextBox();
            this.textBox_wifiPW = new System.Windows.Forms.TextBox();
            this.textBox_wifiSSID = new System.Windows.Forms.TextBox();
            this.textBox_externalSD = new System.Windows.Forms.TextBox();
            this.textBox_language = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowDrop = true;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 16);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(384, 279);
            this.dgv.TabIndex = 1;
            this.dgv.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            this.dgv.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseMove);
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgv_DragDrop);
            this.dgv.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgv_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_imageversion);
            this.groupBox1.Controls.Add(this.textBox_imei);
            this.groupBox1.Controls.Add(this.textBox_btmac);
            this.groupBox1.Controls.Add(this.textBox_wifimac);
            this.groupBox1.Controls.Add(this.textBox_wifiPW);
            this.groupBox1.Controls.Add(this.textBox_wifiSSID);
            this.groupBox1.Controls.Add(this.textBox_externalSD);
            this.groupBox1.Controls.Add(this.textBox_language);
            this.groupBox1.Location = new System.Drawing.Point(414, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 248);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本参数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "ImageVersion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "IMEIStart";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "BTAddressStart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "WiFiAddressStart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "WiFiPassWord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "WiFiSSID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "ExternalSDPath";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Language";
            // 
            // textBox_imageversion
            // 
            this.textBox_imageversion.Location = new System.Drawing.Point(113, 209);
            this.textBox_imageversion.Name = "textBox_imageversion";
            this.textBox_imageversion.Size = new System.Drawing.Size(207, 21);
            this.textBox_imageversion.TabIndex = 7;
            // 
            // textBox_imei
            // 
            this.textBox_imei.Location = new System.Drawing.Point(113, 182);
            this.textBox_imei.Name = "textBox_imei";
            this.textBox_imei.Size = new System.Drawing.Size(207, 21);
            this.textBox_imei.TabIndex = 6;
            // 
            // textBox_btmac
            // 
            this.textBox_btmac.Location = new System.Drawing.Point(113, 155);
            this.textBox_btmac.Name = "textBox_btmac";
            this.textBox_btmac.Size = new System.Drawing.Size(207, 21);
            this.textBox_btmac.TabIndex = 5;
            // 
            // textBox_wifimac
            // 
            this.textBox_wifimac.Location = new System.Drawing.Point(113, 128);
            this.textBox_wifimac.Name = "textBox_wifimac";
            this.textBox_wifimac.Size = new System.Drawing.Size(207, 21);
            this.textBox_wifimac.TabIndex = 4;
            // 
            // textBox_wifiPW
            // 
            this.textBox_wifiPW.Location = new System.Drawing.Point(112, 101);
            this.textBox_wifiPW.Name = "textBox_wifiPW";
            this.textBox_wifiPW.Size = new System.Drawing.Size(208, 21);
            this.textBox_wifiPW.TabIndex = 3;
            // 
            // textBox_wifiSSID
            // 
            this.textBox_wifiSSID.Location = new System.Drawing.Point(112, 74);
            this.textBox_wifiSSID.Name = "textBox_wifiSSID";
            this.textBox_wifiSSID.Size = new System.Drawing.Size(208, 21);
            this.textBox_wifiSSID.TabIndex = 2;
            // 
            // textBox_externalSD
            // 
            this.textBox_externalSD.Location = new System.Drawing.Point(112, 47);
            this.textBox_externalSD.Name = "textBox_externalSD";
            this.textBox_externalSD.Size = new System.Drawing.Size(208, 21);
            this.textBox_externalSD.TabIndex = 1;
            // 
            // textBox_language
            // 
            this.textBox_language.Location = new System.Drawing.Point(112, 20);
            this.textBox_language.Name = "textBox_language";
            this.textBox_language.Size = new System.Drawing.Size(208, 21);
            this.textBox_language.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 301);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试项目";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 47);
            this.button1.TabIndex = 22;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "Designed by LiYu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "v1.0.0 20141126";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 325);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTesterConfigBuilder";
            this.Load += new System.EventHandler(this.FrmDGVRowMove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_imageversion;
        private System.Windows.Forms.TextBox textBox_imei;
        private System.Windows.Forms.TextBox textBox_btmac;
        private System.Windows.Forms.TextBox textBox_wifimac;
        private System.Windows.Forms.TextBox textBox_wifiPW;
        private System.Windows.Forms.TextBox textBox_wifiSSID;
        private System.Windows.Forms.TextBox textBox_externalSD;
        private System.Windows.Forms.TextBox textBox_language;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}