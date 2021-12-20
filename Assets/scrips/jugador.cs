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
    int rpposicion;
    public int punto;
    int auxpunto;
    bool moviento;
    // gameover variables


    // Start is called before the first frame update
    void Start()
    {
        total = 0;

        resultado.text ="0";
        inicarMovimiento = false;
        aceptarmov = true;
        canvas = GameObject.Find("Canvas").GetComponent<menu>();
    }

    // Update is called once per frame
    void Update()
    {
         if(inicarMovimiento && !moviento && aceptarmov)
        {
            aceptarmov = false;
            inicarMovimiento = false;
            punto = Random.Range(1, 5);
            Debug.Log("Resul " + punto);
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
    
    IEnumerator Move(int valor){
        if (moviento && aceptarmov ){

            yield break;

        }
        moviento = true;
        while (valor > 0)
        {

            Vector3 nextPos = rott.puesto[rpposicion + 0].position;
            while (MoveToNexNode(nextPos)) { yield return null; }

            yield return new WaitForSeconds(0.1f);
            valor--;
            rpposicion++;
            //Debug.Log("posicion "+ rpposicion);
        }
        moviento = false;   
        aceptarmov = true;
        inicarMovimiento = false;
        GameObject cv = GameObject.Find("Canvas");
        cv.GetComponent<menu>().activo =false;
        Debug.Log("posicion "+ rpposicion);   
        Pregunta p = rott.getPregunta(rpposicion);
        canvas.setPregunta(p);
    }
    bool MoveToNexNode(Vector3 goal){
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 2f * Time.deltaTime));
    }
}