using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkScript : MonoBehaviour
{
    public RagdollController ragdollController=null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.collider.CompareTag("Line"))
        {
            //  Debug.Log(collision.gameObject.name);
            //   Debug.Log("Mark collision");
            //ragdollController.
            if (ragdollController != null)
            {
                ragdollController.Die();
                Destroy(gameObject);
            }
            else
            {
                Destroy(transform.parent.gameObject);
            }
             
        }

    }
}
