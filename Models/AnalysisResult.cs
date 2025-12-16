namespace Marjane.Models;

public class AnalysisResult
{
    public string OriginalText { get; set; } = "";
    public string CorrectedText { get; set; } = "";
    public List<string> Feedback { get; set; } = new();
}
