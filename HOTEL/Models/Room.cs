using System;
using System.Collections.Generic;

namespace HOTEL.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public string Category { get; set; } = null!;

    public decimal PricePerNight { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
