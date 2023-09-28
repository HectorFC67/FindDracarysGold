using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DracarysCreator : MonoBehaviour
{
    [SerializeField] private GameObject dracarysPrefab;
    [SerializeField] private Vector3 prefabOffset;

    private GameObject dracarys;
    private ARTrackedImageManager aRTrackedImageManager;

    private void OnEnable()
    {
        aRTrackedImageManager = gameObject.GetComponent<ARTrackedImageManager>();

        aRTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs obj)
    {
        foreach (ARTrackedImage image in obj.added)
        {
            dracarys = Instantiate(dracarysPrefab, image.transform);
            dracarys.transform.position += prefabOffset;
        }
    }
}
