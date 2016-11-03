namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.maxteks = new System.Windows.Forms.Label();
            this.minteks = new System.Windows.Forms.Label();
            this.tgl = new System.Windows.Forms.DateTimePicker();
            this.vmax = new System.Windows.Forms.VScrollBar();
            this.vmin = new System.Windows.Forms.VScrollBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.maxteks);
            this.tabPage2.Controls.Add(this.minteks);
            this.tabPage2.Controls.Add(this.tgl);
            this.tabPage2.Controls.Add(this.vmax);
            this.tabPage2.Controls.Add(this.vmin);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(348, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // maxteks
            // 
            this.maxteks.AutoSize = true;
            this.maxteks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxteks.Location = new System.Drawing.Point(242, 238);
            this.maxteks.Name = "maxteks";
            this.maxteks.Size = new System.Drawing.Size(40, 18);
            this.maxteks.TabIndex = 4;
            this.maxteks.Text = "MAX";
            // 
            // minteks
            // 
            this.minteks.AutoSize = true;
            this.minteks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minteks.Location = new System.Drawing.Point(63, 238);
            this.minteks.Name = "minteks";
            this.minteks.Size = new System.Drawing.Size(35, 18);
            this.minteks.TabIndex = 3;
            this.minteks.Text = "MIN";
            this.minteks.Click += new System.EventHandler(this.minteks_Click);
            // 
            // tgl
            // 
            this.tgl.Location = new System.Drawing.Point(72, 25);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(200, 20);
            this.tgl.TabIndex = 2;
            this.tgl.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // vmax
            // 
            this.vmax.LargeChange = 1;
            this.vmax.Location = new System.Drawing.Point(285, 25);
            this.vmax.Maximum = 10;
            this.vmax.Name = "vmax";
            this.vmax.Size = new System.Drawing.Size(32, 231);
            this.vmax.TabIndex = 1;
            this.vmax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vmax_Scroll);
            // 
            // vmin
            // 
            this.vmin.LargeChange = 1;
            this.vmin.Location = new System.Drawing.Point(28, 25);
            this.vmin.Maximum = 10;
            this.vmin.Name = "vmin";
            this.vmin.Size = new System.Drawing.Size(32, 231);
            this.vmin.TabIndex = 0;
            this.vmin.Value = 10;
            this.vmin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vmin_Scroll_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(348, 295);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1-0.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 315);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker tgl;
        private System.Windows.Forms.VScrollBar vmax;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label maxteks;
        private System.Windows.Forms.Label minteks;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.VScrollBar vmin;
    }
}

