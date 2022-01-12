using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkRandomizer : MonoBehaviour
{
    public GameObject[] markList;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject mark in markList)
        {
            mark.SetActive(false);
        }

        markList[Random.Range(0, markList.Length)].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
