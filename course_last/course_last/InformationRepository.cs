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
namespace course_last
{
    class InformationRepository : ConectRepository
    {
        InformationTableAdapter adapter = new InformationTableAdapter();
   
        private const string InsertIntoInfoQuery = @"INSERT INTO Information
                         (First_name, SurName, Year_of_Birth)
VALUES        (@First_name,@SurName,@Year_of_Birth)";

        private const string UpdateInfoQuery = @"UPDATE [Information] SET [First_name] = @First_name, [SurName] = @SurName, [Year_of_Birth] = @Year_of_Birth WHERE (([First_name] = @Original_First_name))";

        private const string DeleteInfoQuery = @"DELETE FROM [Information] WHERE (([First_name] = @Original_First_name))";

       

        public string Add(Information inform)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(InsertIntoInfoQuery, connection))
                {


                    command.Parameters.AddWithValue("@First_name", inform.FirstName);
                    command.Parameters.AddWithValue("@SurName", inform.SurName);
                    command.Parameters.AddWithValue("@Year_of_Birth", inform.Year_of_Birth);



                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        string First_name = "";
                        if (reader.Read())
                        {
                            First_name = (string)reader["First_name"];
                        }

                        return First_name;
                    }
                }
            }
        }

        public string Edit(Information inform)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(UpdateInfoQuery, connection))
                {
                    command.Parameters.AddWithValue("@First_name", inform.FirstName);
                    command.Parameters.AddWithValue("@SurName", inform.SurName);
                    command.Parameters.AddWithValue("@Year_of_Birth", inform.Year_of_Birth);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        string First_name = "";
                        if (reader.Read())
                        {
                            First_name = (string)reader["First_name"];
                        }

                        return First_name;
                    }
                }
            }




        }
        private void DeleteInfo(string First_Name)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(DeleteInfoQuery, connection))
                {
                    command.Parameters.AddWithValue("@First_name", First_Name);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                    }
                }
            }
        }
    }
}


