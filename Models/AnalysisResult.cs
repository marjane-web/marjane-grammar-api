namespace Marjane.Models;

public class AnalysisResult
{
    public string OriginalText { get; set; } = string.Empty;
    public string CorrectedText { get; set; } = string.Empty;
    public List<string> Feedback { get; set; } = new();
}
