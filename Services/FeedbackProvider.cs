using System;
using System.Collections.Generic;

public static class FeedbackProvider
{
    private static readonly Dictionary<string, List<string>> feedback =
        new()
        {
            {
                "91-100",
                new List<string>
                {
                    "Fidbak: Malaki ang kakulangan sa gramatika ng sanaysay."
                }
            }
        };

    public static string GetRandomFeedback(string levelKey)
    {
        var rnd = new Random();
        return feedback[levelKey][rnd.Next(feedback[levelKey].Count)];
    }
}
