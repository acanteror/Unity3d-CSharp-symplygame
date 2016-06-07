using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Impactos : MonoBehaviour {

    static public int impactos;
   
    void Update()
    {
        impactos = Ovni.impactos;    
        this.gameObject.GetComponent<Text>().text= "Impactos: " + impactos;

    }
}