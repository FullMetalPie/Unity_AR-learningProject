using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Management;

public class Navigation : MonoBehaviour
{

    public GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void goBack() {
        EndSession();
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void EndSession() {
        XRGeneralSettings instance = XRGeneralSettings.Instance;
        if (instance != null)
        {
            instance.Manager.DeinitializeLoader();
            instance.Manager.StopSubsystems();
        }
    }
}
