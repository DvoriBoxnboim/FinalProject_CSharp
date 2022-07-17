namespace SearchApp
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
            this.lstbx_result = new System.Windows.Forms.ListBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.r_person = new System.Windows.Forms.RadioButton();
            this.r_car = new System.Windows.Forms.RadioButton();
            this.r_student = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_suffix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_flat = new System.Windows.Forms.Button();
            this.btn_deep = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tb_value1 = new System.Windows.Forms.TextBox();
            this.tb_value2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbx_result
            // 
            this.lstbx_result.FormattingEnabled = true;
            this.lstbx_result.ItemHeight = 16;
            this.lstbx_result.Location = new System.Drawing.Point(693, 58);
            this.lstbx_result.Name = "lstbx_result";
            this.lstbx_result.Size = new System.Drawing.Size(628, 420);
            this.lstbx_result.TabIndex = 0;
            this.lstbx_result.SelectedIndexChanged += new System.EventHandler(this.lstbx_result_SelectedIndexChanged);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(39, 38);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(235, 42);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "open directory";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // r_person
            // 
            this.r_person.AutoSize = true;
            this.r_person.Location = new System.Drawing.Point(24, 37);
            this.r_person.Name = "r_person";
            this.r_person.Size = new System.Drawing.Size(70, 20);
            this.r_person.TabIndex = 2;
            this.r_person.TabStop = true;
            this.r_person.Text = "person";
            this.r_person.UseVisualStyleBackColor = true;
            this.r_person.CheckedChanged += new System.EventHandler(this.r_person_CheckedChanged);
            // 
            // r_car
            // 
            this.r_car.AutoSize = true;
            this.r_car.Location = new System.Drawing.Point(24, 63);
            this.r_car.Name = "r_car";
            this.r_car.Size = new System.Drawing.Size(47, 20);
            this.r_car.TabIndex = 3;
            this.r_car.TabStop = true;
            this.r_car.Text = "car";
            this.r_car.UseVisualStyleBackColor = true;
            this.r_car.CheckedChanged += new System.EventHandler(this.r_car_CheckedChanged);
            // 
            // r_student
            // 
            this.r_student.AutoSize = true;
            this.r_student.Location = new System.Drawing.Point(24, 89);
            this.r_student.Name = "r_student";
            this.r_student.Size = new System.Drawing.Size(71, 20);
            this.r_student.TabIndex = 4;
            this.r_student.TabStop = true;
            this.r_student.Text = "student";
            this.r_student.UseVisualStyleBackColor = true;
            this.r_student.CheckedChanged += new System.EventHandler(this.r_student_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_student);
            this.groupBox1.Controls.Add(this.r_car);
            this.groupBox1.Controls.Add(this.r_person);
            this.groupBox1.Location = new System.Drawing.Point(40, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 140);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "choose an object";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_suffix
            // 
            this.tb_suffix.Location = new System.Drawing.Point(38, 398);
            this.tb_suffix.Multiline = true;
            this.tb_suffix.Name = "tb_suffix";
            this.tb_suffix.Size = new System.Drawing.Size(235, 121);
            this.tb_suffix.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "enter file ends";
            // 
            // btn_flat
            // 
            this.btn_flat.Location = new System.Drawing.Point(428, 113);
            this.btn_flat.Name = "btn_flat";
            this.btn_flat.Size = new System.Drawing.Size(144, 71);
            this.btn_flat.TabIndex = 8;
            this.btn_flat.Text = "flat search";
            this.btn_flat.UseVisualStyleBackColor = true;
            this.btn_flat.Click += new System.EventHandler(this.btn_flat_Click);
            // 
            // btn_deep
            // 
            this.btn_deep.Location = new System.Drawing.Point(428, 207);
            this.btn_deep.Name = "btn_deep";
            this.btn_deep.Size = new System.Drawing.Size(143, 77);
            this.btn_deep.TabIndex = 9;
            this.btn_deep.Text = "deep search";
            this.btn_deep.UseVisualStyleBackColor = true;
            this.btn_deep.Click += new System.EventHandler(this.btn_deep_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(428, 308);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(143, 113);
            this.btn_stop.TabIndex = 10;
            this.btn_stop.Text = "stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tb_value1
            // 
            this.tb_value1.Location = new System.Drawing.Point(40, 284);
            this.tb_value1.Name = "tb_value1";
            this.tb_value1.Size = new System.Drawing.Size(234, 22);
            this.tb_value1.TabIndex = 11;
            // 
            // tb_value2
            // 
            this.tb_value2.Location = new System.Drawing.Point(40, 334);
            this.tb_value2.Name = "tb_value2";
            this.tb_value2.Size = new System.Drawing.Size(234, 22);
            this.tb_value2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "value 1 to find";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "value 2 to find";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 557);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_value2);
            this.Controls.Add(this.tb_value1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_deep);
            this.Controls.Add(this.btn_flat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_suffix);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lstbx_result);
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_result;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.RadioButton r_person;
        private System.Windows.Forms.RadioButton r_car;
        private System.Windows.Forms.RadioButton r_student;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_suffix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_flat;
        private System.Windows.Forms.Button btn_deep;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox tb_value1;
        private System.Windows.Forms.TextBox tb_value2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

