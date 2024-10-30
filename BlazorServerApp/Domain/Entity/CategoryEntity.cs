namespace Domain.Entity;

public class CategoryEntity
{
    public string Name { get; set; } = string.Empty;
    public IEnumerable<ApplicationEntity> Applications { get; set; } = [];
}
