using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task3.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime GreatedAt { get; set; }


        public override string ToString() =>
          $" Id: {Id} ... Address:{Address} ... GreatedAt :{GreatedAt}";

    }
}
