using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject playerHUD;

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
}
