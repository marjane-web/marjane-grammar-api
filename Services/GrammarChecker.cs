namespace Marjane.Services;

public class GrammarChecker
{
    public object Check(string text)
    {
        var corrected = text;
        var feedback = new List<string>();

        if (text.Contains("kahapon bukas"))
        {
            corrected = corrected.Replace("kahapon bukas", "bukas");
            feedback.Add("Magkasalungat ang 'kahapon' at 'bukas'.");
        }

        if (text.Contains("ako ay kumain bukas"))
        {
            corrected = corrected.Replace("ako ay kumain bukas", "ako ay kakain bukas");
            feedback.Add("Mali ang tense. Gamitin ang 'kakain' para sa hinaharap.");
        }

        if (!corrected.EndsWith("."))
        {
            corrected += ".";
            feedback.Add("Lagyan ng tuldok ang pangungusap.");
        }

        return new
        {
            originalText = text,
            correctedText = corrected,
            feedback
        };
    }
}
