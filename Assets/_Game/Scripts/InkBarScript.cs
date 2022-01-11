using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InkBarScript : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetMaxInk(float ink)
    {
        slider.maxValue = ink;
        slider.value = ink;
    }

    public void SetInk(float ink)
    {
        slider.value = ink;
    }
}
