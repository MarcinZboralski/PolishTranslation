using UnityEngine;
using KSP.Localization;
using System.Linq;
using TMPro;

namespace PolishTranslation
{
    [KSPAddon(KSPAddon.Startup.EveryScene,false)]
    public class Localization : MonoBehaviour
    {
        public void Awake()
        {
            FontLoader fontLoader = FindObjectOfType<FontLoader>();
            TMP_FontAsset fontAsset = fontLoader.LoadedFonts.FirstOrDefault(t => t.name.Equals("JD-LCD-PL-modified"));
            fontLoader.AddMenuSubFont("pl", false, new[] { fontAsset });
            fontLoader.SwitchFontLanguage("pl");
            Localizer.SwitchToLanguage("pl");
        }
    }
}