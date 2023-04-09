using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
    public GameObject[] asteroides;
    public Vector3 aparicion;
    public int cantidadAsteroides;
    public float espera, esperaInicial;
    public Text textoPuntuacion, textoReinicio, textoGameOver;
    private int puntuacion;
    private bool reinicio, gameOver;

    void Start()
    {
        reinicio = false;
        gameOver = false;
        textoReinicio.gameObject.SetActive(false);
        textoGameOver.gameObject.SetActive(false);
        puntuacion = 0;
        ActualizarPuntuacion();
        StartCoroutine(Asteroides());
    }

    void Update() {
        if(reinicio && Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator Asteroides()
    {
        yield return new WaitForSeconds(esperaInicial);
        while (true)
        {
            for(int i=0; i<cantidadAsteroides; i++){
                GameObject asteroide = asteroides[Random.Range(0, asteroides.Length)];
                Vector3 spawn = new Vector3(Random.Range(-aparicion.x, aparicion.x), aparicion.y, aparicion.z);
                Instantiate(asteroide, spawn, Quaternion.identity);
                yield return new WaitForSeconds(espera);
            }        
            yield return new WaitForSeconds(0);

            if(gameOver){
                textoReinicio.gameObject.SetActive(true);
                reinicio = true;                
                break;
            }
        }
    }

    public void sumarPuntuacion(int incremento){
        puntuacion += incremento;
        ActualizarPuntuacion();
    }

    void ActualizarPuntuacion(){
        textoPuntuacion.text = "Puntuación: " + puntuacion;
    }

    public void GameOver(){
        textoGameOver.gameObject.SetActive(true);
        gameOver = true;
    }
}
