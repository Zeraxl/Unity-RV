using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void JugarTierra(){
        SceneManager.LoadScene("nivel_tierra");
    }

    public void JugarMarte(){
        SceneManager.LoadScene("nivel_marte");
    }

    public void JugarSaturno(){
        SceneManager.LoadScene("nivel_saturno");
    }

    public void Salir(){
        Application.Quit();
    }
}
