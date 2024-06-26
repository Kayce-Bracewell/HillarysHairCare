using System.ComponentModel.DataAnnotations;

namespace HillarysHairCare.Models.DTOs;

public class StylistDTO
{
    public int Id { get; set;}

    [Required]
    public string Name { get; set;}

    [Required]
    public bool IsActive { get; set; }
}