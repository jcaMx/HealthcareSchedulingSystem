using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace c__project_proposal
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string SchedDate { get; set; }
        public string SchedTime { get; set; }
        public string AppointmentType { get; set; }

        // Save Appointment to Database
        public void SaveToDatabase()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = @"
                    INSERT INTO Appointments (Name, ContactNumber, SchedDate, SchedTime, AppointmentType)
                    VALUES (@Name, @ContactNumber, @SchedDate, @SchedTime, @AppointmentType);";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                    command.Parameters.AddWithValue("@SchedDate", SchedDate);
                    command.Parameters.AddWithValue("@SchedTime", SchedTime);
                    command.Parameters.AddWithValue("@AppointmentType", AppointmentType);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Retrieve All Appointments
        public static DataTable GetAllAppointments()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Appointments;";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
