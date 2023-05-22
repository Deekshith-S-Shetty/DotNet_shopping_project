using System.Data.SqlClient;

namespace Assignment1_0733.Models
{
    public class LaptopAccess
    {
        List<Laptop> LaptopData = new List<Laptop>();

        public List<Laptop> GetLaptop()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ShoppingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from laptop", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Laptop s = new Laptop();
                    s.laptopID = int.Parse(dr[0].ToString());
                    s.laptopName = dr[1].ToString();
                    s.laptopImage = dr[2].ToString();
                    s.laptopDesc = dr[3].ToString();
                    s.laptopPrice = int.Parse(dr[4].ToString());
                    LaptopData.Add(s);
                }
                return LaptopData;
            }
            catch (Exception ex)
            {
                return LaptopData;
            }
        }
    }
}
