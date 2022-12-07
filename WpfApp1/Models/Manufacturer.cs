using System;
using System.Collections.Generic;

namespace WpfApp1;

public partial class Manufacturer
{
    public int Id { get; set; }

    public string Country { get; set; } = null!;

    public string City { get; set; } = null!;

    public virtual ICollection<Wine> Wines { get; } = new List<Wine>();
}
