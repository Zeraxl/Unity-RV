using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed;
    private Rigidbody rig;

    void Awake(){
        rig = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rig.velocity = new Vector3 (0, speed, 0);
    }
}
