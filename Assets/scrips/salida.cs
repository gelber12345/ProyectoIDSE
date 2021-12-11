using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salida : MonoBehaviour
{
    Transform[] lista;
    List<Pregunta> preguntasNivel1;
    List<Pregunta> preguntasNivel2;
    List<Pregunta> preguntasNivel3;
    public List<Transform> puesto = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        preguntasNivel1 =new List<Pregunta>();
        preguntasNivel1.Add(new Pregunta("pregunta1","opcion 1", "opcion 2", "opcion 3","opcion 4", 1));
        preguntasNivel1.Add(new Pregunta("pregunta2","opcion 1", "opcion 2", "opcion 3","opcion 4", 2));
        preguntasNivel1.Add(new Pregunta("pregunta3","opcion 1", "opcion 2", "opcion 3","opcion 4", 3));
        preguntasNivel1.Add(new Pregunta("pregunta4","opcion 1", "opcion 2", "opcion 3","opcion 4", 4));
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
    public Pregunta getPregunta(int position){
        Debug.Log("nivel Pregunta " + puesto[position-1].GetComponent<casilla>().nivel);
        int pick = Random.Range(0, preguntasNivel1.Count);
        return preguntasNivel1[pick];
    }
}

public class Pregunta{
    private string titulo;
    private string alternativa1;
    private string alternativa2;
    private string alternativa3;
    private string alternativa4;

    private int rpCorrecta;

    public Pregunta (){
        titulo ="";
        alternativa1="";
        alternativa2="";
        alternativa3="";
        alternativa4="";
        rpCorrecta=0;
    }
    public Pregunta (string titulo,string alternativa1,string alternativa2,string alternativa3,string alternativa4,int correcta){
        this.titulo =titulo;
        this.alternativa1=alternativa1;
        this.alternativa2=alternativa2;
        this.alternativa3=alternativa3;
        this.alternativa4=alternativa4;
        rpCorrecta=correcta;
    }

    public string getTitulo(){
        return titulo;
    }
    public string getAlt1(){
        return alternativa1;
    }
    public string getAlt2(){
        return alternativa2;
    }
    public string getAlt3(){
        return alternativa3;
    }
    public string getAlt4(){
        return alternativa4;
    }
    public int getCorrecto(){
        return rpCorrecta;
    }
}
