using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impacto : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosionJugador;

    public int puntuacion;
    private Controlador cont;

    void OnTriggerEnter(Collider col){
        if (col.CompareTag("Limite")) return;

        Instantiate(explosion, transform.position, transform.rotation);

        if(col.CompareTag("Jugador")){
            Instantiate(explosionJugador, col.transform.position, col.transform.rotation);
        }     

        cont.sumarPuntuacion(puntuacion);

        Destroy(col.gameObject);
        Destroy(gameObject);
    }
}
