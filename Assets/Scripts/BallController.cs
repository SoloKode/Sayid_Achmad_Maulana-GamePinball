using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public float maxSpeed;
    private Rigidbody rig;
    // Start is called before the first frame update
    void Start() => rig = GetComponent<Rigidbody>();

    // Update is called once per frame
    void Update()
    {
        if (rig.velocity.magnitude > maxSpeed) rig.velocity = rig.velocity.normalized * maxSpeed;

        if(Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene("Pinball_Scene");
        }   
    }
}
