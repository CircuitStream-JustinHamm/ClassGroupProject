using UnityEngine;
using UnityEngine.SceneManagement;

// Title screen!
public class TitleMenu : MonoBehaviour
{
    [Header("Start Game")]
    [Tooltip("First scene after Start Game.")]
    [SerializeField] private string gameplaySceneName = "WorldMap";

    private void Start()
    {
        // Title should never stay frozen if we arrived from a paused Quit.
        Time.timeScale = 1f;
        Debug.Log($"[TitleMenu] Ready. Start Game will load '{gameplaySceneName}'.");
    }

    // Start Game button OnClick
    public void StartGame()
    {
        if (string.IsNullOrWhiteSpace(gameplaySceneName))
        {
            Debug.LogError("[TitleMenu] Gameplay Scene Name is empty.");
            return;
        }
        Debug.Log($"[TitleMenu] Start Game → loading '{gameplaySceneName}'");
        SceneManager.LoadScene(gameplaySceneName);
    }
}
