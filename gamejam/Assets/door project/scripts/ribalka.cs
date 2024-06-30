using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ribalka : MonoBehaviour
{
    public GameObject canvas;
    int Randomm = 0;
    public GameObject Rybka; 
    public GameObject NeRybka;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Key E");
            Eenter();
        }
    }

    void OnTriggerEnter()
    {
        canvas.SetActive(true);
    }

    void OnTriggerExit()
    {
        canvas.SetActive(false);
    }

    void Eenter()
    {
        Randomm = Random.Range(0, 2);
        if (Randomm == 0)
        {
            Rybka.SetActive(true);
        }
        if (Randomm == 1)
        {
            NeRybka.SetActive(true);
        }
    }
}
