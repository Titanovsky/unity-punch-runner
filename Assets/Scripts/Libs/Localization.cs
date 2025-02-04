using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class Localization
{
    public Dictionary<LocalizationCountryCodes, string> Phrases { get; private set; } = new();

    public Localization(string text = "", LocalizationCountryCodes code = LocalizationCountryCodes.En)
    {
        Phrases.Add(code, text);
    }

    public string Get(LocalizationCountryCodes code = LocalizationCountryCodes.En)
    {
        var text = "";

        Phrases.TryGetValue(code, out text);

        return text;
    }
}

public enum LocalizationCountryCodes
{
    Ru,
    En,
    Fr
}