namespace c__project_proposal
{
    partial class frmCreateSched
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAppointment = new System.Windows.Forms.ComboBox();
            this.buttonSetSchedule = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.comboBoxMinute = new System.Windows.Forms.ComboBox();
            this.comboBoxTimeOfDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type of Appointment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time";
            // 
            // comboBoxAppointment
            // 
            this.comboBoxAppointment.FormattingEnabled = true;
            this.comboBoxAppointment.Location = new System.Drawing.Point(24, 192);
            this.comboBoxAppointment.Name = "comboBoxAppointment";
            this.comboBoxAppointment.Size = new System.Drawing.Size(275, 21);
            this.comboBoxAppointment.TabIndex = 3;
            // 
            // buttonSetSchedule
            // 
            this.buttonSetSchedule.Location = new System.Drawing.Point(112, 244);
            this.buttonSetSchedule.Name = "buttonSetSchedule";
            this.buttonSetSchedule.Size = new System.Drawing.Size(106, 39);
            this.buttonSetSchedule.TabIndex = 4;
            this.buttonSetSchedule.Text = "Create Schedule";
            this.buttonSetSchedule.UseVisualStyleBackColor = true;
            this.buttonSetSchedule.Click += new System.EventHandler(this.buttonSetSchedule_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(29, 59);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(270, 20);
            this.dateTimePickerDate.TabIndex = 5;
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.FormattingEnabled = true;
            this.comboBoxHour.Location = new System.Drawing.Point(24, 117);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(79, 21);
            this.comboBoxHour.TabIndex = 6;
            // 
            // comboBoxMinute
            // 
            this.comboBoxMinute.FormattingEnabled = true;
            this.comboBoxMinute.Location = new System.Drawing.Point(126, 117);
            this.comboBoxMinute.Name = "comboBoxMinute";
            this.comboBoxMinute.Size = new System.Drawing.Size(79, 21);
            this.comboBoxMinute.TabIndex = 7;
            // 
            // comboBoxTimeOfDay
            // 
            this.comboBoxTimeOfDay.FormattingEnabled = true;
            this.comboBoxTimeOfDay.Location = new System.Drawing.Point(234, 117);
            this.comboBoxTimeOfDay.Name = "comboBoxTimeOfDay";
            this.comboBoxTimeOfDay.Size = new System.Drawing.Size(69, 21);
            this.comboBoxTimeOfDay.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // frmCreateSched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTimeOfDay);
            this.Controls.Add(this.comboBoxMinute);
            this.Controls.Add(this.comboBoxHour);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonSetSchedule);
            this.Controls.Add(this.comboBoxAppointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateSched";
            this.Text = "Create new schedule";
            this.Load += new System.EventHandler(this.frmCreateSched_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAppointment;
        private System.Windows.Forms.Button buttonSetSchedule;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxHour;
        private System.Windows.Forms.ComboBox comboBoxMinute;
        private System.Windows.Forms.ComboBox comboBoxTimeOfDay;
        private System.Windows.Forms.Label label4;
    }
}