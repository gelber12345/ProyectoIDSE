using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resolucion : MonoBehaviour
{
    // Start is called before the first frame update
    public float aspect;
    public float rounded;
    UnityEngine.UI.CanvasScaler cv;
    void Start()
    {
        cv = this.GetComponent<UnityEngine.UI.CanvasScaler>();
    }

    // Update is called once per frame
    void Update()
    {
        updateResolution();
    }
    void updateResolution(){
        aspect = Camera.main.aspect;
        rounded = (int) (aspect * 100.0f )/100.0f;

        if (rounded == 1.65f || rounded == 1.66f || rounded == 1.57f){
            Addratios(0,7.50f);
        } else if (rounded == 2.04f || rounded == 2.05f || rounded == 2.06f){
             Addratios(0.88f,4.86f);
        }else if (rounded == 1.70f || rounded == 1.71f || rounded == 1.69f){
             Addratios(0.88f,4.86f);
        }else if (rounded == 1.33f || rounded == 1.34f || rounded == 1.32f){
             Addratios(0.88f,4.86f);
        }else if (rounded == 1.85f ){
             Addratios(1,5);
        }else if (rounded == 2.11f){
             Addratios(1,4.75f);
        }else if (rounded == 1.77f){
             Addratios(0,6.80f);
        }else {
            Addratios(0,5);
        }
    }
    void Addratios (float m, float sz){
        if (cv!=null ) 
            cv.matchWidthOrHeight =m;
        Camera.main.orthographicSize =sz;
    }
}
