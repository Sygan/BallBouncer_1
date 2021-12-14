using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float HorizontalForceMin;
    public float HorizontalForceMax;

    public Rigidbody Rigid;
    
    private void OnCollisionEnter(Collision other)
    {
        var randomForce = UnityEngine.Random.Range(HorizontalForceMin, HorizontalForceMax);
        
        Rigid.AddForce(new Vector3(randomForce, 0, 0), ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger! " + other.gameObject.name);
    }
}
