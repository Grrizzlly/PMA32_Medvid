using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbApp.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public int? FirmId { get; set; }
        public virtual Firm firm { get; set; }
    }
}
