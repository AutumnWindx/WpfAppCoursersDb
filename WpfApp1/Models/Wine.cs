using System;
using System.Collections.Generic;

namespace WpfApp1;

public partial class Wine
{
    public int Id { get; set; }

    public string TitleWine { get; set; } = null!;

    public string Grade { get; set; } = null!;

    public int Price { get; set; }

    public int Manufacturer { get; set; }

    public DateTime YearOfAging { get; set; }

    public double Volume { get; set; }

    public double Estimation { get; set; }

    public virtual Manufacturer ManufacturerNavigation { get; set; } = null!;
}
