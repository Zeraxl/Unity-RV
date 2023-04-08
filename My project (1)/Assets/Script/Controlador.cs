using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public GameObject asteroide;
    public Vector3 aparicion;
    public int cantidadAsteroides;
    public float espera, esperaInicial;
    public Text textoPuntuacion;
    private int puntuacion;

    void Start()
    {
        puntuacion = 0;
        ActualizarPuntuacion();
        StartCoroutine(Asteroides());
    }

    IEnumerator Asteroides()
    {
        yield return new WaitForSeconds(esperaInicial);
        for(int i=0; i<cantidadAsteroides; i++){
            Vector3 spawn = new Vector3(Random.Range(-aparicion.x, aparicion.x), aparicion.y, aparicion.z);
            Instantiate(asteroide, spawn, Quaternion.identity);
            yield return new WaitForSeconds(espera);
        }        
    }

    public void sumarPuntuacion(int incremento){
        puntuacion += incremento;
        ActualizarPuntuacion();
    }

    void ActualizarPuntuacion(){
        textoPuntuacion.text = "Puntuación: " + puntuacion;
    }
}
