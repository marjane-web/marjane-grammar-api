namespace Marjane.Services;

public class GrammarChecker
{
    public object Check(string text)
    {
        int wordCount = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

        var feedbackList = new List<string>();
        int errors = 0;

        var corrected = text;

        if (text.Contains("kahapon bukas"))
        {
            corrected = corrected.Replace("kahapon bukas", "bukas");
            feedbackList.Add("Magkasalungat ang 'kahapon' at 'bukas'.");
            errors++;
        }

        if (text.Contains("ako ay kumain bukas"))
        {
            corrected = corrected.Replace("ako ay kumain bukas", "ako ay kakain bukas");
            feedbackList.Add("Mali ang tense. Gamitin ang 'kakain' para sa hinaharap.");
            errors++;
        }

        if (!corrected.EndsWith('.'))
        {
            corrected += ".";
            feedbackList.Add("Lagyan ng tuldok ang pangungusap.");
            errors++;
        }

        int errorPercent = wordCount == 0
            ? 0
            : Math.Min(100, (errors * 100) / wordCount);

        return new
        {
            originalText = text,
            correctedText = corrected,
            wordCount,
            errors,
            errorPercent,
            feedback = feedbackList
        };
    }
}
