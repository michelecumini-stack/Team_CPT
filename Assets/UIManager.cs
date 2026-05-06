using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenuUI;
    [SerializeField] private GameObject LevelSelectionUI;
    [SerializeField] private GameObject CreditiUI;
    [SerializeField] private GameObject GiocoUI;
    [SerializeField] private GameObject GameOverUI;

    void Start()
    {
        ShowMainMenuUI();
    }
    public void HideAll()
    {
        MainMenuUI.SetActive(false);
        LevelSelectionUI.SetActive(false);
        CreditiUI.SetActive(false);
        GiocoUI.SetActive(false);
        GameOverUI.SetActive(false);
    }
    public void ShowMainMenuUI()
    {
        HideAll();
        MainMenuUI.SetActive(true);
    }
    public void ShowLevelSelectionUI()
    {
        HideAll();
        LevelSelectionUI.SetActive(true);
    }
    public void ShowCreditiUI()
    {
        HideAll();
        CreditiUI.SetActive(true);
    }
    public void ShowGiocoUI()
    {
        HideAll();
        GiocoUI.SetActive(true);
    }
    public void ShowGameOverUI()
    {
        HideAll();
        GameOverUI.SetActive(true);
    }
}
