using System;
using System.Collections.Generic;

namespace ProductsAPI.Models;

public partial class CustomerMaster
{
    public int CustomerCode { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? MobileNo { get; set; }

    public string? GeoLocation { get; set; }
}
