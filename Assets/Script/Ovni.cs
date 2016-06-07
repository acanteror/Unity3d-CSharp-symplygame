using UnityEngine;
using System.Collections;
public class Ovni : MonoBehaviour
{
    //Movimiento del ovni
    public float speed = 8f;
    public float leftAndRightEdge = 12f;
    public float chanceToChangeDirections = 0.03f;

    //Contador de impactos
    public static int impactosInicio = 5;
    public static int impactos = impactosInicio;
    //Contador de naves
    public static int navesDerribadas = 0;
    //Tiempo extra
    public static float extraTime = 30f;
    //Sonido de la Explosión
    public AudioClip explotionSound = null;
    public float explotionVol = 1f;
    protected Transform posicionE = null;


    void Start()
    {
        posicionE = transform;
    }


    void Update()
    {
        //movimiento de la nave
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        
        if (impactos == 0)
        {
            //Modificaciones sucesivas al lograr derribar naves
            impactosInicio = impactosInicio+ 3;
            impactos = impactosInicio;
            navesDerribadas++;
            Timer.timeLeft += extraTime;
            speed = speed * 1.1f;
            Proyectil.velProyectil += 0.0005f;
            extraTime -= 5f;
            if (explotionSound) AudioSource.PlayClipAtPoint(explotionSound, posicionE.position, explotionVol);




        }

    }

    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }


}