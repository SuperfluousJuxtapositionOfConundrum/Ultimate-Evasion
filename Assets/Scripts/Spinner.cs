using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{   
[SerializeField] float rotationSpeed = 500f;

    void Update()
    {
        transform.Rotate(0, -1.125f * Time.deltaTime * rotationSpeed, 0);
    }
}
