using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elgameover : MonoBehaviour {
   [SerializeField]
    GameObject resultado;
    [SerializeField]
    GameObject resultadoCompleto;
    [SerializeField]
    GameObject gameOverPanel;
    [SerializeField]
    GameObject gameOverPane2;
    [SerializeField]
    GameObject gameOverPane3;
    [SerializeField]
    GameObject gameOverPane4;
    private void Start() {
        gameOverPanel.SetActive(false);
        
    }

    void OnCollisionEnter2D(Collision2D c) {
        Time.timeScale=0;
        gameOverPanel.SetActive(true);
        gameOverPane2.SetActive(false);
        gameOverPane3.SetActive(false);
        gameOverPane4.SetActive(false);
        string res ="";
        GameObject player = GameObject.Find("jugador");

        if(player.GetComponent<jugador>().puntaje>0){
            resultado.GetComponent<TMPro.TextMeshProUGUI>().text ="¡   GANASTE  :) !";
        }
        else{
             resultado.GetComponent<TMPro.TextMeshProUGUI>().text ="¡   PERDISTE :( !";
        }
        res += " SU PUNTUACION FUE DE : " +  player.GetComponent<jugador>().puntaje + " \n"
            + " LA CANTIDAD DE RESPUESTAS CORRECTAS FUE DE : " + player.GetComponent<jugador>().resCorrect;
        
          resultadoCompleto.GetComponent<TMPro.TextMeshProUGUI>().text =res;
    }
}
