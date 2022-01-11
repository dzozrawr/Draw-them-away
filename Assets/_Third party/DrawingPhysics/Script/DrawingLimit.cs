using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingLimit : MonoBehaviour
{
    private static float maxInk = 100f, minInk = 0f, inkLoseRatePerSec=100f;

    float curInk;

    public DrawingPhysics drawingPhysics;

    public InkBarScript inkBar;
    private void Awake()
    {
        curInk = maxInk;
        inkBar.SetMaxInk(maxInk);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            curInk = ((curInk - inkLoseRatePerSec * Time.deltaTime) < minInk) ? minInk :  (curInk - inkLoseRatePerSec * Time.deltaTime);
            if (curInk <= 0)
            {
              //  drawingPhysics.enabled = false;  //disable drawing script
                drawingPhysics.isDrawing = false;  //disable isDrawing flag
            }
            inkBar.SetInk(curInk);//set slider value
        }
        else 
        {
          //  if (curInk >= maxInk) return;
            curInk = (curInk + inkLoseRatePerSec * Time.deltaTime) > maxInk ? maxInk : (curInk + inkLoseRatePerSec * Time.deltaTime);
            drawingPhysics.enabled = true;  //enable drawing again
            inkBar.SetInk(curInk);//set slider value
        }
    }
}
