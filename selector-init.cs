namespace windowHandler
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.ulabel2 = new System.Windows.Forms.Label();
            this.ulabel3 = new System.Windows.Forms.Label();
            this.ulabel4 = new System.Windows.Forms.Label();
            this.ulabel5 = new System.Windows.Forms.Label();
            this.ulabel1 = new System.Windows.Forms.Label();
            this.ulabel0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 1);
            this.label1.MaximumSize = new System.Drawing.Size(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ulabel2
            // 
            this.ulabel2.AutoSize = true;
            this.ulabel2.BackColor = System.Drawing.Color.Transparent;
            this.ulabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulabel2.Location = new System.Drawing.Point(1, 64);
            this.ulabel2.MinimumSize = new System.Drawing.Size(95, 32);
            this.ulabel2.Name = "ulabel2";
            this.ulabel2.Size = new System.Drawing.Size(95, 32);
            this.ulabel2.TabIndex = 17;
            this.ulabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ulabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.ulabel2.Resize += new System.EventHandler(this.form_Resize);
            // 
            // ulabel3
            // 
            this.ulabel3.AutoSize = true;
            this.ulabel3.BackColor = System.Drawing.Color.Transparent;
            this.ulabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulabel3.Location = new System.Drawing.Point(1, 95);
            this.ulabel3.MinimumSize = new System.Drawing.Size(95, 32);
            this.ulabel3.Name = "ulabel3";
            this.ulabel3.Size = new System.Drawing.Size(95, 32);
            this.ulabel3.TabIndex = 18;
            this.ulabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ulabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.ulabel3.Resize += new System.EventHandler(this.form_Resize);
            // 
            // ulabel4
            // 
            this.ulabel4.AutoSize = true;
            this.ulabel4.BackColor = System.Drawing.Color.Transparent;
            this.ulabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulabel4.Location = new System.Drawing.Point(1, 126);
            this.ulabel4.MinimumSize = new System.Drawing.Size(95, 32);
            this.ulabel4.Name = "ulabel4";
            this.ulabel4.Size = new System.Drawing.Size(95, 32);
            this.ulabel4.TabIndex = 19;
            this.ulabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ulabel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.ulabel4.Resize += new System.EventHandler(this.form_Resize);
            // 
            // ulabel5
            // 
            this.ulabel5.AutoSize = true;
            this.ulabel5.BackColor = System.Drawing.Color.Transparent;
            this.ulabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulabel5.Location = new System.Drawing.Point(1, 157);
            this.ulabel5.MinimumSize = new System.Drawing.Size(95, 32);
            this.ulabel5.Name = "ulabel5";
            this.ulabel5.Size = new System.Drawing.Size(95, 32);
            this.ulabel5.TabIndex = 20;
            this.ulabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ulabel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.ulabel5.Resize += new System.EventHandler(this.form_Resize);
            // 
            // ulabel1
            // 
            this.ulabel1.AutoSize = true;
            this.ulabel1.BackColor = System.Drawing.Color.Transparent;
            this.ulabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulabel1.Location = new System.Drawing.Point(1, 33);
            this.ulabel1.MinimumSize = new System.Drawing.Size(95, 32);
            this.ulabel1.Name = "ulabel1";
            this.ulabel1.Size = new System.Drawing.Size(95, 32);
            this.ulabel1.TabIndex = 21;
            this.ulabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ulabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.ulabel1.Resize += new System.EventHandler(this.form_Resize);
            // 
            // ulabel0
            // 
            this.ulabel0.AutoSize = true;
            this.ulabel0.BackColor = System.Drawing.Color.Transparent;
            this.ulabel0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulabel0.Location = new System.Drawing.Point(1, 0);
            this.ulabel0.MinimumSize = new System.Drawing.Size(95, 34);
            this.ulabel0.Name = "ulabel0";
            this.ulabel0.Size = new System.Drawing.Size(95, 34);
            this.ulabel0.TabIndex = 22;
            this.ulabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ulabel0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.ulabel0.Resize += new System.EventHandler(this.form_Resize);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(97, 189);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ulabel0);
            this.Controls.Add(this.ulabel1);
            this.Controls.Add(this.ulabel5);
            this.Controls.Add(this.ulabel4);
            this.Controls.Add(this.ulabel3);
            this.Controls.Add(this.ulabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(200, 189);
            this.MinimumSize = new System.Drawing.Size(97, 0);
            this.Name = "Form3";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label ulabel2;
        public System.Windows.Forms.Label ulabel3;
        public System.Windows.Forms.Label ulabel4;
        public System.Windows.Forms.Label ulabel5;
        public System.Windows.Forms.Label ulabel1;
        public System.Windows.Forms.Label ulabel0;
    }
}