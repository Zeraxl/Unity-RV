using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float speed;
    public float xMin, xMax, yMin, yMax;
    
    public GameObject disparo;
    public Transform spawn;
    public float cadencia;
    private float siguienteDisparo;

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, transform.position.z);
        float x = Mathf.Clamp(transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(transform.position.y, yMin, yMax);
        transform.position = new Vector3(x, y, 0);

        if(Input.GetButton("Fire1") && Time.time > siguienteDisparo){
            siguienteDisparo = Time.time + cadencia;
            Instantiate(disparo, spawn.position, Quaternion.identity);
        }
    }
}
