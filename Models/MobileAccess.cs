using System.Data.SqlClient;

namespace Assignment1_0733.Models
{
    public class MobileAccess 
    {
        List<Mobile> MobileData = new List<Mobile>();

        public List<Mobile> GetMobile()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ShoppingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from mobile", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Mobile s = new Mobile();
                    s.mobileID = int.Parse(dr[0].ToString());
                    s.mobileName = dr[1].ToString();
                    s.mobileImage = dr[2].ToString();
                    s.mobileDesc = dr[3].ToString();
                    s.mobilePrice = int.Parse(dr[4].ToString());
                    MobileData.Add(s);
                }
                return MobileData;
            }
            catch (Exception ex)
            {
                return MobileData;
            } finally
            {
                conn.Close();
            }
        }
    }
}
