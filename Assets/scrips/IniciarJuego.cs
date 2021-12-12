using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJuego : MonoBehaviour
{
    public void Iniciar(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
   public void Salir(){
       Debug.Log("QUIT");
       Application.Quit();
   }
}
