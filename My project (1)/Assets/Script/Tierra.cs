using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tierra : MonoBehaviour
{
    public float rotacion;
    private Rigidbody rig;

    void Awake(){
        rig = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rig.angularVelocity = Random.insideUnitSphere * rotacion;
    }
    
}
