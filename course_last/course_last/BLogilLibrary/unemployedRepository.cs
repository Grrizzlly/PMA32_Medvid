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
    class unemployedRepository: ConectRepository
    {
        InformationTableAdapter adapter = new InformationTableAdapter();

        private const string InsertunemployedQuery = @"INSERT INTO [unemployed] ([Unemployer], [profesion], [education], [requirements], [Post], [Previous_place], [Whyfired], [Contacts]) VALUES (@Unemployer, @profesion, @education, @requirements, @Post, @Previous_place, @Whyfired, @Contacts)";

        private const string UpdateunemployedQuery = @"UPDATE [unemployed] SET [Unemployer] = @Unemployer, [profesion] = @profesion, [education] = @education, [requirements]=@requirements, [Post]=@Post, [Previous_place]=@Previous_place, [Whyfired]=@Whyfired, [Contacts]=@Contacts WHERE (([Unemployer] = @Original_Unemployer))";

        private const string DeleteunemployedQuery = @"DELETE FROM [unemployed] WHERE (([Unemployer] = @Original_Unemployer))";



        public string Add(unemployed umenploy)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(InsertunemployedQuery, connection))
                {


                    command.Parameters.AddWithValue("@Unemployer", umenploy.Unemployer);
                    command.Parameters.AddWithValue("@profesion", umenploy.profesion);
                    command.Parameters.AddWithValue("@education", umenploy.education);
                    command.Parameters.AddWithValue("@requirements", umenploy.requirements);
                    command.Parameters.AddWithValue("@Post", umenploy.Post);
                    command.Parameters.AddWithValue("@Previous_place", umenploy.Previos_place);
                    command.Parameters.AddWithValue("@Whyfired", umenploy.Whyfired);
                    command.Parameters.AddWithValue("@Contacts", umenploy.Contacts);



                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        string Unemploy = "";
                        if (reader.Read())
                        {
                            Unemploy = (string)reader["Unemployer"];
                        }

                        return Unemploy;
                    }
                }
            }
        }

        public string Edit(unemployed umenploy)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(UpdateunemployedQuery, connection))
                {
                    command.Parameters.AddWithValue("@Unemployer", umenploy.Unemployer);
                    command.Parameters.AddWithValue("@profesion", umenploy.profesion);
                    command.Parameters.AddWithValue("@education", umenploy.education);
                    command.Parameters.AddWithValue("@requirements", umenploy.requirements);
                    command.Parameters.AddWithValue("@Post", umenploy.Post);
                    command.Parameters.AddWithValue("@Previous_place", umenploy.Previos_place);
                    command.Parameters.AddWithValue("@Whyfired", umenploy.Whyfired);
                    command.Parameters.AddWithValue("@Contacts", umenploy.Contacts);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        string Unemploy = "";
                        if (reader.Read())
                        {
                            Unemploy = (string)reader["Unemployer"];
                        }

                        return Unemploy;
                    }
                }
            }




        }
        private void DeleteInfo(string unemploy)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(DeleteunemployedQuery, connection))
                {
                    command.Parameters.AddWithValue("@Unemployer", unemploy);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                    }
                }
            }
        }
    }
}
