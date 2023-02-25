using UnityEngine;
using KSP.UI.Screens;
using KSP.UI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace PolishTranslation
{
    [KSPAddon(KSPAddon.Startup.AllGameScenes, false)]
    public class MainMenuButtons : MonoBehaviour
    {
        private const string url = "https://forum.kerbalspaceprogram.com/index.php?/topic/212193-1125-kerbal-space-program-polish-translation-v091-beta/";

        private ApplicationLauncherButton menuButtonUrlButton;
        private Texture2D ToolbarButtonTexture;
        private void Awake()
        {
            if (GameDatabase.Instance.ExistsTexture("PolishTranslation/Textures/kspplico"))
            {
                ToolbarButtonTexture = GameDatabase.Instance.GetTexture("PolishTranslation/Textures/kspplico", false);
            }
            GameEvents.onGUIApplicationLauncherReady.Add(OnGUIApplicationLauncherReady);
        }

        private void OnGUIApplicationLauncherReady()
        {
            if (menuButtonUrlButton == null)
            {
                menuButtonUrlButton = ApplicationLauncher.Instance.AddModApplication(
                    OpenForumURL, null,
                    null, null,
                    null, null,
                    ApplicationLauncher.AppScenes.ALWAYS,
                    ToolbarButtonTexture
                );

            }
        }

        private void OpenForumURL()
        {
            Application.OpenURL(url);
        }
    }
}
