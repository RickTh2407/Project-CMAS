using CMAS.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;



namespace CMAS.DataAccessLayer
{
    public class DAL
    {
        private List<Doctor> doctors { get; set; } = new List<Doctor>();
        private List<Exercise> exercises { get; set; } = new List<Exercise>();
        private List<Guardian> guardians { get; set; } = new List<Guardian>();
        private List<Patient> patients { get; set; } = new List<Patient>();

        private string connectionString = "Data Source=ASUSDRG4N\\SQLDRG4N;Initial Catalog=CMASDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        //Create
        private Doctor CreateDoctor(Doctor doctor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                { 
                    connection.Open();
                    string sql = "INSERT INTO Doctor (DoctorName, Department) VALUES (@DoctorName, @Department)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorName", doctor.DoctorName);
                        command.Parameters.AddWithValue("@Department", doctor.Department);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Doctor)
            {
                throw Doctor;
            }
        }

        //Read
        private void ReadDoctor(List<Doctor> doctors)
        {
            try 
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "SELECT DoctorId, DoctorName, Department FROM Doctor ORDER BY DoctorId";
                        using (SqlDataReader reader = command.ExecuteReader()) 
                        {
                            while (reader.Read())
                            {
                                doctors.Add(new Doctor(Int32.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString()));
                            }
                        }
                    }
                }
            }
            catch (Exception Values) 
            { 
                throw Values;
            }
        }
        private void ReadExercise(List<Exercise> exercises)
        {
            try 
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand command = new SqlCommand())
                    { 
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "SELECT ExerciseId, ExerciseName, ExerciseDescription, ExerciseFinished FROM Exercise ORDER BY ExerciseId";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            { 
                                exercises.Add(new Exercise(Int32.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), bool.Parse(reader[3].ToString())));
                            }
                        }
                    }
                }
            }
            catch (Exception Exercise)
            {
                throw Exercise;
            }
        }
        private void ReadGuardian(List<Guardian> guardians)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand command = new SqlCommand())
                    { 
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "SELECT GuardianId, RelativePatient, GuardianName FROM Guardian ORDER BY GuardianId";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                guardians.Add(new Guardian(Int32.Parse(reader[0].ToString()), Int32.Parse(reader[1].ToString()), reader[2].ToString()));
                            }
                        }
                    }
                }
            }
            catch (Exception Guardian)
            {
                throw Guardian;
            }
        }
        private void ReadPatient(List<Patient> patients)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand command = new SqlCommand())
                    { 
                        connection.ConnectionString= connectionString;
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "SELECT PatientId, PolisNumber, PatientName, PatientAdress, Advice, DateOfBirth FROM Patient ORDER BY PatientId";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                patients.Add(new Patient(Int32.Parse(reader[0].ToString()), Int32.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), DateTime.Parse(reader[5].ToString())));
                            }
                        }
                    }
                }
            }
            catch (Exception Patient)
            { 
                throw Patient;
            }
        }
        //Update

        //Delete

    }
}


