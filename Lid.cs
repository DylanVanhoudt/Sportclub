using System.ComponentModel;

namespace Sportclub;

public class Lid
{
    public int LidId { get; set; }

    public string? Name { get; set; }

    public int GroepId { get; set; }
    public virtual Groep Groep { get; set; } = null!;
}