using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace c__project_proposal
{
    public partial class frmCreateSched : Form
    {
        string name;
        string contactNumber;
        string schedDate;
        string schedTime;
        string appointmentType;
        
        public frmCreateSched()
        {
            InitializeComponent();
        }
        public class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) { }
        }

        public class StringFormatException : Exception
        {
            public StringFormatException(string message) : base(message) { }

        }
        private void frmCreateSched_Load(object sender, EventArgs e)
        {


            for (int min = 01; min <= 12; min++)
            {
                comboBoxHour.Items.Add(min);
            }
            for (int sec = 01; sec <= 59; sec++)
            {
                comboBoxMinute.Items.Add(sec);
            }
            string[] time = { "AM", "PM" };
            for (int i = 0; i < time.Length; i++)
            {
                comboBoxTimeOfDay.Items.Add(time[i]);
            }


            string[] typeOfAppointment =
            {
                "Routine or Preventive Appointment",
                "Annual Physical Exam",
                "Vaccination Appointment",
                "Specialist Appointment",
                "Follow-Up Appointment",
                "Acute Care Appointment",
                "Diagnostic Appointment",
                "Therapy Appointment",
                "Dental Appointment",
                "Pediatric Appointment",
                "Telemedicine Appointment",
                "Emergency Car",
                "Surgical Consultation",
                "Rehabilitation Appointment",
                "Fertility and Reproductive Health Appointment",
                "Vision and Eye Care Appointment"
            };
            for (int app = 0; app < typeOfAppointment.Length; app++)
            {
                comboBoxAppointment.Items.Add(typeOfAppointment[app]);
            }
        }
        private void buttonSetSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                name = textBoxName.Text;
                contactNumber = textBoxNumber.Text;
                schedDate = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
                schedTime = $"{comboBoxHour.Text}:{comboBoxMinute.Text}  {comboBoxTimeOfDay.Text} ";
                appointmentType = comboBoxAppointment.SelectedItem.ToString();


                DialogResult result = MessageBox.Show(
                $"Name: {name}\n" +
                $"Contact Number: {contactNumber}\n" +
                "Appointment\n" +
                "Type of Appointment: " + appointmentType + "\n" +
                "Date: " + schedDate + " " + schedTime + "\n\n" +
                "Do you want to confirm this appointment?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    frmDashboard show = new frmDashboard(name, contactNumber, schedDate, schedTime, appointmentType);
                    show.Show();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    // Code to execute if the user clicks "No" (e.g., cancel the operation)
                }
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "String format error");
                Console.WriteLine(ex.Message);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Number format error");
                Console.WriteLine(ex.Message);
            }
            




        }
    }
}
