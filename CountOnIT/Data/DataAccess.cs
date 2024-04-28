using CountOnIT.Models;
using Npgsql;

namespace CountOnIT.Data
{
    public class DataAccess
    {
        string connectionString = "Host=localhost;Username=PGUSER;Password=1505;Database=CountOnIT";

        public List<ProductModel> GetProduct()
        {
            List<ProductModel> productList = new List<ProductModel>();

            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            con.Open();
            //Koden når ikke længere end her til. Jeg formoder at det er forbindelsen mellem projekt og db som fejler. 
            string query = "SELECT * FROM PRODUCT;";

            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            ProductModel product = new ProductModel(1, "name", "description","image");

            while (reader.Read())
            {
                product.Id = Convert.ToInt32(reader["Id"]);
                product.Name = reader["Name"].ToString();
                product.Description = reader["Description"].ToString();
                product.Image = reader["Image"].ToString();
                productList.Add(product);

            }

            return productList;
        }
    }
}
