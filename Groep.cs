using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Sportclub;

public class Groep
{
    public int GroepId { get; set; }

    public string? Name { get; set; }

    public virtual ObservableCollectionListSource<Lid> Leden { get; } = new();
}