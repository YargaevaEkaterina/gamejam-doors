using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass : MonoBehaviour
{
    public Animator anim;
    public GameObject credits;
    public GameObject grasss;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Key E");
            anim.Play("sit");
            credits.SetActive(true);
            grasss.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)
         || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("go");
            anim.Play("Locomotion");
        }
    }
}
