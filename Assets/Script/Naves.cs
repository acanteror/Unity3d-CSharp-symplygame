using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Naves : MonoBehaviour {

    static public int naves;
	
	void Update () {
       
        naves = Ovni.navesDerribadas;
        this.gameObject.GetComponent<Text>().text = "Naves: " + naves;

    }
}
