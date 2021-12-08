using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salida : MonoBehaviour
{
    Transform[] lista;
    public List<Transform> puesto = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puesto.Clear();
        lista = GetComponentsInChildren<Transform> ();
        foreach (Transform child in lista){
            if (child != this.transform){
                puesto.Add(child);
            }
        }
    }
}
