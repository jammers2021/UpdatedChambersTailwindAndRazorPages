namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models
{
    public interface IStatsGenerationMethod
    {
        List<int> stats { get; set; }

        List<int> SelectStats(string statsMethod, List<int>? stats = null);
    }
}