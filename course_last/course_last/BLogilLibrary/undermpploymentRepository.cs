using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_last.Enteties;
using System.Configuration;
using course_last.BLogilLibrary;
using System.Data;
using System.Data.SqlClient;
using course_last.Database1DataSetTableAdapters;
using course_last.Enteties.Conteiners;

namespace course_last.BLogilLibrary
{
    class undermpploymentRepository : ConectRepository
    {
        InformationTableAdapter adapter = new InformationTableAdapter();

        private const string InsertunderempQuery = @"INSERT INTO [undermployment] ([Firm], [working_conditions], [payment], [requirements], [Post], [hours_per_day], [Home_work]) VALUES (@Firm, @working_conditions, @payment, @requirements, @Post, @hours_per_day, @Home_work)";

        private const string UpdateunderempQuery = @"UPDATE undermployment 
SET Firm = @Firm, working_conditions = @Working_conditions, payment = @payment, requirements = @requirements, Post = @Post, hours_per_day = @hours_per_day, 
Home_work = @Home_work 
WHERE (Firm = @Original_Firm)";

        private const string DeleteunderempQuery = @"DELETE FROM [underemployment] WHERE (([Firm] = @Original_Firm))";



        public string Add(underemployment underemp)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(InsertunderempQuery, connection))
                {


                    command.Parameters.AddWithValue("@Firm", underemp.Firm);
                    command.Parameters.AddWithValue("@Working_conditions", underemp.working_conditions);
                    command.Parameters.AddWithValue("@payment", underemp.payment);
                    command.Parameters.AddWithValue("@requirements", underemp.requirements);
                    command.Parameters.AddWithValue("@Post", underemp.Post);
                    command.Parameters.AddWithValue("@hours_per_day", underemp.hours_per_day);
                    command.Parameters.AddWithValue("@Home_work", underemp.Home_work);




                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        string Full_empl = "";
                        if (reader.Read())
                        {
                            Full_empl = (string)reader["Firm"];
                        }

                        return Full_empl;
                    }
                }
            }
        }

        public string Edit(underemployment underemp)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(UpdateunderempQuery, connection))
                {
                    command.Parameters.AddWithValue("@Firm", underemp.Firm);
                    command.Parameters.AddWithValue("@Working_conditions", underemp.working_conditions);
                    command.Parameters.AddWithValue("@payment", underemp.payment);
                    command.Parameters.AddWithValue("@requirements", underemp.requirements);
                    command.Parameters.AddWithValue("@Post", underemp.Post);
                    command.Parameters.AddWithValue("@hours_per_day", underemp.hours_per_day);
                    command.Parameters.AddWithValue("@Home_work", underemp.Home_work);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        string underempl = "";
                        if (reader.Read())
                        {
                            underempl = (string)reader["Firm"];
                        }

                        return underempl;
                    }
                }
            }




        }
        private void DeleteInfo(string Firm)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(DeleteunderempQuery, connection))
                {
                    command.Parameters.AddWithValue("@Firm", Firm);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                    }
                }
            }
        }
    }
}