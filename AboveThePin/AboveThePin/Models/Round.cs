using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AboveThePin.Models
{
  public class Round
  {
    public int ID { get; set; }

    public virtual Course Course { get; set; }
    public virtual ApplicationUser User { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int NumberOfHoles { get; set; }

  }
}