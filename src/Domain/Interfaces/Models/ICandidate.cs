using Domain.Models;

namespace Domain.Interfaces.Models;

public interface ICandidate
{
    public string Name { get; set; }
    public string CellPhone { get; set; }
    public Seniority Seniority { get; set; }
}
