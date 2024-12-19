
using UnityEngine;
using UnityEngine.UI;

namespace ScenesSystem
{
    public class TogglePanelCredits : MonoBehaviour
    {
        public GameObject panel;

        public void TogglePanelVisibility()
        {
            bool isActive = panel.activeSelf;

            panel.SetActive(!isActive);
        }
    }
}
