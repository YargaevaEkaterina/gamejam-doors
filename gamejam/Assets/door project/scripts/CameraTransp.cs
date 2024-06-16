using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransp : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Walls") 
        {
            col.GetComponent<MeshRenderer>().enabled = false; // Или true для включение 
            
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Walls") 
        {
            col.GetComponent<MeshRenderer>().enabled = true; // Или true для включение 
            
        }
    }
}
