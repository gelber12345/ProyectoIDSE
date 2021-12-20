using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public bool activo =true;
    bool puedeResponder = false;
    GameObject texto;
    GameObject alternativa1;
    GameObject alternativa2;

    GameObject alternativa3;
    int  res;
    // Start is called before the first frame update
    void Start()
    {
        texto = transform.GetChild(2).gameObject;

        res=0;
        alternativa1 = transform.GetChild(3).gameObject;
        alternativa2 = transform.GetChild(4).gameObject;
        alternativa3 = transform.GetChild(5).gameObject;
        
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
        if (puedeResponder){
            GameObject player = GameObject.Find("jugador");
            player.GetComponent<jugador>().resRewards =true;
            puedeResponder =false;
            //Debug.Log("OPCION SELECCIONADA " + opc);
             if (opc == res ){
                cambiarColorAlternativa(opc,2);
                player.GetComponent<jugador>().resCorrect++;
                player.GetComponent<jugador>().puntaje += 100;
                if (player.GetComponent<jugador>().rpposicion == 5 ){
                    player.GetComponent<jugador>().moverAtajo(1);
                }else if (player.GetComponent<jugador>().rpposicion == 14 ){
                    player.GetComponent<jugador>().moverAtajo(2);
                }else{
                    player.GetComponent<jugador>().mover(1);
                }
                
            }else{
                cambiarColorAlternativa(opc,1);
                player.GetComponent<jugador>().puntaje -= 50;
                player.GetComponent<jugador>().mover(-1);
            }
            activo = true;
            
        }
        
    }   
    public void setPregunta(Pregunta pregunta){
        texto.GetComponent<Text>().text = pregunta.getTitulo();
        alternativa1.GetComponent<Button>().transform.GetChild(0).GetComponent<Text>().text = pregunta.getAlt1();
        alternativa2.GetComponent<Button>().transform.GetChild(0).GetComponent<Text>().text = pregunta.getAlt2();
        alternativa3.GetComponent<Button>().transform.GetChild(0).GetComponent<Text>().text = pregunta.getAlt3();
        res = pregunta.getCorrecto();
        puedeResponder= true;
    }
    public void cambiarColorAlternativas(){
        ColorBlock cb =  alternativa1.GetComponent<Button>().colors;
        cb.selectedColor = Color.white;
        cb.normalColor = Color.white;
        alternativa1.GetComponent<Button>().colors = cb;
        alternativa2.GetComponent<Button>().colors = cb;
        alternativa3.GetComponent<Button>().colors = cb;
    }
    public void cambiarColorAlternativa(int alt, int color){
        Color c;
        if (color == 1){
            c =Color.red;
        }else{
            c =Color.green;
        }
       
        if (alt==1){
            ColorBlock cb =  alternativa1.GetComponent<Button>().colors;
            cb.selectedColor = c;
            cb.normalColor = c;
            alternativa1.GetComponent<Button>().colors = cb;
        }else if(alt ==2){
            ColorBlock cb =  alternativa2.GetComponent<Button>().colors;
            cb.selectedColor = c;
            cb.normalColor = c;
            alternativa2.GetComponent<Button>().colors = cb;
        }else{
            ColorBlock cb =  alternativa3.GetComponent<Button>().colors;
            cb.selectedColor = c;
            cb.normalColor = c;
            alternativa3.GetComponent<Button>().colors = cb;
        }
    }
}
