using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jugador : MonoBehaviour
{
    public Text resultado;
    public bool inicarMovimiento = false;
    bool aceptarmov = true;
    private int total;
    public salida rott;
    public menu canvas;
    public int rpposicion;
    public int punto;
    int auxpunto;
    bool moviento;
    // gameover variables
    GameObject cv;
    public bool resRewards;
    public int puntaje;
    public int resCorrect;

    // Start is called before the first frame update
    void Start()
    {
        total = 0;
        resRewards =false;
        puntaje =0;
        resCorrect =0;
        cv =  GameObject.Find("Canvas");
        resultado.text ="0";
        inicarMovimiento = false;
        aceptarmov = true;
        Time.timeScale=1;
        canvas = GameObject.Find("Canvas").GetComponent<menu>();
    }

    // Update is called once per frame
    void Update()
    {
         if(inicarMovimiento && !moviento && aceptarmov)
        {
            aceptarmov = false;
            inicarMovimiento = false;
            punto = Random.Range(1, 7);
            //Debug.Log("Resul " + punto);
            total = punto;
            resultado.text= " "+ total;

            if (rpposicion + punto <= rott.puesto.Count){

                StartCoroutine(Move(punto));
                
            }
            else if (rpposicion + punto >= rott.puesto.Count) 
            {
               auxpunto = rott.puesto.Count - rpposicion;
               StartCoroutine(Move(auxpunto));
            }else{
                //Debug.Log("Resultado "+ punto);
            } 
           

        } 
    }
    public void mover(int val){
        StartCoroutine(Move(val));
    }
     public void moverAtajo(int val){
         //Primer atajo
         if ( val ==1 ){
            StartCoroutine(MoveAtajo(val));
         }else{ // Segundo atajo
            StartCoroutine(MoveAtajo(val));
         }
        
    }
    IEnumerator MoveAtajo(int val){
        if (moviento && aceptarmov ){

            yield break;

        }
        moviento = true;
        int mov =0;
        if (val ==1 ){
            mov =6;
        }else{
            mov =5;
        }
        Vector3 nextPos = rott.puesto[rpposicion + mov].position;
        while (MoveToNexNode(nextPos)) { yield return null; }

        yield return new WaitForSeconds(0.1f);
        
        rpposicion+=mov+1;
         //Debug.Log("posicion "+ rpposicion);   
        
        moviento = false;   
        aceptarmov = true;
        inicarMovimiento = false;
        resRewards=false;
    }
    IEnumerator Move(int valor){
        if (moviento && aceptarmov ){

            yield break;

        }
        moviento = true;
        if (valor > 0 ){
            if (rpposicion !=25){
                while (valor > 0)
                {

                    Vector3 nextPos = rott.puesto[rpposicion + 0].position;
                    while (MoveToNexNode(nextPos)) { yield return null; }

                    yield return new WaitForSeconds(0.1f);
                    valor--;
                    rpposicion++;
                    //Debug.Log("posicion "+ rpposicion);
                }
            }

        } else{
            if (rpposicion !=1){
                while (valor <0)
                {
                    Debug.Log("RETROSEDIENDO " + valor);
                    Vector3 nextPos = rott.puesto[rpposicion - 2].position;
                   
                    while (MoveToNexNode(nextPos)) { yield return null; }

                    yield return new WaitForSeconds(0.1f);
                    valor++;
                    rpposicion--;
                }
            }
            
        }

        moviento = false;   
        aceptarmov = true;
        inicarMovimiento = false;
        if (!resRewards){
             //Desabilitamos l boton de lanzar dado
            cv.GetComponent<menu>().activo =false;
            //Regresamos el color base a los botones
            cv.GetComponent<menu>().cambiarColorAlternativas();

            //Debug.Log("posicion "+ rpposicion);   
            Pregunta p = rott.getPregunta(rpposicion);
            canvas.setPregunta(p);
            
        }else{
            resRewards=false;
        }
        
       
    }
    bool MoveToNexNode(Vector3 goal){
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 2f * Time.deltaTime));
    }
    
}