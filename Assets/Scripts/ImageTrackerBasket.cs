using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Management;

public class ImageTrackerBasket : MonoBehaviour
{
    private ARTrackedImageManager trackedImages;
    public GameObject[] ArPrefabs;

    List<GameObject> ARObjects = new List<GameObject>();
    
    void Awake()
    {
        trackedImages = GetComponent<ARTrackedImageManager>();
    }

    void OnEnable()
    {
        trackedImages.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        trackedImages.trackedImagesChanged -= OnTrackedImagesChanged;
    }


    // Quando la camera vede un immagine 
    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        //Scorre immagini 
        foreach (var trackedImage in eventArgs.added)
        {
            //Scorre prefabs
            foreach (var arPrefab in ArPrefabs)
            {
                if(trackedImage.referenceImage.name == arPrefab.name)
                {
                    //var prefabPosition = trackedImage.transform.position;
                    //prefabPosition.y = 1;
                    var newPrefab = Instantiate(arPrefab, trackedImage.transform.position, trackedImage.transform.rotation);
                    ARObjects.Add(newPrefab);
                    newPrefab.transform.parent = trackedImage.transform;   
                }
            }
        }

        //Update tracking position
        foreach (var trackedImage in eventArgs.updated)
        {
            foreach (var gameObject in ARObjects)
            {
                if(gameObject.name == trackedImage.name)
                {
                    gameObject.SetActive(trackedImage.trackingState == TrackingState.Tracking);
                }
            }
        }
        
    }

    private void OnDestroy()
    {
        XRGeneralSettings instance = XRGeneralSettings.Instance;
        if (instance != null)
        {
            instance.Manager.DeinitializeLoader();
            instance.Manager.StopSubsystems();
        }
    }
}