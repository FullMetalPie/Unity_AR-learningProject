using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Management;
public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void playGame() {
        StartSession();
        SceneManager.LoadSceneAsync("AR_ImageTracking");
    }

    public void playPlaneDetect() {
        StartSession();
        SceneManager.LoadSceneAsync("PlaneDetect");
    }

    public void gitHubButton() {
        Application.OpenURL("https://github.com/FullMetalPie");
    }


    public void StartSession() {
        XRGeneralSettings instance = XRGeneralSettings.Instance;
        if (instance != null)
        {
            StartCoroutine(instance.Manager.InitializeLoader());
            instance.Manager.StartSubsystems();
        }
    }
}
