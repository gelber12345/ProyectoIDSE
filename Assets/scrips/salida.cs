// Gerardo avance: Correccion de errores de codigo, errores de requerimientos

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
        preguntasNivel1 = new List<Pregunta>();
        
        preguntasNivel1.Add(new Pregunta("Que sucede si un puntero nulo es convertido a bool?","Un error es desplegado", "El valor del booleano es verdadero", "El valor del booleano es falso (correcto)", 1));
        preguntasNivel1.Add(new Pregunta("Un booleano es un tipo primitivo en C++?","Si (correcto)", "No, es un tipo char no asignado", "No, es una expansión de la macros", 2));
        preguntasNivel1.Add(new Pregunta("El operador usado por desreferenciar","->", "->>", "* (correcto)", 3));
        preguntasNivel1.Add(new Pregunta("Cuantas funciones como mínimo deben estar presentes en C++?","2", "1 (correcto)", "0", 4));
        preguntasNivel1.Add(new Pregunta("Como almacenar objetos grandes en C++ si extiende su memoria asignada?","Memoria heap (correcto)", "Stack", "Queue", 5));
        preguntasNivel1.Add(new Pregunta("Que librería es usada para declarar un número complejo?","complex (correcto)", "complex number", "complexnum", 6));
        preguntasNivel1.Add(new Pregunta("Que operador es usado para indicar un namespace?","Operador condicional", "Operador ternario", "Operador scope (correcto)", 7));
        preguntasNivel1.Add(new Pregunta("Cual es usado para indicarle a la computadora a donde un puntero esta apuntando?","Dereferencia (correcto)", "Referencia", "Operaciones heap", 8));
        preguntasNivel1.Add(new Pregunta("Cual es el tipo de retorno de malloc() o calloc()","void** (correcto)", "int*", "void*", 9));
        preguntasNivel1.Add(new Pregunta("Cual es el tamaño de un dato tipo entero?","2 Bytes", "4 Bytes", "Depende del sistema/compilador (correcto)", 10));
        preguntasNivel1.Add(new Pregunta("Cual de los tipos de datos tiene un tamaño variable?","int", "struct (correcto)", "float", 11));
        preguntasNivel1.Add(new Pregunta("Cuando un double es convertido a un float, el valor es?","Truncated (correcto)", "Rounded", "Depende del compilador", 12));
        preguntasNivel1.Add(new Pregunta("Qué algoritmo es usado para búsqueda en una tabla?","Busqueda de lista", "Busqueda informada", "Busqueda hash (correcto)", 13));
        preguntasNivel1.Add(new Pregunta("Ventajas de un array multidimensional sobre un array puntero?","Tamaño pre definido", "El input puede ser tomar por usuario", "Todos los mencionados (correcto)", 14));
        preguntasNivel1.Add(new Pregunta("Cual de las siguientes no puede ser un miembro estructurado?","Otra estructura", "Funcion (correcto)", "Array", 15));
        preguntasNivel1.Add(new Pregunta("Si hay un error mientras se abre un archivo, fopen retornara?","Nada", "EOF", "NULL (correcto)", 16));
        preguntasNivel1.Add(new Pregunta("Que clase no puede ser subclase o extendida en java?","Clase abstracta", "Clase pariente", "Clase final (correcto)", 17));
        preguntasNivel1.Add(new Pregunta("Porque se usa un array como parametro de metodo principal?","Es la sintaxis", "Puede almacenar multiples valores (correcto)", "Los dos anteriores", 18));
        preguntasNivel1.Add(new Pregunta("Qué metodo es usado para el desempeñar en declaraciones DML?","execute()", "executeUpdate() (correcto)", "executeQuery()", 19));
        preguntasNivel1.Add(new Pregunta("Todos los tipos de datos raw pueden ser leidos y actualizados a una bd como un array de?","int", "char", "byte (correcto)", 20));
        preguntasNivel1.Add(new Pregunta("Cual de estos metodos se usa para que el hilo principal sea llamado al final?","sleep() (correcto)", "stop()", "call()", 21));
        preguntasNivel1.Add(new Pregunta("Que clase o interfaz define los métodos wait(), notify(), y notifyAll()?","Object (correcto)", "Thread", "Runnable", 22));
        preguntasNivel1.Add(new Pregunta("Que permite al programador destruir un objeto x en java?","x.delete()", "Solo el sistema recolector de basura (correcto)", "Runtime.getRuntime().gc()", 23));
        preguntasNivel1.Add(new Pregunta("El proceso de crear una copia exacta de un objeto exitente es llamado?","cloning (correcto)", "overloading", "overriding", 24));
        preguntasNivel1.Add(new Pregunta("Cual es las siguiente es división haci abajo en python?","/", "// (correcto)", "%", 25));
        preguntasNivel1.Add(new Pregunta("Cual de las siguientes no es un tipo de dato nucleo en python?","Class (correcto)", "Lists", "Dictionary", 26));
        preguntasNivel1.Add(new Pregunta("Cual de los siguientes comandos creara una lista en python?","list1 = []", "list1 = list()", "Todas las anteriores (correcto)", 27));
        preguntasNivel1.Add(new Pregunta("Cual es el tipo de cada elemento en sys.argv en python?","set", "list", "string (correcto)", 28));
        preguntasNivel1.Add(new Pregunta("Para que es usado getattr() en python?","Para acceder a los atributos de un objeto (correcto)", "Para establecer un atributo", "Para verificar si un atributo existe", 29));
        preguntasNivel1.Add(new Pregunta("El comando que nos ayuda a restablecer el lapiz en turtle de python?","turtle.penreset", "turtle.penreset()", "turtle.reset() (correcto)", 30));
        preguntasNivel1.Add(new Pregunta("Cual es la salida del siguiente codigo: print('{:$}'.format(1112223334))","1,112,223,334", "1112223334", "Error (correcto)", 31));
        preguntasNivel1.Add(new Pregunta("Que operador aritmetico no puede ser usado con string en python?","- (correcto)", "+", "*", 32));
        preguntasNivel1.Add(new Pregunta("Que funcion es usada para obtener la direccion de memoria en python?","id(obj) (correcto)", "dir(obj)", "*obj", 33));
        preguntasNivel1.Add(new Pregunta("Cuantoa tributos tiene la siguiente clase: class Game: def __init__(self): self.title = '' self.levels = '' ","2", "1 (correcto)", "0", 34));
        preguntasNivel1.Add(new Pregunta("Cual es la diferencia entre: obj = Class y obj = Class()","No hay diferencia", "El primero es la propia clase y el segundo es instanciacion (correcta)", "El primero es instanciacion de la clase y el segundo es la misma clase", 35));
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

    private int rpCorrecta;

    public Pregunta (){
        titulo ="";
        alternativa1="";
        alternativa2="";
        alternativa3="";
        rpCorrecta=0;
    }
    public Pregunta (string titulo,string alternativa1,string alternativa2,string alternativa3,int correcta){
        this.titulo =titulo;
        this.alternativa1=alternativa1;
        this.alternativa2=alternativa2;
        this.alternativa3=alternativa3;
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
    public int getCorrecto(){
        return rpCorrecta;
    }
}
