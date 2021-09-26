using System.Collections.Generic;

namespace Packt.Shared
{
    public class Shipper
    {
        public int SjipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}