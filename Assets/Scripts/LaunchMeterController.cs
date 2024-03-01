using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchMeterController : MonoBehaviour
{
    public LauncherController launcherController;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(launcherController.isHold == true){
            slider.value = launcherController.force / launcherController.maxForce;
        }
        if (slider.value > 0)
        {
            slider.value = Mathf.Lerp(slider.value, 0, Time.deltaTime);
        }
    }
}
