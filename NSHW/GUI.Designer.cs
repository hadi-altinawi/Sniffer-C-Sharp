namespace NSHW
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.save = new System.Windows.Forms.CheckBox();
            this._udp = new System.Windows.Forms.CheckBox();
            this._tcp = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adapters_label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.start_button = new System.Windows.Forms.Button();
            this.adapters_list = new System.Windows.Forms.ComboBox();
            this.stop_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.AutoSize = true;
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.save.Location = new System.Drawing.Point(292, 139);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(141, 22);
            this.save.TabIndex = 22;
            this.save.Text = "Save Capturing";
            this.save.UseVisualStyleBackColor = false;
            // 
            // _udp
            // 
            this._udp.AutoSize = true;
            this._udp.BackColor = System.Drawing.Color.Transparent;
            this._udp.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this._udp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._udp.Location = new System.Drawing.Point(538, 72);
            this._udp.Name = "_udp";
            this._udp.Size = new System.Drawing.Size(52, 20);
            this._udp.TabIndex = 20;
            this._udp.Text = "UDP";
            this._udp.UseVisualStyleBackColor = false;
            // 
            // _tcp
            // 
            this._tcp.AutoSize = true;
            this._tcp.BackColor = System.Drawing.Color.Transparent;
            this._tcp.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this._tcp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._tcp.Location = new System.Drawing.Point(383, 73);
            this._tcp.Name = "_tcp";
            this._tcp.Size = new System.Drawing.Size(50, 20);
            this._tcp.TabIndex = 19;
            this._tcp.Text = "TCP";
            this._tcp.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(41, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Set filter :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 418);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(496, 168);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(35, 396);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Protocol Info :";
            // 
            // adapters_label
            // 
            this.adapters_label.AutoSize = true;
            this.adapters_label.BackColor = System.Drawing.Color.Transparent;
            this.adapters_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.adapters_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.adapters_label.Location = new System.Drawing.Point(35, 28);
            this.adapters_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adapters_label.Name = "adapters_label";
            this.adapters_label.Size = new System.Drawing.Size(216, 19);
            this.adapters_label.TabIndex = 15;
            this.adapters_label.Text = "Select Network Adeptar :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(39, 193);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(733, 177);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 182;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Source";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 142;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Destination";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Protocol";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Length";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 115;
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.start_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.start_button.Location = new System.Drawing.Point(39, 139);
            this.start_button.Margin = new System.Windows.Forms.Padding(4);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(176, 32);
            this.start_button.TabIndex = 13;
            this.start_button.Text = "Start capturing";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // adapters_list
            // 
            this.adapters_list.FormattingEnabled = true;
            this.adapters_list.Location = new System.Drawing.Point(322, 30);
            this.adapters_list.Margin = new System.Windows.Forms.Padding(4);
            this.adapters_list.Name = "adapters_list";
            this.adapters_list.Size = new System.Drawing.Size(341, 21);
            this.adapters_list.TabIndex = 12;
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.Transparent;
            this.stop_button.Enabled = false;
            this.stop_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.stop_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stop_button.Location = new System.Drawing.Point(521, 139);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(190, 32);
            this.stop_button.TabIndex = 23;
            this.stop_button.Text = "Stop capturing";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NSHW.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(899, 598);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.save);
            this.Controls.Add(this._udp);
            this.Controls.Add(this._tcp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adapters_label);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.adapters_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sniffer Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox save;
        private System.Windows.Forms.CheckBox _udp;
        private System.Windows.Forms.CheckBox _tcp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adapters_label;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.ComboBox adapters_list;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

