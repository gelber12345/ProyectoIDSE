using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public bool activo =true;
    [SerializeField]
    GameObject texto;
    [SerializeField]
    GameObject alternativa1;
    [SerializeField]
    GameObject alternativa2;
    [SerializeField]
     GameObject alternativa3;
    GameObject alternativa4;
    // Start is called before the first frame update
    void Start()
    {
        /*texto = transform.GetChild(2).gameObject;
        alternativa1 = transform.GetChild(3).gameObject;
        Debug.Log("este es el objeto agarrado"+transform.GetChild(6).gameObject);
        alternativa2 = transform.GetChild(4).gameObject;
        alternativa3 = transform.GetChild(5).gameObject;*/
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void lanzarDado(){
        if (activo){
            GameObject player = GameObject.Find("jugador");
            player.GetComponent<jugador>().inicarMovimiento = true;
        }
        
    }
    public void selecAlternativa(int opc){
        Debug.Log("OPCION SELECCIONADA " + opc);
        activo = true;
    }   
    public void setPregunta(Pregunta pregunta){
        texto.GetComponent<Text>().text = pregunta.getTitulo();
        alternativa1.GetComponent<Button>().transform.GetChild(0).GetComponent<Text>().text = pregunta.getAlt1();
        alternativa2.GetComponent<Button>().transform.GetChild(0).GetComponent<Text>().text = pregunta.getAlt2();
        alternativa3.GetComponent<Button>().transform.GetChild(0).GetComponent<Text>().text = pregunta.getAlt3();
    }
}
