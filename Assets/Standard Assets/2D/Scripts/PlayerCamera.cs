using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        Vector3 desiredPositon = target.position + offset;
        Vector3 smoothedDesiredPosition = Vector3.Lerp(transform.position, desiredPositon, smoothSpeed);
        transform.position = smoothedDesiredPosition;
    }
   
}
