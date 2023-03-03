namespace WeeksTime
{
    partial class WeekHour
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
            cmbDaysWeek = new ComboBox();
            label2 = new Label();
            lblSelectedDay = new Label();
            txtboxTime = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtUserVal = new TextBox();
            lblHoursW = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // cmbDaysWeek
            // 
            cmbDaysWeek.FormattingEnabled = true;
            cmbDaysWeek.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            cmbDaysWeek.Location = new Point(357, 148);
            cmbDaysWeek.Name = "cmbDaysWeek";
            cmbDaysWeek.Size = new Size(199, 29);
            cmbDaysWeek.TabIndex = 0;
            cmbDaysWeek.SelectedIndexChanged += cmbDaysWeek_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(161, 208);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 2;
            label2.Text = "Day";
            // 
            // lblSelectedDay
            // 
            lblSelectedDay.AutoSize = true;
            lblSelectedDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectedDay.Location = new Point(357, 208);
            lblSelectedDay.Name = "lblSelectedDay";
            lblSelectedDay.Size = new Size(17, 21);
            lblSelectedDay.TabIndex = 3;
            lblSelectedDay.Text = "?";
            // 
            // txtboxTime
            // 
            txtboxTime.Location = new Point(357, 56);
            txtboxTime.Name = "txtboxTime";
            txtboxTime.Size = new Size(100, 29);
            txtboxTime.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(161, 64);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 5;
            label3.Text = "Hours Worked";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(161, 156);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 6;
            label1.Text = "Day of the Week";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(161, 326);
            label4.Name = "label4";
            label4.Size = new Size(180, 21);
            label4.TabIndex = 7;
            label4.Text = "Enter Day of the Week";
            // 
            // txtUserVal
            // 
            txtUserVal.Location = new Point(357, 318);
            txtUserVal.Name = "txtUserVal";
            txtUserVal.Size = new Size(199, 29);
            txtUserVal.TabIndex = 8;
            txtUserVal.TextChanged += txtUserVal_TextChanged;
            // 
            // lblHoursW
            // 
            lblHoursW.AutoSize = true;
            lblHoursW.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoursW.Location = new Point(360, 401);
            lblHoursW.Name = "lblHoursW";
            lblHoursW.Size = new Size(17, 21);
            lblHoursW.TabIndex = 9;
            lblHoursW.Text = "?";
            lblHoursW.Click += lblHoursW_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(161, 401);
            label5.Name = "label5";
            label5.Size = new Size(165, 21);
            label5.TabIndex = 10;
            label5.Text = "Show Hours Worked";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(label5);
            Controls.Add(lblHoursW);
            Controls.Add(txtUserVal);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtboxTime);
            Controls.Add(lblSelectedDay);
            Controls.Add(label2);
            Controls.Add(cmbDaysWeek);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Location = new Point(500, 250);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Week";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDaysWeek;
        private Label label2;
        private Label lblSelectedDay;
        private TextBox txtboxTime;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox txtUserVal;
        private Label lblHoursW;
        private Label label5;
    }
}