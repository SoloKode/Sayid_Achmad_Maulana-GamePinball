using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
    public Collider bola;
    public AudioManager audioManager;
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            audioManager.StopBGM();
            audioManager.PlaySFX(transform.position);
            gameOverCanvas.SetActive(true);
            scoreCanvas.SetActive(false);
        }
    }
}
