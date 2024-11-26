using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace c__project_proposal
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\appointments.mdf;Integrated Security=True;";

        public static void InitializeDatabase()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create the Appointments table if it doesn't exist
                string createTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Appointments' AND xtype='U')
                    CREATE TABLE Appointments (
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        Name NVARCHAR(100) NOT NULL,
                        ContactNumber NVARCHAR(15) NOT NULL,
                        SchedDate NVARCHAR(50) NOT NULL,
                        SchedTime NVARCHAR(50) NOT NULL,
                        AppointmentType NVARCHAR(100) NOT NULL
                    );";

                using (var command = new SqlCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static void AddAppointment(string name, string contactNumber, string schedDate, string schedTime, string appointmentType)
        {
            using (var connection = new SqlConnection(connectionString)) // SqlConnection for SQL Server
            {
                connection.Open();
                string insertQuery = @"
            INSERT INTO Appointments (Name, ContactNumber, SchedDate, SchedTime, AppointmentType)
            VALUES (@Name, @ContactNumber, @SchedDate, @SchedTime, @AppointmentType);";

                using (var command = new SqlCommand(insertQuery, connection)) // SqlCommand for SQL Server
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    command.Parameters.AddWithValue("@SchedDate", schedDate);
                    command.Parameters.AddWithValue("@SchedTime", schedTime);
                    command.Parameters.AddWithValue("@AppointmentType", appointmentType);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetAppointments()
        {
            DataTable appointments = new DataTable();

            using (var connection = GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Appointments;";

                using (var command = new SqlCommand(selectQuery, connection))
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(appointments);
                }
            }

            return appointments;
        }
    }
}
