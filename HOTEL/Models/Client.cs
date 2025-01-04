using System;
using System.Collections.Generic;

namespace HOTEL.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string? Name { get; set; }

    public string? ContactInfo { get; set; }

    public int? LoyaltyPoints { get; set; }

    public string? Preferences { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
