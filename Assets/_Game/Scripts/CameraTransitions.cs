﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransitions : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform view;
    [SerializeField] private float transitionSpeed;
    private Transform currentView;

    private bool changeCamera = false;
    // Start is called before the first frame update
    void Start()
    {
        currentView = transform;
    }

    private void Update()
    {
/*        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentView = views[0];
        }*/
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (changeCamera)
        {
            transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

            Vector3 currentAngle = new Vector3(
                Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
                Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
                Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed)
                );
            transform.eulerAngles = currentAngle;
        }
    }

    public bool cameraReachedDestination()
    {
        return Vector3.Distance(transform.position, currentView.position) < 0.5f;
    }

    public void transitionCameraToVictory()  //i will have values from 2 to maxPhase for simplicity
    {
      //  if (i < 2) return;  //also error message should be added
        currentView = view;
        changeCamera = true;
    }
}
