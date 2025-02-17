using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageTracker : MonoBehaviour
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
                    var newPrefab = Instantiate(arPrefab, trackedImage.transform.position, trackedImage.transform.rotation);
                    ARObjects.Add(newPrefab);
                }
            }
        }
        
    }
}
