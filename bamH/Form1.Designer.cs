namespace bamH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fiveMinutes = new System.Windows.Forms.Button();
            this.thirtyMinutes = new System.Windows.Forms.Button();
            this.fifteenMinutes = new System.Windows.Forms.Button();
            this.fourtyFiveMinutes = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.lock_Button = new System.Windows.Forms.Button();
            this.default_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewThongKeTungNgay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeTungNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // fiveMinutes
            // 
            this.fiveMinutes.Location = new System.Drawing.Point(22, 181);
            this.fiveMinutes.Name = "fiveMinutes";
            this.fiveMinutes.Size = new System.Drawing.Size(166, 60);
            this.fiveMinutes.TabIndex = 0;
            this.fiveMinutes.Text = "5 minutes";
            this.fiveMinutes.UseVisualStyleBackColor = true;
            this.fiveMinutes.Click += new System.EventHandler(this.fiveMinutes_Click);
            // 
            // thirtyMinutes
            // 
            this.thirtyMinutes.Location = new System.Drawing.Point(22, 268);
            this.thirtyMinutes.Name = "thirtyMinutes";
            this.thirtyMinutes.Size = new System.Drawing.Size(166, 57);
            this.thirtyMinutes.TabIndex = 1;
            this.thirtyMinutes.Text = "30 minutes";
            this.thirtyMinutes.UseVisualStyleBackColor = true;
            this.thirtyMinutes.Click += new System.EventHandler(this.thirtyMinutes_Click);
            // 
            // fifteenMinutes
            // 
            this.fifteenMinutes.Location = new System.Drawing.Point(220, 181);
            this.fifteenMinutes.Name = "fifteenMinutes";
            this.fifteenMinutes.Size = new System.Drawing.Size(166, 60);
            this.fifteenMinutes.TabIndex = 2;
            this.fifteenMinutes.Text = "15 minutes";
            this.fifteenMinutes.UseVisualStyleBackColor = true;
            this.fifteenMinutes.Click += new System.EventHandler(this.fifteenMinutes_Click);
            // 
            // fourtyFiveMinutes
            // 
            this.fourtyFiveMinutes.Location = new System.Drawing.Point(220, 268);
            this.fourtyFiveMinutes.Name = "fourtyFiveMinutes";
            this.fourtyFiveMinutes.Size = new System.Drawing.Size(166, 57);
            this.fourtyFiveMinutes.TabIndex = 3;
            this.fourtyFiveMinutes.Text = "45 minutes";
            this.fourtyFiveMinutes.UseVisualStyleBackColor = true;
            this.fourtyFiveMinutes.Click += new System.EventHandler(this.fourtyFiveMinutes_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTime.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTime.ForeColor = System.Drawing.Color.SlateBlue;
            this.textBoxTime.Location = new System.Drawing.Point(22, 12);
            this.textBoxTime.Multiline = true;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(364, 136);
            this.textBoxTime.TabIndex = 4;
            this.textBoxTime.Text = "0:00:00";
            this.textBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lock_Button
            // 
            this.lock_Button.Location = new System.Drawing.Point(630, 487);
            this.lock_Button.Name = "lock_Button";
            this.lock_Button.Size = new System.Drawing.Size(166, 57);
            this.lock_Button.TabIndex = 5;
            this.lock_Button.Text = "Lock";
            this.lock_Button.UseVisualStyleBackColor = true;
            this.lock_Button.Click += new System.EventHandler(this.lock_Button_Click);
            // 
            // default_Button
            // 
            this.default_Button.Location = new System.Drawing.Point(431, 487);
            this.default_Button.Name = "default_Button";
            this.default_Button.Size = new System.Drawing.Size(166, 57);
            this.default_Button.TabIndex = 6;
            this.default_Button.Text = "Default";
            this.default_Button.UseVisualStyleBackColor = true;
            this.default_Button.Click += new System.EventHandler(this.default_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // dataGridViewThongKeTungNgay
            // 
            this.dataGridViewThongKeTungNgay.AllowUserToAddRows = false;
            this.dataGridViewThongKeTungNgay.AllowUserToDeleteRows = false;
            this.dataGridViewThongKeTungNgay.AllowUserToResizeColumns = false;
            this.dataGridViewThongKeTungNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKeTungNgay.Location = new System.Drawing.Point(12, 352);
            this.dataGridViewThongKeTungNgay.MultiSelect = false;
            this.dataGridViewThongKeTungNgay.Name = "dataGridViewThongKeTungNgay";
            this.dataGridViewThongKeTungNgay.ReadOnly = true;
            this.dataGridViewThongKeTungNgay.RowHeadersVisible = false;
            this.dataGridViewThongKeTungNgay.RowHeadersWidth = 82;
            this.dataGridViewThongKeTungNgay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewThongKeTungNgay.RowTemplate.Height = 41;
            this.dataGridViewThongKeTungNgay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewThongKeTungNgay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThongKeTungNgay.Size = new System.Drawing.Size(394, 192);
            this.dataGridViewThongKeTungNgay.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(818, 567);
            this.Controls.Add(this.dataGridViewThongKeTungNgay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.default_Button);
            this.Controls.Add(this.lock_Button);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.fourtyFiveMinutes);
            this.Controls.Add(this.fifteenMinutes);
            this.Controls.Add(this.thirtyMinutes);
            this.Controls.Add(this.fiveMinutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1696, 732);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClockVip";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeTungNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button fiveMinutes;
        private Button thirtyMinutes;
        private Button fifteenMinutes;
        private Button fourtyFiveMinutes;
        private TextBox textBoxTime;
        private Button lock_Button;
        private Button default_Button;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewThongKeTungNgay;
    }
}