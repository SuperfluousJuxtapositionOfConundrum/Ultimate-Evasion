using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faller : MonoBehaviour
{   
    MeshRenderer meshRenderer;
    Rigidbody rb;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
