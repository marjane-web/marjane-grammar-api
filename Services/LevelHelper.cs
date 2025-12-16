public static class LevelHelper
{
    public static string GetLevelKey(int percent)
    {
        return percent switch
        {
            >= 91 => "91-100",
            >= 81 => "81-90",
            >= 71 => "71-80",
            >= 61 => "61-70",
            >= 51 => "51-60",
            >= 41 => "41-50",
            >= 31 => "31-40",
            >= 21 => "21-30",
            >= 11 => "11-20",
            _ => "1-10"
        };
    }

    public static string GetLevelDescription(string key) => key switch
    {
        "91-100" => "Napakababa",
        "81-90" => "Mababa",
        "71-80" => "Di-kasiya-siya",
        "61-70" => "Katamtaman",
        "51-60" => "Katanggap-tanggap",
        "41-50" => "Medyo Mahusay",
        "31-40" => "Mahusay",
        "21-30" => "Napakahusay",
        "11-20" => "Halos Perpekto",
        _ => "Perpekto"
    };
}
