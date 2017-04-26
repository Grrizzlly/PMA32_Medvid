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
    class Full_employmentRepository : ConectRepository
    {
        InformationTableAdapter adapter = new InformationTableAdapter();

        private const string InsertFull_empQuery = @"INSERT INTO [Full_employment] ([Firm], [Working_conditions], [payment], [requirements], [Post], [hours_per_day]) VALUES (@Firm, @Working_conditions, @payment, @requirements, @Post, @hours_per_day)";

        private const string UpdateFull_empQuery = @"UPDATE [Full_employment] SET [Firm] = @Firm, [Working_conditions] = @Working_conditions, [payment] = @payment, [requirements]=@requirements, [Post]=@Post, [hours_per_day]=@hours_per_day WHERE (([Firm] = @Original_Firm))";

        private const string DeleteFull_empQuery = @"DELETE FROM [Full_employment] WHERE (([Firm] = @Original_Firm))";

        private const string GetAllFull_empQuery = @"SELECT [Firm], [Working_conditions], [payment], [requirements], [Post], [hours_per_day] FROM [Full_employment]";

        public string Add(Full_employment Full_emp)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(InsertFull_empQuery, connection))
                {


                    command.Parameters.AddWithValue("@Firm", Full_emp.Firm);
                    command.Parameters.AddWithValue("@Working_conditions", Full_emp.working_conditions);
                    command.Parameters.AddWithValue("@payment", Full_emp.payment);
                    command.Parameters.AddWithValue("@requirements", Full_emp.requirements);
                    command.Parameters.AddWithValue("@Post", Full_emp.Post);
                    command.Parameters.AddWithValue("@hours_per_day", Full_emp.hours_per_day);
               



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

        public string Edit(Full_employment Full_emp)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(UpdateFull_empQuery, connection))
                {
                    command.Parameters.AddWithValue("@Firm", Full_emp.Firm);
                    command.Parameters.AddWithValue("@Working_conditions", Full_emp.working_conditions);
                    command.Parameters.AddWithValue("@payment", Full_emp.payment);
                    command.Parameters.AddWithValue("@requirements", Full_emp.requirements);
                    command.Parameters.AddWithValue("@Post", Full_emp.Post);
                    command.Parameters.AddWithValue("@hours_per_day", Full_emp.hours_per_day);


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
        private void DeleteInfo(string Firm)
        {
            using (SqlConnection connection = new SqlConnection(context))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(DeleteFull_empQuery, connection))
                {
                    command.Parameters.AddWithValue("@Firm", Firm);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                    }
                }
            }
        }
    //    private Full_employmentConteiner<Full_employment> GetFull_employmentJobs(Full_employment Full_emp, string type, string query = GetAllFull_empQuery)
    //    {
    //        using (SqlConnection connection = new SqlConnection(context))
    //        {
    //            connection.Open();
    //            using (SqlCommand command = new SqlCommand(query, connection))
    //            {
    //                command.Parameters.AddWithValue("@Firm", Firm);

    //                using (SqlDataReader reader = command.ExecuteReader())
    //                {
                       

    //                    while (reader.Read())
    //                    {
    //                        Full_employment Full_employ = (Full_employment)Activator.CreateInstance(Type.GetType("HomeLibrary.Entities." + type));

    //                        book.Id = (int)reader["id"];
    //                        book.Author = (string)reader["author"];
    //                        book.Title = (string)reader["title"];
    //                        book.Edition = (string)reader["edition"];
    //                        book.Year = (int)reader["year"];
    //                        book.Pages = (int)reader["pages"];
    //                        book.Section.Name = (string)reader["name"];
    //                        book.Estimate.Origin = (string)reader["origin"];
    //                        book.Estimate.Availability = (bool)reader["availability"];
    //                        book.Estimate.Worth = (string)reader["worth"];
    //                        book.Estimate.Recommendation = (string)reader["recommendation"];

    //                        books.Books.Add(book);

    //                    }

    //                    books.BooksCount = books.Books.Count;

    //                    return books;
    //                }
    //            }
    //        }
    //    }
    }

}
