using System;
using System.Collections.Generic;

namespace HOTEL.Models;

public partial class Report
{
    public int ReportId { get; set; }

    public string ReportType { get; set; } = null!;

    public DateOnly DateGenerated { get; set; }

    public string? Data { get; set; }
}
