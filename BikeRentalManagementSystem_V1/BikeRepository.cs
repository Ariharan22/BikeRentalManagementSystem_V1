using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    public class BikeRepository
    {
        private string connectionString = "(localdb)\\MSSQLLocalDB";

        
        public void AddBike(string brand, string model, decimal rentalPrice)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Bikes (Brand, Model, RentalPrice) VALUES (@Brand, @Model, @RentalPrice)";
                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Brand", CapitalizeBrand(brand));
                        cmd.Parameters.AddWithValue("@Model", model);
                        cmd.Parameters.AddWithValue("@RentalPrice", rentalPrice);
                        cmd.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Bike added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding bike: " + ex.Message);
            }
        }

        
        public string CapitalizeBrand(string brand)
        {
            string[] words = brand.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
            return string.Join(" ", words);
        }
    }
}