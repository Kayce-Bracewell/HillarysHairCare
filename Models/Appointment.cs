using System.ComponentModel.DataAnnotations;

namespace HillarysHairCare.Models;

public class Appointment
{
    public int Id { get; set;}

    public DateTime Date { get; set;}

    public DateTime Time { get; set;}
    [Required]
    public int StylistId { get; set; }

    public Stylist Stylist {get; set;}

    [Required]
    public int CustomerId { get; set; }

    public Customer Customer {get; set;}

    public int TotalCost { get; set; }
}