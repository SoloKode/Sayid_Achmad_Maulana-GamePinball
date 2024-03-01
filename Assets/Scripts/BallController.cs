using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public float maxSpeed;
    private Rigidbody rig;
    public CollisionDetectionMode collisionDetectionMode;
    void Start() => rig = GetComponent<Rigidbody>();
    void Update()
    {
        if (rig.velocity.magnitude > maxSpeed) rig.velocity = rig.velocity.normalized * maxSpeed;
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene("Pinball_Scene");
        if (Input.GetKeyDown(KeyCode.Escape)) SceneManager.LoadScene("Main_Menu");
    }
}
