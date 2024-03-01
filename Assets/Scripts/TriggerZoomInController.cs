using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomInController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public float length;
    public GameObject launchMeter;
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola){
            cameraController.FollowTarget(bola.transform, length);
            launchMeter.SetActive(true);
        }
    }
}
