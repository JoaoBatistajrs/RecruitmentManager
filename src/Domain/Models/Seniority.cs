using Domain.Common;
using Domain.Interfaces.Models;

namespace Domain.Models;

public class Seniority : Entity, ISeniority
{
    public Seniority(string description)
    {
        Description = description;
    }
    public Seniority()
    {

    }

    public string Description { get; set; }
    
}
