using UnityEngine;
using System.Collections;

public class Proyectil : MonoBehaviour {

    public static float velProyectil = 0.002f;
    public static bool proyectilActivo;

    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, Cañon.target.transform.position, velProyectil);
        if (transform.position.y > 5 || transform.position.y < -5 || transform.position.x > 14 || transform.position.x < -14)
        {
            Destroy(this.gameObject);
            proyectilActivo = false;
            Debug.Log("proyectil OUT");
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Cañon")
        {
            Destroy(this.gameObject);
            Debug.Log("CHOCADO CON EL SUELO");
            proyectilActivo = false;
 
        }
        if (collidedWith.tag == "Ovni")
        {
            Destroy(this.gameObject);
            Debug.Log("IMPACTO CON LA NAVE");
            Ovni.impactos--;
            proyectilActivo = false;
            Debug.Log(Ovni.impactos.ToString());
        }
        
    }

}
