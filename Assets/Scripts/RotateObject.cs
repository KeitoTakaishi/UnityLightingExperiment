using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] Vector3 rotationSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        float t = Time.realtimeSinceStartup;
        this.transform.localEulerAngles = rotationSpeed * t;
    }
}
