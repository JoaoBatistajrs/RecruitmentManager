using Domain.Common;
using Domain.Interfaces.Models;

namespace Domain.Models;

public class Candidate : Entity, ICandidate
{
    public Candidate(string name,  string cellPhone)
    {
        Name = name;
        CellPhone = cellPhone;
    }

    public string Name { get; set; }
    public string CellPhone { get; set; }
    public Seniority Seniority { get; set; }
}
