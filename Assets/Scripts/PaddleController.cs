using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    private HingeJoint hinge;
    private float targetPressed;
    private float targetRelease;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
        // MovePaddle();
    }

    private void ReadInput()
    {
        JointSpring jointSprint = hinge.spring;
        if (Input.GetKey(input))
        {
            jointSprint.targetPosition = targetPressed;
        }
        else
        {
            jointSprint.targetPosition = targetRelease;
        }
        hinge.spring = jointSprint;
    }
    private void MovePaddle()
    {
    }
}
