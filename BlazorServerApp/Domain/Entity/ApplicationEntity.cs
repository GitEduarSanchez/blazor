namespace Domain.Entity;

public class ApplicationEntity
{
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public Uri Url { get; set; } = default!;
    public string Subcategory { get; set; } = string.Empty;
}
