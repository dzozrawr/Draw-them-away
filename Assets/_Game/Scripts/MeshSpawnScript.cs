using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeshPencil.Common.Controllers;

public class MeshSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 localPos, localScale;
    Quaternion localRot;
    [SerializeField] private MeshPencilController pencilController;

    void Start()
    {
        //player = transform.parent.gameObject;
       if(pencilController!=null)   pencilController.OnFinish.AddListener(unparentNewMesh);
    }

    private void unparentNewMesh()
    {
        /*        Instantiate(gameObject, transform.position, transform.rotation);
                Destroy(transform.GetChild(0).gameObject);*/
        Instantiate(transform.GetChild(0).gameObject, transform.position, transform.rotation);
        Destroy(transform.GetChild(0).gameObject);
    }

    // Update is called once per frame
    void Update()
    {
/*        if (transform.childCount == 0) return; else
        {
           Transform go = transform.GetChild(0);
            Instantiate(gameObject, transform.position, transform.rotation);


        }*/
        /*        while (transform.childCount > 0)
                {
                    for (int i = 0; i < transform.childCount; i++)
                    {
        *//*                localPos = transform.GetChild(i).localPosition;
                        localRot = transform.GetChild(i).localRotation;
                        localScale = transform.GetChild(i).localScale;
        *//*
                    //    Debug.Log(transform.GetChild(i).position);

                      //  transform.GetChild(i).parent = null;
                      //  Instantiate(transform.GetChild(i), transform.GetChild(i).position, Quaternion.identity);
                     //   Destroy(transform.GetChild(i).gameObject);

                      //  Debug.Log(transform.GetChild(i).position);
        *//*
                        Debug.Log("localPos=" + localPos);
                        Debug.Log("localRot=" + localRot);
                        Debug.Log("localScale=" + localScale);

                        transform.GetChild(i).position = localPos;
                        transform.GetChild(i).rotation = localRot;
                        transform.GetChild(i).localScale = localScale;*//*

                        //Invoke()
                    }
                }*/
    }

}
