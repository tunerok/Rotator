namespace CamSharp
{
    partial class f_main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_res = new System.Windows.Forms.Label();
            this.Take_cap_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.tr_lvl_bin = new System.Windows.Forms.TrackBar();
            this.tr_level_dots = new System.Windows.Forms.TrackBar();
            this.tr_lvl_gov = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_inverted = new System.Windows.Forms.CheckBox();
            this.cb_channel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.up_inters = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.im_b_calc = new Emgu.CV.UI.ImageBox();
            this.imageBox5 = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.tr_del_sam = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.l_bin = new System.Windows.Forms.Label();
            this.l_floor = new System.Windows.Forms.Label();
            this.l_smooth = new System.Windows.Forms.Label();
            this.l_zoom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lfkmyjcnm = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_lvl_bin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_level_dots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_lvl_gov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_inters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_b_calc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_del_sam)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1.JPG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Видеовход";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Камера";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(62, 215);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "16:9 (512:288)",
            "4:3 (400:300)"});
            this.comboBox1.Location = new System.Drawing.Point(21, 496);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Change_res);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Разрешение";
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Location = new System.Drawing.Point(26, 520);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(116, 13);
            this.label_res.TabIndex = 11;
            this.label_res.Text = "Разрешение текущее";
            // 
            // Take_cap_btn
            // 
            this.Take_cap_btn.Location = new System.Drawing.Point(292, 212);
            this.Take_cap_btn.Name = "Take_cap_btn";
            this.Take_cap_btn.Size = new System.Drawing.Size(104, 23);
            this.Take_cap_btn.TabIndex = 13;
            this.Take_cap_btn.Text = "Захват теста";
            this.Take_cap_btn.UseVisualStyleBackColor = true;
            this.Take_cap_btn.Click += new System.EventHandler(this.Take_cap_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.Info;
            this.search_btn.Location = new System.Drawing.Point(292, 241);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(104, 23);
            this.search_btn.TabIndex = 14;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // tr_lvl_bin
            // 
            this.tr_lvl_bin.Location = new System.Drawing.Point(7, 283);
            this.tr_lvl_bin.Maximum = 250;
            this.tr_lvl_bin.Minimum = 1;
            this.tr_lvl_bin.Name = "tr_lvl_bin";
            this.tr_lvl_bin.Size = new System.Drawing.Size(173, 45);
            this.tr_lvl_bin.TabIndex = 15;
            this.tr_lvl_bin.TickFrequency = 10;
            this.tr_lvl_bin.Value = 1;
            // 
            // tr_level_dots
            // 
            this.tr_level_dots.Location = new System.Drawing.Point(7, 332);
            this.tr_level_dots.Maximum = 100;
            this.tr_level_dots.Minimum = 1;
            this.tr_level_dots.Name = "tr_level_dots";
            this.tr_level_dots.Size = new System.Drawing.Size(173, 45);
            this.tr_level_dots.TabIndex = 16;
            this.tr_level_dots.TickFrequency = 10;
            this.tr_level_dots.Value = 1;
            // 
            // tr_lvl_gov
            // 
            this.tr_lvl_gov.Location = new System.Drawing.Point(7, 383);
            this.tr_lvl_gov.Maximum = 25;
            this.tr_lvl_gov.Minimum = 1;
            this.tr_lvl_gov.Name = "tr_lvl_gov";
            this.tr_lvl_gov.Size = new System.Drawing.Size(173, 45);
            this.tr_lvl_gov.TabIndex = 18;
            this.tr_lvl_gov.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Порог бинаризации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Порог решения точки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Плавность функции";
            // 
            // chk_inverted
            // 
            this.chk_inverted.AutoSize = true;
            this.chk_inverted.Location = new System.Drawing.Point(461, 393);
            this.chk_inverted.Name = "chk_inverted";
            this.chk_inverted.Size = new System.Drawing.Size(104, 17);
            this.chk_inverted.TabIndex = 24;
            this.chk_inverted.Text = "Инвертировать";
            this.chk_inverted.UseVisualStyleBackColor = true;
            // 
            // cb_channel
            // 
            this.cb_channel.FormattingEnabled = true;
            this.cb_channel.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "All"});
            this.cb_channel.Location = new System.Drawing.Point(461, 434);
            this.cb_channel.Name = "cb_channel";
            this.cb_channel.Size = new System.Drawing.Size(121, 21);
            this.cb_channel.TabIndex = 25;
            this.cb_channel.SelectedIndexChanged += new System.EventHandler(this.cb_channel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Цветовой канал:";
            // 
            // up_inters
            // 
            this.up_inters.Location = new System.Drawing.Point(461, 485);
            this.up_inters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.up_inters.Name = "up_inters";
            this.up_inters.Size = new System.Drawing.Size(120, 20);
            this.up_inters.TabIndex = 30;
            this.up_inters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.up_inters.ValueChanged += new System.EventHandler(this.up_numb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Порядок кернель-матрицы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.text,
            this.value});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(235, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(217, 330);
            this.dataGridView1.TabIndex = 33;
            // 
            // text
            // 
            this.text.HeaderText = "Параметр";
            this.text.Name = "text";
            this.text.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "Значение";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // im_b_calc
            // 
            this.im_b_calc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.im_b_calc.Location = new System.Drawing.Point(681, 202);
            this.im_b_calc.MaximumSize = new System.Drawing.Size(217, 184);
            this.im_b_calc.Name = "im_b_calc";
            this.im_b_calc.Size = new System.Drawing.Size(217, 184);
            this.im_b_calc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.im_b_calc.TabIndex = 32;
            this.im_b_calc.TabStop = false;
            // 
            // imageBox5
            // 
            this.imageBox5.BackColor = System.Drawing.SystemColors.Control;
            this.imageBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox5.Location = new System.Drawing.Point(681, 12);
            this.imageBox5.MaximumSize = new System.Drawing.Size(217, 184);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(217, 184);
            this.imageBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox5.TabIndex = 28;
            this.imageBox5.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox4.Location = new System.Drawing.Point(458, 12);
            this.imageBox4.MaximumSize = new System.Drawing.Size(217, 184);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(217, 184);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox4.TabIndex = 27;
            this.imageBox4.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox3.Location = new System.Drawing.Point(458, 202);
            this.imageBox3.MaximumSize = new System.Drawing.Size(217, 184);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(217, 184);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox3.TabIndex = 2;
            this.imageBox3.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox2.Location = new System.Drawing.Point(235, 12);
            this.imageBox2.MaximumSize = new System.Drawing.Size(217, 184);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(217, 184);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.MaximumSize = new System.Drawing.Size(217, 184);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(217, 184);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // tr_del_sam
            // 
            this.tr_del_sam.Location = new System.Drawing.Point(7, 434);
            this.tr_del_sam.Maximum = 250;
            this.tr_del_sam.Minimum = 1;
            this.tr_del_sam.Name = "tr_del_sam";
            this.tr_del_sam.Size = new System.Drawing.Size(173, 45);
            this.tr_del_sam.TabIndex = 34;
            this.tr_del_sam.TickFrequency = 10;
            this.tr_del_sam.Value = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Приближение";
            // 
            // l_bin
            // 
            this.l_bin.AutoSize = true;
            this.l_bin.Location = new System.Drawing.Point(186, 283);
            this.l_bin.Name = "l_bin";
            this.l_bin.Size = new System.Drawing.Size(13, 13);
            this.l_bin.TabIndex = 36;
            this.l_bin.Text = "1";
            // 
            // l_floor
            // 
            this.l_floor.AutoSize = true;
            this.l_floor.Location = new System.Drawing.Point(186, 332);
            this.l_floor.Name = "l_floor";
            this.l_floor.Size = new System.Drawing.Size(13, 13);
            this.l_floor.TabIndex = 37;
            this.l_floor.Text = "1";
            // 
            // l_smooth
            // 
            this.l_smooth.AutoSize = true;
            this.l_smooth.Location = new System.Drawing.Point(186, 383);
            this.l_smooth.Name = "l_smooth";
            this.l_smooth.Size = new System.Drawing.Size(13, 13);
            this.l_smooth.TabIndex = 38;
            this.l_smooth.Text = "1";
            // 
            // l_zoom
            // 
            this.l_zoom.AutoSize = true;
            this.l_zoom.Location = new System.Drawing.Point(186, 434);
            this.l_zoom.Name = "l_zoom";
            this.l_zoom.Size = new System.Drawing.Size(13, 13);
            this.l_zoom.TabIndex = 39;
            this.l_zoom.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Угловое поле";
            // 
            // Lfkmyjcnm
            // 
            this.Lfkmyjcnm.AutoSize = true;
            this.Lfkmyjcnm.Location = new System.Drawing.Point(608, 466);
            this.Lfkmyjcnm.Name = "Lfkmyjcnm";
            this.Lfkmyjcnm.Size = new System.Drawing.Size(158, 13);
            this.Lfkmyjcnm.TabIndex = 41;
            this.Lfkmyjcnm.Text = "Расстояние до плоскости (м.)";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(613, 434);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 20);
            this.textBox_b.TabIndex = 42;
            this.textBox_b.Text = "56";
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(611, 485);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 20);
            this.textBox_h.TabIndex = 43;
            this.textBox_h.Text = "3";
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 612);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.Lfkmyjcnm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l_zoom);
            this.Controls.Add(this.l_smooth);
            this.Controls.Add(this.l_floor);
            this.Controls.Add(this.l_bin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tr_del_sam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.im_b_calc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.up_inters);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.imageBox5);
            this.Controls.Add(this.imageBox4);
            this.Controls.Add(this.cb_channel);
            this.Controls.Add(this.chk_inverted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tr_lvl_gov);
            this.Controls.Add(this.tr_level_dots);
            this.Controls.Add(this.tr_lvl_bin);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.Take_cap_btn);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_res);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "f_main";
            this.Text = "Посадка БПЛА";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_lvl_bin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_level_dots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_lvl_gov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_inters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_b_calc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_del_sam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_res;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button Take_cap_btn;
        private Emgu.CV.UI.ImageBox imageBox3;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TrackBar tr_lvl_bin;
        private System.Windows.Forms.TrackBar tr_level_dots;
        private System.Windows.Forms.TrackBar tr_lvl_gov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_inverted;
        private System.Windows.Forms.ComboBox cb_channel;
        private Emgu.CV.UI.ImageBox imageBox4;
        private Emgu.CV.UI.ImageBox imageBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown up_inters;
        private System.Windows.Forms.Label label8;
        private Emgu.CV.UI.ImageBox im_b_calc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.TrackBar tr_del_sam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label l_bin;
        private System.Windows.Forms.Label l_floor;
        private System.Windows.Forms.Label l_smooth;
        private System.Windows.Forms.Label l_zoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lfkmyjcnm;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_h;
    }
}

