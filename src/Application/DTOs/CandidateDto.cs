using Domain.Models;

namespace Application.DTOs;

public class CandidateDto
{
    public string Name { get; set; }
    public string CellPhone { get; set; }
    public Seniority Seniority { get; set; }
}
