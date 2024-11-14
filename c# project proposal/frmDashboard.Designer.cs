namespace c__project_proposal
{
    partial class frmDashboard
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
            this.listviewcalendar = new System.Windows.Forms.ListView();
            this.Sun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Thu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FRI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profilepicture = new System.Windows.Forms.PictureBox();
            this.listViewdaymonthandweek = new System.Windows.Forms.ListView();
            this.buttonCreateSched = new System.Windows.Forms.Button();
            this.buttonViewSched = new System.Windows.Forms.Button();
            this.calendarclick = new System.Windows.Forms.Button();
            this.buttonEditSched = new System.Windows.Forms.Button();
            this.buttonDeleteSched = new System.Windows.Forms.Button();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.settingsclick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationview1 = new System.Windows.Forms.ListView();
            this.locationview2 = new System.Windows.Forms.ListView();
            this.locationview3 = new System.Windows.Forms.ListView();
            this.userName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilepicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listviewcalendar
            // 
            this.listviewcalendar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sun,
            this.Mon,
            this.Tue,
            this.Wed,
            this.Thu,
            this.FRI,
            this.Sat});
            this.listviewcalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewcalendar.FullRowSelect = true;
            this.listviewcalendar.GridLines = true;
            this.listviewcalendar.HideSelection = false;
            this.listviewcalendar.Location = new System.Drawing.Point(274, 143);
            this.listviewcalendar.Name = "listviewcalendar";
            this.listviewcalendar.Size = new System.Drawing.Size(442, 343);
            this.listviewcalendar.TabIndex = 0;
            this.listviewcalendar.UseCompatibleStateImageBehavior = false;
            this.listviewcalendar.View = System.Windows.Forms.View.Details;
            // 
            // Sun
            // 
            this.Sun.Text = "SUN";
            this.Sun.Width = 69;
            // 
            // Mon
            // 
            this.Mon.Text = "MON";
            this.Mon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tue
            // 
            this.Tue.Text = "TUE";
            this.Tue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Wed
            // 
            this.Wed.Text = "WED";
            this.Wed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Thu
            // 
            this.Thu.Text = "THU";
            this.Thu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRI
            // 
            this.FRI.Text = "FRI";
            this.FRI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sat
            // 
            this.Sat.Text = "SAT";
            this.Sat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profilepicture
            // 
            this.profilepicture.Location = new System.Drawing.Point(63, 28);
            this.profilepicture.Name = "profilepicture";
            this.profilepicture.Size = new System.Drawing.Size(100, 106);
            this.profilepicture.TabIndex = 1;
            this.profilepicture.TabStop = false;
            // 
            // listViewdaymonthandweek
            // 
            this.listViewdaymonthandweek.HideSelection = false;
            this.listViewdaymonthandweek.Location = new System.Drawing.Point(274, 70);
            this.listViewdaymonthandweek.Name = "listViewdaymonthandweek";
            this.listViewdaymonthandweek.Size = new System.Drawing.Size(442, 35);
            this.listViewdaymonthandweek.TabIndex = 2;
            this.listViewdaymonthandweek.UseCompatibleStateImageBehavior = false;
            // 
            // buttonCreateSched
            // 
            this.buttonCreateSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSched.Location = new System.Drawing.Point(748, 143);
            this.buttonCreateSched.Name = "buttonCreateSched";
            this.buttonCreateSched.Size = new System.Drawing.Size(144, 26);
            this.buttonCreateSched.TabIndex = 3;
            this.buttonCreateSched.Text = "CREATE NEW SCHED";
            this.buttonCreateSched.UseVisualStyleBackColor = true;
            this.buttonCreateSched.Click += new System.EventHandler(this.buttonCreateSched_Click);
            // 
            // buttonViewSched
            // 
            this.buttonViewSched.Location = new System.Drawing.Point(27, 181);
            this.buttonViewSched.Name = "buttonViewSched";
            this.buttonViewSched.Size = new System.Drawing.Size(83, 68);
            this.buttonViewSched.TabIndex = 4;
            this.buttonViewSched.Text = "VIEW SCHEDULE";
            this.buttonViewSched.UseVisualStyleBackColor = true;
            // 
            // calendarclick
            // 
            this.calendarclick.Location = new System.Drawing.Point(143, 181);
            this.calendarclick.Name = "calendarclick";
            this.calendarclick.Size = new System.Drawing.Size(83, 68);
            this.calendarclick.TabIndex = 5;
            this.calendarclick.Text = "CALENDAR";
            this.calendarclick.UseVisualStyleBackColor = true;
            // 
            // buttonEditSched
            // 
            this.buttonEditSched.Location = new System.Drawing.Point(27, 267);
            this.buttonEditSched.Name = "buttonEditSched";
            this.buttonEditSched.Size = new System.Drawing.Size(83, 68);
            this.buttonEditSched.TabIndex = 6;
            this.buttonEditSched.Text = "EDIT SCHEDULE";
            this.buttonEditSched.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSched
            // 
            this.buttonDeleteSched.Location = new System.Drawing.Point(143, 267);
            this.buttonDeleteSched.Name = "buttonDeleteSched";
            this.buttonDeleteSched.Size = new System.Drawing.Size(83, 68);
            this.buttonDeleteSched.TabIndex = 7;
            this.buttonDeleteSched.Text = "DELETE SCHED";
            this.buttonDeleteSched.UseVisualStyleBackColor = true;
            // 
            // buttonMessage
            // 
            this.buttonMessage.Location = new System.Drawing.Point(27, 357);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(83, 68);
            this.buttonMessage.TabIndex = 8;
            this.buttonMessage.Text = "MESSAGE";
            this.buttonMessage.UseVisualStyleBackColor = true;
            // 
            // settingsclick
            // 
            this.settingsclick.Location = new System.Drawing.Point(143, 357);
            this.settingsclick.Name = "settingsclick";
            this.settingsclick.Size = new System.Drawing.Size(83, 68);
            this.settingsclick.TabIndex = 9;
            this.settingsclick.Text = "SETTINGS";
            this.settingsclick.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "TODAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "MONTH / WEEK / DAY";
            // 
            // locationview1
            // 
            this.locationview1.HideSelection = false;
            this.locationview1.Location = new System.Drawing.Point(748, 177);
            this.locationview1.Name = "locationview1";
            this.locationview1.Size = new System.Drawing.Size(156, 95);
            this.locationview1.TabIndex = 14;
            this.locationview1.UseCompatibleStateImageBehavior = false;
            // 
            // locationview2
            // 
            this.locationview2.HideSelection = false;
            this.locationview2.Location = new System.Drawing.Point(748, 278);
            this.locationview2.Name = "locationview2";
            this.locationview2.Size = new System.Drawing.Size(156, 99);
            this.locationview2.TabIndex = 15;
            this.locationview2.UseCompatibleStateImageBehavior = false;
            // 
            // locationview3
            // 
            this.locationview3.HideSelection = false;
            this.locationview3.Location = new System.Drawing.Point(748, 383);
            this.locationview3.Name = "locationview3";
            this.locationview3.Size = new System.Drawing.Size(156, 99);
            this.locationview3.TabIndex = 16;
            this.locationview3.UseCompatibleStateImageBehavior = false;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(60, 150);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(122, 13);
            this.userName.TabIndex = 10;
            this.userName.Text = "Healthcare Administrator";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 526);
            this.Controls.Add(this.locationview3);
            this.Controls.Add(this.locationview2);
            this.Controls.Add(this.locationview1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.settingsclick);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.buttonDeleteSched);
            this.Controls.Add(this.buttonEditSched);
            this.Controls.Add(this.calendarclick);
            this.Controls.Add(this.buttonViewSched);
            this.Controls.Add(this.buttonCreateSched);
            this.Controls.Add(this.listViewdaymonthandweek);
            this.Controls.Add(this.profilepicture);
            this.Controls.Add(this.listviewcalendar);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.profilepicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewcalendar;
        private System.Windows.Forms.ColumnHeader Sun;
        private System.Windows.Forms.ColumnHeader Mon;
        private System.Windows.Forms.ColumnHeader Tue;
        private System.Windows.Forms.ColumnHeader Wed;
        private System.Windows.Forms.ColumnHeader Thu;
        private System.Windows.Forms.ColumnHeader FRI;
        private System.Windows.Forms.PictureBox profilepicture;
        private System.Windows.Forms.ColumnHeader Sat;
        private System.Windows.Forms.ListView listViewdaymonthandweek;
        private System.Windows.Forms.Button buttonCreateSched;
        private System.Windows.Forms.Button buttonViewSched;
        private System.Windows.Forms.Button calendarclick;
        private System.Windows.Forms.Button buttonEditSched;
        private System.Windows.Forms.Button buttonDeleteSched;
        private System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.Button settingsclick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView locationview1;
        private System.Windows.Forms.ListView locationview2;
        private System.Windows.Forms.ListView locationview3;
        private System.Windows.Forms.Label userName;
    }
}

