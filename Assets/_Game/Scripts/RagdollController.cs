using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    public float timeToDie = 6f;
    public GameObject goToApplyDeathMat;
    public Material deathMat;
    // Start is called before the first frame update
    void Start()
    {
        SetRigidBodyState(true);
        SetColliderState(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Die()
    {
        Destroy(transform.parent.gameObject, timeToDie);
        transform.parent.parent = null;
        GetComponent<Animator>().enabled = false;
        SetRigidBodyState(false);
        SetColliderState(true);

        goToApplyDeathMat.GetComponent<Renderer>().material = deathMat; //change color to death color
    }

    public void SetRigidBodyState(bool state)
    {
        Rigidbody[] rigidBodies = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rigidBody in rigidBodies)
        {
            rigidBody.isKinematic = state;
        }

        //GetComponent<RigidBody>().isKinematic=!state;
    }

    public void SetColliderState(bool state)
    {
        Collider[] colliders = GetComponentsInChildren<Collider>();

        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }

        //GetComponent<Collider>().enabled=!state;
    }
}
