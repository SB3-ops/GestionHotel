using System;
using System.Collections.Generic;

namespace HOTEL.Models;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public int ReservationId { get; set; }

    public int ClientId { get; set; }

    public decimal TotalAmount { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;

    public virtual Reservation Reservation { get; set; } = null!;
}
