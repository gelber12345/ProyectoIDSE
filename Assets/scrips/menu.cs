using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void lanzarDado(){
        GameObject player = GameObject.Find("jugador");
        player.GetComponent<jugador>().inicarMovimiento = true;
    }
}
