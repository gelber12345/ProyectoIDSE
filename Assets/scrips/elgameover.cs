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
        gameOverPanel.SetActive(true);
    }
}
