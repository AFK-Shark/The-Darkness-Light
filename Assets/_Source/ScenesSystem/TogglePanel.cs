using UnityEngine;
using UnityEngine.UI;

public class TogglePanel : MonoBehaviour
{
    public GameObject panel;
    public Button toggleButton; 
    void Start()
    {
        if (toggleButton != null)
        {
            toggleButton.onClick.AddListener(TogglePanelVisibility);
        }

        if (panel != null)
        {
            panel.SetActive(false);
        }
    }

    void TogglePanelVisibility()
    {
        if (panel != null)
        {
            panel.SetActive(!panel.activeSelf); 
        }
    }
}