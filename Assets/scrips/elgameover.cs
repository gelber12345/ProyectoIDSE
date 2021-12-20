using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elgameover : MonoBehaviour {

    public GameObject gameOverPanel;
    
    private void Start() {
        gameOverPanel.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D c) {
        Time.timeScale=0;
        gameOverPanel.SetActive(true);
        string res ="";
        GameObject player = GameObject.Find("jugador");
        res += " SU PUNTIACION FUE DE : " +  player.GetComponent<jugador>().puntaje + " \n"
            + " LA CANTIDAD DE RESPUESTAS CORRECTAS FUE DE : " + player.GetComponent<jugador>().resCorrect;
        
         gameOverPanel.transform.GetChild(2).GetComponent<Text>().text =res;
    }
}
