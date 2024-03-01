using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomOutController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public GameObject launchMeter;
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola) {
            cameraController.GoBackToDefault();
            launchMeter.SetActive(false);
        }
    }
}
