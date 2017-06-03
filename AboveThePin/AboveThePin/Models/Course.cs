using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AboveThePin.Models
{
  public class Course
  {
    public int ID { get; set; }
    public virtual ICollection<Round> Rounds { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public int Par { get; set; }
    public int NumberOfHoles { get; set; }
  }
}