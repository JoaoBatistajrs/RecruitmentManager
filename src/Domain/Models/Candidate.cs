using Domain.Common;
using Domain.Interfaces.Models;

namespace Domain.Models;

public class Candidate : Entity, ICandidate
{
    public Candidate(string name, DateOnly birthDate, string cellPhone)
    {
        Name = name;
        BirthDate = birthDate;
        CellPhone = cellPhone;
    }

    public string Name { get; set; }
    public DateOnly BirthDate { get; set; }
    public string CellPhone { get; set; }
    public Seniority Seniority { get; set; }
}
