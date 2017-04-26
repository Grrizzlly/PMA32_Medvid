using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace course_last.Enteties
{
    class SQLFunctions
    {
        static private SqlConnection connection = new SqlConnection(@"Data Source=|DataDirectory|\Database1.sdf");
        public static void Insert(string First_Name, string SurName, int Year_of_Birth)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Information] VALUES(@First_name, @SurName, @Year_of_Birth)", connection);
                sqlCommand.Parameters.AddWithValue("@First_name", First_Name);
                sqlCommand.Parameters.AddWithValue("@SurName", SurName);
                sqlCommand.Parameters.AddWithValue("@Year_of_Birth", Year_of_Birth);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
              //  MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Delete(string userName)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Information WHERE Username = @username", connection);
                sqlCommand.Parameters.AddWithValue("@username", userName);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
              //  MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Refresh(DataGrid informationDataGrid)
        {
            try
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [Table]", connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                informationDataGrid.DataContext = dataTable;
            }
            catch (Exception exception)
            {
                //  MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Update(string newFirst_Name, string oldFirst_Name)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE [Table] SET First_Name = @newFirst_Name WHERE First_Name = @oldFirst_Namee", connection);
                sqlCommand.Parameters.AddWithValue("@newUsername", newFirst_Name);
                sqlCommand.Parameters.AddWithValue("@oldUsername", oldFirst_Name);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
              //  MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
