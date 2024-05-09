using System.ComponentModel.DataAnnotations;

namespace HillarysHairCare.Models.DTOs;

public class AppointmentDTO
{
    public int Id { get; set;}

    public DateTime? Date { get; set;}

    public DateTime? Time { get; set;}
    [Required]
    public int StylistId { get; set; }

    public StylistDTO Stylist {get; set;}

    [Required]
    public int CustomerId { get; set; }

    public CustomerDTO Customer {get; set;}

    public int TotalCost { get; set; }
}