using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject disparo;
    public Transform inicioDisparo;
    public float espera, cadencia;

    private AudioSource sonido;


    void Awake(){
        sonido = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparar", espera, cadencia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Disparar(){
        Instantiate(disparo, inicioDisparo.position, inicioDisparo.rotation);
        sonido.Play();
    }
}
