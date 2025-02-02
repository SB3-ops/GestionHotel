﻿using System;
using System.Collections.Generic;

namespace HOTEL.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public string Status { get; set; } = null!;
}
