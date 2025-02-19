using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void playGame() {
        SceneManager.LoadScene("AR_ImageTracking");
    }

    public void gitHubButton() {
        Application.OpenURL("https://github.com/FullMetalPie");
    }

}
