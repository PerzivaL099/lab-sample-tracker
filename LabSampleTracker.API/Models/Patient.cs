using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace LabSampleTracker.API.Models;

public class Patient
{
    [Key]
    public int Id {get; set;}

    [Required]
    [StringLength(100)]
    public string Name{get; set;} = string.Empty;

    [Required]
    public DateTime BirthDate {get; set; }

    //Un paciente puede tener muchas muestras
    public ICollection<Sample> Samples {get; set; } = new List<Sample>();
}