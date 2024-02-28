using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    private Animator animator;
    public AudioManager audioManager;
    public ScoreManager scoreManager;
    public VFXManager VFXManager;
    public float score;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
            animator.SetTrigger("hit");
            audioManager.PlaySFX(other.transform.position);
            VFXManager.PlayVFX(other.transform.position);
            scoreManager.AddScore(score);
        }
    }
}
