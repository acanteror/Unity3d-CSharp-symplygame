using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public static float timeLeft = 60;
    public string time;

    public AudioClip notimeSound = null;
    public float notimeVol = 1f;
    protected Transform posicionN = null;

    

    void Start()
    {
        posicionN = transform;
        
    }


    void Update()
    {

        timeLeft -= Time.deltaTime;
        time = timeLeft.ToString("####0.00");

        this.gameObject.GetComponent<Text>().text = ""+time;
        if (timeLeft < 0)
        {
            if (notimeSound) AudioSource.PlayClipAtPoint(notimeSound, posicionN.position, notimeVol);
            timeLeft = 0;

            Invoke("CambiarEscena", 3f);
            
            
        }
    }

    void CambiarEscena()
    {
        SceneManager.LoadScene("GameOver");
        timeLeft = 60;
    }

}
