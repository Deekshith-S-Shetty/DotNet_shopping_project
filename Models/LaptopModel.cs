using Microsoft.AspNetCore.Mvc;

namespace Assignment1_0733.Models
{
    public class Laptop
    {
        public int laptopID { get; set; }
        public string laptopName { get; set; }

        public string laptopImage { get; set; }

        public string laptopDesc { get; set; }

        public int laptopPrice { get; set; }
    }
}
