using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalScene : MonoBehaviour
{
    public GameObject flowers_end;
    public GameObject bad_end;
    public GameObject grass;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trees")
        {
            bad_end.SetActive(true);
            grass.SetActive(false);
        }
        if (other.gameObject.tag == "Flowers")
        {
            Debug.Log("flowers win!");
            flowers_end.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Trees")
        {
            bad_end.SetActive(false);
        }
    }
}
