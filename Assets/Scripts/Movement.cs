using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 15f;

    void Start()
    {
        
    }

    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zAxis = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xAxis, 0, zAxis);
    }
}
