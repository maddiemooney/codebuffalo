using System;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using codebuffalo.Data;

namespace codebuffalo.Helpers
{
    /* Gets information from Database
     */
    public class DatabaseHelper
    {
        public DatabaseHelper()
        {
        }

        public void InitDatabase()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "<server>.database.windows.net";
                builder.UserID = "<username>";
                builder.Password = "<password>";
                builder.InitialCatalog = "<database>";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT TOP 20 pc.Name as CategoryName, p.name as ProductName ");
                    sb.Append("FROM [SalesLT].[ProductCategory] pc ");
                    sb.Append("JOIN [SalesLT].[Product] p ");
                    sb.Append("ON pc.productcategoryid = p.productcategoryid;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }

        public Task<Account> GetAccount()
        {
            Account test = new Account();
            test.UserID = "123";
            test.FirstName = "Mike";
            test.LastName = "Hawk";
            test.Email = "mhawk@test.com";
            test.City = "Coolsville";
            test.State = "New Fuck";
            test.Country = "USA";
            test.Radius = "50";
            test.PhoneNumber = "4444444444";
            test.DOB = "01011900";

            return Task.FromResult(test);

        }

    }
}
