using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Logro : MonoBehaviour {

    public static int navesDerribadas;
	
	void Update () {

        navesDerribadas = Ovni.navesDerribadas;
        this.gameObject.GetComponent<Text>().text = "Has derribado " + navesDerribadas+" naves";

    }
}
