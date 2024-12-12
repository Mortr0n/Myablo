using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject playerHUD;
    [SerializeField] GameObject characterStatsPanel;

    public static UIManager instance;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Start()
    {
        // HideAll();
    }

    public void HideAll()
    {
        // Hide everything
        HidePlayerHUD();
        HideCharacterStatsPanel();
    }

    #region PlayerHUD
    public void ShowPlayerHUD()
    {
        playerHUD.SetActive(true);
    }
    public void HidePlayerHUD()
    {
        playerHUD.SetActive(false);
    }
    #endregion
    #region Character Stat Panel
    public void ShowCharacterStatsPanel()
    {
        characterStatsPanel.SetActive(true);
    }
    public void HideCharacterStatsPanel()
    {
        characterStatsPanel.SetActive(false);
    }
    public void ToggleCharacterStatsPanel()
    {
        if (characterStatsPanel.activeInHierarchy) HideCharacterStatsPanel();
        else ShowCharacterStatsPanel();
    }

    #endregion
}
