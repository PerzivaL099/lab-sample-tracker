using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabSampleTracker.API.Models;

public enum SampleStatus
{
    Collected,
    InProcessing,
    Analyzed,
    Rejected
}

public class Sample
{
    [Key]
    public int Id {get; set; }

    [Required]
    public DateTime CollectionDate {get; set;}
    [Required]
    public SampleStatus Status {get; set; } = SampleStatus.Collected;

    //Llave foranea
    [Required]
    public int PatientId {get; set; }

    [ForeignKey(nameof(PatientId))]
    public Patient? Patient { get; set; }
}