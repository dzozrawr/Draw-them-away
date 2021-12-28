using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0) return;
        while (transform.childCount > 0)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).parent = null;
            }
        }
    }
}
