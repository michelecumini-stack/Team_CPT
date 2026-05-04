using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenuUI;
    [SerializeField] private GameObject LevelSelectionUI;
    [SerializeField] private GameObject CreditiUI;

    void Start()
    {
        ShowMainMenuUI();
    }
    public void HideAll()
    {
        MainMenuUI.SetActive(false);
        LevelSelectionUI.SetActive(false);
        CreditiUI.SetActive(false);
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
}
