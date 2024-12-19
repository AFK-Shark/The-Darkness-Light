using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneName;
    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
