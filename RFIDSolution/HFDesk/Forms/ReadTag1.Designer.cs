namespace HFDesk
{
    partial class ReadTag1
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
            this.lrtxtLog = new CustomControl.LogRichTextBox();
            this.ckClearOperationRec = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btn_readTag = new System.Windows.Forms.Button();
            this.ivCurves1 = new CustomControl.IVCurves();
            this.tbx_SerialWrite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_prodtype = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_max_sys_voltage = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_polarity = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_cell_source = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_cell_mfg = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_iso14000_date = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_iso14000_name = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_iso9000_date = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_iso9000_name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_ff = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_celldate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_packdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_ipm = new System.Windows.Forms.TextBox();
            this.tbx_vpm = new System.Windows.Forms.TextBox();
            this.tbx_pmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lrtxtLog
            // 
            this.lrtxtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lrtxtLog.Location = new System.Drawing.Point(0, 559);
            this.lrtxtLog.Name = "lrtxtLog";
            this.lrtxtLog.Size = new System.Drawing.Size(1271, 132);
            this.lrtxtLog.TabIndex = 3;
            this.lrtxtLog.Text = "";
            // 
            // ckClearOperationRec
            // 
            this.ckClearOperationRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckClearOperationRec.AutoSize = true;
            this.ckClearOperationRec.Checked = true;
            this.ckClearOperationRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClearOperationRec.Location = new System.Drawing.Point(81, 530);
            this.ckClearOperationRec.Name = "ckClearOperationRec";
            this.ckClearOperationRec.Size = new System.Drawing.Size(72, 16);
            this.ckClearOperationRec.TabIndex = 23;
            this.ckClearOperationRec.Text = "自动清空";
            this.ckClearOperationRec.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 531);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 12);
            this.label35.TabIndex = 22;
            this.label35.Text = "操作记录:";
            // 
            // btn_readTag
            // 
            this.btn_readTag.Location = new System.Drawing.Point(533, 12);
            this.btn_readTag.Name = "btn_readTag";
            this.btn_readTag.Size = new System.Drawing.Size(75, 23);
            this.btn_readTag.TabIndex = 31;
            this.btn_readTag.Text = "读取";
            this.btn_readTag.UseVisualStyleBackColor = true;
            this.btn_readTag.Visible = false;
            this.btn_readTag.Click += new System.EventHandler(this.btn_readTag_Click);
            // 
            // ivCurves1
            // 
            this.ivCurves1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ivCurves1.Location = new System.Drawing.Point(161, 99);
            this.ivCurves1.Name = "ivCurves1";
            this.ivCurves1.Size = new System.Drawing.Size(330, 234);
            this.ivCurves1.TabIndex = 37;
            this.ivCurves1.Text = "ivCurves1";
            // 
            // tbx_SerialWrite
            // 
            this.tbx_SerialWrite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbx_SerialWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbx_SerialWrite.Font = new System.Drawing.Font("SimSun", 20F);
            this.tbx_SerialWrite.Location = new System.Drawing.Point(161, 52);
            this.tbx_SerialWrite.Name = "tbx_SerialWrite";
            this.tbx_SerialWrite.ReadOnly = true;
            this.tbx_SerialWrite.Size = new System.Drawing.Size(330, 38);
            this.tbx_SerialWrite.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "组件序列号";
            // 
            // tbx_prodtype
            // 
            this.tbx_prodtype.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbx_prodtype.BackColor = System.Drawing.Color.White;
            this.tbx_prodtype.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_prodtype.Location = new System.Drawing.Point(161, 389);
            this.tbx_prodtype.Name = "tbx_prodtype";
            this.tbx_prodtype.ReadOnly = true;
            this.tbx_prodtype.Size = new System.Drawing.Size(1009, 134);
            this.tbx_prodtype.TabIndex = 40;
            this.tbx_prodtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 39;
            this.label7.Text = "ProductType";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.txt_max_sys_voltage);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txt_polarity);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txt_cell_source);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txt_cell_mfg);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txt_iso14000_date);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txt_iso14000_name);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txt_iso9000_date);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_iso9000_name);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbx_ff);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbx_celldate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbx_packdate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbx_ipm);
            this.groupBox1.Controls.Add(this.tbx_vpm);
            this.groupBox1.Controls.Add(this.tbx_pmax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(655, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 351);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // txt_max_sys_voltage
            // 
            this.txt_max_sys_voltage.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txt_max_sys_voltage.Location = new System.Drawing.Point(124, 205);
            this.txt_max_sys_voltage.Name = "txt_max_sys_voltage";
            this.txt_max_sys_voltage.ReadOnly = true;
            this.txt_max_sys_voltage.Size = new System.Drawing.Size(110, 23);
            this.txt_max_sys_voltage.TabIndex = 66;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label24.Location = new System.Drawing.Point(38, 208);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 17);
            this.label24.TabIndex = 65;
            this.label24.Text = "最大系统电压";
            // 
            // txt_polarity
            // 
            this.txt_polarity.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txt_polarity.Location = new System.Drawing.Point(124, 169);
            this.txt_polarity.Name = "txt_polarity";
            this.txt_polarity.ReadOnly = true;
            this.txt_polarity.Size = new System.Drawing.Size(110, 23);
            this.txt_polarity.TabIndex = 64;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label23.Location = new System.Drawing.Point(62, 172);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 17);
            this.label23.TabIndex = 63;
            this.label23.Text = "终端极性";
            // 
            // txt_cell_source
            // 
            this.txt_cell_source.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txt_cell_source.Location = new System.Drawing.Point(399, 205);
            this.txt_cell_source.Name = "txt_cell_source";
            this.txt_cell_source.ReadOnly = true;
            this.txt_cell_source.Size = new System.Drawing.Size(110, 23);
            this.txt_cell_source.TabIndex = 62;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label22.Location = new System.Drawing.Point(329, 208);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 17);
            this.label22.TabIndex = 61;
            this.label22.Text = "电池产地";
            // 
            // txt_cell_mfg
            // 
            this.txt_cell_mfg.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txt_cell_mfg.Location = new System.Drawing.Point(399, 61);
            this.txt_cell_mfg.Name = "txt_cell_mfg";
            this.txt_cell_mfg.ReadOnly = true;
            this.txt_cell_mfg.Size = new System.Drawing.Size(110, 23);
            this.txt_cell_mfg.TabIndex = 60;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label21.Location = new System.Drawing.Point(329, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 17);
            this.label21.TabIndex = 59;
            this.label21.Text = "电池厂商";
            // 
            // txt_iso14000_date
            // 
            this.txt_iso14000_date.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txt_iso14000_date.Location = new System.Drawing.Point(124, 313);
            this.txt_iso14000_date.Name = "txt_iso14000_date";
            this.txt_iso14000_date.ReadOnly = true;
            this.txt_iso14000_date.Size = new System.Drawing.Size(110, 23);
            this.txt_iso14000_date.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(6, 316);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 17);
            this.label19.TabIndex = 57;
            this.label19.Text = "ISO14000证书日期";
            // 
            // txt_iso14000_name
            // 
            this.txt_iso14000_name.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txt_iso14000_name.Location = new System.Drawing.Point(399, 313);
            this.txt_iso14000_name.Name = "txt_iso14000_name";
            this.txt_iso14000_name.ReadOnly = true;
            this.txt_iso14000_name.Size = new System.Drawing.Size(110, 23);
            this.txt_iso14000_name.TabIndex = 56;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(281, 316);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 17);
            this.label20.TabIndex = 55;
            this.label20.Text = "ISO14000证书名称";
            // 
            // txt_iso9000_date
            // 
            this.txt_iso9000_date.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txt_iso9000_date.Location = new System.Drawing.Point(124, 277);
            this.txt_iso9000_date.Name = "txt_iso9000_date";
            this.txt_iso9000_date.ReadOnly = true;
            this.txt_iso9000_date.Size = new System.Drawing.Size(110, 23);
            this.txt_iso9000_date.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(13, 280);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 17);
            this.label18.TabIndex = 53;
            this.label18.Text = "ISO9000证书日期";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.textBox5.Location = new System.Drawing.Point(399, 169);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(110, 23);
            this.textBox5.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label15.Location = new System.Drawing.Point(329, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "组件产地";
            // 
            // txt_iso9000_name
            // 
            this.txt_iso9000_name.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txt_iso9000_name.Location = new System.Drawing.Point(399, 277);
            this.txt_iso9000_name.Name = "txt_iso9000_name";
            this.txt_iso9000_name.ReadOnly = true;
            this.txt_iso9000_name.Size = new System.Drawing.Size(110, 23);
            this.txt_iso9000_name.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(288, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = "ISO9000证书名称";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.textBox3.Location = new System.Drawing.Point(399, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(110, 23);
            this.textBox3.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label13.Location = new System.Drawing.Point(337, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "证书名称";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.textBox1.Location = new System.Drawing.Point(124, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label11.Location = new System.Drawing.Point(62, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "证书日期";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.textBox2.Location = new System.Drawing.Point(399, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(110, 23);
            this.textBox2.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label12.Location = new System.Drawing.Point(329, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "组件厂商";
            // 
            // tbx_ff
            // 
            this.tbx_ff.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.tbx_ff.Location = new System.Drawing.Point(124, 133);
            this.tbx_ff.Name = "tbx_ff";
            this.tbx_ff.ReadOnly = true;
            this.tbx_ff.Size = new System.Drawing.Size(110, 23);
            this.tbx_ff.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label10.Location = new System.Drawing.Point(79, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "FF(%)";
            // 
            // tbx_celldate
            // 
            this.tbx_celldate.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.tbx_celldate.Location = new System.Drawing.Point(399, 133);
            this.tbx_celldate.Name = "tbx_celldate";
            this.tbx_celldate.ReadOnly = true;
            this.tbx_celldate.Size = new System.Drawing.Size(110, 23);
            this.tbx_celldate.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label9.Location = new System.Drawing.Point(305, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "电池生产日期";
            // 
            // tbx_packdate
            // 
            this.tbx_packdate.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.tbx_packdate.Location = new System.Drawing.Point(399, 97);
            this.tbx_packdate.Name = "tbx_packdate";
            this.tbx_packdate.ReadOnly = true;
            this.tbx_packdate.Size = new System.Drawing.Size(110, 23);
            this.tbx_packdate.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label8.Location = new System.Drawing.Point(305, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "组件生产日期";
            // 
            // tbx_ipm
            // 
            this.tbx_ipm.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.tbx_ipm.Location = new System.Drawing.Point(124, 97);
            this.tbx_ipm.Name = "tbx_ipm";
            this.tbx_ipm.ReadOnly = true;
            this.tbx_ipm.Size = new System.Drawing.Size(110, 23);
            this.tbx_ipm.TabIndex = 32;
            // 
            // tbx_vpm
            // 
            this.tbx_vpm.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.tbx_vpm.Location = new System.Drawing.Point(124, 61);
            this.tbx_vpm.Name = "tbx_vpm";
            this.tbx_vpm.ReadOnly = true;
            this.tbx_vpm.Size = new System.Drawing.Size(110, 23);
            this.tbx_vpm.TabIndex = 31;
            // 
            // tbx_pmax
            // 
            this.tbx_pmax.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.tbx_pmax.Location = new System.Drawing.Point(124, 25);
            this.tbx_pmax.Name = "tbx_pmax";
            this.tbx_pmax.ReadOnly = true;
            this.tbx_pmax.Size = new System.Drawing.Size(110, 23);
            this.tbx_pmax.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label6.Location = new System.Drawing.Point(66, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Imax(A)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label5.Location = new System.Drawing.Point(62, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Vmax(V)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pmax(W)";
            // 
            // ReadTag1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 691);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ivCurves1);
            this.Controls.Add(this.tbx_SerialWrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_prodtype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_readTag);
            this.Controls.Add(this.ckClearOperationRec);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.lrtxtLog);
            this.Name = "ReadTag1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "读标签";
            this.Activated += new System.EventHandler(this.ReadTag1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReadTag1_FormClosing);
            this.Load += new System.EventHandler(this.ReadTag1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.LogRichTextBox lrtxtLog;
        private System.Windows.Forms.CheckBox ckClearOperationRec;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btn_readTag;
        private CustomControl.IVCurves ivCurves1;
        private System.Windows.Forms.TextBox tbx_SerialWrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_prodtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_max_sys_voltage;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_polarity;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_cell_source;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_cell_mfg;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_iso14000_date;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_iso14000_name;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_iso9000_date;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_iso9000_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbx_ff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_celldate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_packdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_ipm;
        private System.Windows.Forms.TextBox tbx_vpm;
        private System.Windows.Forms.TextBox tbx_pmax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}