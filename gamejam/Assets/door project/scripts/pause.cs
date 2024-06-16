using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject panel; 
    // Start is called before the first frame update

    public void topause()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void play()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
}
