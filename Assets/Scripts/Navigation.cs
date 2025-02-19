using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void goBack() {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
