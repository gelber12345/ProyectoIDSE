using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elgameover : MonoBehaviour {
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
        res += " SU PUNTIACION FUE DE : " +  player.GetComponent<jugador>().puntaje + " \n"
            + " LA CANTIDAD DE RESPUESTAS CORRECTAS FUE DE : " + player.GetComponent<jugador>().resCorrect;
        
         gameOverPanel.transform.GetChild(2).GetComponent<Text>().text =res;
    }
}
