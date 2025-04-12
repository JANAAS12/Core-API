using System;
using System.Collections.Generic;

namespace CoreApi.Server.Models;

public partial class Product
{
    public int ProductsId { get; set; }

    public string ProductsName { get; set; } = null!;

    public string? ProductsDescription { get; set; }
}
