using Domain.Common;
using Domain.Interfaces;

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
