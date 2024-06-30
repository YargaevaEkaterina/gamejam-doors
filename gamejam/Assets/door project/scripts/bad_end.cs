using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bad_end : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Key E");
            PlayerPrefs.SetString("PlayerIs", "Loh");
            PlayerPrefs.Save();
            Debug.Log("Loh!");
            SceneManager.LoadScene(1);
        }
    }
}
