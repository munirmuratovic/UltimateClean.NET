namespace UltimateClean.Application.Models;

public class BaseSearchObject
{
    public int? Page { get; set; }
    public int? PageSize { get; set; }
    public bool? RetrieveAll { get; set; }
    public bool? IncludeCount { get; set; }
    public string? OrderBy { get; set; }
}
