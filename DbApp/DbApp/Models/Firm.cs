using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbApp.Models
{
  public  class Firm
    {
      public int Id { get; set; }
    public string Name { get; set; } 
    public string Owner { get; set; } 
 
    public virtual ICollection<Phone> Phones { get; set; }
 
    public Firm()
    {
        Phones = new List<Phone>();
    }
    public override string ToString()
    {
        return Name;
    }
    }
}
