using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float Speed;

    private float horizontal; 
    
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + Speed * horizontal * Time.fixedDeltaTime, transform.position.y, transform.position.z);
    }
}
