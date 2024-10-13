using System;
using System.Collections.Generic;

namespace PARCIAL20200046.DOMAIN.Core.Entities;

public partial class AutoParts
{
    public int Id { get; set; }

    public string? PartName { get; set; }

    public string? Description { get; set; }

    public double? Price { get; set; }

    public int? Stock { get; set; }
}
