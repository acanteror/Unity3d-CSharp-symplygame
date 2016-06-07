using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene("Main");
    }

}
