using UnityEngine;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] GameObject statLevelUpButton;

    private void Start()
    {
        EventsManager.instance.onPlayerLeveledUp.AddListener(ShowStatLevelUpButton);
        HideStatLevelUpButton();
    }
    private void OnDestroy()
    {
        EventsManager.instance.onPlayerLeveledUp.RemoveListener(ShowStatLevelUpButton);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) ToggleCharacterStatPanel();
    }

    public void ToggleCharacterStatPanel()
    {
        UIManager.instance.ToggleCharacterStatsPanel();
        HideStatLevelUpButton();
    }

    #region StatLevelUpButton
    public void HideStatLevelUpButton()
    {
        statLevelUpButton.SetActive(false);
    }
    public void ShowStatLevelUpButton()
    {
        statLevelUpButton.SetActive(true);
    }
    #endregion
}
