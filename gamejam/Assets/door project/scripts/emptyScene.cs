using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class emptyScene : MonoBehaviour
{
    public GameObject LohScene;
    public GameObject Opening;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("PlayerIs") == "Loh")
        {
            LohScene.SetActive(true);
        }
        else
        {
            Opening.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "exit")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
