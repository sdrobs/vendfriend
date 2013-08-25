namespace windowHandler
{
    partial class GUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.plabel0 = new System.Windows.Forms.Label();
            this.plabel1 = new System.Windows.Forms.Label();
            this.plabel5 = new System.Windows.Forms.Label();
            this.plabel4 = new System.Windows.Forms.Label();
            this.plabel3 = new System.Windows.Forms.Label();
            this.plabel2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(265, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Window URL:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(2, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(95, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 21);
            this.button7.TabIndex = 5;
            this.button7.Text = "Select Region";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button7_MouseDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(71, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 21);
            this.button3.TabIndex = 13;
            this.button3.Text = "Choose Item Data Source:";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ItemData_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(6, 433);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(274, 20);
            this.textBox9.TabIndex = 14;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(39, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 22);
            this.button4.TabIndex = 15;
            this.button4.Text = "Pop Out Grid";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // plabel0
            // 
            this.plabel0.AutoSize = true;
            this.plabel0.BackColor = System.Drawing.Color.Transparent;
            this.plabel0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plabel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plabel0.Location = new System.Drawing.Point(3, 9);
            this.plabel0.MaximumSize = new System.Drawing.Size(98, 34);
            this.plabel0.MinimumSize = new System.Drawing.Size(98, 34);
            this.plabel0.Name = "plabel0";
            this.plabel0.Size = new System.Drawing.Size(98, 34);
            this.plabel0.TabIndex = 16;
            this.plabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plabel1
            // 
            this.plabel1.AutoSize = true;
            this.plabel1.BackColor = System.Drawing.Color.Transparent;
            this.plabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plabel1.Location = new System.Drawing.Point(3, 42);
            this.plabel1.MaximumSize = new System.Drawing.Size(98, 32);
            this.plabel1.MinimumSize = new System.Drawing.Size(98, 32);
            this.plabel1.Name = "plabel1";
            this.plabel1.Size = new System.Drawing.Size(98, 32);
            this.plabel1.TabIndex = 21;
            this.plabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plabel5
            // 
            this.plabel5.AutoSize = true;
            this.plabel5.BackColor = System.Drawing.Color.Transparent;
            this.plabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plabel5.Location = new System.Drawing.Point(3, 166);
            this.plabel5.MaximumSize = new System.Drawing.Size(98, 32);
            this.plabel5.MinimumSize = new System.Drawing.Size(98, 32);
            this.plabel5.Name = "plabel5";
            this.plabel5.Size = new System.Drawing.Size(98, 32);
            this.plabel5.TabIndex = 22;
            this.plabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plabel4
            // 
            this.plabel4.AutoSize = true;
            this.plabel4.BackColor = System.Drawing.Color.Transparent;
            this.plabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plabel4.Location = new System.Drawing.Point(3, 135);
            this.plabel4.MaximumSize = new System.Drawing.Size(98, 32);
            this.plabel4.MinimumSize = new System.Drawing.Size(98, 32);
            this.plabel4.Name = "plabel4";
            this.plabel4.Size = new System.Drawing.Size(98, 32);
            this.plabel4.TabIndex = 23;
            this.plabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plabel3
            // 
            this.plabel3.AutoSize = true;
            this.plabel3.BackColor = System.Drawing.Color.Transparent;
            this.plabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plabel3.Location = new System.Drawing.Point(3, 104);
            this.plabel3.MaximumSize = new System.Drawing.Size(98, 32);
            this.plabel3.MinimumSize = new System.Drawing.Size(98, 32);
            this.plabel3.Name = "plabel3";
            this.plabel3.Size = new System.Drawing.Size(98, 32);
            this.plabel3.TabIndex = 24;
            this.plabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plabel2
            // 
            this.plabel2.AutoSize = true;
            this.plabel2.BackColor = System.Drawing.Color.Transparent;
            this.plabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plabel2.Location = new System.Drawing.Point(3, 73);
            this.plabel2.MaximumSize = new System.Drawing.Size(98, 32);
            this.plabel2.MinimumSize = new System.Drawing.Size(98, 32);
            this.plabel2.Name = "plabel2";
            this.plabel2.Size = new System.Drawing.Size(98, 32);
            this.plabel2.TabIndex = 25;
            this.plabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(96, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 35);
            this.button5.TabIndex = 26;
            this.button5.Text = "Generate Tektek Price Data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.plabel2);
            this.groupBox5.Controls.Add(this.plabel3);
            this.groupBox5.Controls.Add(this.plabel4);
            this.groupBox5.Controls.Add(this.plabel5);
            this.groupBox5.Controls.Add(this.plabel1);
            this.groupBox5.Controls.Add(this.plabel0);
            this.groupBox5.Location = new System.Drawing.Point(2, 89);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(283, 204);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.trackBar1);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Location = new System.Drawing.Point(103, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(176, 151);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Misprice Criteria";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(159, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(61, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(95, 20);
            this.textBox7.TabIndex = 21;
            this.textBox7.Text = "0";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Max. Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Min. Price:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(61, 21);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(95, 20);
            this.textBox6.TabIndex = 18;
            this.textBox6.Text = "10000";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(134, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(32, 20);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "60%";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 75);
            this.trackBar1.Maximum = 100;
            this.trackBar1.MaximumSize = new System.Drawing.Size(150, 25);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(127, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 60;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(7, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 93);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Item:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 72);
            this.label8.MaximumSize = new System.Drawing.Size(0, 13);
            this.label8.MinimumSize = new System.Drawing.Size(250, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 13);
            this.label8.TabIndex = 12;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update Price / Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Go_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "LBP:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(35, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(94, 20);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(2, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 109);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(287, 503);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vend Friend 1.0";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void progressBar()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button6 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(201, 33);
            this.progressBar1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(93, 56);
            this.button6.Name = "button1";
            this.button6.Size = new System.Drawing.Size(97, 21);
            this.button6.TabIndex = 1;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 40);
            this.label13.Name = "label1";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "0/xxxx items loaded";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 80);
            this.ControlBox = false;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "progressBar";
            this.ShowIcon = false;
            this.Text = "Data Generation Progress (0%)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public static keyReceive kR;
        public static Retriever RT;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label plabel0;
        public System.Windows.Forms.Label plabel1;
        public System.Windows.Forms.Label plabel5;
        public System.Windows.Forms.Label plabel4;
        public System.Windows.Forms.Label plabel3;
        public System.Windows.Forms.Label plabel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

