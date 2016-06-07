using UnityEngine;
using System.Collections;

public class Cañon : MonoBehaviour {
    public GameObject proyectilPrefab;
    public static float horizontalSpeed = 5.0F;
    
    public static float h;

    public static GameObject mira;
    public static GameObject target;
    public static GameObject proyectil;


    public AudioClip disparoSound = null;
    public float disparoVol = 1f;
    protected Transform posicionD = null;



    void Start ()
    {
        mira = GameObject.Find("Mira");
        target = GameObject.Find("target");
        posicionD = transform;
        
    }
    void Update()
    {
        h = horizontalSpeed * Input.GetAxis("Mouse X");

        //Debug.Log(h);
        transform.Rotate(0, 0, h);

        bool disparo = Input.GetButtonDown("Fire1");
        if (disparo)
        {
            if (Proyectil.proyectilActivo == false)
            {
                Disparar();
                if (disparoSound) AudioSource.PlayClipAtPoint(disparoSound, posicionD.position, disparoVol);
            }
            
        }


    }

    void Disparar()
    {
        proyectil = Instantiate(proyectilPrefab) as GameObject;
        Proyectil.proyectilActivo = true;
        proyectil.transform.position = mira.transform.position;
        /*
        proyectil.transform.position = mira.transform.localPosition;
        proyectil.transform.localRotation = mira.transform.localRotation;
        */
    }

}
